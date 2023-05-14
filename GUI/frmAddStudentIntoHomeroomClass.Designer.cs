namespace GUI
{
    partial class frmAddStudentIntoHomeroomClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudentIntoHomeroomClass));
            this.pnlUpload = new GUI.MyCustomControl.PanelGradient();
            this.lblImgUpload = new System.Windows.Forms.Label();
            this.lblTextUpload = new System.Windows.Forms.Label();
            this.btnCancel = new GUI.MyCustomControl.CustomButton();
            this.btnAdd = new GUI.MyCustomControl.CustomButton();
            this.txtIdStudent = new GUI.MyCustomControl.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUpload.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpload
            // 
            this.pnlUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpload.BackColor = System.Drawing.Color.White;
            this.pnlUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlUpload.BorderRadius = 30;
            this.pnlUpload.Controls.Add(this.lblImgUpload);
            this.pnlUpload.Controls.Add(this.lblTextUpload);
            this.pnlUpload.ForeColor = System.Drawing.Color.Black;
            this.pnlUpload.GradientAngle = 90F;
            this.pnlUpload.GradientBottomColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpload.GradientTopColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpload.Location = new System.Drawing.Point(42, 121);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(419, 176);
            this.pnlUpload.TabIndex = 9;
            // 
            // lblImgUpload
            // 
            this.lblImgUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImgUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblImgUpload.Image = global::GUI.Properties.Resources.csv;
            this.lblImgUpload.Location = new System.Drawing.Point(174, 67);
            this.lblImgUpload.Name = "lblImgUpload";
            this.lblImgUpload.Size = new System.Drawing.Size(74, 78);
            this.lblImgUpload.TabIndex = 6;
            // 
            // lblTextUpload
            // 
            this.lblTextUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextUpload.AutoSize = true;
            this.lblTextUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblTextUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTextUpload.Location = new System.Drawing.Point(54, 16);
            this.lblTextUpload.Name = "lblTextUpload";
            this.lblTextUpload.Size = new System.Drawing.Size(314, 38);
            this.lblTextUpload.TabIndex = 5;
            this.lblTextUpload.Text = "Chọn file CSV để tải lên";
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
            this.btnCancel.Location = new System.Drawing.Point(326, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 45);
            this.btnCancel.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(51, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdStudent.BorderColor = System.Drawing.Color.Black;
            this.txtIdStudent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdStudent.BorderRadius = 10;
            this.txtIdStudent.BorderSize = 2;
            this.txtIdStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStudent.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdStudent.Location = new System.Drawing.Point(231, 72);
            this.txtIdStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdStudent.MaxLength = 32767;
            this.txtIdStudent.Multiline = false;
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdStudent.PasswordChar = false;
            this.txtIdStudent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdStudent.PlaceholderText = "";
            this.txtIdStudent.Size = new System.Drawing.Size(227, 38);
            this.txtIdStudent.TabIndex = 6;
            this.txtIdStudent.Texts = "";
            this.txtIdStudent.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sinh viên";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.IndianRed;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(509, 50);
            this.panelTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm sinh viên vào lớp sinh hoạt";
            // 
            // frmAddStudentIntoHomeroomClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 381);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStudentIntoHomeroomClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sinh viên vào lớp sinh hoạt";
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomControl.PanelGradient pnlUpload;
        private System.Windows.Forms.Label lblImgUpload;
        private System.Windows.Forms.Label lblTextUpload;
        private MyCustomControl.CustomButton btnCancel;
        private MyCustomControl.CustomButton btnAdd;
        private MyCustomControl.CustomTextBox txtIdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}