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
            this.tbPhong = new GUI.MyCustomControl.CustomTextBox();
            this.tbTietKT = new GUI.MyCustomControl.CustomTextBox();
            this.tbTietBD = new GUI.MyCustomControl.CustomTextBox();
            this.tbThu = new GUI.MyCustomControl.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenGV = new GUI.MyCustomControl.CustomTextBox();
            this.tbMaGV = new GUI.MyCustomControl.CustomTextBox();
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
            this.tbTenHP = new GUI.MyCustomControl.CustomTextBox();
            this.tbMaHP = new GUI.MyCustomControl.CustomTextBox();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnXacNhan = new GUI.MyCustomControl.CustomButton();
            this.btnSearch = new GUI.MyCustomControl.CustomButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên học phần:";
            // 
            // tbPhong
            // 
            this.tbPhong.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhong.BorderColor = System.Drawing.Color.Teal;
            this.tbPhong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPhong.BorderRadius = 15;
            this.tbPhong.BorderSize = 1;
            this.tbPhong.Enabled = false;
            this.tbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhong.ForeColor = System.Drawing.Color.DimGray;
            this.tbPhong.Location = new System.Drawing.Point(1011, 50);
            this.tbPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhong.MaxLength = 32767;
            this.tbPhong.Multiline = false;
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Padding = new System.Windows.Forms.Padding(30, 7, 7, 7);
            this.tbPhong.PasswordChar = false;
            this.tbPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPhong.PlaceholderText = "";
            this.tbPhong.Size = new System.Drawing.Size(111, 35);
            this.tbPhong.TabIndex = 45;
            this.tbPhong.Texts = "H202";
            this.tbPhong.UnderlinedStyle = false;
            // 
            // tbTietKT
            // 
            this.tbTietKT.BackColor = System.Drawing.SystemColors.Window;
            this.tbTietKT.BorderColor = System.Drawing.Color.Teal;
            this.tbTietKT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTietKT.BorderRadius = 15;
            this.tbTietKT.BorderSize = 1;
            this.tbTietKT.Enabled = false;
            this.tbTietKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTietKT.ForeColor = System.Drawing.Color.DimGray;
            this.tbTietKT.Location = new System.Drawing.Point(741, 50);
            this.tbTietKT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTietKT.MaxLength = 32767;
            this.tbTietKT.Multiline = false;
            this.tbTietKT.Name = "tbTietKT";
            this.tbTietKT.Padding = new System.Windows.Forms.Padding(30, 7, 7, 7);
            this.tbTietKT.PasswordChar = false;
            this.tbTietKT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTietKT.PlaceholderText = "";
            this.tbTietKT.Size = new System.Drawing.Size(111, 35);
            this.tbTietKT.TabIndex = 44;
            this.tbTietKT.Texts = "Tiết 5";
            this.tbTietKT.UnderlinedStyle = false;
            // 
            // tbTietBD
            // 
            this.tbTietBD.BackColor = System.Drawing.SystemColors.Window;
            this.tbTietBD.BorderColor = System.Drawing.Color.Teal;
            this.tbTietBD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTietBD.BorderRadius = 15;
            this.tbTietBD.BorderSize = 1;
            this.tbTietBD.Enabled = false;
            this.tbTietBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTietBD.ForeColor = System.Drawing.Color.DimGray;
            this.tbTietBD.Location = new System.Drawing.Point(397, 50);
            this.tbTietBD.Margin = new System.Windows.Forms.Padding(4);
            this.tbTietBD.MaxLength = 32767;
            this.tbTietBD.Multiline = false;
            this.tbTietBD.Name = "tbTietBD";
            this.tbTietBD.Padding = new System.Windows.Forms.Padding(30, 7, 7, 7);
            this.tbTietBD.PasswordChar = false;
            this.tbTietBD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTietBD.PlaceholderText = "";
            this.tbTietBD.Size = new System.Drawing.Size(111, 35);
            this.tbTietBD.TabIndex = 43;
            this.tbTietBD.Texts = "Tiết 4";
            this.tbTietBD.UnderlinedStyle = false;
            // 
            // tbThu
            // 
            this.tbThu.BackColor = System.Drawing.SystemColors.Window;
            this.tbThu.BorderColor = System.Drawing.Color.Teal;
            this.tbThu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbThu.BorderRadius = 15;
            this.tbThu.BorderSize = 1;
            this.tbThu.Enabled = false;
            this.tbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThu.ForeColor = System.Drawing.Color.DimGray;
            this.tbThu.Location = new System.Drawing.Point(71, 50);
            this.tbThu.Margin = new System.Windows.Forms.Padding(4);
            this.tbThu.MaxLength = 32767;
            this.tbThu.Multiline = false;
            this.tbThu.Name = "tbThu";
            this.tbThu.Padding = new System.Windows.Forms.Padding(30, 7, 7, 7);
            this.tbThu.PasswordChar = false;
            this.tbThu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbThu.PlaceholderText = "";
            this.tbThu.Size = new System.Drawing.Size(111, 35);
            this.tbThu.TabIndex = 42;
            this.tbThu.Texts = "Thứ ba";
            this.tbThu.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(932, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(615, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiết kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(273, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tiết bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thứ:";
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
            this.tbTenGV.ForeColor = System.Drawing.Color.DimGray;
            this.tbTenGV.Location = new System.Drawing.Point(816, 44);
            this.tbTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenGV.MaxLength = 32767;
            this.tbTenGV.Multiline = false;
            this.tbTenGV.Name = "tbTenGV";
            this.tbTenGV.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenGV.PasswordChar = false;
            this.tbTenGV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTenGV.PlaceholderText = "";
            this.tbTenGV.Size = new System.Drawing.Size(315, 35);
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
            this.tbMaGV.ForeColor = System.Drawing.Color.DimGray;
            this.tbMaGV.Location = new System.Drawing.Point(144, 44);
            this.tbMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaGV.MaxLength = 32767;
            this.tbMaGV.Multiline = false;
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.Padding = new System.Windows.Forms.Padding(7);
            this.tbMaGV.PasswordChar = false;
            this.tbMaGV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMaGV.PlaceholderText = "";
            this.tbMaGV.Size = new System.Drawing.Size(130, 35);
            this.tbMaGV.TabIndex = 40;
            this.tbMaGV.Texts = "";
            this.tbMaGV.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(674, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên giảng viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 50);
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
            // 
            // tbTenHP
            // 
            this.tbTenHP.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenHP.BorderColor = System.Drawing.Color.Teal;
            this.tbTenHP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenHP.BorderRadius = 10;
            this.tbTenHP.BorderSize = 1;
            this.tbTenHP.Enabled = false;
            this.tbTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenHP.ForeColor = System.Drawing.Color.DimGray;
            this.tbTenHP.Location = new System.Drawing.Point(862, 72);
            this.tbTenHP.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenHP.MaxLength = 32767;
            this.tbTenHP.Multiline = false;
            this.tbTenHP.Name = "tbTenHP";
            this.tbTenHP.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenHP.PasswordChar = false;
            this.tbTenHP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTenHP.PlaceholderText = "";
            this.tbTenHP.Size = new System.Drawing.Size(315, 35);
            this.tbTenHP.TabIndex = 40;
            this.tbTenHP.Texts = "";
            this.tbTenHP.UnderlinedStyle = false;
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
            this.tbMaHP.ForeColor = System.Drawing.Color.DimGray;
            this.tbMaHP.Location = new System.Drawing.Point(190, 72);
            this.tbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHP.MaxLength = 32767;
            this.tbMaHP.Multiline = false;
            this.tbMaHP.Name = "tbMaHP";
            this.tbMaHP.Padding = new System.Windows.Forms.Padding(7);
            this.tbMaHP.PasswordChar = false;
            this.tbMaHP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMaHP.PlaceholderText = "";
            this.tbMaHP.Size = new System.Drawing.Size(130, 35);
            this.tbMaHP.TabIndex = 39;
            this.tbMaHP.Texts = "";
            this.tbMaHP.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXacNhan.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.tbTenGV);
            this.guna2GroupBox1.Controls.Add(this.tbMaGV);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.BurlyWood;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(46, 114);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1139, 102);
            this.guna2GroupBox1.TabIndex = 41;
            this.guna2GroupBox1.Text = "Giảng viên phụ trách";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.tbPhong);
            this.guna2GroupBox2.Controls.Add(this.tbThu);
            this.guna2GroupBox2.Controls.Add(this.tbTietKT);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.tbTietBD);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.BurlyWood;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(46, 222);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1139, 102);
            this.guna2GroupBox2.TabIndex = 42;
            this.guna2GroupBox2.Text = "Lịch học";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAssignTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 751);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.tbTenHP);
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
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
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
        private MyCustomControl.CustomTextBox tbPhong;
        private MyCustomControl.CustomTextBox tbTietKT;
        private MyCustomControl.CustomTextBox tbTietBD;
        private MyCustomControl.CustomTextBox tbThu;
        private MyCustomControl.CustomTextBox tbTenGV;
        private MyCustomControl.CustomTextBox tbMaGV;
        private MyCustomControl.CustomTextBox tbTenHP;
        private MyCustomControl.CustomButton btnPrev;
        private MyCustomControl.CustomButton btnNext;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}