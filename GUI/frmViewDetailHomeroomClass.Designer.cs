namespace GUI
{
    partial class frmViewDetailHomeroomClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaLopSH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.lblMaGVCN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new GUI.MyCustomControl.CustomButton();
            this.btnAddSV = new GUI.MyCustomControl.CustomButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnPhanCongGV = new GUI.MyCustomControl.CustomButton();
            this.txtSoLuongSVMax = new GUI.MyCustomControl.CustomTextBox();
            this.btnExit = new GUI.MyCustomControl.CustomButton();
            this.btnUpdate = new GUI.MyCustomControl.CustomButton();
            this.btnRefresh = new GUI.MyCustomControl.CustomButton();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1206, 55);
            this.panelTitle.TabIndex = 23;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(32, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(347, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thông tin chi tiết của lớp sinh hoạt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã lớp sinh hoạt:";
            // 
            // lblMaLopSH
            // 
            this.lblMaLopSH.AutoSize = true;
            this.lblMaLopSH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLopSH.Location = new System.Drawing.Point(278, 77);
            this.lblMaLopSH.Name = "lblMaLopSH";
            this.lblMaLopSH.Size = new System.Drawing.Size(65, 23);
            this.lblMaLopSH.TabIndex = 25;
            this.lblMaLopSH.Text = "_Empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Khoa:";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.Location = new System.Drawing.Point(278, 123);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(65, 23);
            this.lblTenKhoa.TabIndex = 27;
            this.lblTenKhoa.Text = "_Empty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(792, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Họ tên GVCN:";
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGVCN.Location = new System.Drawing.Point(960, 121);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(65, 23);
            this.lblGVCN.TabIndex = 29;
            this.lblGVCN.Text = "_Empty";
            // 
            // lblMaGVCN
            // 
            this.lblMaGVCN.AutoSize = true;
            this.lblMaGVCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGVCN.Location = new System.Drawing.Point(960, 77);
            this.lblMaGVCN.Name = "lblMaGVCN";
            this.lblMaGVCN.Size = new System.Drawing.Size(65, 23);
            this.lblMaGVCN.TabIndex = 31;
            this.lblMaGVCN.Text = "_Empty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(792, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mã giảng viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số lượng sinh viên tối đa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAddSV);
            this.panel2.Controls.Add(this.lblCurrentPage);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.dtgv);
            this.panel2.Location = new System.Drawing.Point(46, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 429);
            this.panel2.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnDelete.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::GUI.Properties.Resources.DeleteUser;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(771, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "          Xoá sinh viên";
            this.btnDelete.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAddSV.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAddSV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSV.BorderRadius = 20;
            this.btnAddSV.BorderSize = 0;
            this.btnAddSV.FlatAppearance.BorderSize = 0;
            this.btnAddSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSV.Image = global::GUI.Properties.Resources.AddStudent;
            this.btnAddSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSV.Location = new System.Drawing.Point(939, 7);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(155, 40);
            this.btnAddSV.TabIndex = 24;
            this.btnAddSV.Text = "     Thêm sinh viên";
            this.btnAddSV.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCurrentPage.Location = new System.Drawing.Point(40, 395);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(87, 22);
            this.lblCurrentPage.TabIndex = 20;
            this.lblCurrentPage.Text = "Trang 1/...";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNext.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 30;
            this.btnNext.Location = new System.Drawing.Point(1020, 389);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 19;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPrev.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.IconSize = 30;
            this.btnPrev.Location = new System.Drawing.Point(943, 389);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 32);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(40, 56);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 35;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1055, 327);
            this.dtgv.TabIndex = 17;
            this.dtgv.DataSourceChanged += new System.EventHandler(this.dtgv_DataSourceChanged);
            // 
            // btnPhanCongGV
            // 
            this.btnPhanCongGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnPhanCongGV.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnPhanCongGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhanCongGV.BorderRadius = 20;
            this.btnPhanCongGV.BorderSize = 0;
            this.btnPhanCongGV.FlatAppearance.BorderSize = 0;
            this.btnPhanCongGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCongGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongGV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongGV.Image = global::GUI.Properties.Resources.AssignTeacher;
            this.btnPhanCongGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCongGV.Location = new System.Drawing.Point(796, 177);
            this.btnPhanCongGV.Name = "btnPhanCongGV";
            this.btnPhanCongGV.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.btnPhanCongGV.Size = new System.Drawing.Size(206, 40);
            this.btnPhanCongGV.TabIndex = 39;
            this.btnPhanCongGV.Text = "    Phân công GVCN";
            this.btnPhanCongGV.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongGV.UseVisualStyleBackColor = false;
            this.btnPhanCongGV.Click += new System.EventHandler(this.btnPhanCongGV_Click);
            // 
            // txtSoLuongSVMax
            // 
            this.txtSoLuongSVMax.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoLuongSVMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSoLuongSVMax.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuongSVMax.BorderRadius = 15;
            this.txtSoLuongSVMax.BorderSize = 2;
            this.txtSoLuongSVMax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSVMax.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoLuongSVMax.Location = new System.Drawing.Point(282, 172);
            this.txtSoLuongSVMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongSVMax.MaxLength = 32767;
            this.txtSoLuongSVMax.Multiline = false;
            this.txtSoLuongSVMax.Name = "txtSoLuongSVMax";
            this.txtSoLuongSVMax.Padding = new System.Windows.Forms.Padding(20, 9, 7, 7);
            this.txtSoLuongSVMax.PasswordChar = false;
            this.txtSoLuongSVMax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuongSVMax.PlaceholderText = "";
            this.txtSoLuongSVMax.Size = new System.Drawing.Size(61, 40);
            this.txtSoLuongSVMax.TabIndex = 38;
            this.txtSoLuongSVMax.Texts = "30";
            this.txtSoLuongSVMax.UnderlinedStyle = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnExit.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Image = global::GUI.Properties.Resources.exit1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(776, 682);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 40);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "       Thoát";
            this.btnExit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnUpdate.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Image = global::GUI.Properties.Resources.updated;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(334, 682);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 40);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "       Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnRefresh.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Image = global::GUI.Properties.Resources.Undo32px;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1008, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 40);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "    Tải lại form";
            this.btnRefresh.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmViewDetailHomeroomClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 746);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPhanCongGV);
            this.Controls.Add(this.txtSoLuongSVMax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaGVCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGVCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaLopSH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewDetailHomeroomClass";
            this.Text = "frmViewDetailHomeroomClass";
            this.Load += new System.EventHandler(this.frmViewDetailHomeroomClass_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaLopSH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.Label lblMaGVCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private MyCustomControl.CustomButton btnDelete;
        private MyCustomControl.CustomButton btnAddSV;
        private System.Windows.Forms.Label lblCurrentPage;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private System.Windows.Forms.DataGridView dtgv;
        private MyCustomControl.CustomButton btnExit;
        private MyCustomControl.CustomButton btnUpdate;
        private MyCustomControl.CustomTextBox txtSoLuongSVMax;
        private MyCustomControl.CustomButton btnPhanCongGV;
        private MyCustomControl.CustomButton btnRefresh;
    }
}