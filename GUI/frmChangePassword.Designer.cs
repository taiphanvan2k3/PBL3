namespace GUI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txtOldPass = new GUI.MyCustomControl.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new GUI.MyCustomControl.CustomTextBox();
            this.txtNewPass = new GUI.MyCustomControl.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new GUI.MyCustomControl.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnUnShowPassOld = new FontAwesome.Sharp.IconButton();
            this.btnShowPassOld = new FontAwesome.Sharp.IconButton();
            this.btnNotShow2 = new FontAwesome.Sharp.IconButton();
            this.btnDoNotShow = new FontAwesome.Sharp.IconButton();
            this.btnShow1 = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContinue = new GUI.MyCustomControl.CustomButton();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtOldPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOldPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOldPass.BorderRadius = 5;
            this.txtOldPass.BorderSize = 1;
            this.txtOldPass.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.ForeColor = System.Drawing.Color.Silver;
            this.txtOldPass.Location = new System.Drawing.Point(28, 89);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Multiline = false;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOldPass.PasswordChar = true;
            this.txtOldPass.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtOldPass.PlaceholderText = "";
            this.txtOldPass.Size = new System.Drawing.Size(285, 41);
            this.txtOldPass.TabIndex = 42;
            this.txtOldPass.Texts = "";
            this.txtOldPass.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mật khẩu cũ";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConfirmPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConfirmPass.BorderRadius = 5;
            this.txtConfirmPass.BorderSize = 1;
            this.txtConfirmPass.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPass.Location = new System.Drawing.Point(28, 232);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmPass.PasswordChar = true;
            this.txtConfirmPass.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtConfirmPass.PlaceholderText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(285, 41);
            this.txtConfirmPass.TabIndex = 36;
            this.txtConfirmPass.Texts = "";
            this.txtConfirmPass.UnderlinedStyle = false;
            this.txtConfirmPass._TextChanged += new System.EventHandler(this.txtConfirmPass__TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNewPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNewPass.BorderRadius = 5;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Silver;
            this.txtNewPass.Location = new System.Drawing.Point(28, 161);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass.PasswordChar = true;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.Size = new System.Drawing.Size(285, 41);
            this.txtNewPass.TabIndex = 35;
            this.txtNewPass.Texts = "";
            this.txtNewPass.UnderlinedStyle = false;
            this.txtNewPass._TextChanged += new System.EventHandler(this.txtNewPass__TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackGroundColor = System.Drawing.Color.Silver;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnBack.BorderRadius = 40;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(327, 290);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Hủy";
            this.btnBack.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(3, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogin.Controls.Add(this.btnUnShowPassOld);
            this.panelLogin.Controls.Add(this.btnShowPassOld);
            this.panelLogin.Controls.Add(this.txtOldPass);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.btnNotShow2);
            this.panelLogin.Controls.Add(this.btnDoNotShow);
            this.panelLogin.Controls.Add(this.btnShow1);
            this.panelLogin.Controls.Add(this.btnShow);
            this.panelLogin.Controls.Add(this.txtConfirmPass);
            this.panelLogin.Controls.Add(this.txtNewPass);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.btnBack);
            this.panelLogin.Controls.Add(this.btnContinue);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(600, 350);
            this.panelLogin.TabIndex = 2;
            // 
            // btnUnShowPassOld
            // 
            this.btnUnShowPassOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnShowPassOld.FlatAppearance.BorderSize = 0;
            this.btnUnShowPassOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnShowPassOld.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnShowPassOld.ForeColor = System.Drawing.Color.White;
            this.btnUnShowPassOld.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnUnShowPassOld.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnUnShowPassOld.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnShowPassOld.IconSize = 30;
            this.btnUnShowPassOld.Location = new System.Drawing.Point(340, 90);
            this.btnUnShowPassOld.Name = "btnUnShowPassOld";
            this.btnUnShowPassOld.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUnShowPassOld.Size = new System.Drawing.Size(40, 35);
            this.btnUnShowPassOld.TabIndex = 44;
            this.btnUnShowPassOld.UseVisualStyleBackColor = false;
            this.btnUnShowPassOld.Click += new System.EventHandler(this.btnUnShowPassOld_Click);
            // 
            // btnShowPassOld
            // 
            this.btnShowPassOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowPassOld.FlatAppearance.BorderSize = 0;
            this.btnShowPassOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassOld.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassOld.ForeColor = System.Drawing.Color.White;
            this.btnShowPassOld.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowPassOld.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnShowPassOld.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPassOld.IconSize = 30;
            this.btnShowPassOld.Location = new System.Drawing.Point(340, 90);
            this.btnShowPassOld.Name = "btnShowPassOld";
            this.btnShowPassOld.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowPassOld.Size = new System.Drawing.Size(40, 35);
            this.btnShowPassOld.TabIndex = 43;
            this.btnShowPassOld.UseVisualStyleBackColor = false;
            this.btnShowPassOld.Click += new System.EventHandler(this.btnShowPassOld_Click);
            // 
            // btnNotShow2
            // 
            this.btnNotShow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNotShow2.FlatAppearance.BorderSize = 0;
            this.btnNotShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotShow2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotShow2.ForeColor = System.Drawing.Color.White;
            this.btnNotShow2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnNotShow2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnNotShow2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotShow2.IconSize = 30;
            this.btnNotShow2.Location = new System.Drawing.Point(340, 235);
            this.btnNotShow2.Name = "btnNotShow2";
            this.btnNotShow2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNotShow2.Size = new System.Drawing.Size(40, 35);
            this.btnNotShow2.TabIndex = 40;
            this.btnNotShow2.UseVisualStyleBackColor = false;
            this.btnNotShow2.Click += new System.EventHandler(this.btnNotShow2_Click);
            // 
            // btnDoNotShow
            // 
            this.btnDoNotShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoNotShow.FlatAppearance.BorderSize = 0;
            this.btnDoNotShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoNotShow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNotShow.ForeColor = System.Drawing.Color.White;
            this.btnDoNotShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnDoNotShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnDoNotShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoNotShow.IconSize = 30;
            this.btnDoNotShow.Location = new System.Drawing.Point(340, 165);
            this.btnDoNotShow.Name = "btnDoNotShow";
            this.btnDoNotShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDoNotShow.Size = new System.Drawing.Size(40, 35);
            this.btnDoNotShow.TabIndex = 39;
            this.btnDoNotShow.UseVisualStyleBackColor = false;
            this.btnDoNotShow.Click += new System.EventHandler(this.btnDoNotShow_Click);
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShow1.FlatAppearance.BorderSize = 0;
            this.btnShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow1.ForeColor = System.Drawing.Color.White;
            this.btnShow1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShow1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnShow1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShow1.IconSize = 30;
            this.btnShow1.Location = new System.Drawing.Point(340, 235);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShow1.Size = new System.Drawing.Size(40, 35);
            this.btnShow1.TabIndex = 38;
            this.btnShow1.UseVisualStyleBackColor = false;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShow.IconSize = 30;
            this.btnShow.Location = new System.Drawing.Point(340, 165);
            this.btnShow.Name = "btnShow";
            this.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShow.Size = new System.Drawing.Size(40, 35);
            this.btnShow.TabIndex = 37;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(28, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnContinue.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnContinue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnContinue.BorderRadius = 40;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.Location = new System.Drawing.Point(440, 290);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 50);
            this.btnContinue.TabIndex = 25;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChangePassword";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnUnShowPassOld;
        private FontAwesome.Sharp.IconButton btnShowPassOld;
        private MyCustomControl.CustomTextBox txtOldPass;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnNotShow2;
        private FontAwesome.Sharp.IconButton btnDoNotShow;
        private FontAwesome.Sharp.IconButton btnShow1;
        private FontAwesome.Sharp.IconButton btnShow;
        private MyCustomControl.CustomTextBox txtConfirmPass;
        private MyCustomControl.CustomTextBox txtNewPass;
        private System.Windows.Forms.Panel panel1;
        private MyCustomControl.CustomButton btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label3;
        private MyCustomControl.CustomButton btnContinue;
    }
}