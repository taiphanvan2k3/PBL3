namespace GUI.MyUserControls
{
    partial class UC_DoExam
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaiKiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianLamBai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamBai = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelButton = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerPopupForm = new System.Windows.Forms.Timer(this.components);
            this.btnPrev = new GUI.MyCustomControl.CustomButton();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.panelMain.SuspendLayout();
            this.flowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain.Controls.Add(this.flowPanel);
            this.panelMain.Controls.Add(this.separator);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Location = new System.Drawing.Point(14, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(977, 506);
            this.panelMain.TabIndex = 0;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowPanel.Controls.Add(this.dtgv);
            this.flowPanel.Controls.Add(this.panelButton);
            this.flowPanel.Location = new System.Drawing.Point(18, 70);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(943, 415);
            this.flowPanel.TabIndex = 6;
            this.flowPanel.SizeChanged += new System.EventHandler(this.flowPanel_SizeChanged);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.BaiKiemTra,
            this.SoLuongCauHoi,
            this.ThoiGianLamBai,
            this.StartEndTime,
            this.LamBai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(5, 5);
            this.dtgv.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(935, 332);
            this.dtgv.TabIndex = 5;
            this.dtgv.DataSourceChanged += new System.EventHandler(this.dtgv_DataSourceChanged);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            this.dtgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgv_CellPainting);
            // 
            // MaHP
            // 
            this.MaHP.HeaderText = "Mã học phần";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            this.MaHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenHP
            // 
            this.TenHP.HeaderText = "Học phần";
            this.TenHP.MinimumWidth = 6;
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            this.TenHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BaiKiemTra
            // 
            this.BaiKiemTra.HeaderText = "Bài kiểm tra";
            this.BaiKiemTra.MinimumWidth = 6;
            this.BaiKiemTra.Name = "BaiKiemTra";
            this.BaiKiemTra.ReadOnly = true;
            this.BaiKiemTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuongCauHoi
            // 
            this.SoLuongCauHoi.HeaderText = "Số lượng câu hỏi";
            this.SoLuongCauHoi.MinimumWidth = 6;
            this.SoLuongCauHoi.Name = "SoLuongCauHoi";
            this.SoLuongCauHoi.ReadOnly = true;
            this.SoLuongCauHoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThoiGianLamBai
            // 
            this.ThoiGianLamBai.HeaderText = "Thời gian làm bài";
            this.ThoiGianLamBai.MinimumWidth = 6;
            this.ThoiGianLamBai.Name = "ThoiGianLamBai";
            this.ThoiGianLamBai.ReadOnly = true;
            this.ThoiGianLamBai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartEndTime
            // 
            this.StartEndTime.HeaderText = "Khung giờ";
            this.StartEndTime.MinimumWidth = 6;
            this.StartEndTime.Name = "StartEndTime";
            this.StartEndTime.ReadOnly = true;
            this.StartEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LamBai
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LamBai.DefaultCellStyle = dataGridViewCellStyle2;
            this.LamBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LamBai.HeaderText = "Làm bài";
            this.LamBai.MinimumWidth = 6;
            this.LamBai.Name = "LamBai";
            this.LamBai.ReadOnly = true;
            this.LamBai.Text = "Làm bài";
            this.LamBai.UseColumnTextForButtonValue = true;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnPrev);
            this.panelButton.Controls.Add(this.btnNext);
            this.panelButton.Location = new System.Drawing.Point(3, 343);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(935, 61);
            this.panelButton.TabIndex = 6;
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(19, 59);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(942, 1);
            this.separator.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(22, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(185, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Danh sách bài kiểm tra";
            // 
            // timerPopupForm
            // 
            this.timerPopupForm.Interval = 80;
            this.timerPopupForm.Tick += new System.EventHandler(this.timerPopupForm_Tick);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.Image = global::GUI.Properties.Resources.left1;
            this.btnPrev.Location = new System.Drawing.Point(827, 9);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 45);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Image = global::GUI.Properties.Resources.right;
            this.btnNext.Location = new System.Drawing.Point(880, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 10;
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // UC_DoExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_DoExam";
            this.Size = new System.Drawing.Size(1008, 528);
            this.Load += new System.EventHandler(this.UC_DoExam_Load);
            this.SizeChanged += new System.EventHandler(this.UC_DoExam_SizeChanged);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaiKiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianLamBai;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartEndTime;
        private System.Windows.Forms.DataGridViewButtonColumn LamBai;
        private System.Windows.Forms.Timer timerPopupForm;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panelButton;
        private MyCustomControl.CustomButton btnPrev;
        private MyCustomControl.CustomButton btnNext;
    }
}
