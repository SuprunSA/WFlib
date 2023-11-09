namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateImage();
            Component.FileName = "C:\\Users\\User\\OneDrive\\Рабочий стол\\1.txt";
        }

        private void CreateImage()
        {
            Bitmap bmp = new(userControl11.Width - 10, userControl11.Height - 10);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawEllipse(new Pen(Color.Red), 10, 10, 20, 20);
            userControl11.Avatar = bmp;
        }

        private void userControl11_AvatarChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Change avatar, width={userControl11.Avatar.Width}");
        }

        private void userControl11_AnArrorOccured()
        {
            MessageBox.Show($"An error occured: {userControl11.Error}");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Component.SaveToFile(RichTextBox.Lines);
                MessageBox.Show("Сохрынено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}