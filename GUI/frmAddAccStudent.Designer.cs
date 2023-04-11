namespace GUI
{
    partial class frmAddAccStudent
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
            this.btnClose = new System.Windows.Forms.Button();
            this.Hủy = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFacultyOrProgram = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.txtCCCD = new GUI.MyCustomControl.CustomTextBox();
            this.cmbList = new GUI.MyCustomControl.CustomComboBox();
            this.customRadioButton2 = new GUI.MyCustomControl.CustomRadioButton();
            this.customRadioButton1 = new GUI.MyCustomControl.CustomRadioButton();
            this.dtpBirthday = new GUI.MyCustomControl.CustomDatetimePicker();
            this.txtName = new GUI.MyCustomControl.CustomTextBox();
            this.lbYearOrLevel = new System.Windows.Forms.Label();
            this.cmbYearOrLevel = new GUI.MyCustomControl.CustomComboBox();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(470, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
            // 
            // Hủy
            // 
            this.Hủy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Hủy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.Hủy.FlatAppearance.BorderSize = 0;
            this.Hủy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hủy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hủy.ForeColor = System.Drawing.Color.LightGray;
            this.Hủy.Location = new System.Drawing.Point(43, 744);
            this.Hủy.Margin = new System.Windows.Forms.Padding(4);
            this.Hủy.Name = "Hủy";
            this.Hủy.Size = new System.Drawing.Size(200, 49);
            this.Hủy.TabIndex = 16;
            this.Hủy.Text = "Hủy";
            this.Hủy.UseVisualStyleBackColor = false;
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.LightGray;
            this.btnADD.Location = new System.Drawing.Point(251, 738);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(200, 49);
            this.btnADD.TabIndex = 15;
            this.btnADD.Text = "Thêm ";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(51, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Căn cước công dân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(51, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(51, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giới tính";
            // 
            // lbFacultyOrProgram
            // 
            this.lbFacultyOrProgram.AutoSize = true;
            this.lbFacultyOrProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbFacultyOrProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacultyOrProgram.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFacultyOrProgram.Location = new System.Drawing.Point(51, 407);
            this.lbFacultyOrProgram.Name = "lbFacultyOrProgram";
            this.lbFacultyOrProgram.Size = new System.Drawing.Size(295, 25);
            this.lbFacultyOrProgram.TabIndex = 27;
            this.lbFacultyOrProgram.Text = "Khoa và chương trình đào tạo";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(500, 30);
            this.panelTitleBar.TabIndex = 30;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtCCCD.BorderColor = System.Drawing.Color.Lavender;
            this.txtCCCD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCCCD.BorderRadius = 5;
            this.txtCCCD.BorderSize = 1;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.Lavender;
            this.txtCCCD.Location = new System.Drawing.Point(50, 165);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.MaxLength = 32767;
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(7);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtCCCD.PlaceholderText = "Căn cước công dân";
            this.txtCCCD.Size = new System.Drawing.Size(400, 40);
            this.txtCCCD.TabIndex = 29;
            this.txtCCCD.Texts = "";
            this.txtCCCD.UnderlinedStyle = false;
            // 
            // cmbList
            // 
            this.cmbList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbList.BorderSize = 1;
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbList.ForeColor = System.Drawing.Color.DimGray;
            this.cmbList.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbList.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbList.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbList.Location = new System.Drawing.Point(50, 449);
            this.cmbList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbList.Name = "cmbList";
            this.cmbList.Padding = new System.Windows.Forms.Padding(1);
            this.cmbList.Size = new System.Drawing.Size(400, 40);
            this.cmbList.TabIndex = 28;
            this.cmbList.Texts = "";
            this.cmbList.OnSelectedIndexChanged += new System.EventHandler(this.cmbList_OnSelectedIndexChanged);
            // 
            // customRadioButton2
            // 
            this.customRadioButton2.AutoSize = true;
            this.customRadioButton2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.customRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRadioButton2.ForeColor = System.Drawing.Color.Silver;
            this.customRadioButton2.Location = new System.Drawing.Point(161, 357);
            this.customRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.customRadioButton2.Name = "customRadioButton2";
            this.customRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customRadioButton2.Size = new System.Drawing.Size(61, 24);
            this.customRadioButton2.TabIndex = 26;
            this.customRadioButton2.TabStop = true;
            this.customRadioButton2.Text = "Nữ";
            this.customRadioButton2.UnCheckedColor = System.Drawing.Color.Lavender;
            this.customRadioButton2.UseVisualStyleBackColor = true;
            // 
            // customRadioButton1
            // 
            this.customRadioButton1.AutoSize = true;
            this.customRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.customRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRadioButton1.ForeColor = System.Drawing.Color.Silver;
            this.customRadioButton1.Location = new System.Drawing.Point(56, 357);
            this.customRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.customRadioButton1.Name = "customRadioButton1";
            this.customRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customRadioButton1.Size = new System.Drawing.Size(75, 24);
            this.customRadioButton1.TabIndex = 24;
            this.customRadioButton1.TabStop = true;
            this.customRadioButton1.Text = "Nam";
            this.customRadioButton1.UnCheckedColor = System.Drawing.Color.Lavender;
            this.customRadioButton1.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpBirthday.BorderSize = 0;
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(50, 258);
            this.dtpBirthday.MaxDate = new System.DateTime(2074, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1983, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(400, 35);
            this.dtpBirthday.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dtpBirthday.TabIndex = 23;
            this.dtpBirthday.TextColor = System.Drawing.Color.Lavender;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtName.BorderColor = System.Drawing.Color.Lavender;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 5;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Lavender;
            this.txtName.Location = new System.Drawing.Point(50, 69);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtName.PlaceholderText = "Họ và tên";
            this.txtName.Size = new System.Drawing.Size(400, 40);
            this.txtName.TabIndex = 17;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // lbYearOrLevel
            // 
            this.lbYearOrLevel.AutoSize = true;
            this.lbYearOrLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbYearOrLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYearOrLevel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbYearOrLevel.Location = new System.Drawing.Point(51, 519);
            this.lbYearOrLevel.Name = "lbYearOrLevel";
            this.lbYearOrLevel.Size = new System.Drawing.Size(151, 25);
            this.lbYearOrLevel.TabIndex = 31;
            this.lbYearOrLevel.Text = "Năm nhập học";
            // 
            // cmbYearOrLevel
            // 
            this.cmbYearOrLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbYearOrLevel.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbYearOrLevel.BorderSize = 1;
            this.cmbYearOrLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbYearOrLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearOrLevel.ForeColor = System.Drawing.Color.DimGray;
            this.cmbYearOrLevel.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbYearOrLevel.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbYearOrLevel.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbYearOrLevel.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbYearOrLevel.Location = new System.Drawing.Point(50, 566);
            this.cmbYearOrLevel.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbYearOrLevel.Name = "cmbYearOrLevel";
            this.cmbYearOrLevel.Padding = new System.Windows.Forms.Padding(1);
            this.cmbYearOrLevel.Size = new System.Drawing.Size(400, 40);
            this.cmbYearOrLevel.TabIndex = 32;
            this.cmbYearOrLevel.Texts = "";
            // 
            // frmAddAccStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.cmbYearOrLevel);
            this.Controls.Add(this.lbYearOrLevel);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.lbFacultyOrProgram);
            this.Controls.Add(this.customRadioButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customRadioButton1);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Hủy);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddAccStudent";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmAddAccStudent_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Hủy;
        private System.Windows.Forms.Button btnADD;
        private MyCustomControl.CustomTextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCustomControl.CustomDatetimePicker dtpBirthday;
        private MyCustomControl.CustomRadioButton customRadioButton1;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomRadioButton customRadioButton2;
        private System.Windows.Forms.Label lbFacultyOrProgram;
        private MyCustomControl.CustomComboBox cmbList;
        private MyCustomControl.CustomTextBox txtCCCD;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbYearOrLevel;
        private MyCustomControl.CustomComboBox cmbYearOrLevel;
    }
}