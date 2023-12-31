﻿namespace GUI.MyUserControls
{
    partial class UC_Calendar_New
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSunday = new System.Windows.Forms.Label();
            this.lbSaturday = new System.Windows.Forms.Label();
            this.lbFriday = new System.Windows.Forms.Label();
            this.lbThursday = new System.Windows.Forms.Label();
            this.lbWednesday = new System.Windows.Forms.Label();
            this.lbTuesday = new System.Windows.Forms.Label();
            this.lbMonday = new System.Windows.Forms.Label();
            this.UC_MonthCa = new GUI.MyUserControls.UC_MonthCalendar();
            this.panelGradient1 = new GUI.MyCustomControl.PanelGradient();
            this.panelGradient2 = new GUI.MyCustomControl.PanelGradient();
            this.btnXemChiTiet = new GUI.MyCustomControl.CustomButton();
            this.lbCacLopCoBaiKiemTra = new System.Windows.Forms.Label();
            this.lbLoaiBaiKiemTra = new System.Windows.Forms.Label();
            this.btnNext = new GUI.MyCustomControl.CustomButton();
            this.buttonToday = new GUI.MyCustomControl.CustomButton();
            this.btnPrevious = new GUI.MyCustomControl.CustomButton();
            this.panel1.SuspendLayout();
            this.panelGradient1.SuspendLayout();
            this.panelGradient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.UC_MonthCa);
            this.panel1.Controls.Add(this.panelGradient1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.buttonToday);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.tableLayoutPanel);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbSunday);
            this.panel1.Controls.Add(this.lbSaturday);
            this.panel1.Controls.Add(this.lbFriday);
            this.panel1.Controls.Add(this.lbThursday);
            this.panel1.Controls.Add(this.lbWednesday);
            this.panel1.Controls.Add(this.lbTuesday);
            this.panel1.Controls.Add(this.lbMonday);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 815);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.UC_Calendar_Resize);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(373, 125);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1134, 672);
            this.tableLayoutPanel.TabIndex = 64;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.lbDate.Location = new System.Drawing.Point(747, 7);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(345, 50);
            this.lbDate.TabIndex = 63;
            this.lbDate.Text = "MONTH YEAR";
            // 
            // lbSunday
            // 
            this.lbSunday.AutoSize = true;
            this.lbSunday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.Location = new System.Drawing.Point(407, 82);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.Size = new System.Drawing.Size(99, 28);
            this.lbSunday.TabIndex = 62;
            this.lbSunday.Text = "Chủ nhật";
            // 
            // lbSaturday
            // 
            this.lbSaturday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSaturday.AutoSize = true;
            this.lbSaturday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.Location = new System.Drawing.Point(1381, 82);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.Size = new System.Drawing.Size(90, 28);
            this.lbSaturday.TabIndex = 61;
            this.lbSaturday.Text = "Thứ bảy";
            // 
            // lbFriday
            // 
            this.lbFriday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFriday.AutoSize = true;
            this.lbFriday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.Location = new System.Drawing.Point(1214, 82);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.Size = new System.Drawing.Size(88, 28);
            this.lbFriday.TabIndex = 60;
            this.lbFriday.Text = "Thứ sáu";
            // 
            // lbThursday
            // 
            this.lbThursday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThursday.AutoSize = true;
            this.lbThursday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.Location = new System.Drawing.Point(1054, 82);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.Size = new System.Drawing.Size(97, 28);
            this.lbThursday.TabIndex = 59;
            this.lbThursday.Text = "Thứ năm";
            // 
            // lbWednesday
            // 
            this.lbWednesday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWednesday.AutoSize = true;
            this.lbWednesday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.Location = new System.Drawing.Point(897, 82);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.Size = new System.Drawing.Size(76, 28);
            this.lbWednesday.TabIndex = 58;
            this.lbWednesday.Text = "Thứ tư";
            // 
            // lbTuesday
            // 
            this.lbTuesday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTuesday.AutoSize = true;
            this.lbTuesday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.Location = new System.Drawing.Point(736, 82);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.Size = new System.Drawing.Size(79, 28);
            this.lbTuesday.TabIndex = 57;
            this.lbTuesday.Text = "Thứ ba";
            // 
            // lbMonday
            // 
            this.lbMonday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMonday.AutoSize = true;
            this.lbMonday.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.Location = new System.Drawing.Point(575, 82);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.Size = new System.Drawing.Size(85, 28);
            this.lbMonday.TabIndex = 56;
            this.lbMonday.Text = "Thứ hai";
            // 
            // UC_MonthCa
            // 
            this.UC_MonthCa.BackColor = System.Drawing.Color.White;
            this.UC_MonthCa.ColorBack = System.Drawing.Color.White;
            this.UC_MonthCa.Location = new System.Drawing.Point(27, 34);
            this.UC_MonthCa.Name = "UC_MonthCa";
            this.UC_MonthCa.Size = new System.Drawing.Size(315, 439);
            this.UC_MonthCa.TabIndex = 72;
            this.UC_MonthCa.UC_Calendar = null;
            // 
            // panelGradient1
            // 
            this.panelGradient1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGradient1.BackColor = System.Drawing.Color.White;
            this.panelGradient1.BorderRadius = 30;
            this.panelGradient1.Controls.Add(this.panelGradient2);
            this.panelGradient1.Controls.Add(this.lbLoaiBaiKiemTra);
            this.panelGradient1.ForeColor = System.Drawing.Color.Black;
            this.panelGradient1.GradientAngle = 90F;
            this.panelGradient1.GradientBottomColor = System.Drawing.Color.Azure;
            this.panelGradient1.GradientTopColor = System.Drawing.Color.Azure;
            this.panelGradient1.Location = new System.Drawing.Point(12, 506);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(341, 300);
            this.panelGradient1.TabIndex = 69;
            // 
            // panelGradient2
            // 
            this.panelGradient2.BackColor = System.Drawing.Color.White;
            this.panelGradient2.BorderRadius = 30;
            this.panelGradient2.Controls.Add(this.btnXemChiTiet);
            this.panelGradient2.Controls.Add(this.lbCacLopCoBaiKiemTra);
            this.panelGradient2.ForeColor = System.Drawing.Color.Black;
            this.panelGradient2.GradientAngle = 90F;
            this.panelGradient2.GradientBottomColor = System.Drawing.Color.Tomato;
            this.panelGradient2.GradientTopColor = System.Drawing.Color.DarkTurquoise;
            this.panelGradient2.Location = new System.Drawing.Point(0, 38);
            this.panelGradient2.Name = "panelGradient2";
            this.panelGradient2.Size = new System.Drawing.Size(341, 259);
            this.panelGradient2.TabIndex = 2;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.Crimson;
            this.btnXemChiTiet.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnXemChiTiet.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnXemChiTiet.BorderRadius = 40;
            this.btnXemChiTiet.BorderSize = 2;
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(188, 216);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(150, 40);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextColor = System.Drawing.Color.White;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // lbCacLopCoBaiKiemTra
            // 
            this.lbCacLopCoBaiKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.lbCacLopCoBaiKiemTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCacLopCoBaiKiemTra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCacLopCoBaiKiemTra.Location = new System.Drawing.Point(0, 0);
            this.lbCacLopCoBaiKiemTra.Name = "lbCacLopCoBaiKiemTra";
            this.lbCacLopCoBaiKiemTra.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbCacLopCoBaiKiemTra.Size = new System.Drawing.Size(341, 259);
            this.lbCacLopCoBaiKiemTra.TabIndex = 0;
            // 
            // lbLoaiBaiKiemTra
            // 
            this.lbLoaiBaiKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.lbLoaiBaiKiemTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaiBaiKiemTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiBaiKiemTra.Location = new System.Drawing.Point(0, 0);
            this.lbLoaiBaiKiemTra.Name = "lbLoaiBaiKiemTra";
            this.lbLoaiBaiKiemTra.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbLoaiBaiKiemTra.Size = new System.Drawing.Size(341, 35);
            this.lbLoaiBaiKiemTra.TabIndex = 1;
            this.lbLoaiBaiKiemTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNext.BackGroundColor = System.Drawing.Color.RosyBrown;
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.BorderRadius = 15;
            this.btnNext.BorderSize = 1;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1386, 24);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 34);
            this.btnNext.TabIndex = 67;
            this.btnNext.Text = "Tháng sau";
            this.btnNext.TextColor = System.Drawing.Color.Black;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonToday.BackGroundColor = System.Drawing.Color.PeachPuff;
            this.buttonToday.BorderColor = System.Drawing.Color.Black;
            this.buttonToday.BorderRadius = 15;
            this.buttonToday.BorderSize = 1;
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.Black;
            this.buttonToday.Location = new System.Drawing.Point(1259, 24);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(106, 34);
            this.buttonToday.TabIndex = 66;
            this.buttonToday.Text = "Hôm nay";
            this.buttonToday.TextColor = System.Drawing.Color.Black;
            this.buttonToday.UseVisualStyleBackColor = false;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrevious.BackGroundColor = System.Drawing.Color.RosyBrown;
            this.btnPrevious.BorderColor = System.Drawing.Color.Black;
            this.btnPrevious.BorderRadius = 15;
            this.btnPrevious.BorderSize = 1;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(1132, 24);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(106, 34);
            this.btnPrevious.TabIndex = 65;
            this.btnPrevious.Text = "Tháng trước";
            this.btnPrevious.TextColor = System.Drawing.Color.Black;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // UC_Calendar_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Calendar_New";
            this.Size = new System.Drawing.Size(1510, 815);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MyCustomControl.CustomButton btnNext;
        private MyCustomControl.CustomButton buttonToday;
        private MyCustomControl.CustomButton btnPrevious;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSunday;
        private System.Windows.Forms.Label lbSaturday;
        private System.Windows.Forms.Label lbFriday;
        private System.Windows.Forms.Label lbThursday;
        private System.Windows.Forms.Label lbWednesday;
        private System.Windows.Forms.Label lbTuesday;
        private System.Windows.Forms.Label lbMonday;
        private MyCustomControl.PanelGradient panelGradient1;
        private MyCustomControl.PanelGradient panelGradient2;
        private System.Windows.Forms.Label lbCacLopCoBaiKiemTra;
        private System.Windows.Forms.Label lbLoaiBaiKiemTra;
        private UC_MonthCalendar UC_MonthCa;
        private MyCustomControl.CustomButton btnXemChiTiet;
    }
}
