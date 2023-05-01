namespace GUI.MyUserControls
{
    partial class UC_FinishDoExam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTenBaiKiemTra = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblLopSH = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblNhomHP = new System.Windows.Forms.Label();
            this.lblTitleNhomHP = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblTitleHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.beginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCauDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLanViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.iconCheckSaveImage = new FontAwesome.Sharp.IconButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnCaptureScreen = new GUI.MyCustomControl.CustomButton();
            this.btnClose = new GUI.MyCustomControl.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenBaiKiemTra
            // 
            this.lblTenBaiKiemTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenBaiKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.lblTenBaiKiemTra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiKiemTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTenBaiKiemTra.Location = new System.Drawing.Point(12, 10);
            this.lblTenBaiKiemTra.Name = "lblTenBaiKiemTra";
            this.lblTenBaiKiemTra.Size = new System.Drawing.Size(1204, 35);
            this.lblTenBaiKiemTra.TabIndex = 0;
            this.lblTenBaiKiemTra.Text = "Thi cuối kỳ OOP";
            this.lblTenBaiKiemTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMSSV.Location = new System.Drawing.Point(168, 94);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(91, 23);
            this.lblMSSV.TabIndex = 19;
            this.lblMSSV.Text = "102210230";
            // 
            // lblLopSH
            // 
            this.lblLopSH.AutoSize = true;
            this.lblLopSH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopSH.Location = new System.Drawing.Point(168, 127);
            this.lblLopSH.Name = "lblLopSH";
            this.lblLopSH.Size = new System.Drawing.Size(101, 23);
            this.lblLopSH.TabIndex = 18;
            this.lblLopSH.Text = "21TCLC_DT3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lớp sinh hoạt:";
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTenHP.Location = new System.Drawing.Point(168, 59);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(301, 23);
            this.lblTenHP.TabIndex = 16;
            this.lblTenHP.Text = "Phân tích và thiết kế hướng đối tượng";
            // 
            // lblNhomHP
            // 
            this.lblNhomHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhomHP.AutoSize = true;
            this.lblNhomHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomHP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNhomHP.Location = new System.Drawing.Point(1097, 94);
            this.lblNhomHP.Name = "lblNhomHP";
            this.lblNhomHP.Size = new System.Drawing.Size(99, 23);
            this.lblNhomHP.TabIndex = 15;
            this.lblNhomHP.Text = "OOAD21.13";
            // 
            // lblTitleNhomHP
            // 
            this.lblTitleNhomHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleNhomHP.AutoSize = true;
            this.lblTitleNhomHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNhomHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTitleNhomHP.Location = new System.Drawing.Point(907, 94);
            this.lblTitleNhomHP.Name = "lblTitleNhomHP";
            this.lblTitleNhomHP.Size = new System.Drawing.Size(142, 23);
            this.lblTitleNhomHP.TabIndex = 14;
            this.lblTitleNhomHP.Text = "Nhóm học phần:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTenSV.Location = new System.Drawing.Point(1097, 59);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(108, 23);
            this.lblTenSV.TabIndex = 13;
            this.lblTenSV.Text = "Phan Văn Tài";
            // 
            // lblTitleHoTen
            // 
            this.lblTitleHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleHoTen.AutoSize = true;
            this.lblTitleHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTitleHoTen.Location = new System.Drawing.Point(907, 59);
            this.lblTitleHoTen.Name = "lblTitleHoTen";
            this.lblTitleHoTen.Size = new System.Drawing.Size(69, 23);
            this.lblTitleHoTen.TabIndex = 12;
            this.lblTitleHoTen.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã số sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Học phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Học phần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã số sinh viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lớp sinh hoạt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(168, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "21TCLC_DT3";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separator.Location = new System.Drawing.Point(13, 166);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1203, 1);
            this.separator.TabIndex = 20;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginTime,
            this.endTime,
            this.tongSoCauHoi,
            this.soCauDung,
            this.soLanViPham,
            this.diem});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(14, 184);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv.Size = new System.Drawing.Size(1198, 79);
            this.dtgv.TabIndex = 21;
            // 
            // beginTime
            // 
            this.beginTime.HeaderText = "Thời gian bắt đầu";
            this.beginTime.MinimumWidth = 6;
            this.beginTime.Name = "beginTime";
            this.beginTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "Thời gian nộp bài";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tongSoCauHoi
            // 
            this.tongSoCauHoi.HeaderText = "Tổng số câu hỏi";
            this.tongSoCauHoi.MinimumWidth = 6;
            this.tongSoCauHoi.Name = "tongSoCauHoi";
            this.tongSoCauHoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // soCauDung
            // 
            this.soCauDung.HeaderText = "Số câu đúng";
            this.soCauDung.MinimumWidth = 6;
            this.soCauDung.Name = "soCauDung";
            this.soCauDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // soLanViPham
            // 
            this.soLanViPham.HeaderText = "Số lần vi phạm";
            this.soLanViPham.MinimumWidth = 6;
            this.soLanViPham.Name = "soLanViPham";
            this.soLanViPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // diem
            // 
            this.diem.HeaderText = "Điểm số";
            this.diem.MinimumWidth = 6;
            this.diem.Name = "diem";
            this.diem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain.BorderRadius = 20;
            this.panelMain.Controls.Add(this.iconCheckSaveImage);
            this.panelMain.Controls.Add(this.btnCaptureScreen);
            this.panelMain.Controls.Add(this.lblTenBaiKiemTra);
            this.panelMain.Controls.Add(this.separator);
            this.panelMain.Controls.Add(this.dtgv);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.lblMSSV);
            this.panelMain.Controls.Add(this.lblNhomHP);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.lblTenSV);
            this.panelMain.Controls.Add(this.lblLopSH);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.lblTenHP);
            this.panelMain.Controls.Add(this.lblTitleNhomHP);
            this.panelMain.Controls.Add(this.lblTitleHoTen);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.FillColor = System.Drawing.SystemColors.Info;
            this.panelMain.FillColor2 = System.Drawing.SystemColors.Info;
            this.panelMain.Location = new System.Drawing.Point(38, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1228, 363);
            this.panelMain.TabIndex = 23;
            // 
            // iconCheckSaveImage
            // 
            this.iconCheckSaveImage.FlatAppearance.BorderSize = 0;
            this.iconCheckSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCheckSaveImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCheckSaveImage.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconCheckSaveImage.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconCheckSaveImage.IconColor = System.Drawing.Color.Green;
            this.iconCheckSaveImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCheckSaveImage.IconSize = 35;
            this.iconCheckSaveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCheckSaveImage.Location = new System.Drawing.Point(431, 292);
            this.iconCheckSaveImage.Name = "iconCheckSaveImage";
            this.iconCheckSaveImage.Size = new System.Drawing.Size(224, 38);
            this.iconCheckSaveImage.TabIndex = 25;
            this.iconCheckSaveImage.Text = "   Lưu ảnh thành công";
            this.iconCheckSaveImage.UseVisualStyleBackColor = true;
            this.iconCheckSaveImage.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnCaptureScreen
            // 
            this.btnCaptureScreen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCaptureScreen.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.btnCaptureScreen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCaptureScreen.BorderRadius = 40;
            this.btnCaptureScreen.BorderSize = 0;
            this.btnCaptureScreen.FlatAppearance.BorderSize = 0;
            this.btnCaptureScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptureScreen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureScreen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaptureScreen.Location = new System.Drawing.Point(40, 290);
            this.btnCaptureScreen.Name = "btnCaptureScreen";
            this.btnCaptureScreen.Size = new System.Drawing.Size(126, 40);
            this.btnCaptureScreen.TabIndex = 23;
            this.btnCaptureScreen.Text = "Lưu kết quả";
            this.btnCaptureScreen.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaptureScreen.UseVisualStyleBackColor = false;
            this.btnCaptureScreen.Click += new System.EventHandler(this.btnCaptureScreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 40;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(221, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 40);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UC_FinishDoExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Name = "UC_FinishDoExam";
            this.Size = new System.Drawing.Size(1308, 432);
            this.Load += new System.EventHandler(this.UC_FinishDoExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenBaiKiemTra;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblLopSH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblNhomHP;
        private System.Windows.Forms.Label lblTitleNhomHP;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblTitleHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.DataGridView dtgv;
        private MyCustomControl.CustomButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCauDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLanViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private MyCustomControl.CustomButton btnCaptureScreen;
        private FontAwesome.Sharp.IconButton iconCheckSaveImage;
        private System.Windows.Forms.Timer timer;
    }
}
