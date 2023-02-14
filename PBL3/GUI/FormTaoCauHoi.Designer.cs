namespace PBL3.GUI
{
    partial class FormTaoCauHoi
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
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxCauHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMultiChoices = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.customButton2 = new PBL3.MyCustomControl.CustomButton();
            this.customButton1 = new PBL3.MyCustomControl.CustomButton();
            this.customButton3 = new PBL3.MyCustomControl.CustomButton();
            this.groupBoxSingleChoice.SuspendLayout();
            this.groupBoxMultiChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSingleMulti
            // 
            this.checkBoxSingleMulti.AutoSize = true;
            this.checkBoxSingleMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelDanhSachDapAn.AutoScroll = true;
            this.panelDanhSachDapAn.BackColor = System.Drawing.Color.Lavender;
            this.panelDanhSachDapAn.Location = new System.Drawing.Point(25, 116);
            this.panelDanhSachDapAn.Name = "panelDanhSachDapAn";
            this.panelDanhSachDapAn.Size = new System.Drawing.Size(624, 577);
            this.panelDanhSachDapAn.TabIndex = 2;
            // 
            // groupBoxSingleChoice
            // 
            this.groupBoxSingleChoice.Controls.Add(this.radioButton4);
            this.groupBoxSingleChoice.Controls.Add(this.radioButton3);
            this.groupBoxSingleChoice.Controls.Add(this.radioButton2);
            this.groupBoxSingleChoice.Controls.Add(this.radioButton1);
            this.groupBoxSingleChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSingleChoice.Location = new System.Drawing.Point(688, 177);
            this.groupBoxSingleChoice.Name = "groupBoxSingleChoice";
            this.groupBoxSingleChoice.Size = new System.Drawing.Size(179, 197);
            this.groupBoxSingleChoice.TabIndex = 3;
            this.groupBoxSingleChoice.TabStop = false;
            this.groupBoxSingleChoice.Text = "Đáp án đúng";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Đáp án D";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(100, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Đáp án C";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Đáp án B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Đáp án A";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.selectChoiceChanged);
            // 
            // textBoxCauHoi
            // 
            this.textBoxCauHoi.Location = new System.Drawing.Point(120, 18);
            this.textBoxCauHoi.Multiline = true;
            this.textBoxCauHoi.Name = "textBoxCauHoi";
            this.textBoxCauHoi.Size = new System.Drawing.Size(471, 82);
            this.textBoxCauHoi.TabIndex = 0;
            this.textBoxCauHoi.TextChanged += new System.EventHandler(this.textBoxCauHoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Câu hỏi";
            // 
            // groupBoxMultiChoices
            // 
            this.groupBoxMultiChoices.Controls.Add(this.checkBox4);
            this.groupBoxMultiChoices.Controls.Add(this.checkBox3);
            this.groupBoxMultiChoices.Controls.Add(this.checkBox2);
            this.groupBoxMultiChoices.Controls.Add(this.checkBox1);
            this.groupBoxMultiChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMultiChoices.Location = new System.Drawing.Point(688, 483);
            this.groupBoxMultiChoices.Name = "groupBoxMultiChoices";
            this.groupBoxMultiChoices.Size = new System.Drawing.Size(179, 197);
            this.groupBoxMultiChoices.TabIndex = 7;
            this.groupBoxMultiChoices.TabStop = false;
            this.groupBoxMultiChoices.Text = "Đáp án đúng";
            this.groupBoxMultiChoices.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 24);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Đáp án D";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Đáp án C";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Đáp án B";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Đáp án A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheck.Location = new System.Drawing.Point(603, 49);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(16, 20);
            this.labelCheck.TabIndex = 8;
            this.labelCheck.Text = "*";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton2.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 40;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.Location = new System.Drawing.Point(784, 437);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(88, 40);
            this.customButton2.TabIndex = 9;
            this.customButton2.Text = "Thoát";
            this.customButton2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton1.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.Location = new System.Drawing.Point(678, 437);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(97, 40);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "Lưu";
            this.customButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton3.BackGroundColor = System.Drawing.Color.SteelBlue;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 40;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton3.Location = new System.Drawing.Point(699, 49);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(97, 40);
            this.customButton3.TabIndex = 10;
            this.customButton3.Text = "Test";
            this.customButton3.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // FormTaoCauHoi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(897, 719);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.groupBoxMultiChoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCauHoi);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.groupBoxSingleChoice);
            this.Controls.Add(this.panelDanhSachDapAn);
            this.Controls.Add(this.checkBoxSingleMulti);
            this.Name = "FormTaoCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private MyCustomControl.CustomButton customButton1;
        private System.Windows.Forms.TextBox textBoxCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMultiChoices;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelCheck;
        private MyCustomControl.CustomButton customButton2;
        private MyCustomControl.CustomButton customButton3;
    }
}