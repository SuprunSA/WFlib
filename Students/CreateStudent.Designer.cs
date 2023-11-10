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
            this.UndoChanges = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descControl1
            // 
            this.descControl1.Location = new System.Drawing.Point(-24, 3);
            this.descControl1.Name = "descControl1";
            this.descControl1.Size = new System.Drawing.Size(917, 20);
            this.descControl1.TabIndex = 0;
            // 
            // UndoChanges
            // 
            this.UndoChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoChanges.Location = new System.Drawing.Point(794, 415);
            this.UndoChanges.Name = "UndoChanges";
            this.UndoChanges.Size = new System.Drawing.Size(75, 23);
            this.UndoChanges.TabIndex = 1;
            this.UndoChanges.Text = "Отмена";
            this.UndoChanges.UseVisualStyleBackColor = true;
            this.UndoChanges.Click += new System.EventHandler(this.UndoChanges_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChanges.Location = new System.Drawing.Point(713, 415);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.UndoChanges);
            this.Controls.Add(this.descControl1);
            this.KeyPreview = true;
            this.Name = "CreateStudent";
            this.Text = "CreateStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateStudent_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsLibrary1.DescControl descControl1;
        private Button UndoChanges;
        private Button SaveChanges;
    }
}