namespace Students
{
    partial class CreateStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descControl1 = new WinFormsLibrary1.DescControl();
            this.SuspendLayout();
            // 
            // descControl1
            // 
            this.descControl1.Location = new System.Drawing.Point(-24, 3);
            this.descControl1.Name = "descControl1";
            this.descControl1.Size = new System.Drawing.Size(917, 20);
            this.descControl1.TabIndex = 0;
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.descControl1);
            this.Name = "CreateStudent";
            this.Text = "CreateStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsLibrary1.DescControl descControl1;
    }
}