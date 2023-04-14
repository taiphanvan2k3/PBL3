namespace GUI
{
    partial class frmAssignTeacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrev = new GUI.MyCustomControl.CustomButton();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xacNhan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbTenGV = new GUI.MyCustomControl.CustomTextBox();
            this.tbMaGV = new GUI.MyCustomControl.CustomTextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTietKT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTietBD = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbThu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTenMH = new GUI.MyCustomControl.CustomTextBox();
            this.tbMaHP = new GUI.MyCustomControl.CustomTextBox();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnXacNhan = new GUI.MyCustomControl.CustomButton();
            this.btnSearch = new GUI.MyCustomControl.CustomButton();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1230, 55);
            this.panelTitle.TabIndex = 23;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(44, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(313, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Phân công giảng viên phụ trách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã học phần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên môn học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(7, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên giảng viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã giảng viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.panelGradient1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(46, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 273);
            this.panel1.TabIndex = 35;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.Image = global::GUI.Properties.Resources.left1;
            this.btnPrev.Location = new System.Drawing.Point(1030, 201);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 45);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.dtgv);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.panelGradient1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.panelGradient1.Location = new System.Drawing.Point(115, 16);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(879, 230);
            this.panelGradient1.TabIndex = 38;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maGV,
            this.tenGV,
            this.Sdt,
            this.soLuong,
            this.xacNhan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.White;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aquamarine;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(879, 230);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 53.47594F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // maGV
            // 
            this.maGV.FillWeight = 111.631F;
            this.maGV.HeaderText = "Mã giảng viên";
            this.maGV.MinimumWidth = 6;
            this.maGV.Name = "maGV";
            this.maGV.ReadOnly = true;
            // 
            // tenGV
            // 
            this.tenGV.FillWeight = 111.631F;
            this.tenGV.HeaderText = "Tên giảng viên";
            this.tenGV.MinimumWidth = 6;
            this.tenGV.Name = "tenGV";
            this.tenGV.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.FillWeight = 111.631F;
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.FillWeight = 111.631F;
            this.soLuong.HeaderText = "Số lượng HP phụ trách";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // xacNhan
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xacNhan.DefaultCellStyle = dataGridViewCellStyle2;
            this.xacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xacNhan.HeaderText = "Phân công";
            this.xacNhan.MinimumWidth = 6;
            this.xacNhan.Name = "xacNhan";
            this.xacNhan.ReadOnly = true;
            this.xacNhan.Text = "Chọn";
            this.xacNhan.UseColumnTextForButtonValue = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Image = global::GUI.Properties.Resources.right;
            this.btnNext.Location = new System.Drawing.Point(1081, 201);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 1;
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.tbTenGV);
            this.guna2GroupBox1.Controls.Add(this.tbMaGV);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.BurlyWood;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(704, 134);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(473, 186);
            this.guna2GroupBox1.TabIndex = 41;
            this.guna2GroupBox1.Text = "Giảng viên phụ trách";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTenGV
            // 
            this.tbTenGV.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenGV.BorderColor = System.Drawing.Color.Teal;
            this.tbTenGV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenGV.BorderRadius = 10;
            this.tbTenGV.BorderSize = 1;
            this.tbTenGV.Enabled = false;
            this.tbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenGV.ForeColor = System.Drawing.Color.Black;
            this.tbTenGV.Location = new System.Drawing.Point(144, 130);
            this.tbTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenGV.MaxLength = 32767;
            this.tbTenGV.Multiline = false;
            this.tbTenGV.Name = "tbTenGV";
            this.tbTenGV.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenGV.PasswordChar = false;
            this.tbTenGV.PlaceholderColor = System.Drawing.Color.White;
            this.tbTenGV.PlaceholderText = "";
            this.tbTenGV.Size = new System.Drawing.Size(287, 35);
            this.tbTenGV.TabIndex = 41;
            this.tbTenGV.Texts = "";
            this.tbTenGV.UnderlinedStyle = false;
            // 
            // tbMaGV
            // 
            this.tbMaGV.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaGV.BorderColor = System.Drawing.Color.Teal;
            this.tbMaGV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMaGV.BorderRadius = 10;
            this.tbMaGV.BorderSize = 1;
            this.tbMaGV.Enabled = false;
            this.tbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaGV.ForeColor = System.Drawing.Color.Black;
            this.tbMaGV.Location = new System.Drawing.Point(144, 53);
            this.tbMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaGV.MaxLength = 32767;
            this.tbMaGV.Multiline = false;
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.Padding = new System.Windows.Forms.Padding(7);
            this.tbMaGV.PasswordChar = false;
            this.tbMaGV.PlaceholderColor = System.Drawing.Color.White;
            this.tbMaGV.PlaceholderText = "";
            this.tbMaGV.Size = new System.Drawing.Size(287, 35);
            this.tbMaGV.TabIndex = 40;
            this.tbMaGV.Texts = "";
            this.tbMaGV.UnderlinedStyle = false;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.Controls.Add(this.tbPhong);
            this.guna2GroupBox3.Controls.Add(this.cbbTietKT);
            this.guna2GroupBox3.Controls.Add(this.cbbTietBD);
            this.guna2GroupBox3.Controls.Add(this.cbbThu);
            this.guna2GroupBox3.Controls.Add(this.label7);
            this.guna2GroupBox3.Controls.Add(this.label8);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.BurlyWood;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(49, 134);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(453, 249);
            this.guna2GroupBox3.TabIndex = 43;
            this.guna2GroupBox3.Text = "Lịch học";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPhong
            // 
            this.tbPhong.BackColor = System.Drawing.Color.Transparent;
            this.tbPhong.BorderRadius = 8;
            this.tbPhong.BorderThickness = 2;
            this.tbPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhong.DefaultText = "";
            this.tbPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tbPhong.ForeColor = System.Drawing.Color.Black;
            this.tbPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhong.Location = new System.Drawing.Point(138, 129);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.PasswordChar = '\0';
            this.tbPhong.PlaceholderText = "";
            this.tbPhong.SelectedText = "";
            this.tbPhong.Size = new System.Drawing.Size(223, 35);
            this.tbPhong.TabIndex = 35;
            // 
            // cbbTietKT
            // 
            this.cbbTietKT.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietKT.BorderRadius = 8;
            this.cbbTietKT.BorderThickness = 2;
            this.cbbTietKT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietKT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietKT.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cbbTietKT.ForeColor = System.Drawing.Color.Black;
            this.cbbTietKT.ItemHeight = 30;
            this.cbbTietKT.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "7",
            "8",
            "9",
            "10"});
            this.cbbTietKT.Location = new System.Drawing.Point(276, 192);
            this.cbbTietKT.Name = "cbbTietKT";
            this.cbbTietKT.Size = new System.Drawing.Size(81, 36);
            this.cbbTietKT.TabIndex = 5;
            // 
            // cbbTietBD
            // 
            this.cbbTietBD.BackColor = System.Drawing.Color.Transparent;
            this.cbbTietBD.BorderRadius = 8;
            this.cbbTietBD.BorderThickness = 2;
            this.cbbTietBD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTietBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietBD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTietBD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTietBD.ForeColor = System.Drawing.Color.Black;
            this.cbbTietBD.ItemHeight = 30;
            this.cbbTietBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "7",
            "8",
            "9"});
            this.cbbTietBD.Location = new System.Drawing.Point(134, 192);
            this.cbbTietBD.Name = "cbbTietBD";
            this.cbbTietBD.Size = new System.Drawing.Size(82, 36);
            this.cbbTietBD.TabIndex = 4;
            // 
            // cbbThu
            // 
            this.cbbThu.BackColor = System.Drawing.Color.Transparent;
            this.cbbThu.BorderRadius = 8;
            this.cbbThu.BorderThickness = 2;
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
            this.cbbThu.Location = new System.Drawing.Point(138, 63);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(219, 36);
            this.cbbThu.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thứ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tiết:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Phòng:";
            // 
            // tbTenMH
            // 
            this.tbTenMH.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenMH.BorderColor = System.Drawing.Color.Teal;
            this.tbTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenMH.BorderRadius = 10;
            this.tbTenMH.BorderSize = 1;
            this.tbTenMH.Enabled = false;
            this.tbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMH.ForeColor = System.Drawing.Color.Black;
            this.tbTenMH.Location = new System.Drawing.Point(862, 72);
            this.tbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenMH.MaxLength = 32767;
            this.tbTenMH.Multiline = false;
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenMH.PasswordChar = false;
            this.tbTenMH.PlaceholderColor = System.Drawing.Color.White;
            this.tbTenMH.PlaceholderText = "";
            this.tbTenMH.Size = new System.Drawing.Size(315, 35);
            this.tbTenMH.TabIndex = 40;
            this.tbTenMH.Texts = "";
            this.tbTenMH.UnderlinedStyle = false;
            // 
            // tbMaHP
            // 
            this.tbMaHP.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaHP.BorderColor = System.Drawing.Color.Teal;
            this.tbMaHP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMaHP.BorderRadius = 10;
            this.tbMaHP.BorderSize = 1;
            this.tbMaHP.Enabled = false;
            this.tbMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHP.ForeColor = System.Drawing.Color.Black;
            this.tbMaHP.Location = new System.Drawing.Point(190, 72);
            this.tbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHP.MaxLength = 32767;
            this.tbMaHP.Multiline = false;
            this.tbMaHP.Name = "tbMaHP";
            this.tbMaHP.Padding = new System.Windows.Forms.Padding(7);
            this.tbMaHP.PasswordChar = false;
            this.tbMaHP.PlaceholderColor = System.Drawing.Color.White;
            this.tbMaHP.PlaceholderText = "";
            this.tbMaHP.Size = new System.Drawing.Size(130, 35);
            this.tbMaHP.TabIndex = 39;
            this.tbMaHP.Texts = "";
            this.tbMaHP.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Moccasin;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Moccasin;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::GUI.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(742, 691);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(138, 43);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "    Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Moccasin;
            this.btnXacNhan.BackGroundColor = System.Drawing.Color.Moccasin;
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 40;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Image = global::GUI.Properties.Resources.confirm;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(309, 691);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXacNhan.Size = new System.Drawing.Size(140, 43);
            this.btnXacNhan.TabIndex = 37;
            this.btnXacNhan.Text = "      Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 40;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::GUI.Properties.Resources.loupe;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(968, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(213, 54);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "   Tìm GV phù hợp";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmAssignTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 751);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.tbTenMH);
            this.Controls.Add(this.tbMaHP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1230, 751);
            this.MinimumSize = new System.Drawing.Size(1230, 751);
            this.Name = "frmAssignTeacher";
            this.Text = "frm_AssignTeacher";
            this.Load += new System.EventHandler(this.frm_AssignTeacher_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewButtonColumn xacNhan;
        private MyCustomControl.PanelGradient panelGradient1;
        private MyCustomControl.CustomButton btnSearch;
        private MyCustomControl.CustomButton btnXacNhan; 
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.CustomTextBox tbMaHP;
        private MyCustomControl.CustomTextBox tbTenGV;
        private MyCustomControl.CustomTextBox tbMaGV;
        private MyCustomControl.CustomTextBox tbTenMH;
        private MyCustomControl.CustomButton btnPrev;
        private MyCustomControl.CustomButton btnNext;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox tbPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietKT;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTietBD;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}