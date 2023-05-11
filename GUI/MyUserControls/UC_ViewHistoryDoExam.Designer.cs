namespace GUI.MyUserControls
{
    partial class UC_ViewHistoryDoExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelShow = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnExpandPanelShow = new FontAwesome.Sharp.IconButton();
            this.panelDTGV = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrev = new GUI.MyCustomControl.CustomButton();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.label7 = new System.Windows.Forms.Label();
            this.separator2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpandPanelSearch = new FontAwesome.Sharp.IconButton();
            this.txtTenHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbKiHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHocphan = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.panelShow.SuspendLayout();
            this.panelDTGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.BorderRadius = 15;
            this.panelShow.Controls.Add(this.btnExpandPanelShow);
            this.panelShow.Controls.Add(this.panelDTGV);
            this.panelShow.Controls.Add(this.label7);
            this.panelShow.Controls.Add(this.separator2);
            this.panelShow.Location = new System.Drawing.Point(3, 204);
            this.panelShow.MaximumSize = new System.Drawing.Size(2000, 500);
            this.panelShow.MinimumSize = new System.Drawing.Size(1065, 78);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1065, 500);
            this.panelShow.TabIndex = 15;
            // 
            // btnExpandPanelShow
            // 
            this.btnExpandPanelShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandPanelShow.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandPanelShow.FlatAppearance.BorderSize = 0;
            this.btnExpandPanelShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandPanelShow.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.btnExpandPanelShow.IconColor = System.Drawing.Color.Black;
            this.btnExpandPanelShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandPanelShow.IconSize = 30;
            this.btnExpandPanelShow.Location = new System.Drawing.Point(1014, 14);
            this.btnExpandPanelShow.Name = "btnExpandPanelShow";
            this.btnExpandPanelShow.Size = new System.Drawing.Size(36, 29);
            this.btnExpandPanelShow.TabIndex = 9;
            this.btnExpandPanelShow.UseVisualStyleBackColor = false;
            this.btnExpandPanelShow.Click += new System.EventHandler(this.btnExpandPanelShow_Click);
            // 
            // panelDTGV
            // 
            this.panelDTGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDTGV.BackColor = System.Drawing.Color.White;
            this.panelDTGV.Controls.Add(this.dtgv);
            this.panelDTGV.Controls.Add(this.panel2);
            this.panelDTGV.Location = new System.Drawing.Point(19, 70);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(1035, 414);
            this.panelDTGV.TabIndex = 8;
            this.panelDTGV.SizeChanged += new System.EventHandler(this.panelDTGV_SizeChanged);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(10, 10);
            this.dtgv.Margin = new System.Windows.Forms.Padding(10);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1009, 292);
            this.dtgv.TabIndex = 0;
            this.dtgv.DataSourceChanged += new System.EventHandler(this.dtgv_DataSourceChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPage);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Location = new System.Drawing.Point(3, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 87);
            this.panel2.TabIndex = 9;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.Image = global::GUI.Properties.Resources.left1;
            this.btnPrev.Location = new System.Drawing.Point(11, 36);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 45);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BackGroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Image = global::GUI.Properties.Resources.right;
            this.btnNext.Location = new System.Drawing.Point(62, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 6;
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Danh sách bài kiểm tra";
            // 
            // separator2
            // 
            this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator2.Location = new System.Drawing.Point(7, 52);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(1047, 1);
            this.separator2.TabIndex = 3;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMain.Controls.Add(this.panelSearch);
            this.flowLayoutPanelMain.Controls.Add(this.panelShow);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(6, 11);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1080, 740);
            this.flowLayoutPanelMain.TabIndex = 16;
            this.flowLayoutPanelMain.Resize += new System.EventHandler(this.flowLayoutPanelMain_Resize);
            // 
            // panelSearch
            // 
            this.panelSearch.BorderRadius = 15;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.btnExpandPanelSearch);
            this.panelSearch.Controls.Add(this.txtTenHP);
            this.panelSearch.Controls.Add(this.cbbKiHoc);
            this.panelSearch.Controls.Add(this.lblHocphan);
            this.panelSearch.Controls.Add(this.lblHocKy);
            this.panelSearch.Controls.Add(this.labelTitle);
            this.panelSearch.Controls.Add(this.separator);
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panelSearch.MaximumSize = new System.Drawing.Size(2000, 178);
            this.panelSearch.MinimumSize = new System.Drawing.Size(1065, 70);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1065, 178);
            this.panelSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(921, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 45);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExpandPanelSearch
            // 
            this.btnExpandPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandPanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandPanelSearch.FlatAppearance.BorderSize = 0;
            this.btnExpandPanelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandPanelSearch.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.btnExpandPanelSearch.IconColor = System.Drawing.Color.Black;
            this.btnExpandPanelSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandPanelSearch.IconSize = 30;
            this.btnExpandPanelSearch.Location = new System.Drawing.Point(1014, 13);
            this.btnExpandPanelSearch.Name = "btnExpandPanelSearch";
            this.btnExpandPanelSearch.Size = new System.Drawing.Size(36, 29);
            this.btnExpandPanelSearch.TabIndex = 10;
            this.btnExpandPanelSearch.UseVisualStyleBackColor = false;
            this.btnExpandPanelSearch.Click += new System.EventHandler(this.btnExpandPanelSearch_Click);
            // 
            // txtTenHP
            // 
            this.txtTenHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenHP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenHP.BackColor = System.Drawing.Color.Transparent;
            this.txtTenHP.BorderRadius = 10;
            this.txtTenHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHP.DefaultText = "";
            this.txtTenHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtTenHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHP.Location = new System.Drawing.Point(491, 109);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.PasswordChar = '\0';
            this.txtTenHP.PlaceholderText = "";
            this.txtTenHP.SelectedText = "";
            this.txtTenHP.Size = new System.Drawing.Size(405, 36);
            this.txtTenHP.TabIndex = 12;
            // 
            // cbbKiHoc
            // 
            this.cbbKiHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbKiHoc.BorderRadius = 10;
            this.cbbKiHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKiHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKiHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKiHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKiHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbKiHoc.ItemHeight = 30;
            this.cbbKiHoc.Location = new System.Drawing.Point(17, 109);
            this.cbbKiHoc.Name = "cbbKiHoc";
            this.cbbKiHoc.Size = new System.Drawing.Size(312, 36);
            this.cbbKiHoc.TabIndex = 9;
            this.cbbKiHoc.SelectedIndexChanged += new System.EventHandler(this.cbbKiHoc_SelectedIndexChanged);
            // 
            // lblHocphan
            // 
            this.lblHocphan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocphan.AutoSize = true;
            this.lblHocphan.BackColor = System.Drawing.Color.Transparent;
            this.lblHocphan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocphan.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHocphan.Location = new System.Drawing.Point(487, 73);
            this.lblHocphan.Name = "lblHocphan";
            this.lblHocphan.Size = new System.Drawing.Size(84, 23);
            this.lblHocphan.TabIndex = 7;
            this.lblHocphan.Text = "Học phần";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHocKy.Location = new System.Drawing.Point(18, 73);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(61, 23);
            this.lblHocKy.TabIndex = 6;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTitle.Location = new System.Drawing.Point(11, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(204, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Điều kiện tìm kiếm";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(7, 52);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1047, 1);
            this.separator.TabIndex = 3;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(13, 8);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(53, 23);
            this.lblPage.TabIndex = 8;
            this.lblPage.Text = "Trang";
            // 
            // UC_ViewHistoryDoExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Name = "UC_ViewHistoryDoExam";
            this.Size = new System.Drawing.Size(1098, 784);
            this.Load += new System.EventHandler(this.UC_ViewHistoryDoExam_Load);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.panelDTGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel separator2;
        private MyCustomControl.CustomButton btnPrev;
        private MyCustomControl.CustomButton btnNext;
        private System.Windows.Forms.FlowLayoutPanel panelDTGV;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnExpandPanelShow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelSearch;
        private FontAwesome.Sharp.IconButton btnExpandPanelSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHP;
        private Guna.UI2.WinForms.Guna2ComboBox cbbKiHoc;
        private System.Windows.Forms.Label lblHocphan;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel separator;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lblPage;
    }
}
