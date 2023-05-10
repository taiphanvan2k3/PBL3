namespace GUI
{
    partial class frmDesinEnterDigitCode
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnSendBackAgain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberCode = new GUI.MyCustomControl.CustomTextBox();
            this.btnBack = new GUI.MyCustomControl.CustomButton();
            this.btnContinue = new GUI.MyCustomControl.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogin.Controls.Add(this.btnSendBackAgain);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.lbCountdown);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.txtNumberCode);
            this.panelLogin.Controls.Add(this.btnBack);
            this.panelLogin.Controls.Add(this.btnContinue);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(200, 125);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(600, 350);
            this.panelLogin.TabIndex = 0;
            // 
            // btnSendBackAgain
            // 
            this.btnSendBackAgain.AutoSize = true;
            this.btnSendBackAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendBackAgain.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendBackAgain.ForeColor = System.Drawing.Color.White;
            this.btnSendBackAgain.Location = new System.Drawing.Point(26, 293);
            this.btnSendBackAgain.Name = "btnSendBackAgain";
            this.btnSendBackAgain.Size = new System.Drawing.Size(183, 24);
            this.btnSendBackAgain.TabIndex = 32;
            this.btnSendBackAgain.Text = "Chưa nhận được mã?";
            this.btnSendBackAgain.Click += new System.EventHandler(this.btnSendBackAgain_Click);
            this.btnSendBackAgain.MouseLeave += new System.EventHandler(this.btnForgetPass_MouseLeave);
            this.btnSendBackAgain.MouseHover += new System.EventHandler(this.btnForgetPass_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(3, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(538, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "s";
            // 
            // lbCountdown
            // 
            this.lbCountdown.AutoSize = true;
            this.lbCountdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCountdown.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbCountdown.Location = new System.Drawing.Point(492, 184);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(0, 24);
            this.lbCountdown.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(303, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã còn hiệu lực sau:";
            // 
            // txtNumberCode
            // 
            this.txtNumberCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNumberCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNumberCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNumberCode.BorderRadius = 10;
            this.txtNumberCode.BorderSize = 2;
            this.txtNumberCode.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumberCode.Location = new System.Drawing.Point(30, 169);
            this.txtNumberCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumberCode.MaxLength = 6;
            this.txtNumberCode.Multiline = false;
            this.txtNumberCode.Name = "txtNumberCode";
            this.txtNumberCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumberCode.PasswordChar = false;
            this.txtNumberCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumberCode.PlaceholderText = "Nhập mã";
            this.txtNumberCode.Size = new System.Drawing.Size(254, 53);
            this.txtNumberCode.TabIndex = 28;
            this.txtNumberCode.Texts = "";
            this.txtNumberCode.UnderlinedStyle = false;
            this.txtNumberCode._TextChanged += new System.EventHandler(this.txtNumberCode__TextChanged);
            this.txtNumberCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOnlyAllowNumeric);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackGroundColor = System.Drawing.Color.Silver;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnBack.BorderRadius = 40;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(319, 276);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 50);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Hủy";
            this.btnBack.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnContinue.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btnContinue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnContinue.BorderRadius = 40;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.Location = new System.Drawing.Point(432, 276);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 50);
            this.btnContinue.TabIndex = 25;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã này gồm 6 số.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vui lòng kiểm tra mã trong email của bạn.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(3, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 1);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã bảo mật";
            // 
            // frmDesinEnterDigitCode
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::GUI.Properties.Resources.backroud1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDesinEnterDigitCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDesignLogin";
            this.Load += new System.EventHandler(this.frmDesinEnterDigitCode_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MyCustomControl.CustomButton btnBack;
        private MyCustomControl.CustomButton btnContinue;
        private MyCustomControl.CustomTextBox txtNumberCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnSendBackAgain;
    }
}