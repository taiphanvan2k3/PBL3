namespace GUI
{
    partial class frmAddAccount
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
            this.lbYearOrLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.txtName = new GUI.MyCustomControl.CustomTextBox();
            this.txtSurname = new GUI.MyCustomControl.CustomTextBox();
            this.cmbYearOrLevel = new GUI.MyCustomControl.CustomComboBox();
            this.txtCCCD = new GUI.MyCustomControl.CustomTextBox();
            this.dtpBirthday = new GUI.MyCustomControl.CustomDatetimePicker();
            this.cmbList = new GUI.MyCustomControl.CustomComboBox();
            this.rbMen = new GUI.MyCustomControl.CustomRadioButton();
            this.rbWomen = new GUI.MyCustomControl.CustomRadioButton();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.txtIDAcc = new GUI.MyCustomControl.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelEdit.SuspendLayout();
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
            this.btnADD.Location = new System.Drawing.Point(251, 744);
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
            this.label3.Location = new System.Drawing.Point(34, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(34, 106);
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
            this.label2.Location = new System.Drawing.Point(34, 200);
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
            this.label4.Location = new System.Drawing.Point(34, 295);
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
            this.lbFacultyOrProgram.Location = new System.Drawing.Point(34, 387);
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
            // lbYearOrLevel
            // 
            this.lbYearOrLevel.AutoSize = true;
            this.lbYearOrLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lbYearOrLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYearOrLevel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbYearOrLevel.Location = new System.Drawing.Point(34, 499);
            this.lbYearOrLevel.Name = "lbYearOrLevel";
            this.lbYearOrLevel.Size = new System.Drawing.Size(151, 25);
            this.lbYearOrLevel.TabIndex = 31;
            this.lbYearOrLevel.Text = "Năm nhập học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(249, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.txtName);
            this.panelContainer.Controls.Add(this.txtSurname);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.cmbYearOrLevel);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.lbYearOrLevel);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.txtCCCD);
            this.panelContainer.Controls.Add(this.dtpBirthday);
            this.panelContainer.Controls.Add(this.cmbList);
            this.panelContainer.Controls.Add(this.rbMen);
            this.panelContainer.Controls.Add(this.lbFacultyOrProgram);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.rbWomen);
            this.panelContainer.Location = new System.Drawing.Point(10, 110);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(480, 600);
            this.panelContainer.TabIndex = 35;
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
            this.txtName.Location = new System.Drawing.Point(254, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtName.PlaceholderText = "Tên";
            this.txtName.Size = new System.Drawing.Size(180, 40);
            this.txtName.TabIndex = 34;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtSurname.BorderColor = System.Drawing.Color.Lavender;
            this.txtSurname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSurname.BorderRadius = 5;
            this.txtSurname.BorderSize = 1;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Lavender;
            this.txtSurname.Location = new System.Drawing.Point(33, 49);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Padding = new System.Windows.Forms.Padding(7);
            this.txtSurname.PasswordChar = false;
            this.txtSurname.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtSurname.PlaceholderText = "Họ";
            this.txtSurname.Size = new System.Drawing.Size(180, 40);
            this.txtSurname.TabIndex = 17;
            this.txtSurname.Texts = "";
            this.txtSurname.UnderlinedStyle = false;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
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
            this.cmbYearOrLevel.Location = new System.Drawing.Point(33, 546);
            this.cmbYearOrLevel.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbYearOrLevel.Name = "cmbYearOrLevel";
            this.cmbYearOrLevel.Padding = new System.Windows.Forms.Padding(1);
            this.cmbYearOrLevel.Size = new System.Drawing.Size(400, 40);
            this.cmbYearOrLevel.TabIndex = 32;
            this.cmbYearOrLevel.Texts = "";
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
            this.txtCCCD.Location = new System.Drawing.Point(33, 145);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.MaxLength = 12;
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
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpBirthday.BorderSize = 0;
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(33, 238);
            this.dtpBirthday.MaxDate = new System.DateTime(2074, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(400, 35);
            this.dtpBirthday.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dtpBirthday.TabIndex = 23;
            this.dtpBirthday.TextColor = System.Drawing.Color.Lavender;
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
            this.cmbList.Location = new System.Drawing.Point(33, 429);
            this.cmbList.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbList.Name = "cmbList";
            this.cmbList.Padding = new System.Windows.Forms.Padding(1);
            this.cmbList.Size = new System.Drawing.Size(400, 40);
            this.cmbList.TabIndex = 28;
            this.cmbList.Texts = "";
            this.cmbList.OnSelectedIndexChanged += new System.EventHandler(this.cmbList_OnSelectedIndexChanged);
            // 
            // rbMen
            // 
            this.rbMen.AutoSize = true;
            this.rbMen.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMen.ForeColor = System.Drawing.Color.Silver;
            this.rbMen.Location = new System.Drawing.Point(39, 337);
            this.rbMen.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbMen.Name = "rbMen";
            this.rbMen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbMen.Size = new System.Drawing.Size(75, 24);
            this.rbMen.TabIndex = 24;
            this.rbMen.TabStop = true;
            this.rbMen.Text = "Nam";
            this.rbMen.UnCheckedColor = System.Drawing.Color.Lavender;
            this.rbMen.UseVisualStyleBackColor = true;
            // 
            // rbWomen
            // 
            this.rbWomen.AutoSize = true;
            this.rbWomen.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWomen.ForeColor = System.Drawing.Color.Silver;
            this.rbWomen.Location = new System.Drawing.Point(144, 337);
            this.rbWomen.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbWomen.Name = "rbWomen";
            this.rbWomen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbWomen.Size = new System.Drawing.Size(61, 24);
            this.rbWomen.TabIndex = 26;
            this.rbWomen.TabStop = true;
            this.rbWomen.Text = "Nữ";
            this.rbWomen.UnCheckedColor = System.Drawing.Color.Lavender;
            this.rbWomen.UseVisualStyleBackColor = true;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.txtIDAcc);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Location = new System.Drawing.Point(10, 35);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(480, 74);
            this.panelEdit.TabIndex = 36;
            this.panelEdit.Visible = false;
            // 
            // txtIDAcc
            // 
            this.txtIDAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtIDAcc.BorderColor = System.Drawing.Color.Lavender;
            this.txtIDAcc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIDAcc.BorderRadius = 5;
            this.txtIDAcc.BorderSize = 1;
            this.txtIDAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAcc.ForeColor = System.Drawing.Color.Lavender;
            this.txtIDAcc.Location = new System.Drawing.Point(33, 29);
            this.txtIDAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDAcc.MaxLength = 12;
            this.txtIDAcc.Multiline = false;
            this.txtIDAcc.Name = "txtIDAcc";
            this.txtIDAcc.Padding = new System.Windows.Forms.Padding(7);
            this.txtIDAcc.PasswordChar = false;
            this.txtIDAcc.PlaceholderColor = System.Drawing.Color.Lavender;
            this.txtIDAcc.PlaceholderText = "ID";
            this.txtIDAcc.Size = new System.Drawing.Size(400, 40);
            this.txtIDAcc.TabIndex = 30;
            this.txtIDAcc.Texts = "";
            this.txtIDAcc.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(34, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.Hủy);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddAccount";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmAddAccStudent_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Hủy;
        private System.Windows.Forms.Button btnADD;
        private MyCustomControl.CustomTextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCustomControl.CustomDatetimePicker dtpBirthday;
        private MyCustomControl.CustomRadioButton rbMen;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomRadioButton rbWomen;
        private System.Windows.Forms.Label lbFacultyOrProgram;
        private MyCustomControl.CustomComboBox cmbList;
        private MyCustomControl.CustomTextBox txtCCCD;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbYearOrLevel;
        private MyCustomControl.CustomComboBox cmbYearOrLevel;
        private System.Windows.Forms.Label label5;
        private MyCustomControl.CustomTextBox txtName;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label6;
        private MyCustomControl.CustomTextBox txtIDAcc;
    }
}