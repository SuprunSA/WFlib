using Students.BL;
using System.Text;

namespace WinFormsLibrary1
{
    public partial class StudentControl : UserControl
    {
        private readonly Student? student;
        private readonly bool isUpdating;
        public StudentControl(Student? student = default, bool isUpdating = false)
        {
            this.isUpdating = isUpdating;
            this.student = student;
            InitializeComponent();
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            Id.ReadOnly = true;
            Course.SelectedIndex = 0;
            if (student != default) 
            {
                Id.Text = student.Id.ToString();
                FullName.Text = student.FullName;
                Description.Text = student.Description ?? string.Empty;
                Course.SelectedIndex = (int)student.Course;
                Stipend.Checked = student.Stipend ?? false;

                if (!isUpdating)
                {
                    FullName.ReadOnly = true;
                    Description.ReadOnly = true;
                    Stipend.Click += StipendChecked;
                    Course.Enabled = false;
                }
            }
        }

        private void StipendChecked(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                checkBox.Checked = !checkBox.Checked;
            }
        }

        public Student GetStudent(bool isCr = false)
        {
            var course = Course.Text switch
            {
                "1" => Students.BL.Course.First,
                "2" => Students.BL.Course.Second,
                "3" => Students.BL.Course.Third,
                "4" => Students.BL.Course.Fourth,
                _ => Students.BL.Course.Unknown,
            };
            return new Student()
            {
                Id = isCr ? 0 : int.Parse(Id.Text),
                FullName = FullName.Text,
                Description = Description.Text,
                Course = course,
                Stipend = Stipend.Checked,
            };
        }

        public string Validate()
        {
            var result = new StringBuilder();

            if (string.IsNullOrEmpty(FullName.Text)) 
            {
                result.AppendLine("Имя не может быть пустым");
                FullName.BackColor = Color.Red;
            }

            if (FullName.Text.Length > 50)
            {
                result.AppendLine("Полное имя не может превышать 50 символов");
                FullName.BackColor = Color.Red;
            }

            if (Description.Text.Length > 200)
            {
                result.AppendLine("Характеристика не может превышать 200 символов");
                Description.BackColor = Color.Red;
            }

            return result.ToString();
        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {
            FullName.BackColor = Color.White;
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            Description.BackColor = Color.White;
        }
    }
}
