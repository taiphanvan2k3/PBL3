﻿namespace GUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlManageClass = new System.Windows.Forms.Panel();
            this.btnSendAnnounce = new System.Windows.Forms.Button();
            this.btnViewListDoExam = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.btnHomeRoomClass = new System.Windows.Forms.Button();
            this.btnManageClass = new System.Windows.Forms.Button();
            this.pnlViewCalendar = new System.Windows.Forms.Panel();
            this.btnCalendarDays = new System.Windows.Forms.Button();
            this.btnCalendarWeek = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flPanel.SuspendLayout();
            this.pnlManageClass.SuspendLayout();
            this.pnlViewCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Location = new System.Drawing.Point(250, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1182, 798);
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
            this.panel1.Size = new System.Drawing.Size(1432, 803);
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
            this.panelMenu.Size = new System.Drawing.Size(250, 803);
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
            // flPanel
            // 
            this.flPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flPanel.Controls.Add(this.btnHome);
            this.flPanel.Controls.Add(this.pnlManageClass);
            this.flPanel.Controls.Add(this.pnlViewCalendar);
            this.flPanel.Location = new System.Drawing.Point(0, 76);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(250, 653);
            this.flPanel.TabIndex = 8;
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
            // pnlManageClass
            // 
            this.pnlManageClass.Controls.Add(this.btnSendAnnounce);
            this.pnlManageClass.Controls.Add(this.btnViewListDoExam);
            this.pnlManageClass.Controls.Add(this.btnCreateQuestion);
            this.pnlManageClass.Controls.Add(this.btnCreateExam);
            this.pnlManageClass.Controls.Add(this.btnHomeRoomClass);
            this.pnlManageClass.Controls.Add(this.btnManageClass);
            this.pnlManageClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlManageClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlManageClass.Location = new System.Drawing.Point(3, 77);
            this.pnlManageClass.Name = "pnlManageClass";
            this.pnlManageClass.Size = new System.Drawing.Size(250, 68);
            this.pnlManageClass.TabIndex = 7;
            // 
            // btnSendAnnounce
            // 
            this.btnSendAnnounce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnSendAnnounce.FlatAppearance.BorderSize = 0;
            this.btnSendAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendAnnounce.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAnnounce.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendAnnounce.Image = global::GUI.Properties.Resources.SendAnnounce;
            this.btnSendAnnounce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendAnnounce.Location = new System.Drawing.Point(26, 340);
            this.btnSendAnnounce.Name = "btnSendAnnounce";
            this.btnSendAnnounce.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSendAnnounce.Size = new System.Drawing.Size(224, 68);
            this.btnSendAnnounce.TabIndex = 14;
            this.btnSendAnnounce.Tag = "   Gửi thông báo";
            this.btnSendAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendAnnounce.UseVisualStyleBackColor = false;
            this.btnSendAnnounce.Click += new System.EventHandler(this.btnSendAnnounce_Click);
            // 
            // btnViewListDoExam
            // 
            this.btnViewListDoExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnViewListDoExam.FlatAppearance.BorderSize = 0;
            this.btnViewListDoExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewListDoExam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListDoExam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewListDoExam.Image = global::GUI.Properties.Resources.ChangeGrade;
            this.btnViewListDoExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewListDoExam.Location = new System.Drawing.Point(26, 204);
            this.btnViewListDoExam.Name = "btnViewListDoExam";
            this.btnViewListDoExam.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnViewListDoExam.Size = new System.Drawing.Size(224, 68);
            this.btnViewListDoExam.TabIndex = 12;
            this.btnViewListDoExam.Tag = "   Thống kê điểm";
            this.btnViewListDoExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewListDoExam.UseVisualStyleBackColor = false;
            this.btnViewListDoExam.Click += new System.EventHandler(this.btnViewListDoExam_Click);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCreateQuestion.FlatAppearance.BorderSize = 0;
            this.btnCreateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuestion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateQuestion.Image = global::GUI.Properties.Resources.CreateQuestion;
            this.btnCreateQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQuestion.Location = new System.Drawing.Point(26, 272);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCreateQuestion.Size = new System.Drawing.Size(224, 68);
            this.btnCreateQuestion.TabIndex = 17;
            this.btnCreateQuestion.Tag = "   Tạo câu hỏi";
            this.btnCreateQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQuestion.UseVisualStyleBackColor = false;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCreateExam.FlatAppearance.BorderSize = 0;
            this.btnCreateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateExam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateExam.Image = global::GUI.Properties.Resources.createExam;
            this.btnCreateExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateExam.Location = new System.Drawing.Point(26, 136);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCreateExam.Size = new System.Drawing.Size(224, 68);
            this.btnCreateExam.TabIndex = 16;
            this.btnCreateExam.Tag = "   Tạo bài kiểm tra";
            this.btnCreateExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateExam.UseVisualStyleBackColor = false;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // btnHomeRoomClass
            // 
            this.btnHomeRoomClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnHomeRoomClass.FlatAppearance.BorderSize = 0;
            this.btnHomeRoomClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeRoomClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeRoomClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHomeRoomClass.Image = global::GUI.Properties.Resources.Homeroom;
            this.btnHomeRoomClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeRoomClass.Location = new System.Drawing.Point(26, 68);
            this.btnHomeRoomClass.Name = "btnHomeRoomClass";
            this.btnHomeRoomClass.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHomeRoomClass.Size = new System.Drawing.Size(224, 68);
            this.btnHomeRoomClass.TabIndex = 15;
            this.btnHomeRoomClass.Tag = "   Lớp sinh hoạt";
            this.btnHomeRoomClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeRoomClass.UseVisualStyleBackColor = false;
            this.btnHomeRoomClass.Click += new System.EventHandler(this.btnHomeRoomClass_Click);
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
            // pnlViewCalendar
            // 
            this.pnlViewCalendar.Controls.Add(this.btnCalendarDays);
            this.pnlViewCalendar.Controls.Add(this.btnCalendarWeek);
            this.pnlViewCalendar.Controls.Add(this.btnCalendar);
            this.pnlViewCalendar.Location = new System.Drawing.Point(3, 151);
            this.pnlViewCalendar.Name = "pnlViewCalendar";
            this.pnlViewCalendar.Size = new System.Drawing.Size(250, 68);
            this.pnlViewCalendar.TabIndex = 9;
            // 
            // btnCalendarDays
            // 
            this.btnCalendarDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCalendarDays.FlatAppearance.BorderSize = 0;
            this.btnCalendarDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarDays.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarDays.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalendarDays.Image = global::GUI.Properties.Resources.calendar_date;
            this.btnCalendarDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendarDays.Location = new System.Drawing.Point(26, 68);
            this.btnCalendarDays.Name = "btnCalendarDays";
            this.btnCalendarDays.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendarDays.Size = new System.Drawing.Size(224, 68);
            this.btnCalendarDays.TabIndex = 18;
            this.btnCalendarDays.Tag = " Lịch dạy theo ngày";
            this.btnCalendarDays.UseVisualStyleBackColor = false;
            this.btnCalendarDays.Click += new System.EventHandler(this.btnCalendarDays_Click);
            // 
            // btnCalendarWeek
            // 
            this.btnCalendarWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnCalendarWeek.FlatAppearance.BorderSize = 0;
            this.btnCalendarWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarWeek.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarWeek.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalendarWeek.Image = global::GUI.Properties.Resources.Calendar_week;
            this.btnCalendarWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendarWeek.Location = new System.Drawing.Point(26, 136);
            this.btnCalendarWeek.Name = "btnCalendarWeek";
            this.btnCalendarWeek.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendarWeek.Size = new System.Drawing.Size(224, 68);
            this.btnCalendarWeek.TabIndex = 17;
            this.btnCalendarWeek.Tag = " Lịch dạy theo tuần";
            this.btnCalendarWeek.UseVisualStyleBackColor = false;
            this.btnCalendarWeek.Click += new System.EventHandler(this.btnCalendarWeek_Click);
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 735);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 68);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Tag = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flPanel.ResumeLayout(false);
            this.pnlManageClass.ResumeLayout(false);
            this.pnlViewCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Panel pnlManageClass;
        private System.Windows.Forms.Panel pnlViewCalendar;
        private System.Windows.Forms.Button btnViewListDoExam;
        private System.Windows.Forms.Button btnHomeRoomClass;
        private System.Windows.Forms.Button btnSendAnnounce;
        private System.Windows.Forms.Button btnManageClass;
        private System.Windows.Forms.Button btnCalendarDays;
        private System.Windows.Forms.Button btnCalendarWeek;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Button btnCreateQuestion;
    }
}