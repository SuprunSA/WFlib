using Students.BL;
using WinFormsLibrary1;

namespace Students
{
    public partial class UpdateStudents : Form
    {
        private readonly List<int> ids;
        private readonly List<Student> students;
        private readonly Form1 form1;
        public int Location_x { get; set; }
        public int Location_y { get; set; }

        public UpdateStudents(List<int> ids, List<Student> students, Form1 form1)
        {
            this.form1 = form1;
            this.students = students;
            this.ids = ids;
            Location_x = 12;
            Location_y = 32;
            InitializeComponent();
            InitStudents();
        }

        private void InitStudents()
        {
            foreach (var student in students)
            {
                if (!ids.Contains(student.Id)) continue;
                var control = new StudentControl(student, true);
                control.Location = new Point(Location_x, Location_y);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                Location_y += 32;
                Controls.Add(control);
            }
            if (Controls.Count * 17 + 32 > 500) this.Size = new Size(this.Size.Width, Controls.Count * 17 + 32);
        }

        private void UndoChanges_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Изменения не сохранены, вы уверены что хотите выйти?", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) return;
            else
            {
                this.Close();
            }
        }

        private async void SaveChanges_Click(object sender, EventArgs e)
        {
            List<Student> stToUpdate = new();
            var res = string.Empty;
            foreach (var control in Controls)
            {
                if (control is StudentControl studentControl)
                {
                    var validResult = studentControl.Validate();
                    if (!string.IsNullOrEmpty(validResult))
                    {
                        MessageBox.Show(validResult, "Update", MessageBoxButtons.OK);
                    }
                    res += validResult;
                    stToUpdate.Add(studentControl.GetStudent());
                }
            }

            if (!string.IsNullOrEmpty(res)) return;

            try
            {
                await form1.UpdateStudents(stToUpdate);
                MessageBox.Show("Сохранение прошло успешно", "Update", MessageBoxButtons.OK);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"При сохранении произошла ошибка: {ex.Message}", "Update", MessageBoxButtons.OK);
            }
            finally
            {
                this.Close();
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            form1.Enabled = true;
            form1.InitStudents();
            form1.Focus();
        }
    }
}
