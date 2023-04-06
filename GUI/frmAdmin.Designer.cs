namespace GUI
{
    partial class frmAdmin
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularPictureBox = new GUI.MyCustomControl.CircularPictureBox();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.btnCalendarExpand = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpandMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLop = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnLopArrowDown = new FontAwesome.Sharp.IconButton();
            this.timerExpandClass = new System.Windows.Forms.Timer(this.components);
            this.timerExpandCalendar = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panelMenuTong = new System.Windows.Forms.Panel();
            this.panelShowDetail = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).BeginInit();
            this.panelCalendar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelLop.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenuTong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.circularPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 69);
            this.panel3.TabIndex = 2;
            // 
            // circularPictureBox
            // 
            this.circularPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox.BorderSize = 2;
            this.circularPictureBox.GradientAngle = 50F;
            this.circularPictureBox.Image = global::GUI.Properties.Resources._294355517_1105843533621186_1411223748583159430_n;
            this.circularPictureBox.InitialImage = global::GUI.Properties.Resources.studentAvatar;
            this.circularPictureBox.Location = new System.Drawing.Point(1192, 8);
            this.circularPictureBox.Name = "circularPictureBox";
            this.circularPictureBox.Size = new System.Drawing.Size(58, 58);
            this.circularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox.TabIndex = 0;
            this.circularPictureBox.TabStop = false;
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnCalendar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(4, 6);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(179, 36);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "Lớp học";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.iconButton10);
            this.panelCalendar.Controls.Add(this.iconButton9);
            this.panelCalendar.Controls.Add(this.btnCalendarExpand);
            this.panelCalendar.Controls.Add(this.btnCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(3, 202);
            this.panelCalendar.MaximumSize = new System.Drawing.Size(217, 156);
            this.panelCalendar.MinimumSize = new System.Drawing.Size(217, 53);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(217, 53);
            this.panelCalendar.TabIndex = 7;
            // 
            // iconButton10
            // 
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(21, 104);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(176, 57);
            this.iconButton10.TabIndex = 7;
            this.iconButton10.Text = "     Thêm sinh viên";
            this.iconButton10.UseVisualStyleBackColor = true;
            // 
            // iconButton9
            // 
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(21, 48);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(162, 57);
            this.iconButton9.TabIndex = 6;
            this.iconButton9.Text = "     Thêm giảng viên";
            this.iconButton9.UseVisualStyleBackColor = true;
            // 
            // btnCalendarExpand
            // 
            this.btnCalendarExpand.FlatAppearance.BorderSize = 0;
            this.btnCalendarExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnCalendarExpand.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnCalendarExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendarExpand.IconSize = 25;
            this.btnCalendarExpand.Location = new System.Drawing.Point(179, 6);
            this.btnCalendarExpand.Name = "btnCalendarExpand";
            this.btnCalendarExpand.Size = new System.Drawing.Size(37, 40);
            this.btnCalendarExpand.TabIndex = 5;
            this.btnCalendarExpand.UseVisualStyleBackColor = true;
            this.btnCalendarExpand.Click += new System.EventHandler(this.btnCalendarExpand_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panelLop);
            this.flowLayoutPanel1.Controls.Add(this.panelCalendar);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 591);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpandMenu);
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnExpandMenu
            // 
            this.btnExpandMenu.FlatAppearance.BorderSize = 0;
            this.btnExpandMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnExpandMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnExpandMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandMenu.IconSize = 33;
            this.btnExpandMenu.Location = new System.Drawing.Point(162, 12);
            this.btnExpandMenu.Name = "btnExpandMenu";
            this.btnExpandMenu.Size = new System.Drawing.Size(54, 44);
            this.btnExpandMenu.TabIndex = 0;
            this.btnExpandMenu.UseVisualStyleBackColor = true;
            this.btnExpandMenu.Click += new System.EventHandler(this.btnExpandMenu_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::GUI.Properties.Resources.Back;
            this.pictureBoxMenu.Location = new System.Drawing.Point(4, 6);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Location = new System.Drawing.Point(3, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 59);
            this.panel4.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(189, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(this.iconButton8);
            this.panelLop.Controls.Add(this.btnLopArrowDown);
            this.panelLop.Controls.Add(this.iconButton7);
            this.panelLop.Controls.Add(this.btnClass);
            this.panelLop.Location = new System.Drawing.Point(3, 140);
            this.panelLop.MaximumSize = new System.Drawing.Size(217, 153);
            this.panelLop.MinimumSize = new System.Drawing.Size(217, 56);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(217, 56);
            this.panelLop.TabIndex = 2;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 35;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(36, 104);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(186, 46);
            this.iconButton8.TabIndex = 11;
            this.iconButton8.Text = "        Lớp học phần";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 35;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(36, 52);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(171, 46);
            this.iconButton7.TabIndex = 10;
            this.iconButton7.Text = "        Lớp sinh hoạt";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 35;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(10, 7);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(173, 38);
            this.btnClass.TabIndex = 9;
            this.btnClass.Text = "Thêm ";
            this.btnClass.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton4);
            this.panel5.Location = new System.Drawing.Point(3, 261);
            this.panel5.MaximumSize = new System.Drawing.Size(217, 153);
            this.panel5.MinimumSize = new System.Drawing.Size(217, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 56);
            this.panel5.TabIndex = 8;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(10, 7);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(154, 38);
            this.iconButton4.TabIndex = 9;
            this.iconButton4.Text = "Search";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // btnLopArrowDown
            // 
            this.btnLopArrowDown.FlatAppearance.BorderSize = 0;
            this.btnLopArrowDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnLopArrowDown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLopArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLopArrowDown.IconSize = 25;
            this.btnLopArrowDown.Location = new System.Drawing.Point(178, 8);
            this.btnLopArrowDown.Name = "btnLopArrowDown";
            this.btnLopArrowDown.Size = new System.Drawing.Size(33, 40);
            this.btnLopArrowDown.TabIndex = 6;
            this.btnLopArrowDown.UseVisualStyleBackColor = true;
            this.btnLopArrowDown.Click += new System.EventHandler(this.btnLopArrowDown_Click);
            // 
            // timerExpandClass
            // 
            this.timerExpandClass.Interval = 150;
            this.timerExpandClass.Tick += new System.EventHandler(this.timerExpandClass_Tick);
            // 
            // timerExpandCalendar
            // 
            this.timerExpandCalendar.Interval = 150;
            this.timerExpandCalendar.Tick += new System.EventHandler(this.timerExpandCalendar_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(3, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 67);
            this.panel2.TabIndex = 8;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(9, 9);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(205, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panelMenuTong
            // 
            this.panelMenuTong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.panelMenuTong.Controls.Add(this.flowLayoutPanel1);
            this.panelMenuTong.Controls.Add(this.panel2);
            this.panelMenuTong.Location = new System.Drawing.Point(2, 0);
            this.panelMenuTong.Name = "panelMenuTong";
            this.panelMenuTong.Size = new System.Drawing.Size(237, 674);
            this.panelMenuTong.TabIndex = 10;
            // 
            // panelShowDetail
            // 
            this.panelShowDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShowDetail.AutoScroll = true;
            this.panelShowDetail.BackColor = System.Drawing.Color.White;
            this.panelShowDetail.Location = new System.Drawing.Point(239, 70);
            this.panelShowDetail.Name = "panelShowDetail";
            this.panelShowDetail.Size = new System.Drawing.Size(1023, 601);
            this.panelShowDetail.TabIndex = 11;
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelShowDetail);
            this.Controls.Add(this.panelMenuTong);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "frmAdmin";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelLop.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMenuTong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCalendar;
        private System.Windows.Forms.Panel panel3;
        private MyCustomControl.CircularPictureBox circularPictureBox;
        private System.Windows.Forms.Panel panelCalendar;
        private FontAwesome.Sharp.IconButton btnCalendarExpand;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExpandMenu;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLop;
        private FontAwesome.Sharp.IconButton btnLopArrowDown;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Timer timerExpandClass;
        private System.Windows.Forms.Timer timerExpandCalendar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelMenuTong;
        private System.Windows.Forms.Panel panelShowDetail;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}