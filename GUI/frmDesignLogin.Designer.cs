namespace GUI
{
    partial class frmDesignLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnForgetPass = new System.Windows.Forms.Label();
            this.btnSignIn = new GUI.MyCustomControl.CustomButton();
            this.txtPassword = new GUI.MyCustomControl.CustomTextBox();
            this.txtUsername = new GUI.MyCustomControl.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new GUI.MyCustomControl.CircularPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinisize = new FontAwesome.Sharp.IconButton();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(144, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chào mừng quay trở lại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(153, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(153, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 1);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(155, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tài khoản";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogin.Controls.Add(this.btnForgetPass);
            this.panelLogin.Controls.Add(this.btnSignIn);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.circularPictureBox1);
            this.panelLogin.Location = new System.Drawing.Point(200, 25);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(600, 550);
            this.panelLogin.TabIndex = 0;
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.AutoSize = true;
            this.btnForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnForgetPass.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.ForeColor = System.Drawing.Color.White;
            this.btnForgetPass.Location = new System.Drawing.Point(238, 494);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(128, 19);
            this.btnForgetPass.TabIndex = 25;
            this.btnForgetPass.Text = "Quên mật khẩu?";
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            this.btnForgetPass.MouseLeave += new System.EventHandler(this.btnForgetPass_MouseLeave);
            this.btnForgetPass.MouseHover += new System.EventHandler(this.btnForgetPass_MouseHover);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnSignIn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnSignIn.BorderRadius = 40;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.Location = new System.Drawing.Point(225, 410);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(150, 50);
            this.btnSignIn.TabIndex = 24;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(153, 331);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(294, 46);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(153, 249);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.Size = new System.Drawing.Size(294, 46);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername._TextChanged += new System.EventHandler(this.txtUsername__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(155, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.DarkOrchid;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = global::GUI.Properties.Resources.LogoPBL3;
            this.circularPictureBox1.Location = new System.Drawing.Point(225, 20);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 0;
            this.circularPictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnClose.IconColor = System.Drawing.Color.IndianRed;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(970, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinisize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinisize.IconSize = 30;
            this.btnMinisize.Location = new System.Drawing.Point(940, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMinisize.Size = new System.Drawing.Size(30, 30);
            this.btnMinisize.TabIndex = 11;
            this.btnMinisize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinisize.UseVisualStyleBackColor = false;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // frmDesignLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GUI.Properties.Resources.backroud1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDesignLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDesignLogin";
            this.Load += new System.EventHandler(this.frmDesignLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDesignLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomTextBox txtUsername;
        private MyCustomControl.CustomTextBox txtPassword;
        private MyCustomControl.CustomButton btnSignIn;
        private System.Windows.Forms.Label btnForgetPass;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinisize;
    }
}