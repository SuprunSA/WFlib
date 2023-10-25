namespace WinFormsApp2
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
            this.userControl21 = new WinFormsLibrary1.UserControl2();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChangeSelectedItemText = new System.Windows.Forms.Button();
            this.ComboBoxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userControl21
            // 
            this.userControl21.CurrentValue = "";
            this.userControl21.Location = new System.Drawing.Point(12, 12);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(362, 290);
            this.userControl21.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Location = new System.Drawing.Point(12, 301);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "очистить список";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChangeSelectedItemText
            // 
            this.ChangeSelectedItemText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeSelectedItemText.Location = new System.Drawing.Point(316, 301);
            this.ChangeSelectedItemText.Name = "ChangeSelectedItemText";
            this.ChangeSelectedItemText.Size = new System.Drawing.Size(192, 23);
            this.ChangeSelectedItemText.TabIndex = 2;
            this.ChangeSelectedItemText.Text = "Изменить выбранное значение";
            this.ChangeSelectedItemText.UseVisualStyleBackColor = true;
            this.ChangeSelectedItemText.Click += new System.EventHandler(this.ChangeSelectedItemText_Click);
            // 
            // ComboBoxValue
            // 
            this.ComboBoxValue.Location = new System.Drawing.Point(316, 272);
            this.ComboBoxValue.Name = "ComboBoxValue";
            this.ComboBoxValue.Size = new System.Drawing.Size(192, 23);
            this.ComboBoxValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 341);
            this.Controls.Add(this.ComboBoxValue);
            this.Controls.Add(this.ChangeSelectedItemText);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.userControl21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsLibrary1.UserControl2 userControl21;
        private Button ClearButton;
        private Button ChangeSelectedItemText;
        private TextBox ComboBoxValue;
    }
}