namespace GUI
{
    partial class frmViewListAccAndClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewListAccAndClass));
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvViewAcc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Location = new System.Drawing.Point(25, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1150, 500);
            this.panelContainer.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvViewAcc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 400);
            this.panel3.TabIndex = 21;
            // 
            // dgvViewAcc
            // 
            this.dgvViewAcc.AllowUserToAddRows = false;
            this.dgvViewAcc.AllowUserToDeleteRows = false;
            this.dgvViewAcc.AllowUserToResizeRows = false;
            this.dgvViewAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAcc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvViewAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvViewAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAcc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewAcc.EnableHeadersVisualStyles = false;
            this.dgvViewAcc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvViewAcc.Location = new System.Drawing.Point(0, 0);
            this.dgvViewAcc.Name = "dgvViewAcc";
            this.dgvViewAcc.RowHeadersVisible = false;
            this.dgvViewAcc.RowHeadersWidth = 51;
            this.dgvViewAcc.RowTemplate.Height = 25;
            this.dgvViewAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewAcc.Size = new System.Drawing.Size(1150, 400);
            this.dgvViewAcc.TabIndex = 19;
            this.dgvViewAcc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvViewAcc_CellBeginEdit);
            this.dgvViewAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAcc_CellClick);
            this.dgvViewAcc.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSelectAll_CellPainting);
            this.dgvViewAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAcc_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 100);
            this.panel1.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(8, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(230, 35);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.Controls.Add(this.btnDelete);
            this.panelButton.Controls.Add(this.btnAdd);
            this.panelButton.Controls.Add(this.btnEdit);
            this.panelButton.Location = new System.Drawing.Point(644, 15);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(506, 79);
            this.panelButton.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(200, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(104, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(292, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(211, 35);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Thêm tài khoản";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(44, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(160, 35);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(247, 38);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Quản lý tài khoản";
            // 
            // frmViewListAccAndClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewListAccAndClass";
            this.Text = "frmAddAccount";
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvViewAcc;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}