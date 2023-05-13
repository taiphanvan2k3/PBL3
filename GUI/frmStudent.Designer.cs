namespace GUI
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.panel3 = new System.Windows.Forms.Panel();
            this.avatarTopRight = new GUI.MyCustomControl.CircularPictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.btnXemTKB = new FontAwesome.Sharp.IconButton();
            this.btnXemLichTrongNgay = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpandMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLop = new System.Windows.Forms.Panel();
            this.btnLopHP = new FontAwesome.Sharp.IconButton();
            this.btnLopSH = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnXemThongBao = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXemKqHocTap = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDoExam = new FontAwesome.Sharp.IconButton();
            this.timerExpandClass = new System.Windows.Forms.Timer(this.components);
            this.timerExpandCalendar = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panelMenuTong = new System.Windows.Forms.Panel();
            this.panelShowDetail = new System.Windows.Forms.Panel();
            this.circularPictureBox = new GUI.MyCustomControl.CircularPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopRight)).BeginInit();
            this.panelCalendar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelLop.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenuTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.avatarTopRight);
            this.panel3.Controls.Add(this.lblAvatar);
            this.panel3.Controls.Add(this.lblXinChao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1532, 69);
            this.panel3.TabIndex = 2;
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
            this.avatarTopRight.Location = new System.Drawing.Point(1452, 1);
            this.avatarTopRight.Name = "avatarTopRight";
            this.avatarTopRight.Size = new System.Drawing.Size(65, 65);
            this.avatarTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarTopRight.TabIndex = 3;
            this.avatarTopRight.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.Location = new System.Drawing.Point(1294, 38);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(109, 20);
            this.lblAvatar.TabIndex = 2;
            this.lblAvatar.Text = "Phan Văn Tài";
            this.lblAvatar.TextChanged += new System.EventHandler(this.lblAvatar_TextChanged);
            // 
            // lblXinChao
            // 
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblXinChao.Location = new System.Drawing.Point(1297, 17);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(66, 18);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào";
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnCalendar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.IconSize = 35;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(2, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(215, 50);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "         Xem lịch";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendarExpand_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.btnXemTKB);
            this.panelCalendar.Controls.Add(this.btnXemLichTrongNgay);
            this.panelCalendar.Controls.Add(this.btnCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(3, 199);
            this.panelCalendar.MaximumSize = new System.Drawing.Size(217, 156);
            this.panelCalendar.MinimumSize = new System.Drawing.Size(217, 53);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(217, 53);
            this.panelCalendar.TabIndex = 7;
            // 
            // btnXemTKB
            // 
            this.btnXemTKB.FlatAppearance.BorderSize = 0;
            this.btnXemTKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTKB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemTKB.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnXemTKB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemTKB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemTKB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemTKB.Location = new System.Drawing.Point(21, 104);
            this.btnXemTKB.Name = "btnXemTKB";
            this.btnXemTKB.Size = new System.Drawing.Size(176, 57);
            this.btnXemTKB.TabIndex = 7;
            this.btnXemTKB.Text = "     Xem thời\r\n     khoá biểu";
            this.btnXemTKB.UseVisualStyleBackColor = true;
            this.btnXemTKB.Click += new System.EventHandler(this.btnXemTKB_Click);
            // 
            // btnXemLichTrongNgay
            // 
            this.btnXemLichTrongNgay.FlatAppearance.BorderSize = 0;
            this.btnXemLichTrongNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLichTrongNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemLichTrongNgay.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnXemLichTrongNgay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemLichTrongNgay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemLichTrongNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichTrongNgay.Location = new System.Drawing.Point(21, 56);
            this.btnXemLichTrongNgay.Name = "btnXemLichTrongNgay";
            this.btnXemLichTrongNgay.Size = new System.Drawing.Size(162, 49);
            this.btnXemLichTrongNgay.TabIndex = 6;
            this.btnXemLichTrongNgay.Text = "        Xem lịch \r\n        trong ngày";
            this.btnXemLichTrongNgay.UseVisualStyleBackColor = true;
            this.btnXemLichTrongNgay.Click += new System.EventHandler(this.btnXemLichTrongNgay_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panelLop);
            this.flowLayoutPanel1.Controls.Add(this.panelCalendar);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 710);
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
            this.btnExpandMenu.Location = new System.Drawing.Point(161, 12);
            this.btnExpandMenu.Name = "btnExpandMenu";
            this.btnExpandMenu.Size = new System.Drawing.Size(54, 44);
            this.btnExpandMenu.TabIndex = 0;
            this.btnExpandMenu.UseVisualStyleBackColor = true;
            this.btnExpandMenu.Click += new System.EventHandler(this.btnExpandMenu_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::GUI.Properties.Resources.Back;
            this.pictureBoxMenu.Location = new System.Drawing.Point(0, 6);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(56, 50);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Location = new System.Drawing.Point(3, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 56);
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
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 56);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "         Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLop
            // 
            this.panelLop.Controls.Add(this.btnLopHP);
            this.panelLop.Controls.Add(this.btnLopSH);
            this.panelLop.Controls.Add(this.btnClass);
            this.panelLop.Location = new System.Drawing.Point(3, 137);
            this.panelLop.MaximumSize = new System.Drawing.Size(217, 153);
            this.panelLop.MinimumSize = new System.Drawing.Size(217, 56);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(217, 56);
            this.panelLop.TabIndex = 2;
            // 
            // btnLopHP
            // 
            this.btnLopHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnLopHP.FlatAppearance.BorderSize = 0;
            this.btnLopHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLopHP.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.btnLopHP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLopHP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLopHP.IconSize = 35;
            this.btnLopHP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHP.Location = new System.Drawing.Point(36, 104);
            this.btnLopHP.Name = "btnLopHP";
            this.btnLopHP.Size = new System.Drawing.Size(179, 46);
            this.btnLopHP.TabIndex = 11;
            this.btnLopHP.Text = "        Lớp học phần";
            this.btnLopHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHP.UseVisualStyleBackColor = false;
            this.btnLopHP.Click += new System.EventHandler(this.btnLopHP_Click);
            // 
            // btnLopSH
            // 
            this.btnLopSH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnLopSH.FlatAppearance.BorderSize = 0;
            this.btnLopSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopSH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLopSH.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnLopSH.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnLopSH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLopSH.IconSize = 35;
            this.btnLopSH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopSH.Location = new System.Drawing.Point(36, 56);
            this.btnLopSH.Name = "btnLopSH";
            this.btnLopSH.Size = new System.Drawing.Size(178, 42);
            this.btnLopSH.TabIndex = 10;
            this.btnLopSH.Text = "        Lớp sinh hoạt";
            this.btnLopSH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopSH.UseVisualStyleBackColor = false;
            this.btnLopSH.Click += new System.EventHandler(this.btnLopSH_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            this.btnClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 35;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(2, 3);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(207, 52);
            this.btnClass.TabIndex = 9;
            this.btnClass.Text = "         Lớp";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnLopArrowDown_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnXemThongBao);
            this.panel7.Location = new System.Drawing.Point(3, 258);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 55);
            this.panel7.TabIndex = 4;
            // 
            // btnXemThongBao
            // 
            this.btnXemThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnXemThongBao.FlatAppearance.BorderSize = 0;
            this.btnXemThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemThongBao.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnXemThongBao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemThongBao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemThongBao.IconSize = 35;
            this.btnXemThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemThongBao.Location = new System.Drawing.Point(3, 5);
            this.btnXemThongBao.Name = "btnXemThongBao";
            this.btnXemThongBao.Size = new System.Drawing.Size(210, 48);
            this.btnXemThongBao.TabIndex = 3;
            this.btnXemThongBao.Text = "    Xem thông báo";
            this.btnXemThongBao.UseVisualStyleBackColor = false;
            this.btnXemThongBao.Click += new System.EventHandler(this.btnXemThongBao_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXemKqHocTap);
            this.panel5.Location = new System.Drawing.Point(3, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 55);
            this.panel5.TabIndex = 5;
            // 
            // btnXemKqHocTap
            // 
            this.btnXemKqHocTap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnXemKqHocTap.FlatAppearance.BorderSize = 0;
            this.btnXemKqHocTap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKqHocTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKqHocTap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemKqHocTap.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnXemKqHocTap.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnXemKqHocTap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemKqHocTap.IconSize = 35;
            this.btnXemKqHocTap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemKqHocTap.Location = new System.Drawing.Point(2, 3);
            this.btnXemKqHocTap.Name = "btnXemKqHocTap";
            this.btnXemKqHocTap.Size = new System.Drawing.Size(210, 48);
            this.btnXemKqHocTap.TabIndex = 3;
            this.btnXemKqHocTap.Text = "    Kết quả học tập";
            this.btnXemKqHocTap.UseVisualStyleBackColor = false;
            this.btnXemKqHocTap.Click += new System.EventHandler(this.btnXemKqHocTap_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDoExam);
            this.panel6.Location = new System.Drawing.Point(3, 380);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 55);
            this.panel6.TabIndex = 6;
            // 
            // btnDoExam
            // 
            this.btnDoExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(213)))));
            this.btnDoExam.FlatAppearance.BorderSize = 0;
            this.btnDoExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnDoExam.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnDoExam.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(142)))));
            this.btnDoExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoExam.IconSize = 35;
            this.btnDoExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoExam.Location = new System.Drawing.Point(4, 4);
            this.btnDoExam.Name = "btnDoExam";
            this.btnDoExam.Size = new System.Drawing.Size(210, 48);
            this.btnDoExam.TabIndex = 2;
            this.btnDoExam.Text = "     Làm bài kiểm tra";
            this.btnDoExam.UseVisualStyleBackColor = false;
            this.btnDoExam.Click += new System.EventHandler(this.btnDoExam_Click);
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
            this.panel2.Location = new System.Drawing.Point(3, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 171);
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 113);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(205, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.panelMenuTong.Size = new System.Drawing.Size(237, 904);
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
            this.panelShowDetail.Size = new System.Drawing.Size(1293, 831);
            this.panelShowDetail.TabIndex = 11;
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
            this.circularPictureBox.Image = global::GUI.Properties.Resources.studentAvatar;
            this.circularPictureBox.InitialImage = global::GUI.Properties.Resources.studentAvatar;
            this.circularPictureBox.Location = new System.Drawing.Point(1381, 8);
            this.circularPictureBox.Name = "circularPictureBox";
            this.circularPictureBox.Size = new System.Drawing.Size(58, 58);
            this.circularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox.TabIndex = 0;
            this.circularPictureBox.TabStop = false;
            // 
            // frmStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1532, 903);
            this.Controls.Add(this.panelShowDetail);
            this.Controls.Add(this.panelMenuTong);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1550, 950);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarTopRight)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelLop.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMenuTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCalendar;
        private System.Windows.Forms.Panel panel3;
        private MyCustomControl.CircularPictureBox circularPictureBox;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExpandMenu;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnDoExam;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton btnLopHP;
        private FontAwesome.Sharp.IconButton btnLopSH;
        private FontAwesome.Sharp.IconButton btnXemTKB;
        private FontAwesome.Sharp.IconButton btnXemLichTrongNgay;
        private System.Windows.Forms.Timer timerExpandClass;
        private System.Windows.Forms.Timer timerExpandCalendar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelMenuTong;
        private System.Windows.Forms.Panel panelShowDetail;
        private MyCustomControl.CircularPictureBox avatarTopRight;
        private FontAwesome.Sharp.IconButton btnXemThongBao;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnXemKqHocTap;
        private System.Windows.Forms.Panel panel6;
    }
}