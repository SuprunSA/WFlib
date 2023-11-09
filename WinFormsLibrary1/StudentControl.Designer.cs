namespace WinFormsLibrary1
{
    partial class StudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Id = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Stipend = new System.Windows.Forms.CheckBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Id.Location = new System.Drawing.Point(3, 3);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(66, 23);
            this.Id.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullName.Location = new System.Drawing.Point(75, 4);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(252, 23);
            this.FullName.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Description.Location = new System.Drawing.Point(333, 4);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(363, 23);
            this.Description.TabIndex = 3;
            // 
            // Stipend
            // 
            this.Stipend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Stipend.AutoSize = true;
            this.Stipend.Location = new System.Drawing.Point(814, 8);
            this.Stipend.Name = "Stipend";
            this.Stipend.Size = new System.Drawing.Size(15, 14);
            this.Stipend.TabIndex = 7;
            this.Stipend.UseVisualStyleBackColor = true;
            // 
            // Course
            // 
            this.Course.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "Неизв.",
            "1",
            "2",
            "3",
            "4"});
            this.Course.Location = new System.Drawing.Point(702, 4);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(81, 23);
            this.Course.TabIndex = 8;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Stipend);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Id);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(864, 31);
            this.Load += new System.EventHandler(this.StudentControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Id;
        private TextBox FullName;
        private TextBox Description;
        private CheckBox Stipend;
        private ComboBox Course;
    }
}
