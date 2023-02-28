namespace GUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.calendarcs1 = new GUI.MyUserControls.Calendarcs();
            this.pnlMenu = new GUI.MyCustomControl.PanelGradient();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.customButton2 = new GUI.MyCustomControl.CustomButton();
            this.ellipseControl1 = new GUI.MyCustomControl.EllipseControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMaximize, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMinimize, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1756, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1699, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1649, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(44, 29);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1599, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.calendarcs1);
            this.panelGradient1.Controls.Add(this.pnlMenu);
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.panelGradient1.GradientTopColor = System.Drawing.Color.White;
            this.panelGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Padding = new System.Windows.Forms.Padding(7);
            this.panelGradient1.Size = new System.Drawing.Size(1756, 850);
            this.panelGradient1.TabIndex = 0;
            // 
            // calendarcs1
            // 
            this.calendarcs1.Location = new System.Drawing.Point(200, 34);
            this.calendarcs1.Name = "calendarcs1";
            this.calendarcs1.Size = new System.Drawing.Size(1548, 836);
            this.calendarcs1.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderRadius = 30;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnSchedule);
            this.pnlMenu.Controls.Add(this.btnScore);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.customButton2);
            this.pnlMenu.ForeColor = System.Drawing.Color.Black;
            this.pnlMenu.GradientAngle = 90F;
            this.pnlMenu.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.pnlMenu.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.pnlMenu.Location = new System.Drawing.Point(-1, 11);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMenu.Size = new System.Drawing.Size(200, 836);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(23, 694);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(167, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Tag = "Exit";
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exam";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(13, 500);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(174, 49);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Tag = "Setting";
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(15, 415);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(172, 49);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Tag = "Schedule";
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSchedule.UseVisualStyleBackColor = false;
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(14, 331);
            this.btnScore.Name = "btnScore";
            this.btnScore.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnScore.Size = new System.Drawing.Size(173, 49);
            this.btnScore.TabIndex = 4;
            this.btnScore.Tag = "Score";
            this.btnScore.Text = "Score";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(14, 248);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(173, 49);
            this.btnHome.TabIndex = 3;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(13, 166);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(174, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Black;
            this.customButton2.BackGroundColor = System.Drawing.Color.Black;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.Location = new System.Drawing.Point(681, 22);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(78, 40);
            this.customButton2.TabIndex = 0;
            this.customButton2.Text = "Exit";
            this.customButton2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 850);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelGradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelGradient1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.PanelGradient panelGradient1;
        private MyCustomControl.EllipseControl ellipseControl1;
        private System.Windows.Forms.Panel panel1;
        private MyCustomControl.PanelGradient pnlMenu;
        private MyCustomControl.CustomButton customButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnHome;
        private MyUserControls.Calendarcs calendarcs1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
    }
}

