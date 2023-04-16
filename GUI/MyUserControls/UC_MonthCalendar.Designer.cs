namespace GUI.MyUserControls
{
    partial class UC_MonthCalendar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbSunday = new System.Windows.Forms.Label();
            this.lbSaturday = new System.Windows.Forms.Label();
            this.lbFriday = new System.Windows.Forms.Label();
            this.lbThursday = new System.Windows.Forms.Label();
            this.lbWednesday = new System.Windows.Forms.Label();
            this.lbTuesday = new System.Windows.Forms.Label();
            this.lbMonday = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.customButton3 = new GUI.MyCustomControl.CustomButton();
            this.customButton2 = new GUI.MyCustomControl.CustomButton();
            this.customButton1 = new GUI.MyCustomControl.CustomButton();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 296);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lbSunday
            // 
            this.lbSunday.AutoSize = true;
            this.lbSunday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.Location = new System.Drawing.Point(9, 45);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.Size = new System.Drawing.Size(31, 20);
            this.lbSunday.TabIndex = 24;
            this.lbSunday.Text = "CN";
            // 
            // lbSaturday
            // 
            this.lbSaturday.AutoSize = true;
            this.lbSaturday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.Location = new System.Drawing.Point(267, 45);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.Size = new System.Drawing.Size(27, 20);
            this.lbSaturday.TabIndex = 23;
            this.lbSaturday.Text = "T7";
            // 
            // lbFriday
            // 
            this.lbFriday.AutoSize = true;
            this.lbFriday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.Location = new System.Drawing.Point(224, 45);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.Size = new System.Drawing.Size(27, 20);
            this.lbFriday.TabIndex = 22;
            this.lbFriday.Text = "T6";
            // 
            // lbThursday
            // 
            this.lbThursday.AutoSize = true;
            this.lbThursday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.Location = new System.Drawing.Point(181, 45);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.Size = new System.Drawing.Size(27, 20);
            this.lbThursday.TabIndex = 21;
            this.lbThursday.Text = "T5";
            // 
            // lbWednesday
            // 
            this.lbWednesday.AutoSize = true;
            this.lbWednesday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.Location = new System.Drawing.Point(138, 45);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.Size = new System.Drawing.Size(27, 20);
            this.lbWednesday.TabIndex = 20;
            this.lbWednesday.Text = "T4";
            // 
            // lbTuesday
            // 
            this.lbTuesday.AutoSize = true;
            this.lbTuesday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.Location = new System.Drawing.Point(95, 45);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.Size = new System.Drawing.Size(27, 20);
            this.lbTuesday.TabIndex = 19;
            this.lbTuesday.Text = "T3";
            // 
            // lbMonday
            // 
            this.lbMonday.AutoSize = true;
            this.lbMonday.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.Location = new System.Drawing.Point(52, 45);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.Size = new System.Drawing.Size(27, 20);
            this.lbMonday.TabIndex = 18;
            this.lbMonday.Text = "T2";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.Transparent;
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.Black;
            this.btnDate.Location = new System.Drawing.Point(92, 2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(120, 40);
            this.btnDate.TabIndex = 27;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.buttonToday_Click);
            this.btnDate.Resize += new System.EventHandler(this.UC_Calendar_Resize);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnNext.Image = global::GUI.Properties.Resources.right_arrow;
            this.btnNext.Location = new System.Drawing.Point(254, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 26;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::GUI.Properties.Resources.left_arrow;
            this.btnPrevious.Location = new System.Drawing.Point(2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.SpringGreen;
            this.customButton3.BackGroundColor = System.Drawing.Color.SpringGreen;
            this.customButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customButton3.BorderRadius = 36;
            this.customButton3.BorderSize = 3;
            this.customButton3.Enabled = false;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(211, 387);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(86, 36);
            this.customButton3.TabIndex = 30;
            this.customButton3.Text = "End-Term";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customButton2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customButton2.BorderColor = System.Drawing.Color.Red;
            this.customButton2.BorderRadius = 36;
            this.customButton2.BorderSize = 3;
            this.customButton2.Enabled = false;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(105, 387);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(86, 36);
            this.customButton2.TabIndex = 29;
            this.customButton2.Text = "Mid-Term";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.customButton1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.customButton1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.customButton1.BorderRadius = 36;
            this.customButton1.BorderSize = 3;
            this.customButton1.Enabled = false;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(3, 387);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(86, 36);
            this.customButton1.TabIndex = 28;
            this.customButton1.Text = "Today";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // UC_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lbSunday);
            this.Controls.Add(this.lbSaturday);
            this.Controls.Add(this.lbFriday);
            this.Controls.Add(this.lbThursday);
            this.Controls.Add(this.lbWednesday);
            this.Controls.Add(this.lbTuesday);
            this.Controls.Add(this.lbMonday);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_MonthCalendar";
            this.Size = new System.Drawing.Size(304, 439);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.UC_Calendar_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbSunday;
        private System.Windows.Forms.Label lbSaturday;
        private System.Windows.Forms.Label lbFriday;
        private System.Windows.Forms.Label lbThursday;
        private System.Windows.Forms.Label lbWednesday;
        private System.Windows.Forms.Label lbTuesday;
        private System.Windows.Forms.Label lbMonday;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDate;
        private MyCustomControl.CustomButton customButton1;
        private MyCustomControl.CustomButton customButton2;
        private MyCustomControl.CustomButton customButton3;
    }
}
