namespace GUI
{
    partial class frmLogin
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinisize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.circularPictureBox1 = new GUI.MyCustomControl.CircularPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnDoNotShow = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtUsername = new GUI.MyCustomControl.CustomTextBox();
            this.txtPassword = new GUI.MyCustomControl.CustomTextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnForgetPass = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnSignIn = new GUI.MyCustomControl.CustomButton();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTitle.Controls.Add(this.btnMinisize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(400, 40);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // btnMinisize
            // 
            this.btnMinisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinisize.IconColor = System.Drawing.Color.DarkRed;
            this.btnMinisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinisize.IconSize = 30;
            this.btnMinisize.Location = new System.Drawing.Point(320, 0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnMinisize.Size = new System.Drawing.Size(40, 40);
            this.btnMinisize.TabIndex = 10;
            this.btnMinisize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnClose.IconColor = System.Drawing.Color.DarkRed;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(360, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello Again!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome back you\'re";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "been missed";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 72);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.circularPictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 150);
            this.panel3.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(275, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 150);
            this.panel5.TabIndex = 6;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.circularPictureBox1.BorderSize = 5;
            this.circularPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = global::GUI.Properties.Resources._294355517_1105843533621186_1411223748583159430_n;
            this.circularPictureBox1.Location = new System.Drawing.Point(125, 0);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 5;
            this.circularPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 150);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 262);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 10);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 272);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(400, 36);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(113, 36);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 308);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 25);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 333);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 38);
            this.panel10.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 371);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(400, 5);
            this.panel11.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 376);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 35);
            this.panel12.TabIndex = 16;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 411);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(400, 45);
            this.panel17.TabIndex = 18;
            // 
            // btnDoNotShow
            // 
            this.btnDoNotShow.BackColor = System.Drawing.Color.White;
            this.btnDoNotShow.FlatAppearance.BorderSize = 0;
            this.btnDoNotShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoNotShow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNotShow.ForeColor = System.Drawing.Color.White;
            this.btnDoNotShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnDoNotShow.IconColor = System.Drawing.SystemColors.InfoText;
            this.btnDoNotShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoNotShow.IconSize = 30;
            this.btnDoNotShow.Location = new System.Drawing.Point(315, 60);
            this.btnDoNotShow.Name = "btnDoNotShow";
            this.btnDoNotShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDoNotShow.Size = new System.Drawing.Size(40, 35);
            this.btnDoNotShow.TabIndex = 19;
            this.btnDoNotShow.UseVisualStyleBackColor = false;
            this.btnDoNotShow.Click += new System.EventHandler(this.btnDoNotShow_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShow.IconColor = System.Drawing.SystemColors.InfoText;
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShow.IconSize = 30;
            this.btnShow.Location = new System.Drawing.Point(315, 60);
            this.btnShow.Name = "btnShow";
            this.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShow.Size = new System.Drawing.Size(40, 35);
            this.btnShow.TabIndex = 20;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 456);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(400, 101);
            this.panel13.TabIndex = 21;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnShow);
            this.panel16.Controls.Add(this.btnDoNotShow);
            this.panel16.Controls.Add(this.txtUsername);
            this.panel16.Controls.Add(this.txtPassword);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(20, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(360, 101);
            this.panel16.TabIndex = 22;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.Lavender;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.BorderSize = 3;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(360, 51);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.Lavender;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(0, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(360, 51);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(380, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(20, 101);
            this.panel15.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(20, 101);
            this.panel14.TabIndex = 0;
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.AutoSize = true;
            this.btnForgetPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnForgetPass.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.Location = new System.Drawing.Point(243, 0);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(157, 21);
            this.btnForgetPass.TabIndex = 22;
            this.btnForgetPass.Text = "Forgotten password?";
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            this.btnForgetPass.MouseLeave += new System.EventHandler(this.btnForgetPass_MouseLeave);
            this.btnForgetPass.MouseHover += new System.EventHandler(this.btnForgetPass_MouseHover);
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 557);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(400, 20);
            this.panel18.TabIndex = 24;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnForgetPass);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 577);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(400, 22);
            this.panel19.TabIndex = 25;
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 599);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(400, 20);
            this.panel20.TabIndex = 26;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnSignIn);
            this.panel21.Controls.Add(this.panel23);
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 619);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(400, 58);
            this.panel21.TabIndex = 27;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(193)))));
            this.btnSignIn.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(193)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.btnSignIn.BorderRadius = 15;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.Location = new System.Drawing.Point(20, 0);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(360, 58);
            this.btnSignIn.TabIndex = 23;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel23.Location = new System.Drawing.Point(380, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(20, 58);
            this.panel23.TabIndex = 1;
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(20, 58);
            this.panel22.TabIndex = 0;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 677);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(400, 123);
            this.panel24.TabIndex = 28;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 800);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                      ";
            this.panelTitle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnMinisize;
        private FontAwesome.Sharp.IconButton btnClose;
        private MyCustomControl.CustomTextBox txtUsername;
        private MyCustomControl.CustomTextBox txtPassword;
        private MyCustomControl.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel17;
        private FontAwesome.Sharp.IconButton btnDoNotShow;
        private FontAwesome.Sharp.IconButton btnShow;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label btnForgetPass;
        private MyCustomControl.CustomButton btnSignIn;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel24;
    }
}