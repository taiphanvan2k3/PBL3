namespace GUI
{
    partial class frmAddStudentIntoModuleClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudentIntoModuleClass));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpload = new GUI.MyCustomControl.PanelGradient();
            this.lblImgUpload = new System.Windows.Forms.Label();
            this.lblTextUpload = new System.Windows.Forms.Label();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // pnlUpload
            // 
            this.pnlUpload.BackColor = System.Drawing.Color.White;
            this.pnlUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlUpload.BorderRadius = 30;
            this.pnlUpload.Controls.Add(this.lblImgUpload);
            this.pnlUpload.Controls.Add(this.lblTextUpload);
            this.pnlUpload.ForeColor = System.Drawing.Color.Black;
            this.pnlUpload.GradientAngle = 90F;
            this.pnlUpload.GradientBottomColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpload.GradientTopColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpload.Location = new System.Drawing.Point(53, 79);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(384, 176);
            this.pnlUpload.TabIndex = 4;
            this.pnlUpload.Click += new System.EventHandler(this.pnlUpload_Click);
            // 
            // lblImgUpload
            // 
            this.lblImgUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblImgUpload.Image = global::GUI.Properties.Resources.csv;
            this.lblImgUpload.Location = new System.Drawing.Point(152, 65);
            this.lblImgUpload.Name = "lblImgUpload";
            this.lblImgUpload.Size = new System.Drawing.Size(74, 78);
            this.lblImgUpload.TabIndex = 6;
            this.lblImgUpload.Click += new System.EventHandler(this.pnlUpload_Click);
            // 
            // lblTextUpload
            // 
            this.lblTextUpload.AutoSize = true;
            this.lblTextUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblTextUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTextUpload.Location = new System.Drawing.Point(35, 16);
            this.lblTextUpload.Name = "lblTextUpload";
            this.lblTextUpload.Size = new System.Drawing.Size(314, 38);
            this.lblTextUpload.TabIndex = 5;
            this.lblTextUpload.Text = "Chọn file CSV để tải lên";
            this.lblTextUpload.Click += new System.EventHandler(this.pnlUpload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.BackGroundColor = System.Drawing.Color.Black;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(316, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(53, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(194, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(230, 35);
            this.txtSearch.TabIndex = 20;
            // 
            // frmAddStudentIntoModuleClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(491, 334);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStudentIntoModuleClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmAddStudentIntoModuleClass_Load);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.PanelGradient pnlUpload;
        private System.Windows.Forms.Label lblTextUpload;
        private System.Windows.Forms.Label lblImgUpload;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}