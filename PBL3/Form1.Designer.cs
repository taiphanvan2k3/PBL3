namespace PBL3
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.customButton1 = new WindowsFormsApp1.Controls.CustomButton();
            this.boxCalendar1 = new WindowsFormsApp1.Controls.BoxCalendar();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 74;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.Location = new System.Drawing.Point(466, 72);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(170, 74);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // boxCalendar1
            // 
            this.boxCalendar1.BackColor = System.Drawing.Color.Red;
            this.boxCalendar1.ComponentBackColor = System.Drawing.Color.WhiteSmoke;
            this.boxCalendar1.ComponentForeColor = System.Drawing.Color.Black;
            this.boxCalendar1.Location = new System.Drawing.Point(129, 128);
            this.boxCalendar1.MinimumSize = new System.Drawing.Size(220, 100);
            this.boxCalendar1.Name = "boxCalendar1";
            this.boxCalendar1.Size = new System.Drawing.Size(220, 100);
            this.boxCalendar1.TabIndex = 1;
            this.boxCalendar1.TitleForeColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxCalendar1);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private WindowsFormsApp1.Controls.CustomButton customButton1;
        private WindowsFormsApp1.Controls.BoxCalendar boxCalendar1;
    }
}

