namespace GUI
{
    partial class frmEnterDigitCode
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
            this.txtNumber6 = new GUI.MyCustomControl.CustomTextBox();
            this.txtNumber5 = new GUI.MyCustomControl.CustomTextBox();
            this.txtNumber4 = new GUI.MyCustomControl.CustomTextBox();
            this.txtNumber3 = new GUI.MyCustomControl.CustomTextBox();
            this.txtNumber2 = new GUI.MyCustomControl.CustomTextBox();
            this.txtNumber1 = new GUI.MyCustomControl.CustomTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.panelContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Silver;
            this.btnSend.BackGroundColor = System.Drawing.Color.Silver;
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
            this.panel6.Controls.Add(this.txtNumber6);
            this.panel6.Controls.Add(this.txtNumber5);
            this.panel6.Controls.Add(this.txtNumber4);
            this.panel6.Controls.Add(this.txtNumber3);
            this.panel6.Controls.Add(this.txtNumber2);
            this.panel6.Controls.Add(this.txtNumber1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 52);
            this.panel6.TabIndex = 12;
            // 
            // txtNumber6
            // 
            this.txtNumber6.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber6.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber6.BorderRadius = 10;
            this.txtNumber6.BorderSize = 2;
            this.txtNumber6.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber6.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber6.Location = new System.Drawing.Point(320, 0);
            this.txtNumber6.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber6.MaxLength = 32767;
            this.txtNumber6.Multiline = false;
            this.txtNumber6.Name = "txtNumber6";
            this.txtNumber6.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber6.PasswordChar = false;
            this.txtNumber6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber6.PlaceholderText = "";
            this.txtNumber6.Size = new System.Drawing.Size(60, 51);
            this.txtNumber6.TabIndex = 18;
            this.txtNumber6.Texts = "";
            this.txtNumber6.UnderlinedStyle = false;
            // 
            // txtNumber5
            // 
            this.txtNumber5.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber5.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber5.BorderRadius = 10;
            this.txtNumber5.BorderSize = 2;
            this.txtNumber5.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber5.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber5.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber5.Location = new System.Drawing.Point(260, 0);
            this.txtNumber5.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber5.MaxLength = 32767;
            this.txtNumber5.Multiline = false;
            this.txtNumber5.Name = "txtNumber5";
            this.txtNumber5.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber5.PasswordChar = false;
            this.txtNumber5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber5.PlaceholderText = "";
            this.txtNumber5.Size = new System.Drawing.Size(60, 51);
            this.txtNumber5.TabIndex = 17;
            this.txtNumber5.Texts = "";
            this.txtNumber5.UnderlinedStyle = false;
            // 
            // txtNumber4
            // 
            this.txtNumber4.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber4.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber4.BorderRadius = 10;
            this.txtNumber4.BorderSize = 2;
            this.txtNumber4.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber4.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber4.Location = new System.Drawing.Point(200, 0);
            this.txtNumber4.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber4.MaxLength = 32767;
            this.txtNumber4.Multiline = false;
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber4.PasswordChar = false;
            this.txtNumber4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber4.PlaceholderText = "";
            this.txtNumber4.Size = new System.Drawing.Size(60, 51);
            this.txtNumber4.TabIndex = 16;
            this.txtNumber4.Texts = "";
            this.txtNumber4.UnderlinedStyle = false;
            // 
            // txtNumber3
            // 
            this.txtNumber3.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber3.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber3.BorderRadius = 10;
            this.txtNumber3.BorderSize = 2;
            this.txtNumber3.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber3.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber3.Location = new System.Drawing.Point(140, 0);
            this.txtNumber3.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber3.MaxLength = 32767;
            this.txtNumber3.Multiline = false;
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber3.PasswordChar = false;
            this.txtNumber3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber3.PlaceholderText = "";
            this.txtNumber3.Size = new System.Drawing.Size(60, 51);
            this.txtNumber3.TabIndex = 15;
            this.txtNumber3.Texts = "";
            this.txtNumber3.UnderlinedStyle = false;
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber2.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber2.BorderRadius = 10;
            this.txtNumber2.BorderSize = 2;
            this.txtNumber2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber2.Location = new System.Drawing.Point(80, 0);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber2.MaxLength = 32767;
            this.txtNumber2.Multiline = false;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber2.PasswordChar = false;
            this.txtNumber2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber2.PlaceholderText = "";
            this.txtNumber2.Size = new System.Drawing.Size(60, 51);
            this.txtNumber2.TabIndex = 14;
            this.txtNumber2.Texts = "";
            this.txtNumber2.UnderlinedStyle = false;
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber1.BorderColor = System.Drawing.Color.Lavender;
            this.txtNumber1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumber1.BorderRadius = 10;
            this.txtNumber1.BorderSize = 2;
            this.txtNumber1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumber1.Location = new System.Drawing.Point(20, 0);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(10);
            this.txtNumber1.MaxLength = 32767;
            this.txtNumber1.Multiline = false;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumber1.PasswordChar = false;
            this.txtNumber1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber1.PlaceholderText = "";
            this.txtNumber1.Size = new System.Drawing.Size(60, 51);
            this.txtNumber1.TabIndex = 13;
            this.txtNumber1.Texts = "";
            this.txtNumber1.UnderlinedStyle = false;
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 35);
            this.panel5.TabIndex = 10;
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
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter digit code";
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
            // frmEnterDigitCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 800);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnterDigitCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panelContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private MyCustomControl.CustomButton btnSend;
        private MyCustomControl.CustomTextBox txtNumber1;
        private MyCustomControl.CustomTextBox txtNumber6;
        private MyCustomControl.CustomTextBox txtNumber5;
        private MyCustomControl.CustomTextBox txtNumber4;
        private MyCustomControl.CustomTextBox txtNumber3;
        private MyCustomControl.CustomTextBox txtNumber2;
    }
}