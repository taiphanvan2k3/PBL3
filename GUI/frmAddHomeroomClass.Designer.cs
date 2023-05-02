namespace GUI
{
    partial class frmAddHomeroomClass
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbYear = new GUI.MyCustomControl.CustomComboBox();
            this.cmbProgramingList = new GUI.MyCustomControl.CustomComboBox();
            this.cmbListFacluty = new GUI.MyCustomControl.CustomComboBox();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.cmbTeacher = new GUI.MyCustomControl.CustomComboBox();
            this.txtNumberMaxStudent = new GUI.MyCustomControl.CustomTextBox();
            this.labelErr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbProgramingList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbListFacluty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbTeacher, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.56286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.60615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.71831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới lớp sinh hoạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chương trình đào tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(50, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khóa nhập học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 399);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 101);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 101);
            this.panel3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(50, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giảng viên chủ nhiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(50, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng tối đa";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelErr);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtNumberMaxStudent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(400, 329);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 70);
            this.panel4.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(246, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 10, 50, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "(Tối đa 50)";
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbYear.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbYear.BorderSize = 1;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.ForeColor = System.Drawing.Color.DimGray;
            this.cmbYear.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbYear.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbYear.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbYear.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbYear.Location = new System.Drawing.Point(403, 199);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.cmbYear.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Padding = new System.Windows.Forms.Padding(1);
            this.cmbYear.Size = new System.Drawing.Size(347, 40);
            this.cmbYear.TabIndex = 31;
            this.cmbYear.Texts = "";
            this.cmbYear.OnSelectedIndexChanged += new System.EventHandler(this.cmbProgramingList_OnSelectedIndexChanged);
            // 
            // cmbProgramingList
            // 
            this.cmbProgramingList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProgramingList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbProgramingList.BorderSize = 1;
            this.cmbProgramingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbProgramingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProgramingList.ForeColor = System.Drawing.Color.DimGray;
            this.cmbProgramingList.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbProgramingList.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbProgramingList.Items.AddRange(new object[] {
            "Chất Lượng Cao",
            "Đại Trà",
            "Tiên Tiến"});
            this.cmbProgramingList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbProgramingList.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbProgramingList.Location = new System.Drawing.Point(403, 126);
            this.cmbProgramingList.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.cmbProgramingList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbProgramingList.Name = "cmbProgramingList";
            this.cmbProgramingList.Padding = new System.Windows.Forms.Padding(1);
            this.cmbProgramingList.Size = new System.Drawing.Size(347, 40);
            this.cmbProgramingList.TabIndex = 30;
            this.cmbProgramingList.Texts = "";
            this.cmbProgramingList.OnSelectedIndexChanged += new System.EventHandler(this.cmbProgramingList_OnSelectedIndexChanged);
            // 
            // cmbListFacluty
            // 
            this.cmbListFacluty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbListFacluty.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbListFacluty.BorderSize = 1;
            this.cmbListFacluty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbListFacluty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListFacluty.ForeColor = System.Drawing.Color.DimGray;
            this.cmbListFacluty.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbListFacluty.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbListFacluty.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbListFacluty.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbListFacluty.Location = new System.Drawing.Point(403, 59);
            this.cmbListFacluty.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.cmbListFacluty.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbListFacluty.Name = "cmbListFacluty";
            this.cmbListFacluty.Padding = new System.Windows.Forms.Padding(1);
            this.cmbListFacluty.Size = new System.Drawing.Size(347, 40);
            this.cmbListFacluty.TabIndex = 29;
            this.cmbListFacluty.Texts = "";
            this.cmbListFacluty.OnSelectedIndexChanged += new System.EventHandler(this.cmbListFacluty_OnSelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(0, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Red;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(225, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTeacher.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTeacher.BorderSize = 1;
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacher.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTeacher.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTeacher.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbTeacher.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTeacher.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTeacher.Location = new System.Drawing.Point(403, 269);
            this.cmbTeacher.Margin = new System.Windows.Forms.Padding(3, 10, 50, 3);
            this.cmbTeacher.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTeacher.Size = new System.Drawing.Size(347, 40);
            this.cmbTeacher.TabIndex = 33;
            this.cmbTeacher.Texts = "";
            this.cmbTeacher.OnSelectedIndexChanged += new System.EventHandler(this.cmbProgramingList_OnSelectedIndexChanged);
            // 
            // txtNumberMaxStudent
            // 
            this.txtNumberMaxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtNumberMaxStudent.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumberMaxStudent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumberMaxStudent.BorderRadius = 10;
            this.txtNumberMaxStudent.BorderSize = 1;
            this.txtNumberMaxStudent.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberMaxStudent.ForeColor = System.Drawing.Color.Lavender;
            this.txtNumberMaxStudent.Location = new System.Drawing.Point(0, 10);
            this.txtNumberMaxStudent.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.txtNumberMaxStudent.MaxLength = 32767;
            this.txtNumberMaxStudent.Multiline = false;
            this.txtNumberMaxStudent.Name = "txtNumberMaxStudent";
            this.txtNumberMaxStudent.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumberMaxStudent.PasswordChar = false;
            this.txtNumberMaxStudent.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtNumberMaxStudent.PlaceholderText = "50";
            this.txtNumberMaxStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberMaxStudent.Size = new System.Drawing.Size(160, 42);
            this.txtNumberMaxStudent.TabIndex = 36;
            this.txtNumberMaxStudent.Texts = "";
            this.txtNumberMaxStudent.UnderlinedStyle = false;
            this.txtNumberMaxStudent._TextChanged += new System.EventHandler(this.txtNumberMaxStudent__TextChanged);
            this.txtNumberMaxStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberMaxStudent_KeyPress);
            // 
            // labelErr
            // 
            this.labelErr.AutoSize = true;
            this.labelErr.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErr.ForeColor = System.Drawing.Color.Firebrick;
            this.labelErr.Location = new System.Drawing.Point(164, 19);
            this.labelErr.Margin = new System.Windows.Forms.Padding(0, 10, 50, 0);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(41, 27);
            this.labelErr.TabIndex = 38;
            this.labelErr.Text = "Lỗi";
            this.labelErr.Visible = false;
            // 
            // frmAddHomeroomClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddHomeroomClass";
            this.Text = "frmAddHomeroomClass";
            this.Load += new System.EventHandler(this.frmAddHomeroomClass_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private MyCustomControl.CustomButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomComboBox cmbTeacher;
        private MyCustomControl.CustomComboBox cmbListFacluty;
        private MyCustomControl.CustomComboBox cmbYear;
        private MyCustomControl.CustomComboBox cmbProgramingList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private MyCustomControl.CustomTextBox txtNumberMaxStudent;
        private System.Windows.Forms.Label labelErr;
    }
}