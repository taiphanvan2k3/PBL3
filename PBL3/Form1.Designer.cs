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
            this.customButton1 = new WindowsFormsApp1.Controls.CustomButton();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 66;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.Location = new System.Drawing.Point(432, 141);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(163, 66);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApp1.Controls.CustomButton customButton1;
    }
}

