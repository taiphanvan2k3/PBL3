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
            this.uC_DailyWorkSchedule1 = new GUI.MyUserControls.UC_DailyWorkSchedule();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_DailyWorkSchedule1
            // 
            this.uC_DailyWorkSchedule1.BackColor = System.Drawing.Color.White;
            this.uC_DailyWorkSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DailyWorkSchedule1.Location = new System.Drawing.Point(0, 0);
            this.uC_DailyWorkSchedule1.MaGV = "102BK0001";
            this.uC_DailyWorkSchedule1.Name = "uC_DailyWorkSchedule1";
            this.uC_DailyWorkSchedule1.Size = new System.Drawing.Size(1198, 555);
            this.uC_DailyWorkSchedule1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmTestExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1198, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_DailyWorkSchedule1);
            this.Name = "frmTestExam";
            this.Text = "frmTestExam";
            this.Load += new System.EventHandler(this.frmTestExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControls.UC_DailyWorkSchedule uC_DailyWorkSchedule1;
        private System.Windows.Forms.Button button1;
    }
}