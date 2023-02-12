namespace PBL3.GUI
{
    partial class Form01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTaiKhoan = new System.Windows.Forms.Label();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.customButton1 = new PBL3.MyCustomControl.CustomButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // labelTaiKhoan
            // 
            this.labelTaiKhoan.AutoSize = true;
            this.labelTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaiKhoan.Location = new System.Drawing.Point(151, 111);
            this.labelTaiKhoan.Name = "labelTaiKhoan";
            this.labelTaiKhoan.Size = new System.Drawing.Size(99, 28);
            this.labelTaiKhoan.TabIndex = 7;
            this.labelTaiKhoan.Text = "Tài khoản";
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.Location = new System.Drawing.Point(152, 191);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(98, 28);
            this.labelMatKhau.TabIndex = 8;
            this.labelMatKhau.Text = "Mật khẩu";
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
            this.customButton1.Location = new System.Drawing.Point(353, 253);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Đăng nhập";
            this.customButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.labelTaiKhoan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "Form01";
            this.Text = "Form01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomControl.CustomButton customButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelTaiKhoan;
        private System.Windows.Forms.Label labelMatKhau;
    }
}