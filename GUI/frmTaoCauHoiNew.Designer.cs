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
            this.tgMultiAnswer = new GUI.MyCustomControl.CustomToggleButton();
            this.tbQuestion = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient4 = new GUI.MyCustomControl.PanelGradient();
            this.tbD = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient3 = new GUI.MyCustomControl.PanelGradient();
            this.tbC = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient2 = new GUI.MyCustomControl.PanelGradient();
            this.tbB = new GUI.MyCustomControl.CustomTextBox();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.tbA = new GUI.MyCustomControl.CustomTextBox();
            this.cbMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCreateQues = new GUI.MyCustomControl.CustomButton();
            this.pnlChooseAnswer.SuspendLayout();
            this.panelGradient4.SuspendLayout();
            this.panelGradient3.SuspendLayout();
            this.panelGradient2.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 736);
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
            this.pnlChooseAnswer.Location = new System.Drawing.Point(16, 372);
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
            // tgMultiAnswer
            // 
            this.tgMultiAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.tgMultiAnswer.Location = new System.Drawing.Point(16, 735);
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
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(188)))), ((int)(((byte)(150)))));
            this.tbQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbQuestion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbQuestion.BorderRadius = 20;
            this.tbQuestion.BorderSize = 3;
            this.tbQuestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.tbQuestion.Location = new System.Drawing.Point(12, 76);
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
            // panelGradient4
            // 
            this.panelGradient4.BackColor = System.Drawing.Color.White;
            this.panelGradient4.BorderRadius = 30;
            this.panelGradient4.Controls.Add(this.tbD);
            this.panelGradient4.ForeColor = System.Drawing.Color.Black;
            this.panelGradient4.GradientAngle = 90F;
            this.panelGradient4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.panelGradient4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(84)))), ((int)(((byte)(109)))));
            this.panelGradient4.Location = new System.Drawing.Point(896, 412);
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
            // panelGradient3
            // 
            this.panelGradient3.BackColor = System.Drawing.Color.White;
            this.panelGradient3.BorderRadius = 30;
            this.panelGradient3.Controls.Add(this.tbC);
            this.panelGradient3.ForeColor = System.Drawing.Color.Black;
            this.panelGradient3.GradientAngle = 90F;
            this.panelGradient3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panelGradient3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(167)))), ((int)(((byte)(41)))));
            this.panelGradient3.Location = new System.Drawing.Point(601, 412);
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
            this.tbC.Location = new System.Drawing.Point(4, 41);
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
            this.panelGradient2.Location = new System.Drawing.Point(307, 412);
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
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.tbA);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.panelGradient1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(112)))), ((int)(((byte)(174)))));
            this.panelGradient1.Location = new System.Drawing.Point(12, 412);
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
            this.cbMonHoc.Location = new System.Drawing.Point(16, 21);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(490, 36);
            this.cbMonHoc.TabIndex = 6;
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
            this.btnCreateQues.Location = new System.Drawing.Point(969, 719);
            this.btnCreateQues.Name = "btnCreateQues";
            this.btnCreateQues.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreateQues.Size = new System.Drawing.Size(164, 55);
            this.btnCreateQues.TabIndex = 5;
            this.btnCreateQues.Text = "A";
            this.btnCreateQues.TextColor = System.Drawing.Color.Black;
            this.btnCreateQues.UseVisualStyleBackColor = false;
            this.btnCreateQues.Click += new System.EventHandler(this.btnCreateQues_Click);
            // 
            // frmTaoCauHoiNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(188)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1180, 794);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.btnCreateQues);
            this.Controls.Add(this.pnlChooseAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tgMultiAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.panelGradient4);
            this.Controls.Add(this.panelGradient3);
            this.Controls.Add(this.panelGradient2);
            this.Controls.Add(this.panelGradient1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaoCauHoiNew";
            this.Text = "frmTaoCauHoiNew";
            this.Load += new System.EventHandler(this.frmTaoCauHoiNew_Load);
            this.pnlChooseAnswer.ResumeLayout(false);
            this.pnlChooseAnswer.PerformLayout();
            this.panelGradient4.ResumeLayout(false);
            this.panelGradient3.ResumeLayout(false);
            this.panelGradient2.ResumeLayout(false);
            this.panelGradient1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}