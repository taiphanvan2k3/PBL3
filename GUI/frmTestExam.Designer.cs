namespace GUI
{
    partial class frmTestExam
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
            this.uC_FinishDoExam1 = new GUI.MyUserControls.UC_FinishDoExam();
            this.SuspendLayout();
            // 
            // uC_FinishDoExam1
            // 
            this.uC_FinishDoExam1.BackColor = System.Drawing.SystemColors.Window;
            this.uC_FinishDoExam1.DiemSo = 0D;
            this.uC_FinishDoExam1.EndTime = new System.DateTime(((long)(0)));
            this.uC_FinishDoExam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.uC_FinishDoExam1.Location = new System.Drawing.Point(12, 12);
            this.uC_FinishDoExam1.Name = "uC_FinishDoExam1";
            this.uC_FinishDoExam1.Size = new System.Drawing.Size(1387, 435);
            this.uC_FinishDoExam1.SoCauDung = 0;
            this.uC_FinishDoExam1.SoLanViPham = 0;
            this.uC_FinishDoExam1.StartTime = new System.DateTime(((long)(0)));
            this.uC_FinishDoExam1.TabIndex = 0;
            this.uC_FinishDoExam1.TongSoCauHoi = 0;
            // 
            // frmTestExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 459);
            this.Controls.Add(this.uC_FinishDoExam1);
            this.Name = "frmTestExam";
            this.Text = "frmTestExam";
            this.Load += new System.EventHandler(this.frmTestExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControls.UC_FinishDoExam uC_FinishDoExam1;
    }
}