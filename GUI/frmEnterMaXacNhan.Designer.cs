namespace GUI
{
    partial class frmEnterMaXacNhan
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
            this.btnSend = new GUI.MyCustomControl.CustomButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEmail = new GUI.MyCustomControl.CustomTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.panelContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(193)))));
            this.btnSend.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(193)))));
            this.btnSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnSend.BorderRadius = 15;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Location = new System.Drawing.Point(20, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(360, 58);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel11);
            this.panelContainer.Controls.Add(this.panel10);
            this.panelContainer.Controls.Add(this.panel6);
            this.panelContainer.Controls.Add(this.panel5);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panel4);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(400, 800);
            this.panelContainer.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.btnSend);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 245);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(400, 60);
            this.panel11.TabIndex = 27;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(380, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(20, 60);
            this.panel13.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(20, 60);
            this.panel12.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 217);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 28);
            this.panel10.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 52);
            this.panel6.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.Lavender;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(20, 0);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(360, 51);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(380, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 52);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 52);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 35);
            this.panel5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(135, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter 6 digit code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 60);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reset Password";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 30);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Back";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 30;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEnterMaXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 800);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnterMaXacNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panelContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private MyCustomControl.CustomTextBox txtEmail;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private MyCustomControl.CustomButton btnSend;
    }
}