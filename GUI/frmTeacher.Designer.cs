namespace GUI
{
    partial class frmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlManageClass = new System.Windows.Forms.Panel();
            this.pnlViewCalendar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSendAnnounce = new System.Windows.Forms.Button();
            this.btnManageClass = new System.Windows.Forms.Button();
            this.btnChangeGrade = new System.Windows.Forms.Button();
            this.btnCalendarDays = new System.Windows.Forms.Button();
            this.btnCalendarWeek = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnDarkMode = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flPanel.SuspendLayout();
            this.pnlManageClass.SuspendLayout();
            this.pnlViewCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(250, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1119, 663);
            this.pnlMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 665);
            this.panel1.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.flPanel);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 665);
            this.panelMenu.TabIndex = 1;
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
            // flPanel
            // 
            this.flPanel.Controls.Add(this.btnHome);
            this.flPanel.Controls.Add(this.btnInfo);
            this.flPanel.Controls.Add(this.pnlManageClass);
            this.flPanel.Controls.Add(this.pnlViewCalendar);
            this.flPanel.Controls.Add(this.btnDarkMode);
            this.flPanel.Location = new System.Drawing.Point(0, 76);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(250, 496);
            this.flPanel.TabIndex = 8;
            // 
            // pnlManageClass
            // 
            this.pnlManageClass.Controls.Add(this.btnCreateQuestion);
            this.pnlManageClass.Controls.Add(this.button2);
            this.pnlManageClass.Controls.Add(this.btnSendAnnounce);
            this.pnlManageClass.Controls.Add(this.btnManageClass);
            this.pnlManageClass.Controls.Add(this.btnChangeGrade);
            this.pnlManageClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlManageClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlManageClass.Location = new System.Drawing.Point(3, 151);
            this.pnlManageClass.Name = "pnlManageClass";
            this.pnlManageClass.Size = new System.Drawing.Size(250, 68);
            this.pnlManageClass.TabIndex = 7;
            // 
            // pnlViewCalendar
            // 
            this.pnlViewCalendar.Controls.Add(this.btnCalendarDays);
            this.pnlViewCalendar.Controls.Add(this.btnCalendarWeek);
            this.pnlViewCalendar.Controls.Add(this.btnCalendar);
            this.pnlViewCalendar.Location = new System.Drawing.Point(3, 225);
            this.pnlViewCalendar.Name = "pnlViewCalendar";
            this.pnlViewCalendar.Size = new System.Drawing.Size(250, 68);
            this.pnlViewCalendar.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoPBL3;
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
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 68);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 30;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(3, 77);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(250, 68);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Tag = "Thông tin cá nhân";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCreateQuestion.FlatAppearance.BorderSize = 0;
            this.btnCreateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuestion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateQuestion.Image = global::GUI.Properties.Resources.CreateQuestion;
            this.btnCreateQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQuestion.Location = new System.Drawing.Point(26, 272);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCreateQuestion.Size = new System.Drawing.Size(224, 68);
            this.btnCreateQuestion.TabIndex = 16;
            this.btnCreateQuestion.Tag = "Tạo câu hỏi";
            this.btnCreateQuestion.UseVisualStyleBackColor = false;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Image = global::GUI.Properties.Resources.Homeroom;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(26, 204);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(224, 68);
            this.button2.TabIndex = 15;
            this.button2.Tag = "Lớp sinh hoạt";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSendAnnounce
            // 
            this.btnSendAnnounce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnSendAnnounce.FlatAppearance.BorderSize = 0;
            this.btnSendAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendAnnounce.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendAnnounce.Image = global::GUI.Properties.Resources.SendAnnounce;
            this.btnSendAnnounce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendAnnounce.Location = new System.Drawing.Point(26, 136);
            this.btnSendAnnounce.Name = "btnSendAnnounce";
            this.btnSendAnnounce.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSendAnnounce.Size = new System.Drawing.Size(224, 68);
            this.btnSendAnnounce.TabIndex = 14;
            this.btnSendAnnounce.Tag = "Gửi thông báo";
            this.btnSendAnnounce.UseVisualStyleBackColor = false;
            // 
            // btnManageClass
            // 
            this.btnManageClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnManageClass.FlatAppearance.BorderSize = 0;
            this.btnManageClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClass.Image = global::GUI.Properties.Resources.ManageClass;
            this.btnManageClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageClass.Location = new System.Drawing.Point(0, 0);
            this.btnManageClass.Name = "btnManageClass";
            this.btnManageClass.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnManageClass.Size = new System.Drawing.Size(250, 68);
            this.btnManageClass.TabIndex = 13;
            this.btnManageClass.Tag = "     Quản lí lớp";
            this.btnManageClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageClass.UseVisualStyleBackColor = false;
            this.btnManageClass.Click += new System.EventHandler(this.btnManageClass_Click);
            // 
            // btnChangeGrade
            // 
            this.btnChangeGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnChangeGrade.FlatAppearance.BorderSize = 0;
            this.btnChangeGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeGrade.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChangeGrade.Image = global::GUI.Properties.Resources.ChangeGrade;
            this.btnChangeGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeGrade.Location = new System.Drawing.Point(26, 68);
            this.btnChangeGrade.Name = "btnChangeGrade";
            this.btnChangeGrade.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnChangeGrade.Size = new System.Drawing.Size(224, 68);
            this.btnChangeGrade.TabIndex = 12;
            this.btnChangeGrade.Tag = "Chỉnh sửa điểm";
            this.btnChangeGrade.UseVisualStyleBackColor = false;
            // 
            // btnCalendarDays
            // 
            this.btnCalendarDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCalendarDays.FlatAppearance.BorderSize = 0;
            this.btnCalendarDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarDays.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendarDays.Image = global::GUI.Properties.Resources.calendar_date;
            this.btnCalendarDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendarDays.Location = new System.Drawing.Point(26, 68);
            this.btnCalendarDays.Name = "btnCalendarDays";
            this.btnCalendarDays.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendarDays.Size = new System.Drawing.Size(224, 68);
            this.btnCalendarDays.TabIndex = 18;
            this.btnCalendarDays.Tag = " Lịch dạy theo ngày";
            this.btnCalendarDays.UseVisualStyleBackColor = false;
            // 
            // btnCalendarWeek
            // 
            this.btnCalendarWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCalendarWeek.FlatAppearance.BorderSize = 0;
            this.btnCalendarWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarWeek.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalendarWeek.Image = global::GUI.Properties.Resources.Calendar_week;
            this.btnCalendarWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendarWeek.Location = new System.Drawing.Point(26, 136);
            this.btnCalendarWeek.Name = "btnCalendarWeek";
            this.btnCalendarWeek.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendarWeek.Size = new System.Drawing.Size(224, 68);
            this.btnCalendarWeek.TabIndex = 17;
            this.btnCalendarWeek.Tag = " Lịch dạy theo tuần";
            this.btnCalendarWeek.UseVisualStyleBackColor = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalendar.Image = global::GUI.Properties.Resources.calendar_day;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(250, 68);
            this.btnCalendar.TabIndex = 16;
            this.btnCalendar.Tag = "     Xem lịch";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnDarkMode.IconChar = FontAwesome.Sharp.IconChar.CircleHalfStroke;
            this.btnDarkMode.IconColor = System.Drawing.Color.White;
            this.btnDarkMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDarkMode.IconSize = 30;
            this.btnDarkMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.Location = new System.Drawing.Point(3, 299);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDarkMode.Size = new System.Drawing.Size(250, 68);
            this.btnDarkMode.TabIndex = 10;
            this.btnDarkMode.Tag = "Nền tối";
            this.btnDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 597);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 68);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Tag = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1372, 665);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacher";
            this.Text = "Teacher";
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flPanel.ResumeLayout(false);
            this.pnlManageClass.ResumeLayout(false);
            this.pnlViewCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDarkMode;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Panel pnlManageClass;
        private System.Windows.Forms.Panel pnlViewCalendar;
        private System.Windows.Forms.Button btnChangeGrade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSendAnnounce;
        private System.Windows.Forms.Button btnManageClass;
        private System.Windows.Forms.Button btnCalendarDays;
        private System.Windows.Forms.Button btnCalendarWeek;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnCreateQuestion;
    }
}