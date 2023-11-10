namespace Students
{
    partial class UpdateStudents
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
            this.UndoChanges = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.descControl1 = new WinFormsLibrary1.DescControl();
            this.SuspendLayout();
            // 
            // UndoChanges
            // 
            this.UndoChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoChanges.Location = new System.Drawing.Point(811, 426);
            this.UndoChanges.Name = "UndoChanges";
            this.UndoChanges.Size = new System.Drawing.Size(75, 23);
            this.UndoChanges.TabIndex = 0;
            this.UndoChanges.Text = "Отмена";
            this.UndoChanges.UseVisualStyleBackColor = true;
            this.UndoChanges.Click += new System.EventHandler(this.UndoChanges_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChanges.Location = new System.Drawing.Point(730, 426);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 1;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // descControl1
            // 
            this.descControl1.Location = new System.Drawing.Point(-26, -1);
            this.descControl1.Name = "descControl1";
            this.descControl1.Size = new System.Drawing.Size(917, 20);
            this.descControl1.TabIndex = 2;
            // 
            // UpdateStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 461);
            this.Controls.Add(this.descControl1);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.UndoChanges);
            this.Name = "UpdateStudents";
            this.Text = "UpdateStudents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.ResumeLayout(false);

        }

        #endregion

        private Button UndoChanges;
        private Button SaveChanges;
        private WinFormsLibrary1.DescControl descControl1;
    }
}