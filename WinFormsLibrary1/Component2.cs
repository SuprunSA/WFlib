using System.ComponentModel;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace WinFormsLibrary1
{
    public partial class Component2 : Component
    {
        private string _fileName = string.Empty;
        public string FileName
        {
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                if (!value.EndsWith(".docx")) throw new ArgumentException("No docx file");
                _fileName = value;
            }
        }

        public Component2()
        {
            InitializeComponent();
        }

        public Component2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SaveToFile(string header, string[] texts)
        {
            CheckFileExists();

            var doc = DocX.Create(_fileName);
            var txtPar = texts[0];

            if (txtPar.Length > 1) 
            {
                for (int i = 1; i < texts.Length; i++)
                {
                    txtPar += Environment.NewLine;
                    txtPar += texts[i];
                }
            }

            var titleFormat = new Formatting();
            titleFormat.Size = 20;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.Orange;
            titleFormat.UnderlineColor = Color.Gray;
            titleFormat.Italic = true;

            Formatting textParagraphFormat = new Formatting();
            textParagraphFormat.Size = 12;
            textParagraphFormat.Spacing = 1;

            Paragraph paragraphTitle = doc.InsertParagraph(header, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;
            //Insert text  
            doc.InsertParagraph(txtPar, false, textParagraphFormat);
            doc.Save();
        }

        private void CheckFileExists()
        {
            if (string.IsNullOrEmpty(_fileName)) throw new ArgumentNullException(_fileName);
            if (!File.Exists(_fileName)) throw new FileNotFoundException(_fileName);
        }
    }
}
