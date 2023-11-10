using Students.BL;
using Students.BL.Services;
using WinFormsLibrary1;

namespace Students
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService;
        private List<int> Nidx { get; set; }
        public int Location_x { get; set; }
        public int Location_y { get; set; }

        public Form1(StudentService studentService)
        {
            this.studentService = studentService;
            InitializeComponent();
            Nidx = new();
            Location_x = 12;
            Location_y = 32;
            InitStudents();
        }

        private async Task SaveToPdf()
        {
            var students = await studentService.GetStudents();
            var stToPdf = students.Where(s => s.Stipend == true).Select(x => Parse(x)).ToArray();
            SaveFileDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PdfComponent.FileName = dialog.FileName;
                PdfComponent.SaveToFile("Список студентов, получающих стипендию", stToPdf);
            }
        }

        private string Parse(Student student)
        {
            var desc = string.IsNullOrEmpty(student.Description) ? "Отсутствует" : student.Description;
            return $"Полное имя - {student.FullName}; Характеристика - {desc}";
        }

        private async void UpdateSelectedStudents()
        {
            UpdateStudents upd = new(Nidx, await studentService.GetStudents(), this);
            upd.Show();
            this.Enabled = false;
        }

        private void AddStudents()
        {
            CreateStudent crt = new(this);
            crt.Show();
            this.Enabled = false;
        } 

        private async Task DeleteSelectedStudents()
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить выбранные сущности?", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Nidx.Any())
                {
                    MessageBox.Show("Нет выбранных сущностей", "Delete", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    await studentService.DeleteStudents(Nidx);
                    MessageBox.Show("Удаление прошло успешно", "Delete", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"При удалении возникла ошибка: {ex.Message}", "Delete", MessageBoxButtons.OK);
                }
            }
        }

        private async Task DeleteSelectedStudent()
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить выбранную сущность?", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!Nidx.Any())
                {
                    MessageBox.Show("Нет выбранной сущности", "Delete", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    await studentService.DeleteStudent(Nidx.Min());
                    MessageBox.Show("Удаление прошло успешно", "Delete", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"При удалении возникла ошибка: {ex.Message}", "Delete", MessageBoxButtons.OK);
                }
            }
        }

        public async void InitStudents()
        {
            for (int i = Controls.Count - 1; i > 0; i--) // remove all controls without Desc
            {
                Controls.RemoveAt(i);
            }

            Nidx = new(); // update vars for reload
            Location_x = 12;
            Location_y = 32;

            var students = await studentService.GetStudents();
            foreach (var student in students) 
            {
                var checkBox = new CheckBox();
                checkBox.Location = new Point(Location_x, Location_y + 4);
                checkBox.Name = $"{student.Id}";
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                var control = new StudentControl(student);
                control.Location = new Point(Location_x + 30, Location_y);
                control.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                Location_y += 32;
                Controls.Add(control);
                Controls.Add(checkBox);
            }
            if (Controls.Count * 17 + 32 > 500) this.Size = new Size(this.Size.Width, Controls.Count * 17 + 32);
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is CheckBox checkBox) 
            {
                var nidx = int.Parse(checkBox.Name);
                if (checkBox.Checked) Nidx.Add(nidx);
                else Nidx.Remove(nidx);
            }
        }

        public async Task UpdateStudents(List<Student> students)
        {
            await studentService.UpdateRangeAsync(students);
        }

        public async Task CreateStudents(List<Student> students)
        {
            await studentService.CreateRange(students);
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.A)
                {
                    AddStudents();
                }
                else if (e.KeyCode == Keys.D)
                {
                    await DeleteSelectedStudents();
                    InitStudents();
                }
                else if (e.KeyCode == Keys.U)
                {
                    UpdateSelectedStudents();
                }
                else if (e.KeyCode == Keys.S)
                {
                    await SaveToPdf();
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                await DeleteSelectedStudent();
                InitStudents();
            }
        }
    }
}