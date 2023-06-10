namespace GUI
{
    partial class frmTaoCauHoiNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoCauHoiNew));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChooseAnswer = new System.Windows.Forms.Panel();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.chbD = new System.Windows.Forms.CheckBox();
            this.chbC = new System.Windows.Forms.CheckBox();
            this.chbB = new System.Windows.Forms.CheckBox();
            this.chbA = new System.Windows.Forms.CheckBox();
            this.cbMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.btnCreateQues = new GUI.MyCustomControl.CustomButton();
            this.panelGradient4 = new GUI.MyCustomControl.PanelGradient();
            this.tbD = new GUI.MyCustomControl.CustomTextBox();
            this.tgMultiAnswer = new GUI.MyCustomControl.CustomToggleButton();
            this.panelGradient3 = new GUI.MyCustomControl.PanelGradient();
            this.tbC = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient2 = new GUI.MyCustomControl.PanelGradient();
            this.tbB = new GUI.MyCustomControl.CustomTextBox();
            this.tbQuestion = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.tbA = new GUI.MyCustomControl.CustomTextBox();
            this.panelCreateByExcel = new System.Windows.Forms.Panel();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorkerLoadFileLocal = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.pnlChooseAnswer.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.panelGradient4.SuspendLayout();
            this.panelGradient3.SuspendLayout();
            this.panelGradient2.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.panelCreateByExcel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Câu hỏi đa đáp án";
            // 
            // pnlChooseAnswer
            // 
            this.pnlChooseAnswer.Controls.Add(this.rbD);
            this.pnlChooseAnswer.Controls.Add(this.rbC);
            this.pnlChooseAnswer.Controls.Add(this.rbB);
            this.pnlChooseAnswer.Controls.Add(this.rbA);
            this.pnlChooseAnswer.Controls.Add(this.chbD);
            this.pnlChooseAnswer.Controls.Add(this.chbC);
            this.pnlChooseAnswer.Controls.Add(this.chbB);
            this.pnlChooseAnswer.Controls.Add(this.chbA);
            this.pnlChooseAnswer.Location = new System.Drawing.Point(16, 343);
            this.pnlChooseAnswer.Name = "pnlChooseAnswer";
            this.pnlChooseAnswer.Size = new System.Drawing.Size(1148, 38);
            this.pnlChooseAnswer.TabIndex = 4;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(1119, 11);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(17, 16);
            this.rbD.TabIndex = 7;
            this.rbD.TabStop = true;
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(825, 12);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(17, 16);
            this.rbC.TabIndex = 6;
            this.rbC.TabStop = true;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(530, 11);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(17, 16);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(237, 12);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(17, 16);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // chbD
            // 
            this.chbD.AutoSize = true;
            this.chbD.Enabled = false;
            this.chbD.Location = new System.Drawing.Point(1119, 11);
            this.chbD.Name = "chbD";
            this.chbD.Size = new System.Drawing.Size(18, 17);
            this.chbD.TabIndex = 3;
            this.chbD.UseVisualStyleBackColor = true;
            // 
            // chbC
            // 
            this.chbC.AutoSize = true;
            this.chbC.Enabled = false;
            this.chbC.Location = new System.Drawing.Point(825, 12);
            this.chbC.Name = "chbC";
            this.chbC.Size = new System.Drawing.Size(18, 17);
            this.chbC.TabIndex = 2;
            this.chbC.UseVisualStyleBackColor = true;
            // 
            // chbB
            // 
            this.chbB.AutoSize = true;
            this.chbB.Enabled = false;
            this.chbB.Location = new System.Drawing.Point(530, 11);
            this.chbB.Name = "chbB";
            this.chbB.Size = new System.Drawing.Size(18, 17);
            this.chbB.TabIndex = 1;
            this.chbB.UseVisualStyleBackColor = true;
            // 
            // chbA
            // 
            this.chbA.AutoSize = true;
            this.chbA.Enabled = false;
            this.chbA.Location = new System.Drawing.Point(237, 12);
            this.chbA.Name = "chbA";
            this.chbA.Size = new System.Drawing.Size(18, 17);
            this.chbA.TabIndex = 0;
            this.chbA.UseVisualStyleBackColor = true;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbMonHoc.BorderRadius = 10;
            this.cbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMonHoc.ItemHeight = 30;
            this.cbMonHoc.Location = new System.Drawing.Point(12, 12);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(490, 36);
            this.cbMonHoc.TabIndex = 6;
            // 
            // cbPhanLoai
            // 
            this.cbPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbPhanLoai.BorderRadius = 10;
            this.cbPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhanLoai.ItemHeight = 30;
            this.cbPhanLoai.Location = new System.Drawing.Point(947, 12);
            this.cbPhanLoai.Name = "cbPhanLoai";
            this.cbPhanLoai.Size = new System.Drawing.Size(218, 36);
            this.cbPhanLoai.TabIndex = 7;
            // 
            // panelCreate
            // 
            this.panelCreate.Controls.Add(this.pnlChooseAnswer);
            this.panelCreate.Controls.Add(this.btnCreateQues);
            this.panelCreate.Controls.Add(this.panelGradient4);
            this.panelCreate.Controls.Add(this.tgMultiAnswer);
            this.panelCreate.Controls.Add(this.panelGradient3);
            this.panelCreate.Controls.Add(this.label1);
            this.panelCreate.Controls.Add(this.panelGradient2);
            this.panelCreate.Controls.Add(this.tbQuestion);
            this.panelCreate.Controls.Add(this.panelGradient1);
            this.panelCreate.Location = new System.Drawing.Point(16, 63);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(1162, 734);
            this.panelCreate.TabIndex = 8;
            // 
            // btnCreateQues
            // 
            this.btnCreateQues.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateQues.BackGroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateQues.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreateQues.BorderRadius = 20;
            this.btnCreateQues.BorderSize = 0;
            this.btnCreateQues.Enabled = false;
            this.btnCreateQues.FlatAppearance.BorderSize = 0;
            this.btnCreateQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQues.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQues.ForeColor = System.Drawing.Color.Black;
            this.btnCreateQues.Image = global::GUI.Properties.Resources.Save1;
            this.btnCreateQues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQues.Location = new System.Drawing.Point(945, 676);
            this.btnCreateQues.Name = "btnCreateQues";
            this.btnCreateQues.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreateQues.Size = new System.Drawing.Size(164, 55);
            this.btnCreateQues.TabIndex = 5;
            this.btnCreateQues.Text = "Tạo";
            this.btnCreateQues.TextColor = System.Drawing.Color.Black;
            this.btnCreateQues.UseVisualStyleBackColor = false;
            this.btnCreateQues.Click += new System.EventHandler(this.btnCreateQues_Click);
            // 
            // panelGradient4
            // 
            this.panelGradient4.BackColor = System.Drawing.Color.White;
            this.panelGradient4.BorderRadius = 30;
            this.panelGradient4.Controls.Add(this.tbD);
            this.panelGradient4.ForeColor = System.Drawing.Color.Black;
            this.panelGradient4.GradientAngle = 90F;
            this.panelGradient4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.panelGradient4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.panelGradient4.Location = new System.Drawing.Point(880, 388);
            this.panelGradient4.Name = "panelGradient4";
            this.panelGradient4.Size = new System.Drawing.Size(273, 283);
            this.panelGradient4.TabIndex = 1;
            // 
            // tbD
            // 
            this.tbD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.tbD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.tbD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbD.BorderRadius = 0;
            this.tbD.BorderSize = 1;
            this.tbD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbD.ForeColor = System.Drawing.Color.DimGray;
            this.tbD.Location = new System.Drawing.Point(4, 41);
            this.tbD.Margin = new System.Windows.Forms.Padding(4);
            this.tbD.MaxLength = 32767;
            this.tbD.Multiline = true;
            this.tbD.Name = "tbD";
            this.tbD.Padding = new System.Windows.Forms.Padding(7);
            this.tbD.PasswordChar = false;
            this.tbD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbD.PlaceholderText = "";
            this.tbD.Size = new System.Drawing.Size(265, 219);
            this.tbD.TabIndex = 3;
            this.tbD.Texts = "Nhập đáp án D";
            this.tbD.UnderlinedStyle = false;
            this.tbD.Enter += new System.EventHandler(this.tbD_Enter);
            this.tbD.Leave += new System.EventHandler(this.tbD_Leave);
            // 
            // tgMultiAnswer
            // 
            this.tgMultiAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.tgMultiAnswer.Location = new System.Drawing.Point(68, 693);
            this.tgMultiAnswer.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgMultiAnswer.Name = "tgMultiAnswer";
            this.tgMultiAnswer.OffBackColor = System.Drawing.Color.Gray;
            this.tgMultiAnswer.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgMultiAnswer.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tgMultiAnswer.OnToggleColor = System.Drawing.Color.Lime;
            this.tgMultiAnswer.Size = new System.Drawing.Size(49, 26);
            this.tgMultiAnswer.TabIndex = 1;
            this.tgMultiAnswer.UseVisualStyleBackColor = false;
            this.tgMultiAnswer.CheckedChanged += new System.EventHandler(this.tgMultiAnswer_CheckedChanged);
            // 
            // panelGradient3
            // 
            this.panelGradient3.BackColor = System.Drawing.Color.White;
            this.panelGradient3.BorderRadius = 30;
            this.panelGradient3.Controls.Add(this.tbC);
            this.panelGradient3.ForeColor = System.Drawing.Color.Black;
            this.panelGradient3.GradientAngle = 90F;
            this.panelGradient3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panelGradient3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panelGradient3.Location = new System.Drawing.Point(586, 388);
            this.panelGradient3.Name = "panelGradient3";
            this.panelGradient3.Size = new System.Drawing.Size(273, 283);
            this.panelGradient3.TabIndex = 1;
            // 
            // tbC
            // 
            this.tbC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.tbC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.tbC.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbC.BorderRadius = 0;
            this.tbC.BorderSize = 1;
            this.tbC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC.ForeColor = System.Drawing.Color.DimGray;
            this.tbC.Location = new System.Drawing.Point(8, 17);
            this.tbC.Margin = new System.Windows.Forms.Padding(4);
            this.tbC.MaxLength = 32767;
            this.tbC.Multiline = true;
            this.tbC.Name = "tbC";
            this.tbC.Padding = new System.Windows.Forms.Padding(7);
            this.tbC.PasswordChar = false;
            this.tbC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbC.PlaceholderText = "";
            this.tbC.Size = new System.Drawing.Size(265, 219);
            this.tbC.TabIndex = 2;
            this.tbC.Texts = "Nhập đáp án C";
            this.tbC.UnderlinedStyle = false;
            this.tbC.Enter += new System.EventHandler(this.tbC_Enter);
            this.tbC.Leave += new System.EventHandler(this.tbC_Leave);
            // 
            // panelGradient2
            // 
            this.panelGradient2.BackColor = System.Drawing.Color.White;
            this.panelGradient2.BorderRadius = 30;
            this.panelGradient2.Controls.Add(this.tbB);
            this.panelGradient2.ForeColor = System.Drawing.Color.Black;
            this.panelGradient2.GradientAngle = 90F;
            this.panelGradient2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.panelGradient2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.panelGradient2.Location = new System.Drawing.Point(295, 387);
            this.panelGradient2.Name = "panelGradient2";
            this.panelGradient2.Size = new System.Drawing.Size(273, 283);
            this.panelGradient2.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.tbB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.tbB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbB.BorderRadius = 0;
            this.tbB.BorderSize = 1;
            this.tbB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.ForeColor = System.Drawing.Color.DimGray;
            this.tbB.Location = new System.Drawing.Point(4, 41);
            this.tbB.Margin = new System.Windows.Forms.Padding(4);
            this.tbB.MaxLength = 32767;
            this.tbB.Multiline = true;
            this.tbB.Name = "tbB";
            this.tbB.Padding = new System.Windows.Forms.Padding(7);
            this.tbB.PasswordChar = false;
            this.tbB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbB.PlaceholderText = "";
            this.tbB.Size = new System.Drawing.Size(265, 219);
            this.tbB.TabIndex = 1;
            this.tbB.Texts = "Nhập đáp án B";
            this.tbB.UnderlinedStyle = false;
            this.tbB.Enter += new System.EventHandler(this.tbB_Enter);
            this.tbB.Leave += new System.EventHandler(this.tbB_Leave);
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(188)))), ((int)(((byte)(150)))));
            this.tbQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbQuestion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbQuestion.BorderRadius = 20;
            this.tbQuestion.BorderSize = 3;
            this.tbQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.tbQuestion.Location = new System.Drawing.Point(7, 26);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuestion.MaxLength = 32767;
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Padding = new System.Windows.Forms.Padding(7);
            this.tbQuestion.PasswordChar = false;
            this.tbQuestion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbQuestion.PlaceholderText = "";
            this.tbQuestion.Size = new System.Drawing.Size(1156, 289);
            this.tbQuestion.TabIndex = 2;
            this.tbQuestion.Texts = "Nhập câu hỏi";
            this.tbQuestion.UnderlinedStyle = false;
            this.tbQuestion.Enter += new System.EventHandler(this.tbQuestion_Enter);
            this.tbQuestion.Leave += new System.EventHandler(this.tbQuestion_Leave);
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.tbA);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.panelGradient1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.panelGradient1.Location = new System.Drawing.Point(16, 387);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(273, 283);
            this.panelGradient1.TabIndex = 0;
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.tbA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.tbA.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbA.BorderRadius = 0;
            this.tbA.BorderSize = 1;
            this.tbA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.ForeColor = System.Drawing.Color.DimGray;
            this.tbA.Location = new System.Drawing.Point(4, 41);
            this.tbA.Margin = new System.Windows.Forms.Padding(4);
            this.tbA.MaxLength = 32767;
            this.tbA.Multiline = true;
            this.tbA.Name = "tbA";
            this.tbA.Padding = new System.Windows.Forms.Padding(7);
            this.tbA.PasswordChar = false;
            this.tbA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbA.PlaceholderText = "";
            this.tbA.Size = new System.Drawing.Size(265, 219);
            this.tbA.TabIndex = 0;
            this.tbA.Texts = "Nhập đáp án A";
            this.tbA.UnderlinedStyle = false;
            this.tbA.Enter += new System.EventHandler(this.tbA_Enter);
            this.tbA.Leave += new System.EventHandler(this.tbA_Leave);
            // 
            // panelCreateByExcel
            // 
            this.panelCreateByExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.panelCreateByExcel.Controls.Add(this.btnCancel);
            this.panelCreateByExcel.Controls.Add(this.btnAdd);
            this.panelCreateByExcel.Controls.Add(this.guna2Panel1);
            this.panelCreateByExcel.Controls.Add(this.pnlProgressBar);
            this.panelCreateByExcel.Controls.Add(this.dataGridView1);
            this.panelCreateByExcel.Location = new System.Drawing.Point(15, 60);
            this.panelCreateByExcel.Name = "panelCreateByExcel";
            this.panelCreateByExcel.Size = new System.Drawing.Size(550, 650);
            this.panelCreateByExcel.TabIndex = 9;
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
            this.btnCancel.Location = new System.Drawing.Point(55, 587);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(355, 587);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnUploadFile);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(55, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(450, 200);
            this.guna2Panel1.TabIndex = 12;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnUploadFile.Image = global::GUI.Properties.Resources.Save;
            this.btnUploadFile.Location = new System.Drawing.Point(192, 17);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(77, 82);
            this.btnUploadFile.TabIndex = 38;
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(177, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "XLSX or XLS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(147, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Chọn tệp để tải lên";
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.White;
            this.pnlProgressBar.Controls.Add(this.lblProgress);
            this.pnlProgressBar.Controls.Add(this.progressBar1);
            this.pnlProgressBar.Location = new System.Drawing.Point(71, 355);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(412, 104);
            this.pnlProgressBar.TabIndex = 42;
            this.pnlProgressBar.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(192, 36);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(26, 16);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dataGridView1.Location = new System.Drawing.Point(55, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 300);
            this.dataGridView1.TabIndex = 43;
            // 
            // backgroundWorkerLoadFileLocal
            // 
            this.backgroundWorkerLoadFileLocal.WorkerReportsProgress = true;
            this.backgroundWorkerLoadFileLocal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadFileLocal_DoWork);
            this.backgroundWorkerLoadFileLocal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLoadFileLocal_ProgressChanged);
            this.backgroundWorkerLoadFileLocal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadFileLocal_RunWorkerCompleted);
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.WorkerReportsProgress = true;
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLoadData_ProgressChanged);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // frmTaoCauHoiNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(188)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.panelCreateByExcel);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.cbPhanLoai);
            this.Controls.Add(this.cbMonHoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 850);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmTaoCauHoiNew";
            this.Text = "frmTaoCauHoiNew";
            this.Load += new System.EventHandler(this.frmTaoCauHoiNew_Load);
            this.pnlChooseAnswer.ResumeLayout(false);
            this.pnlChooseAnswer.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelGradient4.ResumeLayout(false);
            this.panelGradient3.ResumeLayout(false);
            this.panelGradient2.ResumeLayout(false);
            this.panelGradient1.ResumeLayout(false);
            this.panelCreateByExcel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlProgressBar.ResumeLayout(false);
            this.pnlProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.PanelGradient panelGradient1;
        private MyCustomControl.PanelGradient panelGradient2;
        private MyCustomControl.PanelGradient panelGradient3;
        private MyCustomControl.PanelGradient panelGradient4;
        private MyCustomControl.CustomTextBox tbQuestion;
        private MyCustomControl.CustomTextBox tbA;
        private MyCustomControl.CustomTextBox tbB;
        private MyCustomControl.CustomTextBox tbC;
        private MyCustomControl.CustomTextBox tbD;
        private MyCustomControl.CustomToggleButton tgMultiAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChooseAnswer;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.CheckBox chbD;
        private System.Windows.Forms.CheckBox chbC;
        private System.Windows.Forms.CheckBox chbB;
        private System.Windows.Forms.CheckBox chbA;
        private MyCustomControl.CustomButton btnCreateQues;
        private Guna.UI2.WinForms.Guna2ComboBox cbMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhanLoai;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Panel panelCreateByExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadFileLocal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.CustomButton btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
    }
}