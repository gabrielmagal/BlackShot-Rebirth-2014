namespace ByteOrganizer
{
    partial class Main
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_organize_bytes = new System.Windows.Forms.Button();
            this.txb_bytes = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.txb_bytes);
            this.tabPage1.Controls.Add(this.btn_organize_bytes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ByteOrganizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_organize_bytes
            // 
            this.btn_organize_bytes.Location = new System.Drawing.Point(211, 390);
            this.btn_organize_bytes.Name = "btn_organize_bytes";
            this.btn_organize_bytes.Size = new System.Drawing.Size(155, 50);
            this.btn_organize_bytes.TabIndex = 1;
            this.btn_organize_bytes.Text = "Execute";
            this.btn_organize_bytes.UseVisualStyleBackColor = true;
            this.btn_organize_bytes.Click += new System.EventHandler(this.btn_organize_bytes_Click);
            // 
            // txb_bytes
            // 
            this.txb_bytes.Location = new System.Drawing.Point(6, 6);
            this.txb_bytes.Multiline = true;
            this.txb_bytes.Name = "txb_bytes";
            this.txb_bytes.Size = new System.Drawing.Size(595, 357);
            this.txb_bytes.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 504);
            this.tabControl1.TabIndex = 2;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 521);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSR - Developer Tools";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txb_bytes;
        private System.Windows.Forms.Button btn_organize_bytes;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

