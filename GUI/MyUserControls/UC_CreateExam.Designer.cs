namespace GUI.MyUserControls
{
    partial class UC_CreateExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoaiBaiKiemTra = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSoLuongCauHoi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLopHocPhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayKiemTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpGioKT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chbAllowReturn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbMatKhauLamBai = new GUI.MyCustomControl.CustomTextBox();
            this.btnTao = new GUI.MyCustomControl.CustomButton();
            this.btnDatLai = new GUI.MyCustomControl.CustomButton();
            this.tbThoiGianLamBai = new GUI.MyCustomControl.CustomTextBox();
            this.tbTenBaiKiemTra = new GUI.MyCustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bài kiểm tra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại bài kiểm tra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian kiểm tra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thời gian làm bài";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng câu hỏi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lớp học phần";
            // 
            // cbLoaiBaiKiemTra
            // 
            this.cbLoaiBaiKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiBaiKiemTra.BorderColor = System.Drawing.Color.Black;
            this.cbLoaiBaiKiemTra.BorderRadius = 10;
            this.cbLoaiBaiKiemTra.BorderThickness = 2;
            this.cbLoaiBaiKiemTra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiBaiKiemTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiBaiKiemTra.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiBaiKiemTra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiBaiKiemTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiBaiKiemTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiBaiKiemTra.ItemHeight = 30;
            this.cbLoaiBaiKiemTra.Items.AddRange(new object[] {
            "Chọn loại bài kiểm tra",
            "Giữa kỳ",
            "Cuối kỳ",
            "Test"});
            this.cbLoaiBaiKiemTra.Location = new System.Drawing.Point(208, 211);
            this.cbLoaiBaiKiemTra.Name = "cbLoaiBaiKiemTra";
            this.cbLoaiBaiKiemTra.Size = new System.Drawing.Size(250, 36);
            this.cbLoaiBaiKiemTra.TabIndex = 16;
            // 
            // cbSoLuongCauHoi
            // 
            this.cbSoLuongCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.cbSoLuongCauHoi.BorderColor = System.Drawing.Color.Black;
            this.cbSoLuongCauHoi.BorderRadius = 10;
            this.cbSoLuongCauHoi.BorderThickness = 2;
            this.cbSoLuongCauHoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoLuongCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoLuongCauHoi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoLuongCauHoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoLuongCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSoLuongCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSoLuongCauHoi.ItemHeight = 30;
            this.cbSoLuongCauHoi.Items.AddRange(new object[] {
            "Chọn số câu hỏi",
            "30",
            "40",
            "50"});
            this.cbSoLuongCauHoi.Location = new System.Drawing.Point(843, 91);
            this.cbSoLuongCauHoi.Name = "cbSoLuongCauHoi";
            this.cbSoLuongCauHoi.Size = new System.Drawing.Size(250, 36);
            this.cbSoLuongCauHoi.TabIndex = 18;
            // 
            // cbLopHocPhan
            // 
            this.cbLopHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.cbLopHocPhan.BorderColor = System.Drawing.Color.Black;
            this.cbLopHocPhan.BorderRadius = 10;
            this.cbLopHocPhan.BorderThickness = 2;
            this.cbLopHocPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLopHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopHocPhan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLopHocPhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLopHocPhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLopHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLopHocPhan.ItemHeight = 30;
            this.cbLopHocPhan.Location = new System.Drawing.Point(843, 210);
            this.cbLopHocPhan.Name = "cbLopHocPhan";
            this.cbLopHocPhan.Size = new System.Drawing.Size(250, 36);
            this.cbLopHocPhan.TabIndex = 19;
            // 
            // dtpNgayKiemTra
            // 
            this.dtpNgayKiemTra.BorderRadius = 10;
            this.dtpNgayKiemTra.Checked = true;
            this.dtpNgayKiemTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.dtpNgayKiemTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKiemTra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKiemTra.Location = new System.Drawing.Point(208, 432);
            this.dtpNgayKiemTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKiemTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKiemTra.Name = "dtpNgayKiemTra";
            this.dtpNgayKiemTra.Size = new System.Drawing.Size(247, 36);
            this.dtpNgayKiemTra.TabIndex = 23;
            this.dtpNgayKiemTra.Value = new System.DateTime(2023, 4, 26, 23, 39, 58, 40);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mật khẩu bài làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "(phút)";
            // 
            // dtpGioKT
            // 
            this.dtpGioKT.BorderRadius = 10;
            this.dtpGioKT.Checked = true;
            this.dtpGioKT.CustomFormat = "hh:mm tt";
            this.dtpGioKT.FillColor = System.Drawing.Color.Chartreuse;
            this.dtpGioKT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKT.Location = new System.Drawing.Point(208, 492);
            this.dtpGioKT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpGioKT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpGioKT.Name = "dtpGioKT";
            this.dtpGioKT.ShowUpDown = true;
            this.dtpGioKT.Size = new System.Drawing.Size(250, 36);
            this.dtpGioKT.TabIndex = 28;
            this.dtpGioKT.Value = new System.DateTime(2023, 4, 26, 23, 39, 58, 40);
            // 
            // chbAllowReturn
            // 
            this.chbAllowReturn.AutoSize = true;
            this.chbAllowReturn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllowReturn.CheckedState.BorderRadius = 0;
            this.chbAllowReturn.CheckedState.BorderThickness = 0;
            this.chbAllowReturn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAllowReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAllowReturn.Location = new System.Drawing.Point(652, 460);
            this.chbAllowReturn.Name = "chbAllowReturn";
            this.chbAllowReturn.Size = new System.Drawing.Size(187, 29);
            this.chbAllowReturn.TabIndex = 30;
            this.chbAllowReturn.Text = "Cho phép quay lại";
            this.chbAllowReturn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAllowReturn.UncheckedState.BorderRadius = 0;
            this.chbAllowReturn.UncheckedState.BorderThickness = 0;
            this.chbAllowReturn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // tbMatKhauLamBai
            // 
            this.tbMatKhauLamBai.BackColor = System.Drawing.SystemColors.Window;
            this.tbMatKhauLamBai.BorderColor = System.Drawing.Color.Black;
            this.tbMatKhauLamBai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMatKhauLamBai.BorderRadius = 10;
            this.tbMatKhauLamBai.BorderSize = 2;
            this.tbMatKhauLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhauLamBai.ForeColor = System.Drawing.Color.DimGray;
            this.tbMatKhauLamBai.Location = new System.Drawing.Point(843, 324);
            this.tbMatKhauLamBai.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatKhauLamBai.MaxLength = 32767;
            this.tbMatKhauLamBai.Multiline = false;
            this.tbMatKhauLamBai.Name = "tbMatKhauLamBai";
            this.tbMatKhauLamBai.Padding = new System.Windows.Forms.Padding(7);
            this.tbMatKhauLamBai.PasswordChar = false;
            this.tbMatKhauLamBai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMatKhauLamBai.PlaceholderText = "";
            this.tbMatKhauLamBai.Size = new System.Drawing.Size(250, 35);
            this.tbMatKhauLamBai.TabIndex = 24;
            this.tbMatKhauLamBai.Texts = "";
            this.tbMatKhauLamBai.UnderlinedStyle = false;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTao.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTao.BorderRadius = 20;
            this.btnTao.BorderSize = 0;
            this.btnTao.Enabled = false;
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Image = global::GUI.Properties.Resources.Save;
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(717, 614);
            this.btnTao.Name = "btnTao";
            this.btnTao.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTao.Size = new System.Drawing.Size(148, 55);
            this.btnTao.TabIndex = 15;
            this.btnTao.Text = " Tạo";
            this.btnTao.TextColor = System.Drawing.Color.White;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.Black;
            this.btnDatLai.BackGroundColor = System.Drawing.Color.Black;
            this.btnDatLai.BorderColor = System.Drawing.Color.Black;
            this.btnDatLai.BorderRadius = 20;
            this.btnDatLai.BorderSize = 0;
            this.btnDatLai.FlatAppearance.BorderSize = 0;
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatLai.Location = new System.Drawing.Point(246, 614);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(148, 55);
            this.btnDatLai.TabIndex = 14;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // tbThoiGianLamBai
            // 
            this.tbThoiGianLamBai.BackColor = System.Drawing.SystemColors.Window;
            this.tbThoiGianLamBai.BorderColor = System.Drawing.Color.Black;
            this.tbThoiGianLamBai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbThoiGianLamBai.BorderRadius = 10;
            this.tbThoiGianLamBai.BorderSize = 2;
            this.tbThoiGianLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThoiGianLamBai.ForeColor = System.Drawing.Color.DimGray;
            this.tbThoiGianLamBai.Location = new System.Drawing.Point(208, 328);
            this.tbThoiGianLamBai.Margin = new System.Windows.Forms.Padding(4);
            this.tbThoiGianLamBai.MaxLength = 32767;
            this.tbThoiGianLamBai.Multiline = false;
            this.tbThoiGianLamBai.Name = "tbThoiGianLamBai";
            this.tbThoiGianLamBai.Padding = new System.Windows.Forms.Padding(7);
            this.tbThoiGianLamBai.PasswordChar = false;
            this.tbThoiGianLamBai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbThoiGianLamBai.PlaceholderText = "";
            this.tbThoiGianLamBai.Size = new System.Drawing.Size(152, 35);
            this.tbThoiGianLamBai.TabIndex = 6;
            this.tbThoiGianLamBai.Texts = "";
            this.tbThoiGianLamBai.UnderlinedStyle = false;
            // 
            // tbTenBaiKiemTra
            // 
            this.tbTenBaiKiemTra.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenBaiKiemTra.BorderColor = System.Drawing.Color.Black;
            this.tbTenBaiKiemTra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenBaiKiemTra.BorderRadius = 10;
            this.tbTenBaiKiemTra.BorderSize = 2;
            this.tbTenBaiKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBaiKiemTra.ForeColor = System.Drawing.Color.DimGray;
            this.tbTenBaiKiemTra.Location = new System.Drawing.Point(208, 92);
            this.tbTenBaiKiemTra.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenBaiKiemTra.MaxLength = 32767;
            this.tbTenBaiKiemTra.Multiline = false;
            this.tbTenBaiKiemTra.Name = "tbTenBaiKiemTra";
            this.tbTenBaiKiemTra.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenBaiKiemTra.PasswordChar = false;
            this.tbTenBaiKiemTra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTenBaiKiemTra.PlaceholderText = "";
            this.tbTenBaiKiemTra.Size = new System.Drawing.Size(250, 35);
            this.tbTenBaiKiemTra.TabIndex = 0;
            this.tbTenBaiKiemTra.Texts = "";
            this.tbTenBaiKiemTra.UnderlinedStyle = false;
            // 
            // UC_CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbAllowReturn);
            this.Controls.Add(this.dtpGioKT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMatKhauLamBai);
            this.Controls.Add(this.dtpNgayKiemTra);
            this.Controls.Add(this.cbLopHocPhan);
            this.Controls.Add(this.cbSoLuongCauHoi);
            this.Controls.Add(this.cbLoaiBaiKiemTra);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbThoiGianLamBai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenBaiKiemTra);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_CreateExam";
            this.Size = new System.Drawing.Size(1175, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomControl.CustomTextBox tbTenBaiKiemTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomTextBox tbThoiGianLamBai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MyCustomControl.CustomButton btnDatLai;
        private MyCustomControl.CustomButton btnTao;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiBaiKiemTra;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoLuongCauHoi;
        private Guna.UI2.WinForms.Guna2ComboBox cbLopHocPhan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKiemTra;
        private System.Windows.Forms.Label label8;
        private MyCustomControl.CustomTextBox tbMatKhauLamBai;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpGioKT;
        private Guna.UI2.WinForms.Guna2CheckBox chbAllowReturn;
    }
}
