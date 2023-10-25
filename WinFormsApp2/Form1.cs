namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            userControl21.ClearComboBox();
        }

        private void ChangeSelectedItemText_Click(object sender, EventArgs e)
        {
            var txt = ComboBoxValue.Text;
            if (string.IsNullOrEmpty(txt))
            {
                MessageBox.Show($"Попытка добавить пустую строку");
            }
            else
            {
                userControl21.CurrentValue = txt;
            }
        }
    }
}