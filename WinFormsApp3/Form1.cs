namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Component.FileName = "C:\\Users\\User\\OneDrive\\Рабочий стол\\1.docx";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (RichTextBox.Lines == null || RichTextBox.Lines.Length == 0 || string.IsNullOrEmpty(Header.Text))
                {
                    throw new ArgumentNullException();
                }
                Component.SaveToFile(Header.Text, RichTextBox.Lines);
                MessageBox.Show("Сохрынено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}