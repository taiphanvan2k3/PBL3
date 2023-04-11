namespace GUI.MyUserControls
{
    partial class UC_CreateTestQuestions
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
            this.tbTenBaiKiemTra = new GUI.MyCustomControl.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThoiGianKiemTra = new GUI.MyCustomControl.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbThoiGianLamBai = new GUI.MyCustomControl.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDatLai = new GUI.MyCustomControl.CustomButton();
            this.btnTao = new GUI.MyCustomControl.CustomButton();
            this.cbLoaiBaiKiemTra = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSoLuongCauHoi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLopHocPhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên bài kiểm tra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại bài kiểm tra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời gian kiểm tra";
            // 
            // tbThoiGianKiemTra
            // 
            this.tbThoiGianKiemTra.BackColor = System.Drawing.SystemColors.Window;
            this.tbThoiGianKiemTra.BorderColor = System.Drawing.Color.Black;
            this.tbThoiGianKiemTra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbThoiGianKiemTra.BorderRadius = 10;
            this.tbThoiGianKiemTra.BorderSize = 2;
            this.tbThoiGianKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThoiGianKiemTra.ForeColor = System.Drawing.Color.DimGray;
            this.tbThoiGianKiemTra.Location = new System.Drawing.Point(208, 292);
            this.tbThoiGianKiemTra.Margin = new System.Windows.Forms.Padding(4);
            this.tbThoiGianKiemTra.MaxLength = 32767;
            this.tbThoiGianKiemTra.Multiline = false;
            this.tbThoiGianKiemTra.Name = "tbThoiGianKiemTra";
            this.tbThoiGianKiemTra.Padding = new System.Windows.Forms.Padding(7);
            this.tbThoiGianKiemTra.PasswordChar = false;
            this.tbThoiGianKiemTra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbThoiGianKiemTra.PlaceholderText = "";
            this.tbThoiGianKiemTra.Size = new System.Drawing.Size(250, 35);
            this.tbThoiGianKiemTra.TabIndex = 4;
            this.tbThoiGianKiemTra.Texts = "";
            this.tbThoiGianKiemTra.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thời gian làm bài";
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
            this.tbThoiGianLamBai.Location = new System.Drawing.Point(208, 392);
            this.tbThoiGianLamBai.Margin = new System.Windows.Forms.Padding(4);
            this.tbThoiGianLamBai.MaxLength = 32767;
            this.tbThoiGianLamBai.Multiline = false;
            this.tbThoiGianLamBai.Name = "tbThoiGianLamBai";
            this.tbThoiGianLamBai.Padding = new System.Windows.Forms.Padding(7);
            this.tbThoiGianLamBai.PasswordChar = false;
            this.tbThoiGianLamBai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbThoiGianLamBai.PlaceholderText = "";
            this.tbThoiGianLamBai.Size = new System.Drawing.Size(250, 35);
            this.tbThoiGianLamBai.TabIndex = 6;
            this.tbThoiGianLamBai.Texts = "";
            this.tbThoiGianLamBai.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng câu hỏi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lớp học phần";
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
            this.btnDatLai.Location = new System.Drawing.Point(308, 490);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(121, 40);
            this.btnDatLai.TabIndex = 14;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatLai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatLai.UseVisualStyleBackColor = false;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTao.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTao.BorderRadius = 20;
            this.btnTao.BorderSize = 0;
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTao.Location = new System.Drawing.Point(578, 490);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(121, 40);
            this.btnTao.TabIndex = 15;
            this.btnTao.Text = "Tạo";
            this.btnTao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTao.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnTao.UseVisualStyleBackColor = false;
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
            this.cbLoaiBaiKiemTra.Location = new System.Drawing.Point(208, 192);
            this.cbLoaiBaiKiemTra.Name = "cbLoaiBaiKiemTra";
            this.cbLoaiBaiKiemTra.Size = new System.Drawing.Size(250, 36);
            this.cbLoaiBaiKiemTra.TabIndex = 16;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbMonHoc.BorderColor = System.Drawing.Color.Black;
            this.cbMonHoc.BorderRadius = 10;
            this.cbMonHoc.BorderThickness = 2;
            this.cbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMonHoc.ItemHeight = 30;
            this.cbMonHoc.Location = new System.Drawing.Point(731, 92);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(250, 36);
            this.cbMonHoc.TabIndex = 17;
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
            this.cbSoLuongCauHoi.Location = new System.Drawing.Point(731, 192);
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
            this.cbLopHocPhan.Location = new System.Drawing.Point(731, 292);
            this.cbLopHocPhan.Name = "cbLopHocPhan";
            this.cbLopHocPhan.Size = new System.Drawing.Size(250, 36);
            this.cbLopHocPhan.TabIndex = 19;
            this.cbLopHocPhan.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // UC_CreateTestQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLopHocPhan);
            this.Controls.Add(this.cbSoLuongCauHoi);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.cbLoaiBaiKiemTra);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbThoiGianLamBai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbThoiGianKiemTra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenBaiKiemTra);
            this.Name = "UC_CreateTestQuestions";
            this.Size = new System.Drawing.Size(1119, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomControl.CustomTextBox tbTenBaiKiemTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MyCustomControl.CustomTextBox tbThoiGianKiemTra;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomTextBox tbThoiGianLamBai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MyCustomControl.CustomButton btnDatLai;
        private MyCustomControl.CustomButton btnTao;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiBaiKiemTra;
        private Guna.UI2.WinForms.Guna2ComboBox cbMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoLuongCauHoi;
        private Guna.UI2.WinForms.Guna2ComboBox cbLopHocPhan;
    }
}
