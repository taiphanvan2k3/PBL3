namespace GUI
{
    partial class frmAddSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSoTC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupCTDT = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxCTDT_PBL = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.toggleSwitch = new GUI.MyCustomControl.CustomToggleButton();
            this.txtTenMH = new GUI.MyCustomControl.CustomTextBox();
            this.groupCTDT.SuspendLayout();
            this.groupBoxCTDT_PBL.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.AutoSize = true;
            this.txtMaMH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(167, 78);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(22, 23);
            this.txtMaMH.TabIndex = 4;
            this.txtMaMH.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tín chỉ:";
            // 
            // cbbSoTC
            // 
            this.cbbSoTC.BackColor = System.Drawing.Color.Transparent;
            this.cbbSoTC.BorderRadius = 15;
            this.cbbSoTC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSoTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoTC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoTC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSoTC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSoTC.ItemHeight = 30;
            this.cbbSoTC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbSoTC.Location = new System.Drawing.Point(165, 242);
            this.cbbSoTC.Name = "cbbSoTC";
            this.cbbSoTC.Size = new System.Drawing.Size(126, 36);
            this.cbbSoTC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "PBL/Đồ án:";
            // 
            // groupCTDT
            // 
            this.groupCTDT.BorderColor = System.Drawing.Color.Beige;
            this.groupCTDT.BorderRadius = 10;
            this.groupCTDT.Controls.Add(this.radioButton3);
            this.groupCTDT.Controls.Add(this.radioButton2);
            this.groupCTDT.Controls.Add(this.radioButton1);
            this.groupCTDT.CustomBorderColor = System.Drawing.Color.Tomato;
            this.groupCTDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCTDT.ForeColor = System.Drawing.Color.LightYellow;
            this.groupCTDT.Location = new System.Drawing.Point(474, 244);
            this.groupCTDT.Name = "groupCTDT";
            this.groupCTDT.Size = new System.Drawing.Size(339, 175);
            this.groupCTDT.TabIndex = 9;
            this.groupCTDT.Text = "Công thức tính điểm";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton3.Location = new System.Drawing.Point(28, 133);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(253, 27);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "[BT]*0.2 + [GK]*0.3 + [CK]*0.5";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton2.Location = new System.Drawing.Point(28, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(253, 27);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "[BT]*0.3 + [GK]*0.2 + [CK]*0.5";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton1.Location = new System.Drawing.Point(28, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(253, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "[BT]*0.2 + [GK]*0.2 + [CK]*0.6";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // groupBoxCTDT_PBL
            // 
            this.groupBoxCTDT_PBL.BorderColor = System.Drawing.Color.Beige;
            this.groupBoxCTDT_PBL.BorderRadius = 10;
            this.groupBoxCTDT_PBL.Controls.Add(this.radioButton5);
            this.groupBoxCTDT_PBL.Controls.Add(this.radioButton4);
            this.groupBoxCTDT_PBL.CustomBorderColor = System.Drawing.Color.Tomato;
            this.groupBoxCTDT_PBL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCTDT_PBL.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBoxCTDT_PBL.Location = new System.Drawing.Point(474, 244);
            this.groupBoxCTDT_PBL.Name = "groupBoxCTDT_PBL";
            this.groupBoxCTDT_PBL.Size = new System.Drawing.Size(339, 141);
            this.groupBoxCTDT_PBL.TabIndex = 10;
            this.groupBoxCTDT_PBL.Text = "Công thức tính điểm";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton5.Location = new System.Drawing.Point(35, 96);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(173, 27);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "[QT]*0.3 + [CK]*0.7";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButton4.Location = new System.Drawing.Point(35, 53);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(173, 27);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "[QT]*0.4 + [CK]*0.6";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Coral;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(832, 50);
            this.panelTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm mới môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Khoa:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbbKhoa.BorderRadius = 15;
            this.cbbKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbKhoa.ItemHeight = 30;
            this.cbbKhoa.Location = new System.Drawing.Point(165, 179);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(287, 36);
            this.cbbKhoa.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(502, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(147, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch.Location = new System.Drawing.Point(168, 299);
            this.toggleSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.OffBackColor = System.Drawing.Color.White;
            this.toggleSwitch.OffToggleColor = System.Drawing.Color.DimGray;
            this.toggleSwitch.OnBackColor = System.Drawing.Color.CornflowerBlue;
            this.toggleSwitch.OnToggleColor = System.Drawing.Color.Navy;
            this.toggleSwitch.Size = new System.Drawing.Size(82, 30);
            this.toggleSwitch.TabIndex = 7;
            this.toggleSwitch.UseVisualStyleBackColor = true;
            this.toggleSwitch.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // txtTenMH
            // 
            this.txtTenMH.BackColor = System.Drawing.Color.White;
            this.txtTenMH.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenMH.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.txtTenMH.BorderRadius = 15;
            this.txtTenMH.BorderSize = 2;
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenMH.Location = new System.Drawing.Point(165, 117);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMH.MaxLength = 32767;
            this.txtTenMH.Multiline = false;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.txtTenMH.PasswordChar = false;
            this.txtTenMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.Size = new System.Drawing.Size(287, 38);
            this.txtTenMH.TabIndex = 2;
            this.txtTenMH.Texts = "";
            this.txtTenMH.UnderlinedStyle = false;
            this.txtTenMH._TextChanged += new System.EventHandler(this.txtTenMH_TextChanged);
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupCTDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.cbbSoTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCTDT_PBL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSubject";
            this.Text = "Thêm mới môn học";
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.groupCTDT.ResumeLayout(false);
            this.groupCTDT.PerformLayout();
            this.groupBoxCTDT_PBL.ResumeLayout(false);
            this.groupBoxCTDT_PBL.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCustomControl.CustomTextBox txtTenMH;
        private System.Windows.Forms.Label txtMaMH;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSoTC;
        private MyCustomControl.CustomToggleButton toggleSwitch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GroupBox groupCTDT;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxCTDT_PBL;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomButton btnCancel;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbbKhoa;
    }
}