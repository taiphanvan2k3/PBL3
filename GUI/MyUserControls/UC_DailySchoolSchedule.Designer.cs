namespace GUI.MyUserControls
{
    partial class UC_DailySchoolSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowDateTime = new System.Windows.Forms.Label();
            this.btnXemLichHoc = new GUI.MyCustomControl.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch học theo ngày";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(6, 59);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1169, 1);
            this.separator.TabIndex = 1;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maHP,
            this.tenHP,
            this.tenGV,
            this.tkb});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtgv.Location = new System.Drawing.Point(24, 138);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 30;
            this.dtgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1134, 284);
            this.dtgv.TabIndex = 2;
            // 
            // stt
            // 
            this.stt.FillWeight = 53.47594F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // maHP
            // 
            this.maHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maHP.FillWeight = 111.631F;
            this.maHP.HeaderText = "Mã học phần";
            this.maHP.MinimumWidth = 6;
            this.maHP.Name = "maHP";
            this.maHP.ReadOnly = true;
            this.maHP.Width = 145;
            // 
            // tenHP
            // 
            this.tenHP.FillWeight = 111.631F;
            this.tenHP.HeaderText = "Tên học phần";
            this.tenHP.MinimumWidth = 6;
            this.tenHP.Name = "tenHP";
            this.tenHP.ReadOnly = true;
            // 
            // tenGV
            // 
            this.tenGV.FillWeight = 111.631F;
            this.tenGV.HeaderText = "Giảng viên";
            this.tenGV.MinimumWidth = 6;
            this.tenGV.Name = "tenGV";
            this.tenGV.ReadOnly = true;
            // 
            // tkb
            // 
            this.tkb.FillWeight = 111.631F;
            this.tkb.HeaderText = "Thời khoá biểu";
            this.tkb.MinimumWidth = 6;
            this.tkb.Name = "tkb";
            this.tkb.ReadOnly = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.Red;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(135, 76);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(150, 30);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày học:";
            // 
            // lblShowDateTime
            // 
            this.lblShowDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShowDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowDateTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblShowDateTime.Location = new System.Drawing.Point(135, 76);
            this.lblShowDateTime.Name = "lblShowDateTime";
            this.lblShowDateTime.Size = new System.Drawing.Size(150, 30);
            this.lblShowDateTime.TabIndex = 5;
            this.lblShowDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShowDateTime.Click += new System.EventHandler(this.lblShowDateTime_Click);
            // 
            // btnXemLichHoc
            // 
            this.btnXemLichHoc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnXemLichHoc.BackGroundColor = System.Drawing.Color.MediumTurquoise;
            this.btnXemLichHoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemLichHoc.BorderRadius = 20;
            this.btnXemLichHoc.BorderSize = 0;
            this.btnXemLichHoc.FlatAppearance.BorderSize = 0;
            this.btnXemLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLichHoc.ForeColor = System.Drawing.Color.Red;
            //this.btnXemLichHoc.Image = global::GUI.Properties.Resources.calendar_date;
            this.btnXemLichHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemLichHoc.Location = new System.Drawing.Point(372, 74);
            this.btnXemLichHoc.Name = "btnXemLichHoc";
            this.btnXemLichHoc.Size = new System.Drawing.Size(177, 40);
            this.btnXemLichHoc.TabIndex = 16;
            this.btnXemLichHoc.Text = "   Xem lịch học";
            this.btnXemLichHoc.TextColor = System.Drawing.Color.Red;
            this.btnXemLichHoc.UseVisualStyleBackColor = false;
            this.btnXemLichHoc.Click += new System.EventHandler(this.btnXemLich_Click);
            // 
            // UC_DailySchoolSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXemLichHoc);
            this.Controls.Add(this.lblShowDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label1);
            this.Name = "UC_DailySchoolSchedule";
            this.Size = new System.Drawing.Size(1190, 950);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkb;
        private MyCustomControl.CustomButton btnXemLichHoc;
    }
}
