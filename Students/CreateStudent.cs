using Students.BL;
using Students.BL.Services;
using WinFormsLibrary1;

namespace Students
{
    public partial class CreateStudent : Form
    {
        private readonly Form1 form1;

        public int Location_x { get; set; }
        public int Location_y { get; set; }
        public CreateStudent(Form1 form1)
        {
            this.form1 = form1;

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
    }
}
