namespace GUI
{
    partial class frmViewDetailModuleClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditListSV = new GUI.MyCustomControl.CustomButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTietKT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTietBD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbThu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHocKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new GUI.MyCustomControl.CustomButton();
            this.btnUndo = new GUI.MyCustomControl.CustomButton();
            this.btnUpdate = new GUI.MyCustomControl.CustomButton();
            this.btnPhanCongGV = new GUI.MyCustomControl.CustomButton();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.cbbSoTC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenGV = new GUI.MyCustomControl.CustomTextBox();
            this.txtTenMH = new GUI.MyCustomControl.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(791, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên giảng viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Năm học:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(791, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Học kỳ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tiết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thứ:";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(40, 53);
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
            // Column1
            // 
            this.Column1.FillWeight = 37.7134F;
            this.Column1.HeaderText = "TT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 78.72673F;
            this.Column2.HeaderText = "Mã sinh viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 78.72673F;
            this.Column3.HeaderText = "Họ tên SV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 78.72673F;
            this.Column4.HeaderText = "Lớp sinh hoạt";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 78.72673F;
            this.Column5.HeaderText = "Số điện thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã giảng viên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnEditListSV);
            this.panel2.Controls.Add(this.lblCurrentPage);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.dtgv);
            this.panel2.Location = new System.Drawing.Point(65, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 426);
            this.panel2.TabIndex = 20;
            // 
            // btnEditListSV
            // 
            this.btnEditListSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnEditListSV.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnEditListSV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditListSV.BorderRadius = 20;
            this.btnEditListSV.BorderSize = 0;
            this.btnEditListSV.FlatAppearance.BorderSize = 0;
            this.btnEditListSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditListSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditListSV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditListSV.Image = global::GUI.Properties.Resources.pencil;
            this.btnEditListSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditListSV.Location = new System.Drawing.Point(903, 7);
            this.btnEditListSV.Name = "btnEditListSV";
            this.btnEditListSV.Size = new System.Drawing.Size(192, 40);
            this.btnEditListSV.TabIndex = 24;
            this.btnEditListSV.Text = "     Chỉnh sửa danh sách";
            this.btnEditListSV.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditListSV.UseVisualStyleBackColor = false;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCurrentPage.Location = new System.Drawing.Point(40, 392);
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
            this.btnNext.Location = new System.Drawing.Point(1020, 386);
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
            this.btnPrev.Location = new System.Drawing.Point(943, 386);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 32);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1228, 55);
            this.panelTitle.TabIndex = 22;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(44, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(346, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thông tin chi tiết của lớp học phần";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.cbbTietKT);
            this.guna2GroupBox1.Controls.Add(this.cbbTietBD);
            this.guna2GroupBox1.Controls.Add(this.cbbThu);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(802, 64);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(376, 174);
            this.guna2GroupBox1.TabIndex = 30;
            this.guna2GroupBox1.Text = "Lịch học";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(134, 88);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(145, 38);
            this.guna2TextBox1.TabIndex = 35;
            // 
            // cbbTietKT
            // 
            this.cbbTietKT.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietKT.BorderRadius = 8;
            this.cbbTietKT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietKT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTietKT.ForeColor = System.Drawing.Color.Black;
            this.cbbTietKT.ItemHeight = 30;
            this.cbbTietKT.Location = new System.Drawing.Point(276, 129);
            this.cbbTietKT.Name = "cbbTietKT";
            this.cbbTietKT.Size = new System.Drawing.Size(81, 36);
            this.cbbTietKT.TabIndex = 5;
            // 
            // cbbTietBD
            // 
            this.cbbTietBD.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietBD.BorderRadius = 8;
            this.cbbTietBD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietBD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTietBD.ForeColor = System.Drawing.Color.Black;
            this.cbbTietBD.ItemHeight = 30;
            this.cbbTietBD.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            7,
            8,
            9});
            this.cbbTietBD.Location = new System.Drawing.Point(134, 129);
            this.cbbTietBD.Name = "cbbTietBD";
            this.cbbTietBD.Size = new System.Drawing.Size(82, 36);
            this.cbbTietBD.TabIndex = 4;
            this.cbbTietBD.SelectedIndexChanged += new System.EventHandler(this.cbbTietBD_SelectedIndexChanged);
            // 
            // cbbThu
            // 
            this.cbbThu.BackColor = System.Drawing.Color.Transparent;
            this.cbbThu.BorderRadius = 8;
            this.cbbThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbThu.ForeColor = System.Drawing.Color.Black;
            this.cbbThu.ItemHeight = 30;
            this.cbbThu.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật"});
            this.cbbThu.Location = new System.Drawing.Point(133, 45);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(145, 36);
            this.cbbThu.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaGV.BorderRadius = 8;
            this.txtMaGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGV.DefaultText = "";
            this.txtMaGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGV.Enabled = false;
            this.txtMaGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.ForeColor = System.Drawing.Color.Black;
            this.txtMaGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGV.Location = new System.Drawing.Point(240, 238);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.PasswordChar = '\0';
            this.txtMaGV.PlaceholderText = "";
            this.txtMaGV.SelectedText = "";
            this.txtMaGV.Size = new System.Drawing.Size(190, 33);
            this.txtMaGV.TabIndex = 31;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.txtNamHoc.BorderRadius = 8;
            this.txtNamHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamHoc.DefaultText = "";
            this.txtNamHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamHoc.Enabled = false;
            this.txtNamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.ForeColor = System.Drawing.Color.Black;
            this.txtNamHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamHoc.Location = new System.Drawing.Point(240, 282);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.PasswordChar = '\0';
            this.txtNamHoc.PlaceholderText = "";
            this.txtNamHoc.SelectedText = "";
            this.txtNamHoc.Size = new System.Drawing.Size(190, 33);
            this.txtNamHoc.TabIndex = 32;
            // 
            // txtHocKy
            // 
            this.txtHocKy.BackColor = System.Drawing.Color.Transparent;
            this.txtHocKy.BorderRadius = 8;
            this.txtHocKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocKy.DefaultText = "";
            this.txtHocKy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHocKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHocKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocKy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocKy.Enabled = false;
            this.txtHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocKy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.ForeColor = System.Drawing.Color.Black;
            this.txtHocKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocKy.Location = new System.Drawing.Point(936, 287);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.PasswordChar = '\0';
            this.txtHocKy.PlaceholderText = "";
            this.txtHocKy.SelectedText = "";
            this.txtHocKy.Size = new System.Drawing.Size(53, 36);
            this.txtHocKy.TabIndex = 33;
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
            this.btnExit.Location = new System.Drawing.Point(860, 770);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 40);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "       Thoát";
            this.btnExit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnUndo.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnUndo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUndo.BorderRadius = 20;
            this.btnUndo.BorderSize = 0;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUndo.Image = global::GUI.Properties.Resources.Undo32px;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.Location = new System.Drawing.Point(570, 770);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(127, 40);
            this.btnUndo.TabIndex = 26;
            this.btnUndo.Text = "       Hoàn tác";
            this.btnUndo.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(280, 770);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 40);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "       Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnPhanCongGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCongGV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongGV.Image = global::GUI.Properties.Resources.AssignTeacher;
            this.btnPhanCongGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCongGV.Location = new System.Drawing.Point(1009, 285);
            this.btnPhanCongGV.Name = "btnPhanCongGV";
            this.btnPhanCongGV.Size = new System.Drawing.Size(170, 40);
            this.btnPhanCongGV.TabIndex = 25;
            this.btnPhanCongGV.Text = "       Phân công GV";
            this.btnPhanCongGV.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongGV.UseVisualStyleBackColor = false;
            this.btnPhanCongGV.Click += new System.EventHandler(this.btnPhanCongGV_Click);
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.txtTenMH);
            this.panelGradient1.Controls.Add(this.cbbSoTC);
            this.panelGradient1.Controls.Add(this.txtMaHP);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.label6);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.panelGradient1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.panelGradient1.Location = new System.Drawing.Point(65, 61);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(542, 169);
            this.panelGradient1.TabIndex = 28;
            // 
            // cbbSoTC
            // 
            this.cbbSoTC.BackColor = System.Drawing.Color.Transparent;
            this.cbbSoTC.BorderRadius = 8;
            this.cbbSoTC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSoTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoTC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoTC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSoTC.ForeColor = System.Drawing.Color.Black;
            this.cbbSoTC.ItemHeight = 30;
            this.cbbSoTC.Items.AddRange(new object[] {
            1,
            2,
            3,
            4});
            this.cbbSoTC.Location = new System.Drawing.Point(192, 124);
            this.cbbSoTC.Name = "cbbSoTC";
            this.cbbSoTC.Size = new System.Drawing.Size(82, 36);
            this.cbbSoTC.TabIndex = 36;
            // 
            // txtMaHP
            // 
            this.txtMaHP.BackColor = System.Drawing.Color.Transparent;
            this.txtMaHP.BorderRadius = 8;
            this.txtMaHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHP.DefaultText = "";
            this.txtMaHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHP.Enabled = false;
            this.txtMaHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHP.ForeColor = System.Drawing.Color.Black;
            this.txtMaHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHP.Location = new System.Drawing.Point(192, 9);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.PasswordChar = '\0';
            this.txtMaHP.PlaceholderText = "";
            this.txtMaHP.SelectedText = "";
            this.txtMaHP.Size = new System.Drawing.Size(334, 38);
            this.txtMaHP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tín chỉ:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtTenGV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenGV.BorderRadius = 8;
            this.txtTenGV.BorderSize = 1;
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.ForeColor = System.Drawing.Color.Black;
            this.txtTenGV.Location = new System.Drawing.Point(937, 242);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenGV.MaxLength = 32767;
            this.txtTenGV.Multiline = false;
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Padding = new System.Windows.Forms.Padding(9, 9, 0, 0);
            this.txtTenGV.PasswordChar = false;
            this.txtTenGV.PlaceholderColor = System.Drawing.Color.White;
            this.txtTenGV.PlaceholderText = "";
            this.txtTenGV.Size = new System.Drawing.Size(242, 38);
            this.txtTenGV.TabIndex = 34;
            this.txtTenGV.Texts = "";
            this.txtTenGV.UnderlinedStyle = false;
            // 
            // txtTenMH
            // 
            this.txtTenMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtTenMH.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMH.BorderRadius = 8;
            this.txtTenMH.BorderSize = 1;
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.ForeColor = System.Drawing.Color.Black;
            this.txtTenMH.Location = new System.Drawing.Point(192, 65);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenMH.MaxLength = 32767;
            this.txtTenMH.Multiline = false;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Padding = new System.Windows.Forms.Padding(9, 9, 0, 0);
            this.txtTenMH.PasswordChar = false;
            this.txtTenMH.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.Size = new System.Drawing.Size(334, 38);
            this.txtTenMH.TabIndex = 35;
            this.txtTenMH.Texts = "";
            this.txtTenMH.UnderlinedStyle = false;
            // 
            // frmViewDetailModuleClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 827);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPhanCongGV);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelGradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewDetailModuleClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_ViewDetailModuleClass";
            this.Load += new System.EventHandler(this.frm_ViewDetailModuleClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private System.Windows.Forms.Label lblCurrentPage;
        private MyCustomControl.CustomButton btnEditListSV;
        private MyCustomControl.CustomButton btnPhanCongGV;
        private MyCustomControl.CustomButton btnUpdate;
        private MyCustomControl.CustomButton btnUndo;
        private MyCustomControl.CustomButton btnExit;
        private MyCustomControl.PanelGradient panelGradient1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHP;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietKT;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietBD;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaGV;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSoTC;
        private Guna.UI2.WinForms.Guna2TextBox txtNamHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtHocKy;
        private MyCustomControl.CustomTextBox txtTenGV;
        private MyCustomControl.CustomTextBox txtTenMH;
    }
}