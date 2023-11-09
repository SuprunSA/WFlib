namespace WinFormsApp3
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.TextBox();
            this.Component = new WinFormsLibrary1.Component2(this.components);
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(525, 235);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(263, 203);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(444, 415);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Скачать";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(525, 196);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(263, 23);
            this.Header.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.RichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RichTextBox;
        private Button ButtonSave;
        private TextBox Header;
        private WinFormsLibrary1.Component2 Component;
    }
}