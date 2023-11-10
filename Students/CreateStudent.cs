using Students.BL;
using WinFormsLibrary1;

namespace Students
{
    public partial class CreateStudent : Form
    {
        private List<Student> StudentsToCreate { get; set; }
        private readonly Form1 form1;

        public int Location_x { get; set; }
        public int Location_y { get; set; }
        public CreateStudent(Form1 form1)
        {
            this.form1 = form1;

            StudentsToCreate = new();
            Location_x = 12;
            Location_y = 32;

            InitializeComponent();
            InitAddingMenu();
        }

        private void InitAddingMenu()
        {
            var control = new StudentControl();
            control.Location = new Point(Location_x, Location_y);
            control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            Location_y += 32;
            Controls.Add(control);
            if (Controls.Count * 17 + 32 > 500) this.Size = new Size(this.Size.Width, Controls.Count * 17 + 32);
        }

        private void CreateStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                var results = string.Empty;
                foreach (var control in Controls)
                {
                    if (control is StudentControl studentControl)
                    {
                        var validResult = studentControl.Validate();
                        results += validResult;
                        if (!string.IsNullOrEmpty(validResult))
                        {
                            MessageBox.Show(validResult, "Create", MessageBoxButtons.OK);
                        }
                    }
                }
                if (string.IsNullOrEmpty(results)) InitAddingMenu();
            }
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
            try
            {
                foreach (var control in Controls)
                {
                    if (control is StudentControl studentControl)
                    {
                        var validResult = studentControl.Validate();
                        if (!string.IsNullOrEmpty(validResult))
                        {
                            MessageBox.Show(validResult, "Create", MessageBoxButtons.OK);
                            StudentsToCreate.Clear();
                            return;
                        }

                        else
                        {
                            StudentsToCreate.Add(studentControl.GetStudent(true));
                        }
                    }
                }

                await form1.CreateStudents(StudentsToCreate);
                MessageBox.Show("Сохранение прошло успешно", "Update", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При сохранении произошла ошибка: {ex.Message}", "Update", MessageBoxButtons.OK);
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
