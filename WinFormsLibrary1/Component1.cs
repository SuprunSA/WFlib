using System.ComponentModel;

namespace WinFormsLibrary1
{
    public partial class Component1 : Component
    {
        private string _fileName;
        public string FileName
        {
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                if (!value.EndsWith(".txt")) throw new ArgumentException("No txt file");
                _fileName = value;
            }
        }

        public Component1()
        {
            InitializeComponent();
            _fileName = string.Empty;
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            _fileName = string.Empty;
        }

        public bool SaveToFile(string[] texts)
        {
            CheckFileExists();
            using var writer = new StreamWriter(_fileName, true);
            {
                foreach (var text in texts)
                {
                    writer.WriteLine(text);
                }
            }
            return true;
        }

        private void CheckFileExists()
        {
            if (string.IsNullOrEmpty(_fileName)) throw new ArgumentNullException(_fileName);
            if (!File.Exists(_fileName)) throw new FileNotFoundException(_fileName);
        }
    }
}