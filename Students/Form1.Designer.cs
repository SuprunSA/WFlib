namespace Students
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PdfComponent = new WinFormsLibrary1.Component2(this.components);
            this.descControl1 = new WinFormsLibrary1.DescControl();
            this.SuspendLayout();
            // 
            // descControl1
            // 
            this.descControl1.Location = new System.Drawing.Point(0, 0);
            this.descControl1.Name = "descControl1";
            this.descControl1.Size = new System.Drawing.Size(894, 31);
            this.descControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 494);
            this.Controls.Add(this.descControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsLibrary1.Component2 PdfComponent;
        private WinFormsLibrary1.DescControl descControl1;
    }
}