﻿namespace ipMan
{
    partial class formPreferences
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
            this.chcklistbox_adaptselect = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chcklistbox_adaptselect
            // 
            this.chcklistbox_adaptselect.FormattingEnabled = true;
            this.chcklistbox_adaptselect.Location = new System.Drawing.Point(75, 47);
            this.chcklistbox_adaptselect.Name = "chcklistbox_adaptselect";
            this.chcklistbox_adaptselect.Size = new System.Drawing.Size(152, 154);
            this.chcklistbox_adaptselect.TabIndex = 0;
            // 
            // formPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.chcklistbox_adaptselect);
            this.Name = "formPreferences";
            this.Text = "Preferences";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chcklistbox_adaptselect;
    }
}