namespace GUI
{
    partial class frmAddModuleClass
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenMH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhomHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAddModuleClass = new GUI.MyCustomControl.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAssignTeacher = new GUI.MyCustomControl.CustomButton();
            this.btnAddStudent = new GUI.MyCustomControl.CustomButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbKiHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelTitle.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Coral;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(812, 50);
            this.panelTitle.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm mới lớp học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên môn học:";
            // 
            // cbbTenMH
            // 
            this.cbbTenMH.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenMH.BorderRadius = 15;
            this.cbbTenMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenMH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenMH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTenMH.ItemHeight = 30;
            this.cbbTenMH.Items.AddRange(new object[] {
            "Toán rời rạc",
            "Cơ sở dữ liệu",
            "Lập trình Java",
            "Lập trình .Net"});
            this.cbbTenMH.Location = new System.Drawing.Point(199, 91);
            this.cbbTenMH.Name = "cbbTenMH";
            this.cbbTenMH.Size = new System.Drawing.Size(300, 36);
            this.cbbTenMH.TabIndex = 16;
            this.cbbTenMH.Leave += new System.EventHandler(this.cbbTenMH_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhóm học phần:";
            // 
            // txtNhomHP
            // 
            this.txtNhomHP.BorderRadius = 15;
            this.txtNhomHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhomHP.DefaultText = "";
            this.txtNhomHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhomHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhomHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhomHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhomHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhomHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhomHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtNhomHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhomHP.Location = new System.Drawing.Point(198, 151);
            this.txtNhomHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhomHP.Name = "txtNhomHP";
            this.txtNhomHP.PasswordChar = '\0';
            this.txtNhomHP.PlaceholderText = "";
            this.txtNhomHP.SelectedText = "";
            this.txtNhomHP.Size = new System.Drawing.Size(97, 35);
            this.txtNhomHP.TabIndex = 18;
            this.txtNhomHP.Leave += new System.EventHandler(this.cbbTenMH_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(512, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddModuleClass
            // 
            this.btnAddModuleClass.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddModuleClass.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnAddModuleClass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddModuleClass.BorderRadius = 40;
            this.btnAddModuleClass.BorderSize = 0;
            this.btnAddModuleClass.FlatAppearance.BorderSize = 0;
            this.btnAddModuleClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModuleClass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModuleClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddModuleClass.Location = new System.Drawing.Point(157, 421);
            this.btnAddModuleClass.Name = "btnAddModuleClass";
            this.btnAddModuleClass.Size = new System.Drawing.Size(127, 40);
            this.btnAddModuleClass.TabIndex = 19;
            this.btnAddModuleClass.Text = "Tạo lớp";
            this.btnAddModuleClass.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddModuleClass.UseVisualStyleBackColor = false;
            this.btnAddModuleClass.Click += new System.EventHandler(this.btnAddModuleClass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã học phần:";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(669, 157);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(0, 23);
            this.lblMaHP.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kì học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Năm học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Số lượng tối đa:";
            // 
            // txtSoLuongMax
            // 
            this.txtSoLuongMax.BorderRadius = 15;
            this.txtSoLuongMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongMax.DefaultText = "46";
            this.txtSoLuongMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongMax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtSoLuongMax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongMax.Location = new System.Drawing.Point(198, 212);
            this.txtSoLuongMax.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoLuongMax.Name = "txtSoLuongMax";
            this.txtSoLuongMax.PasswordChar = '\0';
            this.txtSoLuongMax.PlaceholderText = "";
            this.txtSoLuongMax.SelectedText = "";
            this.txtSoLuongMax.Size = new System.Drawing.Size(97, 36);
            this.txtSoLuongMax.TabIndex = 28;
            this.txtSoLuongMax.TextChanged += new System.EventHandler(this.txtSoLuongMax_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.btnAddStudent);
            this.guna2GroupBox1.Controls.Add(this.btnAssignTeacher);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(519, 212);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(281, 161);
            this.guna2GroupBox1.TabIndex = 29;
            this.guna2GroupBox1.Text = "Các tuỳ chọn";
            // 
            // btnAssignTeacher
            // 
            this.btnAssignTeacher.BackColor = System.Drawing.Color.IndianRed;
            this.btnAssignTeacher.BackGroundColor = System.Drawing.Color.IndianRed;
            this.btnAssignTeacher.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAssignTeacher.BorderRadius = 40;
            this.btnAssignTeacher.BorderSize = 0;
            this.btnAssignTeacher.FlatAppearance.BorderSize = 0;
            this.btnAssignTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAssignTeacher.Image = global::GUI.Properties.Resources.AssignTeacher;
            this.btnAssignTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignTeacher.Location = new System.Drawing.Point(16, 55);
            this.btnAssignTeacher.Name = "btnAssignTeacher";
            this.btnAssignTeacher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAssignTeacher.Size = new System.Drawing.Size(244, 40);
            this.btnAssignTeacher.TabIndex = 30;
            this.btnAssignTeacher.Text = "        Phân công giảng viên";
            this.btnAssignTeacher.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAssignTeacher.UseVisualStyleBackColor = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Tomato;
            this.btnAddStudent.BackGroundColor = System.Drawing.Color.Tomato;
            this.btnAddStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddStudent.BorderRadius = 40;
            this.btnAddStudent.BorderSize = 0;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudent.Image = global::GUI.Properties.Resources.AddStudent;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(16, 108);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddStudent.Size = new System.Drawing.Size(244, 40);
            this.btnAddStudent.TabIndex = 30;
            this.btnAddStudent.Text = "Thêm sinh viên";
            this.btnAddStudent.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "(Vd 21Nh13)";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbNamHoc.BorderRadius = 15;
            this.cbbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNamHoc.DropDownHeight = 120;
            this.cbbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNamHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNamHoc.IntegralHeight = false;
            this.cbbNamHoc.ItemHeight = 30;
            this.cbbNamHoc.Location = new System.Drawing.Point(198, 332);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(156, 36);
            this.cbbNamHoc.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "(Tối đa 70)";
            // 
            // cbbKiHoc
            // 
            this.cbbKiHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbKiHoc.BorderRadius = 15;
            this.cbbKiHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKiHoc.DropDownHeight = 120;
            this.cbbKiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKiHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKiHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKiHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKiHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbKiHoc.IntegralHeight = false;
            this.cbbKiHoc.ItemHeight = 30;
            this.cbbKiHoc.Location = new System.Drawing.Point(199, 272);
            this.cbbKiHoc.Name = "cbbKiHoc";
            this.cbbKiHoc.Size = new System.Drawing.Size(96, 36);
            this.cbbKiHoc.TabIndex = 33;
            // 
            // frmAddModuleClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(812, 500);
            this.Controls.Add(this.cbbKiHoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbNamHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txtSoLuongMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddModuleClass);
            this.Controls.Add(this.txtNhomHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddModuleClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddModuleClass";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenMH;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNhomHP;
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.CustomButton btnAddModuleClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongMax;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private MyCustomControl.CustomButton btnAddStudent;
        private MyCustomControl.CustomButton btnAssignTeacher;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNamHoc;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbbKiHoc;
    }
}