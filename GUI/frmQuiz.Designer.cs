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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTenCauHoi = new System.Windows.Forms.Label();
            this.lblSTTCauHoi = new System.Windows.Forms.Label();
            this.btnNopBai = new GUI.MyCustomControl.CustomButton();
            this.btnPreious = new GUI.MyCustomControl.CustomButton();
            this.panelMulti = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.gbTime = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.panelSingle = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.gbSoCauDaLam = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbSoCauDaLam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelMulti.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.panelSingle.SuspendLayout();
            this.gbSoCauDaLam.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain.Controls.Add(this.lblTenCauHoi);
            this.panelMain.Controls.Add(this.lblSTTCauHoi);
            this.panelMain.Controls.Add(this.btnNopBai);
            this.panelMain.Controls.Add(this.btnPreious);
            this.panelMain.Controls.Add(this.panelMulti);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.gbTime);
            this.panelMain.Controls.Add(this.panelSingle);
            this.panelMain.Controls.Add(this.gbSoCauDaLam);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1477, 762);
            this.panelMain.TabIndex = 0;
            // 
            // lblTenCauHoi
            // 
            this.lblTenCauHoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCauHoi.Location = new System.Drawing.Point(85, 44);
            this.lblTenCauHoi.Name = "lblTenCauHoi";
            this.lblTenCauHoi.Size = new System.Drawing.Size(1108, 49);
            this.lblTenCauHoi.TabIndex = 25;
            this.lblTenCauHoi.Text = "Đề là 1+1=?";
            // 
            // lblSTTCauHoi
            // 
            this.lblSTTCauHoi.AutoSize = true;
            this.lblSTTCauHoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTTCauHoi.Location = new System.Drawing.Point(44, 16);
            this.lblSTTCauHoi.Name = "lblSTTCauHoi";
            this.lblSTTCauHoi.Size = new System.Drawing.Size(78, 28);
            this.lblSTTCauHoi.TabIndex = 24;
            this.lblSTTCauHoi.Text = "Câu hỏi";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNopBai.BackColor = System.Drawing.Color.Red;
            this.btnNopBai.BackGroundColor = System.Drawing.Color.Red;
            this.btnNopBai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNopBai.BorderRadius = 20;
            this.btnNopBai.BorderSize = 0;
            this.btnNopBai.FlatAppearance.BorderSize = 0;
            this.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNopBai.Location = new System.Drawing.Point(1296, 686);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(150, 47);
            this.btnNopBai.TabIndex = 21;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnPreious
            // 
            this.btnPreious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPreious.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnPreious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPreious.BorderRadius = 20;
            this.btnPreious.BorderSize = 0;
            this.btnPreious.FlatAppearance.BorderSize = 0;
            this.btnPreious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreious.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreious.Location = new System.Drawing.Point(167, 617);
            this.btnPreious.Name = "btnPreious";
            this.btnPreious.Size = new System.Drawing.Size(302, 56);
            this.btnPreious.TabIndex = 20;
            this.btnPreious.Text = "Trước đó";
            this.btnPreious.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreious.UseVisualStyleBackColor = false;
            this.btnPreious.Click += new System.EventHandler(this.btnPreious_Click);
            // 
            // panelMulti
            // 
            this.panelMulti.AutoScroll = true;
            this.panelMulti.BackColor = System.Drawing.Color.Transparent;
            this.panelMulti.Controls.Add(this.checkBoxB);
            this.panelMulti.Controls.Add(this.checkBoxA);
            this.panelMulti.Controls.Add(this.checkBoxC);
            this.panelMulti.Controls.Add(this.checkBoxD);
            this.panelMulti.Location = new System.Drawing.Point(157, 103);
            this.panelMulti.Margin = new System.Windows.Forms.Padding(10);
            this.panelMulti.Name = "panelMulti";
            this.panelMulti.Size = new System.Drawing.Size(990, 484);
            this.panelMulti.TabIndex = 22;
            // 
            // checkBoxB
            // 
            this.checkBoxB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxB.Location = new System.Drawing.Point(10, 10);
            this.checkBoxB.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(965, 106);
            this.checkBoxB.TabIndex = 1;
            this.checkBoxB.UseVisualStyleBackColor = false;
            // 
            // checkBoxA
            // 
            this.checkBoxA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxA.Location = new System.Drawing.Point(10, 129);
            this.checkBoxA.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(965, 106);
            this.checkBoxA.TabIndex = 0;
            this.checkBoxA.UseVisualStyleBackColor = false;
            // 
            // checkBoxC
            // 
            this.checkBoxC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxC.Location = new System.Drawing.Point(10, 248);
            this.checkBoxC.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(965, 106);
            this.checkBoxC.TabIndex = 2;
            this.checkBoxC.UseVisualStyleBackColor = false;
            // 
            // checkBoxD
            // 
            this.checkBoxD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxD.Location = new System.Drawing.Point(10, 367);
            this.checkBoxD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(965, 106);
            this.checkBoxD.TabIndex = 3;
            this.checkBoxD.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnNext.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 20;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(805, 617);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(302, 56);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbTime
            // 
            this.gbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTime.BorderRadius = 20;
            this.gbTime.Controls.Add(this.lbTime);
            this.gbTime.CustomBorderColor = System.Drawing.Color.CornflowerBlue;
            this.gbTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.ForeColor = System.Drawing.Color.White;
            this.gbTime.Location = new System.Drawing.Point(1216, 16);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(208, 127);
            this.gbTime.TabIndex = 18;
            this.gbTime.Text = "Thời gian ";
            this.gbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTime.Location = new System.Drawing.Point(35, 55);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(152, 45);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "00:00:00";
            // 
            // panelSingle
            // 
            this.panelSingle.AutoScroll = true;
            this.panelSingle.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.panelSingle.BackColor = System.Drawing.Color.Transparent;
            this.panelSingle.Controls.Add(this.radioButtonA);
            this.panelSingle.Controls.Add(this.radioButtonB);
            this.panelSingle.Controls.Add(this.radioButtonC);
            this.panelSingle.Controls.Add(this.radioButtonD);
            this.panelSingle.Location = new System.Drawing.Point(157, 103);
            this.panelSingle.Margin = new System.Windows.Forms.Padding(10);
            this.panelSingle.Name = "panelSingle";
            this.panelSingle.Size = new System.Drawing.Size(990, 484);
            this.panelSingle.TabIndex = 23;
            // 
            // radioButtonA
            // 
            this.radioButtonA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonA.Location = new System.Drawing.Point(10, 10);
            this.radioButtonA.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(965, 106);
            this.radioButtonA.TabIndex = 7;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonA.UseVisualStyleBackColor = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonB.Location = new System.Drawing.Point(10, 129);
            this.radioButtonB.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(965, 106);
            this.radioButtonB.TabIndex = 6;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonB.UseVisualStyleBackColor = false;
            // 
            // radioButtonC
            // 
            this.radioButtonC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonC.Location = new System.Drawing.Point(10, 248);
            this.radioButtonC.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(965, 106);
            this.radioButtonC.TabIndex = 5;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonC.UseVisualStyleBackColor = false;
            // 
            // radioButtonD
            // 
            this.radioButtonD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButtonD.Location = new System.Drawing.Point(10, 367);
            this.radioButtonD.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(965, 106);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonD.UseVisualStyleBackColor = false;
            // 
            // gbSoCauDaLam
            // 
            this.gbSoCauDaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSoCauDaLam.BorderRadius = 20;
            this.gbSoCauDaLam.Controls.Add(this.lbSoCauDaLam);
            this.gbSoCauDaLam.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.gbSoCauDaLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSoCauDaLam.ForeColor = System.Drawing.Color.White;
            this.gbSoCauDaLam.Location = new System.Drawing.Point(1216, 167);
            this.gbSoCauDaLam.Name = "gbSoCauDaLam";
            this.gbSoCauDaLam.Size = new System.Drawing.Size(208, 127);
            this.gbSoCauDaLam.TabIndex = 17;
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
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1477, 766);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmQuiz";
            this.RightToLeftLayout = true;
            this.Text = "Quiz";
            this.TopMost = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuiz_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuiz_KeyDown);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMulti.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.panelSingle.ResumeLayout(false);
            this.gbSoCauDaLam.ResumeLayout(false);
            this.gbSoCauDaLam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTenCauHoi;
        private System.Windows.Forms.Label lblSTTCauHoi;
        private MyCustomControl.CustomButton btnNopBai;
        private MyCustomControl.CustomButton btnPreious;
        private System.Windows.Forms.FlowLayoutPanel panelMulti;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxD;
        private MyCustomControl.CustomButton btnNext;
        private Guna.UI2.WinForms.Guna2GroupBox gbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.FlowLayoutPanel panelSingle;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private Guna.UI2.WinForms.Guna2GroupBox gbSoCauDaLam;
        private System.Windows.Forms.Label lbSoCauDaLam;
        private System.Windows.Forms.Timer timer1;
    }
}