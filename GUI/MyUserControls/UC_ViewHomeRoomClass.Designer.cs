namespace GUI.MyUserControls
{
    partial class UC_ViewHomeRoomClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCenter = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panelTop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtNguoiThan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.BackColor = System.Drawing.Color.Transparent;
            this.panelCenter.BorderRadius = 25;
            this.panelCenter.Controls.Add(this.dtgv);
            this.panelCenter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelCenter.FillColor = System.Drawing.Color.Aquamarine;
            this.panelCenter.FillColor2 = System.Drawing.Color.DarkTurquoise;
            this.panelCenter.FillColor3 = System.Drawing.Color.SteelBlue;
            this.panelCenter.FillColor4 = System.Drawing.Color.Olive;
            this.panelCenter.Location = new System.Drawing.Point(21, 101);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1080, 667);
            this.panelCenter.TabIndex = 1;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Mssv,
            this.nameSV,
            this.sdt,
            this.emailCaNhan,
            this.sdtNguoiThan});
            this.dtgv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgv.Location = new System.Drawing.Point(65, 57);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(973, 538);
            this.dtgv.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BorderRadius = 10;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.FillColor = System.Drawing.Color.MediumTurquoise;
            this.panelTop.Location = new System.Drawing.Point(21, 18);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1080, 55);
            this.panelTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 66;
            // 
            // Mssv
            // 
            this.Mssv.HeaderText = "Mã sinh viên";
            this.Mssv.MinimumWidth = 6;
            this.Mssv.Name = "Mssv";
            this.Mssv.ReadOnly = true;
            // 
            // nameSV
            // 
            this.nameSV.HeaderText = "Họ tên sinh viên";
            this.nameSV.MinimumWidth = 6;
            this.nameSV.Name = "nameSV";
            this.nameSV.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // emailCaNhan
            // 
            this.emailCaNhan.HeaderText = "Email cá nhân";
            this.emailCaNhan.MinimumWidth = 6;
            this.emailCaNhan.Name = "emailCaNhan";
            this.emailCaNhan.ReadOnly = true;
            // 
            // sdtNguoiThan
            // 
            this.sdtNguoiThan.HeaderText = "Điện thoại người thân";
            this.sdtNguoiThan.MinimumWidth = 6;
            this.sdtNguoiThan.Name = "sdtNguoiThan";
            this.sdtNguoiThan.ReadOnly = true;
            // 
            // UC_ViewHomeRoomClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.Name = "UC_ViewHomeRoomClass";
            this.Size = new System.Drawing.Size(1139, 800);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelCenter;
        private System.Windows.Forms.DataGridView dtgv;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtNguoiThan;
    }
}
