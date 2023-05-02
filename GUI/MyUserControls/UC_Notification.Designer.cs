namespace GUI.MyUserControls
{
    partial class UC_Notification
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
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblGV = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.ForeColor = System.Drawing.Color.Red;
            this.lblNgayTao.Location = new System.Drawing.Point(19, 14);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(91, 23);
            this.lblNgayTao.TabIndex = 0;
            this.lblNgayTao.Text = "1/5/2023:";
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGV.Location = new System.Drawing.Point(19, 50);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(94, 23);
            this.lblGV.TabIndex = 1;
            this.lblGV.Text = "Thầy nhắn:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTieuDe.Location = new System.Drawing.Point(121, 14);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(584, 23);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Thầy Đặng Hoàng Phương thông báo đến lớp: Lập trình .Net [21.Nh13]";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(121, 50);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(654, 31);
            this.lblNoiDung.TabIndex = 3;
            this.lblNoiDung.Text = "Lớp HỌC BÙ ngày: 15/04/2023,Tiết: 8-9, phòng: H106";
            // 
            // UC_Notification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblGV);
            this.Controls.Add(this.lblNgayTao);
            this.Name = "UC_Notification";
            this.Size = new System.Drawing.Size(793, 94);
            this.Load += new System.EventHandler(this.UC_Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
    }
}
