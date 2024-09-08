namespace BlackShotLegacy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foreverStatusBar1 = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.crownSeparator1 = new ReaLTaiizor.Controls.CrownSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.btn_info = new ReaLTaiizor.Controls.ForeverButton();
            this.btn_reset_password = new ReaLTaiizor.Controls.ForeverButton();
            this.txb_password = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txb_user = new ReaLTaiizor.Controls.PoisonTextBox();
            this.btn_close = new ReaLTaiizor.Controls.ForeverButton();
            this.btn_connect = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.pictureBox1);
            this.foreverForm1.Controls.Add(this.foreverStatusBar1);
            this.foreverForm1.Controls.Add(this.labelEdit1);
            this.foreverForm1.Controls.Add(this.crownSeparator1);
            this.foreverForm1.Controls.Add(this.panel3);
            this.foreverForm1.Controls.Add(this.panel2);
            this.foreverForm1.Controls.Add(this.panel1);
            this.foreverForm1.Controls.Add(this.btn_info);
            this.foreverForm1.Controls.Add(this.btn_reset_password);
            this.foreverForm1.Controls.Add(this.txb_password);
            this.foreverForm1.Controls.Add(this.txb_user);
            this.foreverForm1.Controls.Add(this.btn_close);
            this.foreverForm1.Controls.Add(this.btn_connect);
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
            this.foreverForm1.Size = new System.Drawing.Size(805, 535);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "[BSR] - Launcher BlackShot Rebirth - v1.0.6";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.SeaGreen;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox1.BackgroundImage = global::BlackShotRebirth.Properties.Resources.image_bg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 433);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // foreverStatusBar1
            // 
            this.foreverStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreverStatusBar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverStatusBar1.ForeColor = System.Drawing.Color.White;
            this.foreverStatusBar1.Location = new System.Drawing.Point(1, 502);
            this.foreverStatusBar1.Name = "foreverStatusBar1";
            this.foreverStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverStatusBar1.ShowTimeDate = false;
            this.foreverStatusBar1.Size = new System.Drawing.Size(803, 32);
            this.foreverStatusBar1.TabIndex = 19;
            this.foreverStatusBar1.Text = "Wating for login...";
            this.foreverStatusBar1.TextColor = System.Drawing.Color.White;
            this.foreverStatusBar1.TimeColor = System.Drawing.Color.White;
            this.foreverStatusBar1.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEdit1.Location = new System.Drawing.Point(606, 78);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(184, 30);
            this.labelEdit1.TabIndex = 17;
            this.labelEdit1.Text = "Login Information:";
            // 
            // crownSeparator1
            // 
            this.crownSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crownSeparator1.Location = new System.Drawing.Point(1, 51);
            this.crownSeparator1.Name = "crownSeparator1";
            this.crownSeparator1.Size = new System.Drawing.Size(803, 2);
            this.crownSeparator1.TabIndex = 16;
            this.crownSeparator1.Text = "crownSeparator1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 5);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.foreverLabel1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(607, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 82);
            this.panel1.TabIndex = 15;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(3, 0);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(107, 63);
            this.foreverLabel1.TabIndex = 12;
            this.foreverLabel1.Text = "Credits: \r\nBSR-N1NJ4\r\nBSR-S4MUR4Y";
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_info.Location = new System.Drawing.Point(714, 13);
            this.btn_info.Name = "btn_info";
            this.btn_info.Rounded = false;
            this.btn_info.Size = new System.Drawing.Size(37, 32);
            this.btn_info.TabIndex = 14;
            this.btn_info.Text = "?";
            this.btn_info.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_reset_password
            // 
            this.btn_reset_password.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset_password.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_reset_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_reset_password.Location = new System.Drawing.Point(607, 267);
            this.btn_reset_password.Name = "btn_reset_password";
            this.btn_reset_password.Rounded = false;
            this.btn_reset_password.Size = new System.Drawing.Size(190, 35);
            this.btn_reset_password.TabIndex = 13;
            this.btn_reset_password.Text = "Forgot Password";
            this.btn_reset_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_reset_password.Click += new System.EventHandler(this.btn_reset_password_Click);
            // 
            // txb_password
            // 
            this.txb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // 
            // 
            this.txb_password.CustomButton.Image = null;
            this.txb_password.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.txb_password.CustomButton.Name = "";
            this.txb_password.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txb_password.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txb_password.CustomButton.TabIndex = 1;
            this.txb_password.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txb_password.CustomButton.UseSelectable = true;
            this.txb_password.CustomButton.Visible = false;
            this.txb_password.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            this.txb_password.ForeColor = System.Drawing.Color.Silver;
            this.txb_password.Lines = new string[0];
            this.txb_password.Location = new System.Drawing.Point(607, 153);
            this.txb_password.MaxLength = 10;
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.PromptText = "Password";
            this.txb_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_password.SelectedText = "";
            this.txb_password.SelectionLength = 0;
            this.txb_password.SelectionStart = 0;
            this.txb_password.ShortcutsEnabled = true;
            this.txb_password.Size = new System.Drawing.Size(190, 32);
            this.txb_password.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.txb_password.TabIndex = 11;
            this.txb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_password.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.txb_password.UseCustomBackColor = true;
            this.txb_password.UseCustomForeColor = true;
            this.txb_password.UseSelectable = true;
            this.txb_password.WaterMark = "Password";
            this.txb_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txb_user
            // 
            this.txb_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // 
            // 
            this.txb_user.CustomButton.Image = null;
            this.txb_user.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.txb_user.CustomButton.Name = "";
            this.txb_user.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txb_user.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txb_user.CustomButton.TabIndex = 1;
            this.txb_user.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txb_user.CustomButton.UseSelectable = true;
            this.txb_user.CustomButton.Visible = false;
            this.txb_user.FontSize = ReaLTaiizor.Extension.Poison.PoisonTextBoxSize.Medium;
            this.txb_user.ForeColor = System.Drawing.Color.Silver;
            this.txb_user.Lines = new string[0];
            this.txb_user.Location = new System.Drawing.Point(607, 114);
            this.txb_user.MaxLength = 10;
            this.txb_user.Multiline = true;
            this.txb_user.Name = "txb_user";
            this.txb_user.PasswordChar = '\0';
            this.txb_user.PromptText = "Username";
            this.txb_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_user.SelectedText = "";
            this.txb_user.SelectionLength = 0;
            this.txb_user.SelectionStart = 0;
            this.txb_user.ShortcutsEnabled = true;
            this.txb_user.Size = new System.Drawing.Size(190, 32);
            this.txb_user.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            this.txb_user.TabIndex = 10;
            this.txb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_user.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.txb_user.UseCustomBackColor = true;
            this.txb_user.UseCustomForeColor = true;
            this.txb_user.UseSelectable = true;
            this.txb_user.WaterMark = "Username";
            this.txb_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_close.Location = new System.Drawing.Point(757, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rounded = false;
            this.btn_close.Size = new System.Drawing.Size(37, 32);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_connect.Location = new System.Drawing.Point(607, 192);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Rounded = false;
            this.btn_connect.Size = new System.Drawing.Size(190, 68);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Start Game";
            this.btn_connect.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 535);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverButton btn_connect;
        private ReaLTaiizor.Controls.ForeverButton btn_close;
        private ReaLTaiizor.Controls.PoisonTextBox txb_user;
        private ReaLTaiizor.Controls.PoisonTextBox txb_password;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverButton btn_reset_password;
        private ReaLTaiizor.Controls.ForeverButton btn_info;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.CrownSeparator crownSeparator1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ForeverStatusBar foreverStatusBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

