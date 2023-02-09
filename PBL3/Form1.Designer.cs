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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.testControl1 = new WindowsFormsApp1.Controls.TestControl();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 40;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // testControl1
            // 
            this.testControl1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.testControl1.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.testControl1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.testControl1.BorderRadius = 40;
            this.testControl1.BorderSecondColor = System.Drawing.Color.BlueViolet;
            this.testControl1.BorderSize = 0;
            this.testControl1.FlatAppearance.BorderSize = 0;
            this.testControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testControl1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.testControl1.Location = new System.Drawing.Point(189, 62);
            this.testControl1.Name = "testControl1";
            this.testControl1.Size = new System.Drawing.Size(150, 40);
            this.testControl1.TabIndex = 2;
            this.testControl1.Text = "testControl1";
            this.testControl1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.testControl1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testControl1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApp1.Controls.CustomButton customButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private WindowsFormsApp1.Controls.TestControl testControl1;
    }
}

