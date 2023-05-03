namespace GUI.MyUserControls
{
    partial class UC_Day
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.lbIfMore = new System.Windows.Forms.Label();
            this.lbExam = new System.Windows.Forms.Label();
            this.btnDay = new GUI.MyCustomControl.CustomButton();
            this.pnlEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEvent
            // 
            this.pnlEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEvent.BackColor = System.Drawing.Color.Transparent;
            this.pnlEvent.Controls.Add(this.lbIfMore);
            this.pnlEvent.Controls.Add(this.lbExam);
            this.pnlEvent.Location = new System.Drawing.Point(0, 41);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(162, 63);
            this.pnlEvent.TabIndex = 1;
            //this.pnlEvent.Click += new System.EventHandler(this.pblEvent_Click);
            // 
            // lbIfMore
            // 
            this.lbIfMore.AutoSize = true;
            this.lbIfMore.BackColor = System.Drawing.Color.Transparent;
            this.lbIfMore.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIfMore.Location = new System.Drawing.Point(14, 30);
            this.lbIfMore.Name = "lbIfMore";
            this.lbIfMore.Size = new System.Drawing.Size(0, 20);
            this.lbIfMore.TabIndex = 1;
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExam.Location = new System.Drawing.Point(13, 9);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(0, 20);
            this.lbExam.TabIndex = 0;
            // 
            // btnDay
            // 
            this.btnDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDay.BackColor = System.Drawing.Color.Transparent;
            this.btnDay.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnDay.BorderColor = System.Drawing.Color.Transparent;
            this.btnDay.BorderRadius = 35;
            this.btnDay.BorderSize = 3;
            this.btnDay.Enabled = false;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.ForeColor = System.Drawing.Color.Black;
            this.btnDay.Location = new System.Drawing.Point(114, 0);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(41, 35);
            this.btnDay.TabIndex = 2;
            this.btnDay.Text = "30";
            this.btnDay.TextColor = System.Drawing.Color.Black;
            this.btnDay.UseVisualStyleBackColor = false;
            // 
            // UC_Day
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.pnlEvent);
            this.Name = "UC_Day";
            this.Size = new System.Drawing.Size(162, 112);
            //this.Click += new System.EventHandler(this.pblEvent_Click);
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Label lbIfMore;
        private System.Windows.Forms.Label lbExam;
        private MyCustomControl.CustomButton btnDay;
    }
}
