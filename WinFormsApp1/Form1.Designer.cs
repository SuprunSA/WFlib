﻿namespace WinFormsApp1
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
            this.userControl11 = new WinFormsLibrary1.UserControl1();
            this.Component = new WinFormsLibrary1.Component1(this.components);
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.Avatar = null;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(397, 238);
            this.userControl11.TabIndex = 0;
            this.userControl11.AvatarChanged += new System.EventHandler(this.userControl11_AvatarChanged);
            this.userControl11.AnArrorOccured += new System.Action(this.userControl11_AnArrorOccured);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(688, 342);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(100, 96);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(607, 415);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Скачать";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsLibrary1.UserControl1 userControl11;
        private WinFormsLibrary1.Component1 Component;
        private RichTextBox RichTextBox;
        private Button ButtonSave;
    }
}