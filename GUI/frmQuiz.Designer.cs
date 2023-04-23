namespace GUI
{
    partial class frmQuiz
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
            this.components = new System.ComponentModel.Container();
            this.gbSoCauDaLam = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbSoCauDaLam = new System.Windows.Forms.Label();
            this.gbTime = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.rbDapAnA = new GUI.MyCustomControl.CustomRadioButton();
            this.rbDapAnB = new GUI.MyCustomControl.CustomRadioButton();
            this.rbDapAnC = new GUI.MyCustomControl.CustomRadioButton();
            this.rbDapAnD = new GUI.MyCustomControl.CustomRadioButton();
            this.btnNopBai = new GUI.MyCustomControl.CustomButton();
            this.btnPre = new GUI.MyCustomControl.CustomButton();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.gbSoCauDaLam.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSoCauDaLam
            // 
            this.gbSoCauDaLam.BorderRadius = 20;
            this.gbSoCauDaLam.Controls.Add(this.lbSoCauDaLam);
            this.gbSoCauDaLam.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.gbSoCauDaLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSoCauDaLam.ForeColor = System.Drawing.Color.White;
            this.gbSoCauDaLam.Location = new System.Drawing.Point(1164, 273);
            this.gbSoCauDaLam.Name = "gbSoCauDaLam";
            this.gbSoCauDaLam.Size = new System.Drawing.Size(208, 127);
            this.gbSoCauDaLam.TabIndex = 3;
            this.gbSoCauDaLam.Text = "Số câu đã làm";
            this.gbSoCauDaLam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSoCauDaLam
            // 
            this.lbSoCauDaLam.AutoSize = true;
            this.lbSoCauDaLam.BackColor = System.Drawing.Color.Transparent;
            this.lbSoCauDaLam.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoCauDaLam.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbSoCauDaLam.Location = new System.Drawing.Point(88, 53);
            this.lbSoCauDaLam.Name = "lbSoCauDaLam";
            this.lbSoCauDaLam.Size = new System.Drawing.Size(39, 45);
            this.lbSoCauDaLam.TabIndex = 4;
            this.lbSoCauDaLam.Text = "0";
            // 
            // gbTime
            // 
            this.gbTime.BorderRadius = 20;
            this.gbTime.Controls.Add(this.lbTime);
            this.gbTime.CustomBorderColor = System.Drawing.Color.CornflowerBlue;
            this.gbTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.ForeColor = System.Drawing.Color.White;
            this.gbTime.Location = new System.Drawing.Point(1164, 111);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(208, 127);
            this.gbTime.TabIndex = 5;
            this.gbTime.Text = "Thời gian ";
            this.gbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTime.Location = new System.Drawing.Point(42, 55);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(152, 45);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCauHoi);
            this.panel1.Controls.Add(this.rbDapAnA);
            this.panel1.Controls.Add(this.rbDapAnB);
            this.panel1.Controls.Add(this.rbDapAnC);
            this.panel1.Controls.Add(this.rbDapAnD);
            this.panel1.Location = new System.Drawing.Point(2, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 579);
            this.panel1.TabIndex = 13;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lbCauHoi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCauHoi.ForeColor = System.Drawing.Color.Black;
            this.lbCauHoi.Location = new System.Drawing.Point(39, 16);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(258, 38);
            this.lbCauHoi.TabIndex = 5;
            this.lbCauHoi.Text = "1.Choose question?";
            // 
            // rbDapAnA
            // 
            this.rbDapAnA.AutoSize = true;
            this.rbDapAnA.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbDapAnA.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDapAnA.Location = new System.Drawing.Point(45, 144);
            this.rbDapAnA.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbDapAnA.Name = "rbDapAnA";
            this.rbDapAnA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbDapAnA.Size = new System.Drawing.Size(58, 34);
            this.rbDapAnA.TabIndex = 7;
            this.rbDapAnA.TabStop = true;
            this.rbDapAnA.Text = "A";
            this.rbDapAnA.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbDapAnA.UseVisualStyleBackColor = true;
            // 
            // rbDapAnB
            // 
            this.rbDapAnB.AutoSize = true;
            this.rbDapAnB.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbDapAnB.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDapAnB.Location = new System.Drawing.Point(46, 254);
            this.rbDapAnB.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbDapAnB.Name = "rbDapAnB";
            this.rbDapAnB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbDapAnB.Size = new System.Drawing.Size(57, 34);
            this.rbDapAnB.TabIndex = 8;
            this.rbDapAnB.TabStop = true;
            this.rbDapAnB.Text = "B";
            this.rbDapAnB.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbDapAnB.UseVisualStyleBackColor = true;
            // 
            // rbDapAnC
            // 
            this.rbDapAnC.AutoSize = true;
            this.rbDapAnC.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbDapAnC.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDapAnC.Location = new System.Drawing.Point(47, 364);
            this.rbDapAnC.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbDapAnC.Name = "rbDapAnC";
            this.rbDapAnC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbDapAnC.Size = new System.Drawing.Size(58, 34);
            this.rbDapAnC.TabIndex = 9;
            this.rbDapAnC.TabStop = true;
            this.rbDapAnC.Text = "C";
            this.rbDapAnC.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbDapAnC.UseVisualStyleBackColor = true;
            // 
            // rbDapAnD
            // 
            this.rbDapAnD.AutoSize = true;
            this.rbDapAnD.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbDapAnD.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDapAnD.Location = new System.Drawing.Point(47, 474);
            this.rbDapAnD.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbDapAnD.Name = "rbDapAnD";
            this.rbDapAnD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbDapAnD.Size = new System.Drawing.Size(59, 34);
            this.rbDapAnD.TabIndex = 10;
            this.rbDapAnD.TabStop = true;
            this.rbDapAnD.Text = "D";
            this.rbDapAnD.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbDapAnD.UseVisualStyleBackColor = true;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.Red;
            this.btnNopBai.BackGroundColor = System.Drawing.Color.Red;
            this.btnNopBai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNopBai.BorderRadius = 20;
            this.btnNopBai.BorderSize = 0;
            this.btnNopBai.FlatAppearance.BorderSize = 0;
            this.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNopBai.Location = new System.Drawing.Point(1722, 995);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(150, 56);
            this.btnNopBai.TabIndex = 12;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPre.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPre.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPre.BorderRadius = 20;
            this.btnPre.BorderSize = 0;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPre.Location = new System.Drawing.Point(200, 712);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(302, 56);
            this.btnPre.TabIndex = 11;
            this.btnPre.Text = "Trước đó";
            this.btnPre.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPre.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnNext.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(830, 712);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(302, 56);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // frmQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1453, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbSoCauDaLam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuiz";
            this.RightToLeftLayout = true;
            this.Text = "Quiz";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.gbSoCauDaLam.ResumeLayout(false);
            this.gbSoCauDaLam.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbSoCauDaLam;
        private System.Windows.Forms.Label lbSoCauDaLam;
        private Guna.UI2.WinForms.Guna2GroupBox gbTime;
        private System.Windows.Forms.Label lbTime;
        private MyCustomControl.CustomButton btnNext;
        private MyCustomControl.CustomRadioButton rbDapAnA;
        private MyCustomControl.CustomRadioButton rbDapAnB;
        private MyCustomControl.CustomRadioButton rbDapAnC;
        private MyCustomControl.CustomRadioButton rbDapAnD;
        private MyCustomControl.CustomButton btnPre;
        private System.Windows.Forms.Timer timer1;
        private MyCustomControl.CustomButton btnNopBai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCauHoi;
    }
}