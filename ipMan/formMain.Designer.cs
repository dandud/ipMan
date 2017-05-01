namespace ipMan
{
    partial class formMain
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
            this.cboAdapterSel = new System.Windows.Forms.ComboBox();
            this.btnAdapterRefresh = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboAdapterSel
            // 
            this.cboAdapterSel.AllowDrop = true;
            this.cboAdapterSel.FormatString = "###.###.###";
            this.cboAdapterSel.FormattingEnabled = true;
            this.cboAdapterSel.Location = new System.Drawing.Point(74, 327);
            this.cboAdapterSel.Name = "cboAdapterSel";
            this.cboAdapterSel.Size = new System.Drawing.Size(125, 21);
            this.cboAdapterSel.TabIndex = 0;
            // 
            // btnAdapterRefresh
            // 
            this.btnAdapterRefresh.BackgroundImage = global::ipMan.Properties.Resources.imgRefresh;
            this.btnAdapterRefresh.Location = new System.Drawing.Point(12, 27);
            this.btnAdapterRefresh.Name = "btnAdapterRefresh";
            this.btnAdapterRefresh.Size = new System.Drawing.Size(28, 29);
            this.btnAdapterRefresh.TabIndex = 1;
            this.btnAdapterRefresh.UseVisualStyleBackColor = true;
            this.btnAdapterRefresh.Click += new System.EventHandler(this.btnAdapterRefresh_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(955, 173);
            this.listBox1.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 375);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdapterRefresh);
            this.Controls.Add(this.cboAdapterSel);
            this.Name = "formMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAdapterSel;
        private System.Windows.Forms.Button btnAdapterRefresh;
        private System.Windows.Forms.ListBox listBox1;
    }
}

