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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFacultyOrProgram = new System.Windows.Forms.Label();
            this.lbYearOrLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbYearOrLevel = new GUI.MyCustomControl.CustomComboBox();
            this.dtpBirthday = new GUI.MyCustomControl.CustomDatetimePicker();
            this.cmbList = new GUI.MyCustomControl.CustomComboBox();
            this.rbMen = new GUI.MyCustomControl.CustomRadioButton();
            this.rbWomen = new GUI.MyCustomControl.CustomRadioButton();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.txtIDAcc = new GUI.MyCustomControl.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.panelContainer.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
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
            this.panelContainer.Controls.Add(this.txtCCCD);
            this.panelContainer.Controls.Add(this.txtSurname);
            this.panelContainer.Controls.Add(this.txtName);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.cmbYearOrLevel);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.lbYearOrLevel);
            this.panelContainer.Controls.Add(this.label2);
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
            // txtCCCD
            // 
            this.txtCCCD.BorderColor = System.Drawing.Color.Lavender;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.Lavender;
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(33, 155);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(5);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderForeColor = System.Drawing.Color.Lavender;
            this.txtCCCD.PlaceholderText = "Căn cước công dân";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(400, 40);
            this.txtCCCD.TabIndex = 36;
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderColor = System.Drawing.Color.Lavender;
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.DefaultText = "";
            this.txtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Lavender;
            this.txtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname.Location = new System.Drawing.Point(34, 43);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurname.MaxLength = 12;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PlaceholderForeColor = System.Drawing.Color.Lavender;
            this.txtSurname.PlaceholderText = "Họ";
            this.txtSurname.SelectedText = "";
            this.txtSurname.Size = new System.Drawing.Size(180, 40);
            this.txtSurname.TabIndex = 35;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.Lavender;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Lavender;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(254, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Lavender;
            this.txtName.PlaceholderText = "Tên";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(180, 40);
            this.txtName.TabIndex = 34;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
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
            this.cmbYearOrLevel.TabIndex = 9;
            this.cmbYearOrLevel.Texts = "";
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
            this.dtpBirthday.TabIndex = 5;
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
            this.cmbList.TabIndex = 8;
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
            this.rbMen.TabIndex = 6;
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
            this.rbWomen.TabIndex = 7;
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
            this.txtIDAcc.TabIndex = 1;
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(293, 729);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(43, 729);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmAddAccStudent_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCustomControl.CustomDatetimePicker dtpBirthday;
        private MyCustomControl.CustomRadioButton rbMen;
        private System.Windows.Forms.Label label4;
        private MyCustomControl.CustomRadioButton rbWomen;
        private System.Windows.Forms.Label lbFacultyOrProgram;
        private MyCustomControl.CustomComboBox cmbList;
        private System.Windows.Forms.Label lbYearOrLevel;
        private MyCustomControl.CustomComboBox cmbYearOrLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label6;
        private MyCustomControl.CustomTextBox txtIDAcc;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomButton btnCancel;
    }
}