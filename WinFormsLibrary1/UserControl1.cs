namespace WinFormsLibrary1
{
    public partial class UserControl1 : UserControl
    {
        private event EventHandler? _avatarChanged;
        private event Action? _errorOccured;
        public string Error { get; private set; }

        public Image Avatar
        {
            get
            {
                return PictureBox.Image;
            }
            set
            {
                PictureBox.Image = value;
            }
        }

        public event EventHandler AvatarChanged
        {
            add { _avatarChanged += value; }
            remove { _avatarChanged -= value; }
        }

        public event Action AnArrorOccured
        {
            add { _errorOccured += value; }
            remove { _errorOccured -= value; }
        }

        public UserControl1()
        {
            InitializeComponent();
            Error = string.Empty;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    PictureBox.Image = Image.FromFile(ofd.FileName);
                    _avatarChanged.Invoke(this, e);
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    _errorOccured.Invoke();
                }
            }
        }
    }
}
