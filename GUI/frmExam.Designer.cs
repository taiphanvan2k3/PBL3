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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDarkMode = new FontAwesome.Sharp.IconButton();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.btnGrade = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnTakeExam = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(250, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1119, 663);
            this.pnlMain.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panelMenu.Controls.Add(this.btnDarkMode);
            this.panelMenu.Controls.Add(this.btnCalendar);
            this.panelMenu.Controls.Add(this.btnGrade);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnTakeExam);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 665);
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
            this.btnDarkMode.Location = new System.Drawing.Point(0, 452);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDarkMode.Size = new System.Drawing.Size(250, 94);
            this.btnDarkMode.TabIndex = 10;
            this.btnDarkMode.Tag = "Nền tối";
            this.btnDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnCalendar.IconColor = System.Drawing.Color.White;
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.IconSize = 30;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 358);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(250, 94);
            this.btnCalendar.TabIndex = 9;
            this.btnCalendar.Tag = "Lịch thi";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrade.FlatAppearance.BorderSize = 0;
            this.btnGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrade.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.Color.White;
            this.btnGrade.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnGrade.IconColor = System.Drawing.Color.White;
            this.btnGrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrade.IconSize = 30;
            this.btnGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrade.Location = new System.Drawing.Point(0, 264);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGrade.Size = new System.Drawing.Size(250, 94);
            this.btnGrade.TabIndex = 8;
            this.btnGrade.Tag = "Điểm số";
            this.btnGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 571);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 94);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Tag = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeExam.FlatAppearance.BorderSize = 0;
            this.btnTakeExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeExam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeExam.ForeColor = System.Drawing.Color.White;
            this.btnTakeExam.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnTakeExam.IconColor = System.Drawing.Color.White;
            this.btnTakeExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTakeExam.IconSize = 30;
            this.btnTakeExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeExam.Location = new System.Drawing.Point(0, 170);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTakeExam.Size = new System.Drawing.Size(250, 94);
            this.btnTakeExam.TabIndex = 6;
            this.btnTakeExam.Tag = "Bài kiểm tra";
            this.btnTakeExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeExam.UseVisualStyleBackColor = true;
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 76);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 94);
            this.btnHome.TabIndex = 5;
            this.btnHome.Tag = "Home";
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
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
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
            // frmExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1372, 665);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1300, 712);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExam";
            this.Resize += new System.EventHandler(this.frmExam_Resize);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnTakeExam;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton btnGrade;
        private FontAwesome.Sharp.IconButton btnDarkMode;
        private System.Windows.Forms.Panel pnlMain;
    }
}