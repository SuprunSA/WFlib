using System.Linq;

namespace WinFormsLibrary1
{
    public partial class UserControl2 : UserControl
    {
        private static string[] Values = new string []{ "value 1", "value 2", "value 3", "value 4" };
        public string CurrentValue
        {
            get
            {
                return ComboBox.SelectedItem as string ?? string.Empty;
            }
            set 
            {
                if (string.IsNullOrEmpty(value)) return;
                if (ComboBox.Items.Contains(value)) 
                {
                    ComboBox.SelectedItem = value;
                }
                else
                {
                    ComboBox.Items.Add(value);
                    ComboBox.SelectedItem = value;
                }
            }
        }

        public UserControl2()
        {
            InitializeComponent();
            FillComboBox(Values);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected value changed, now: {CurrentValue}");
        }

        private void FillComboBox(string[] values)
        {
            foreach (var item in values)
            {
                ComboBox.Items.Add(item);
            }
        }

        public void ClearComboBox()
        {
            ComboBox.Items.Clear();
            ComboBox.Text = string.Empty;
        }
    }
}
