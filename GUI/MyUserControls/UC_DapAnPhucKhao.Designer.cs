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
            this.flowPanelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(17, 16);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(23, 23);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "1.";
            // 
            // lblTenCauHoi
            // 
            this.lblTenCauHoi.AutoSize = true;
            this.lblTenCauHoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCauHoi.Location = new System.Drawing.Point(62, 16);
            this.lblTenCauHoi.Name = "lblTenCauHoi";
            this.lblTenCauHoi.Size = new System.Drawing.Size(167, 23);
            this.lblTenCauHoi.TabIndex = 1;
            this.lblTenCauHoi.Text = "Thủ đô Việt Nam là?";
            // 
            // flowPanelRadio
            // 
            this.flowPanelRadio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelRadio.Location = new System.Drawing.Point(21, 53);
            this.flowPanelRadio.Name = "flowPanelRadio";
            this.flowPanelRadio.Size = new System.Drawing.Size(709, 162);
            this.flowPanelRadio.TabIndex = 2;
            // 
            // UC_DapAnPhucKhao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.Controls.Add(this.flowPanelRadio);
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
        private System.Windows.Forms.FlowLayoutPanel flowPanelRadio;
    }
}
