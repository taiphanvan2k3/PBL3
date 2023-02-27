namespace GUI.MyUserControls
{
    partial class Calendar
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbMonday = new System.Windows.Forms.Label();
            this.lbTuesday = new System.Windows.Forms.Label();
            this.lbThursday = new System.Windows.Forms.Label();
            this.lbWednesday = new System.Windows.Forms.Label();
            this.lbSunday = new System.Windows.Forms.Label();
            this.lbSaturday = new System.Windows.Forms.Label();
            this.lbFriday = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(951, 45);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 24);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previuos";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1096, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 24);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbMonday
            // 
            this.lbMonday.AutoSize = true;
            this.lbMonday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonday.Location = new System.Drawing.Point(49, 94);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.Size = new System.Drawing.Size(92, 27);
            this.lbMonday.TabIndex = 3;
            this.lbMonday.Text = "Monday";
            // 
            // lbTuesday
            // 
            this.lbTuesday.AutoSize = true;
            this.lbTuesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuesday.Location = new System.Drawing.Point(224, 94);
            this.lbTuesday.Name = "lbTuesday";
            this.lbTuesday.Size = new System.Drawing.Size(90, 27);
            this.lbTuesday.TabIndex = 4;
            this.lbTuesday.Text = "Tuesday";
            // 
            // lbThursday
            // 
            this.lbThursday.AutoSize = true;
            this.lbThursday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThursday.Location = new System.Drawing.Point(590, 95);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.Size = new System.Drawing.Size(99, 27);
            this.lbThursday.TabIndex = 6;
            this.lbThursday.Text = "Thursday";
            // 
            // lbWednesday
            // 
            this.lbWednesday.AutoSize = true;
            this.lbWednesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWednesday.Location = new System.Drawing.Point(395, 94);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.Size = new System.Drawing.Size(123, 27);
            this.lbWednesday.TabIndex = 5;
            this.lbWednesday.Text = "Wednesday";
            // 
            // lbSunday
            // 
            this.lbSunday.AutoSize = true;
            this.lbSunday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSunday.Location = new System.Drawing.Point(1140, 95);
            this.lbSunday.Name = "lbSunday";
            this.lbSunday.Size = new System.Drawing.Size(83, 27);
            this.lbSunday.TabIndex = 9;
            this.lbSunday.Text = "Sunday";
            // 
            // lbSaturday
            // 
            this.lbSaturday.AutoSize = true;
            this.lbSaturday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaturday.Location = new System.Drawing.Point(961, 95);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.Size = new System.Drawing.Size(97, 27);
            this.lbSaturday.TabIndex = 8;
            this.lbSaturday.Text = "Saturday";
            // 
            // lbFriday
            // 
            this.lbFriday.AutoSize = true;
            this.lbFriday.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriday.Location = new System.Drawing.Point(789, 95);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.Size = new System.Drawing.Size(71, 27);
            this.lbFriday.TabIndex = 7;
            this.lbFriday.Text = "Friday";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Mistral", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lbDate.Location = new System.Drawing.Point(557, 21);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(241, 56);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "MONTH YEAR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1337, 623);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // Calendar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSunday);
            this.Controls.Add(this.lbSaturday);
            this.Controls.Add(this.lbFriday);
            this.Controls.Add(this.lbThursday);
            this.Controls.Add(this.lbWednesday);
            this.Controls.Add(this.lbTuesday);
            this.Controls.Add(this.lbMonday);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(1382, 767);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbMonday;
        private System.Windows.Forms.Label lbTuesday;
        private System.Windows.Forms.Label lbThursday;
        private System.Windows.Forms.Label lbWednesday;
        private System.Windows.Forms.Label lbSunday;
        private System.Windows.Forms.Label lbSaturday;
        private System.Windows.Forms.Label lbFriday;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
