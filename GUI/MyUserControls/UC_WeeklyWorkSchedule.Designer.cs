namespace GUI.MyUserControls
{
    partial class UC_WeeklyWorkSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnXemLich = new GUI.MyCustomControl.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lịch dạy trong tuần";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(14, 58);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(964, 1);
            this.separator.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Học kỳ:";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.AutoRoundedCorners = true;
            this.cbbHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cbbHocKy.BorderRadius = 17;
            this.cbbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.DropDownWidth = 200;
            this.cbbHocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHocKy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.ItemHeight = 30;
            this.cbbHocKy.Location = new System.Drawing.Point(119, 80);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(378, 36);
            this.cbbHocKy.TabIndex = 16;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(35, 169);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(936, 284);
            this.dtgv.TabIndex = 22;
            // 
            // btnXemLich
            // 
            this.btnXemLich.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnXemLich.BackGroundColor = System.Drawing.Color.MediumTurquoise;
            this.btnXemLich.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemLich.BorderRadius = 20;
            this.btnXemLich.BorderSize = 0;
            this.btnXemLich.FlatAppearance.BorderSize = 0;
            this.btnXemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLich.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLich.ForeColor = System.Drawing.Color.Red;
            this.btnXemLich.Image = global::GUI.Properties.Resources.calendar_day;
            this.btnXemLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLich.Location = new System.Drawing.Point(536, 80);
            this.btnXemLich.Name = "btnXemLich";
            this.btnXemLich.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXemLich.Size = new System.Drawing.Size(177, 40);
            this.btnXemLich.TabIndex = 17;
            this.btnXemLich.Text = "     Xem lịch dạy";
            this.btnXemLich.TextColor = System.Drawing.Color.Red;
            this.btnXemLich.UseVisualStyleBackColor = false;
            this.btnXemLich.Click += new System.EventHandler(this.btnXemLich_Click);
            // 
            // UC_WeeklyWorkSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnXemLich);
            this.Controls.Add(this.cbbHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label1);
            this.Name = "UC_WeeklyWorkSchedule";
            this.Size = new System.Drawing.Size(996, 530);
            this.Load += new System.EventHandler(this.UC_WeeklyWorkSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbHocKy;
        private MyCustomControl.CustomButton btnXemLich;
        private System.Windows.Forms.DataGridView dtgv;
    }
}
