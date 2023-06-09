namespace GUI.MyUserControls
{
    partial class UC_DapAnPhucKhao
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
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblTenCauHoi = new System.Windows.Forms.Label();
            this.flowPanelAnswer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDapAnDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(17, 16);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(25, 23);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "1.";
            // 
            // lblTenCauHoi
            // 
            this.lblTenCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenCauHoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCauHoi.Location = new System.Drawing.Point(24, 49);
            this.lblTenCauHoi.Name = "lblTenCauHoi";
            this.lblTenCauHoi.Size = new System.Drawing.Size(706, 48);
            this.lblTenCauHoi.TabIndex = 1;
            this.lblTenCauHoi.Text = "Thủ đô Việt Nam là?";
            // 
            // flowPanelAnswer
            // 
            this.flowPanelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelAnswer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelAnswer.Location = new System.Drawing.Point(21, 100);
            this.flowPanelAnswer.Name = "flowPanelAnswer";
            this.flowPanelAnswer.Size = new System.Drawing.Size(709, 87);
            this.flowPanelAnswer.TabIndex = 2;
            this.flowPanelAnswer.SizeChanged += new System.EventHandler(this.flowPanelAnswer_SizeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đáp án đúng:";
            // 
            // lbDapAnDung
            // 
            this.lbDapAnDung.AutoSize = true;
            this.lbDapAnDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDapAnDung.Location = new System.Drawing.Point(145, 197);
            this.lbDapAnDung.Name = "lbDapAnDung";
            this.lbDapAnDung.Size = new System.Drawing.Size(0, 23);
            this.lbDapAnDung.TabIndex = 4;
            // 
            // UC_DapAnPhucKhao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.Controls.Add(this.lbDapAnDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelAnswer);
            this.Controls.Add(this.lblTenCauHoi);
            this.Controls.Add(this.lblSTT);
            this.Name = "UC_DapAnPhucKhao";
            this.Size = new System.Drawing.Size(759, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblTenCauHoi;
        private System.Windows.Forms.FlowLayoutPanel flowPanelAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDapAnDung;
    }
}
