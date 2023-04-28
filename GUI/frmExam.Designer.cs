namespace GUI
{
    partial class frmExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.avatarTopRight = new GUI.MyCustomControl.CircularPictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelDangXuat = new System.Windows.Forms.Panel();
            this.btnBackFrmStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDarkMode = new FontAwesome.Sharp.IconButton();
            this.btnHistoryDoExam = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnDoExam = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.timerCheckClick = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopRight)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panelDangXuat.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1713, 797);
            this.panel1.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.panelTitle.Controls.Add(this.avatarTopRight);
            this.panelTitle.Controls.Add(this.lblAvatar);
            this.panelTitle.Controls.Add(this.lblXinChao);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(250, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1463, 69);
            this.panelTitle.TabIndex = 3;
            // 
            // avatarTopRight
            // 
            this.avatarTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarTopRight.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.avatarTopRight.BorderColor = System.Drawing.Color.RoyalBlue;
            this.avatarTopRight.BorderColor2 = System.Drawing.Color.HotPink;
            this.avatarTopRight.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.avatarTopRight.BorderSize = 2;
            this.avatarTopRight.GradientAngle = 50F;
            this.avatarTopRight.Image = global::GUI.Properties.Resources.studentAvatar;
            this.avatarTopRight.Location = new System.Drawing.Point(1383, 6);
            this.avatarTopRight.Name = "avatarTopRight";
            this.avatarTopRight.Size = new System.Drawing.Size(57, 57);
            this.avatarTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarTopRight.TabIndex = 3;
            this.avatarTopRight.TabStop = false;
            this.avatarTopRight.Click += new System.EventHandler(this.avatarTopRight_Click);
            // 
            // lblAvatar
            // 
            this.lblAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.Location = new System.Drawing.Point(1225, 38);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(109, 20);
            this.lblAvatar.TabIndex = 2;
            this.lblAvatar.Text = "Phan Văn Tài";
            // 
            // lblXinChao
            // 
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblXinChao.Location = new System.Drawing.Point(1228, 17);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(66, 18);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.panelDangXuat);
            this.pnlMain.Location = new System.Drawing.Point(251, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1460, 728);
            this.pnlMain.TabIndex = 2;
            // 
            // panelDangXuat
            // 
            this.panelDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDangXuat.BackColor = System.Drawing.Color.OldLace;
            this.panelDangXuat.Controls.Add(this.btnBackFrmStudent);
            this.panelDangXuat.Controls.Add(this.btnDangXuat);
            this.panelDangXuat.Location = new System.Drawing.Point(1228, 2);
            this.panelDangXuat.Name = "panelDangXuat";
            this.panelDangXuat.Size = new System.Drawing.Size(228, 108);
            this.panelDangXuat.TabIndex = 0;
            this.panelDangXuat.Visible = false;
            // 
            // btnBackFrmStudent
            // 
            this.btnBackFrmStudent.BorderRadius = 15;
            this.btnBackFrmStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackFrmStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackFrmStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackFrmStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackFrmStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFrmStudent.ForeColor = System.Drawing.Color.White;
            this.btnBackFrmStudent.Location = new System.Drawing.Point(9, 5);
            this.btnBackFrmStudent.Name = "btnBackFrmStudent";
            this.btnBackFrmStudent.Size = new System.Drawing.Size(213, 45);
            this.btnBackFrmStudent.TabIndex = 1;
            this.btnBackFrmStudent.Text = "Quay lại trang sinh viên";
            this.btnBackFrmStudent.Click += new System.EventHandler(this.btnBackFrmStudent_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 15;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(7, 56);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(215, 45);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panelMenu.Controls.Add(this.btnDarkMode);
            this.panelMenu.Controls.Add(this.btnHistoryDoExam);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnDoExam);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 797);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnDarkMode.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            this.btnDarkMode.IconColor = System.Drawing.Color.White;
            this.btnDarkMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDarkMode.IconSize = 30;
            this.btnDarkMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.Location = new System.Drawing.Point(0, 358);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDarkMode.Size = new System.Drawing.Size(250, 94);
            this.btnDarkMode.TabIndex = 10;
            this.btnDarkMode.Tag = "Nền tối";
            this.btnDarkMode.Text = "Nền tối";
            this.btnDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnHistoryDoExam
            // 
            this.btnHistoryDoExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoryDoExam.FlatAppearance.BorderSize = 0;
            this.btnHistoryDoExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryDoExam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryDoExam.ForeColor = System.Drawing.Color.White;
            this.btnHistoryDoExam.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnHistoryDoExam.IconColor = System.Drawing.Color.White;
            this.btnHistoryDoExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistoryDoExam.IconSize = 30;
            this.btnHistoryDoExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryDoExam.Location = new System.Drawing.Point(0, 264);
            this.btnHistoryDoExam.Name = "btnHistoryDoExam";
            this.btnHistoryDoExam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistoryDoExam.Size = new System.Drawing.Size(250, 94);
            this.btnHistoryDoExam.TabIndex = 8;
            this.btnHistoryDoExam.Tag = "Lịch sử làm bài";
            this.btnHistoryDoExam.Text = "Lịch sử làm bài";
            this.btnHistoryDoExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryDoExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoryDoExam.UseVisualStyleBackColor = true;
            this.btnHistoryDoExam.Click += new System.EventHandler(this.btnHistoryDoExam_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 30;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 703);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 94);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Tag = "Đăng xuất";
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDoExam
            // 
            this.btnDoExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoExam.FlatAppearance.BorderSize = 0;
            this.btnDoExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoExam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoExam.ForeColor = System.Drawing.Color.White;
            this.btnDoExam.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnDoExam.IconColor = System.Drawing.Color.White;
            this.btnDoExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoExam.IconSize = 30;
            this.btnDoExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoExam.Location = new System.Drawing.Point(0, 170);
            this.btnDoExam.Name = "btnDoExam";
            this.btnDoExam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoExam.Size = new System.Drawing.Size(250, 94);
            this.btnDoExam.TabIndex = 6;
            this.btnDoExam.Tag = "Làm bài kiểm tra";
            this.btnDoExam.Text = "Làm bài kiểm tra";
            this.btnDoExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoExam.UseVisualStyleBackColor = true;
            this.btnDoExam.Click += new System.EventHandler(this.btnDoExam_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 76);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 94);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "Trang chủ";
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 76);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(190, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timerCheckClick
            // 
            this.timerCheckClick.Interval = 10;
            this.timerCheckClick.Tick += new System.EventHandler(this.timerCheckClick_Tick);
            // 
            // frmExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1713, 797);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1300, 712);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExam";
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.Resize += new System.EventHandler(this.frmExam_Resize);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopRight)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.panelDangXuat.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnDoExam;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnHistoryDoExam;
        private FontAwesome.Sharp.IconButton btnDarkMode;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panelTitle;
        private MyCustomControl.CircularPictureBox avatarTopRight;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Panel panelDangXuat;
        private System.Windows.Forms.Timer timerCheckClick;
        private Guna.UI2.WinForms.Guna2Button btnBackFrmStudent;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
    }
}