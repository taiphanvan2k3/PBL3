namespace GUI
{
    partial class frmTaoCauHoi
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
            this.checkBoxSingleMulti = new System.Windows.Forms.CheckBox();
            this.panelDanhSachDapAn = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxSingleChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.textBoxCauHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMultiChoices = new System.Windows.Forms.GroupBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.btnExit = new GUI.MyCustomControl.CustomButton();
            this.btnSave = new GUI.MyCustomControl.CustomButton();
            this.groupBoxSingleChoice.SuspendLayout();
            this.groupBoxMultiChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSingleMulti
            // 
            this.checkBoxSingleMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSingleMulti.AutoSize = true;
            this.checkBoxSingleMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSingleMulti.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxSingleMulti.Location = new System.Drawing.Point(688, 137);
            this.checkBoxSingleMulti.Name = "checkBoxSingleMulti";
            this.checkBoxSingleMulti.Size = new System.Drawing.Size(197, 24);
            this.checkBoxSingleMulti.TabIndex = 2;
            this.checkBoxSingleMulti.Text = "Câu hỏi nhiều đáp án?";
            this.checkBoxSingleMulti.UseVisualStyleBackColor = true;
            this.checkBoxSingleMulti.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelDanhSachDapAn
            // 
            this.panelDanhSachDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDanhSachDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDanhSachDapAn.Location = new System.Drawing.Point(25, 116);
            this.panelDanhSachDapAn.Name = "panelDanhSachDapAn";
            this.panelDanhSachDapAn.Size = new System.Drawing.Size(609, 564);
            this.panelDanhSachDapAn.TabIndex = 2;
            this.panelDanhSachDapAn.Resize += new System.EventHandler(this.panelDanhSachDapAn_Resize);
            // 
            // groupBoxSingleChoice
            // 
            this.groupBoxSingleChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSingleChoice.Controls.Add(this.radioButtonD);
            this.groupBoxSingleChoice.Controls.Add(this.radioButtonC);
            this.groupBoxSingleChoice.Controls.Add(this.radioButtonB);
            this.groupBoxSingleChoice.Controls.Add(this.radioButtonA);
            this.groupBoxSingleChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSingleChoice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSingleChoice.Location = new System.Drawing.Point(688, 177);
            this.groupBoxSingleChoice.Name = "groupBoxSingleChoice";
            this.groupBoxSingleChoice.Size = new System.Drawing.Size(179, 197);
            this.groupBoxSingleChoice.TabIndex = 3;
            this.groupBoxSingleChoice.TabStop = false;
            this.groupBoxSingleChoice.Text = "Đáp án đúng";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonD.Location = new System.Drawing.Point(6, 157);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(101, 24);
            this.radioButtonD.TabIndex = 3;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Đáp án D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonC.Location = new System.Drawing.Point(6, 117);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(100, 24);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Đáp án C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonB.Location = new System.Drawing.Point(6, 77);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(100, 24);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Đáp án B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonA.Location = new System.Drawing.Point(6, 38);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(99, 24);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "Đáp án A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // textBoxCauHoi
            // 
            this.textBoxCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.textBoxCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCauHoi.ForeColor = System.Drawing.Color.White;
            this.textBoxCauHoi.Location = new System.Drawing.Point(118, 18);
            this.textBoxCauHoi.Multiline = true;
            this.textBoxCauHoi.Name = "textBoxCauHoi";
            this.textBoxCauHoi.Size = new System.Drawing.Size(470, 82);
            this.textBoxCauHoi.TabIndex = 0;
            this.textBoxCauHoi.TextChanged += new System.EventHandler(this.textBoxCauHoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Câu hỏi";
            // 
            // groupBoxMultiChoices
            // 
            this.groupBoxMultiChoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMultiChoices.Controls.Add(this.checkBoxD);
            this.groupBoxMultiChoices.Controls.Add(this.checkBoxC);
            this.groupBoxMultiChoices.Controls.Add(this.checkBoxB);
            this.groupBoxMultiChoices.Controls.Add(this.checkBoxA);
            this.groupBoxMultiChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMultiChoices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxMultiChoices.Location = new System.Drawing.Point(688, 483);
            this.groupBoxMultiChoices.Name = "groupBoxMultiChoices";
            this.groupBoxMultiChoices.Size = new System.Drawing.Size(179, 197);
            this.groupBoxMultiChoices.TabIndex = 7;
            this.groupBoxMultiChoices.TabStop = false;
            this.groupBoxMultiChoices.Text = "Đáp án đúng";
            this.groupBoxMultiChoices.Visible = false;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(6, 157);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(102, 24);
            this.checkBoxD.TabIndex = 7;
            this.checkBoxD.Text = "Đáp án D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(6, 117);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(101, 24);
            this.checkBoxC.TabIndex = 6;
            this.checkBoxC.Text = "Đáp án C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(6, 77);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(101, 24);
            this.checkBoxB.TabIndex = 5;
            this.checkBoxB.Text = "Đáp án B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(6, 38);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(100, 24);
            this.checkBoxA.TabIndex = 4;
            this.checkBoxA.Text = "Đáp án A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // labelCheck
            // 
            this.labelCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheck.Location = new System.Drawing.Point(603, 49);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(16, 20);
            this.labelCheck.TabIndex = 8;
            this.labelCheck.Text = "*";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(38)))));
            this.btnExit.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(38)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 40;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(784, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(38)))));
            this.btnSave.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(38)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 40;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(678, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // frmTaoCauHoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(897, 719);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.groupBoxMultiChoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCauHoi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxSingleChoice);
            this.Controls.Add(this.panelDanhSachDapAn);
            this.Controls.Add(this.checkBoxSingleMulti);
            this.Name = "frmTaoCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo câu hỏi";
            this.Load += new System.EventHandler(this.FormTaoCauHoi_Load);
            this.groupBoxSingleChoice.ResumeLayout(false);
            this.groupBoxSingleChoice.PerformLayout();
            this.groupBoxMultiChoices.ResumeLayout(false);
            this.groupBoxMultiChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSingleMulti;
        private System.Windows.Forms.FlowLayoutPanel panelDanhSachDapAn;
        private System.Windows.Forms.GroupBox groupBoxSingleChoice;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private MyCustomControl.CustomButton btnSave;
        private System.Windows.Forms.TextBox textBoxCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMultiChoices;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Label labelCheck;
        private MyCustomControl.CustomButton btnExit;
    }
}