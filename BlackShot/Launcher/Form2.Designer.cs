namespace BlackShotLegacy
{
    partial class Form2
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
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
            this.btn_close = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.foreverLabel1);
            this.foreverForm1.Controls.Add(this.foreverTextBox1);
            this.foreverForm1.Controls.Add(this.btn_close);
            this.foreverForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreverForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverForm1.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverForm1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverForm1.HeaderMaximize = false;
            this.foreverForm1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverForm1.Image = null;
            this.foreverForm1.Location = new System.Drawing.Point(0, 0);
            this.foreverForm1.MinimumSize = new System.Drawing.Size(210, 50);
            this.foreverForm1.Name = "foreverForm1";
            this.foreverForm1.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.foreverForm1.Sizable = false;
            this.foreverForm1.Size = new System.Drawing.Size(618, 671);
            this.foreverForm1.TabIndex = 1;
            this.foreverForm1.Text = "[BSR] - Info";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(266, 64);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(87, 20);
            this.foreverLabel1.TabIndex = 13;
            this.foreverLabel1.Text = "Changelog:";
            // 
            // foreverTextBox1
            // 
            this.foreverTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTextBox1.FocusOnHover = false;
            this.foreverTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBox1.Location = new System.Drawing.Point(34, 87);
            this.foreverTextBox1.MaxLength = 32767;
            this.foreverTextBox1.Multiline = true;
            this.foreverTextBox1.Name = "foreverTextBox1";
            this.foreverTextBox1.ReadOnly = false;
            this.foreverTextBox1.Size = new System.Drawing.Size(550, 570);
            this.foreverTextBox1.TabIndex = 7;
            this.foreverTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBox1.UseSystemPasswordChar = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_close.Location = new System.Drawing.Point(577, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rounded = false;
            this.btn_close.Size = new System.Drawing.Size(37, 32);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 671);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverButton btn_close;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
    }
}