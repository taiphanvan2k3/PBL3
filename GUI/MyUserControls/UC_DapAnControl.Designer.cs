namespace GUI.MyUserControls
{
    partial class UC_DapAnControl
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
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labelCauHoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDapAn
            // 
            this.txtDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.txtDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAn.ForeColor = System.Drawing.Color.White;
            this.txtDapAn.Location = new System.Drawing.Point(91, 21);
            this.txtDapAn.MinimumSize = new System.Drawing.Size(471, 96);
            this.txtDapAn.Multiline = true;
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(471, 96);
            this.txtDapAn.TabIndex = 1;
            this.txtDapAn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCheck
            // 
            this.labelCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheck.Location = new System.Drawing.Point(574, 62);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(16, 20);
            this.labelCheck.TabIndex = 2;
            this.labelCheck.Text = "*";
            // 
            // labelCauHoi
            // 
            this.labelCauHoi.AutoSize = true;
            this.labelCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCauHoi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCauHoi.Location = new System.Drawing.Point(10, 25);
            this.labelCauHoi.Name = "labelCauHoi";
            this.labelCauHoi.Size = new System.Drawing.Size(68, 20);
            this.labelCauHoi.TabIndex = 3;
            this.labelCauHoi.Text = "Đáp án";
            // 
            // UC_DapAnControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.Controls.Add(this.labelCauHoi);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.txtDapAn);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_DapAnControl";
            this.Size = new System.Drawing.Size(601, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Label labelCauHoi;
    }
}
