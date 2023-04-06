namespace GUI
{
    partial class frmCheckEmail
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
            GUI.MyCustomControl.CustomButton btnOpenEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckEmail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinisize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            btnOpenEmail = new GUI.MyCustomControl.CustomButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenEmail
            // 
            btnOpenEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(192)))), ((int)(((byte)(244)))));
            btnOpenEmail.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(192)))), ((int)(((byte)(244)))));
            btnOpenEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            btnOpenEmail.BorderRadius = 15;
            btnOpenEmail.BorderSize = 0;
            btnOpenEmail.FlatAppearance.BorderSize = 0;
            btnOpenEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenEmail.ForeColor = System.Drawing.SystemColors.Window;
            btnOpenEmail.Location = new System.Drawing.Point(20, 0);
            btnOpenEmail.Name = "btnOpenEmail";
            btnOpenEmail.Size = new System.Drawing.Size(360, 58);
            btnOpenEmail.TabIndex = 25;
            btnOpenEmail.Text = "Open email";
            btnOpenEmail.TextColor = System.Drawing.SystemColors.Window;
            btnOpenEmail.UseVisualStyleBackColor = false;
            btnOpenEmail.Click += new System.EventHandler(this.btnOpenEmail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnMinisize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 125);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 125);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(300, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 125);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 125);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check your email";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 30);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 320);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(400, 60);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 380);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 90);
            this.panel8.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(96, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "instructions to your email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "We have sent a password recover";
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSize = true;
            this.btnSkip.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btnSkip.Location = new System.Drawing.Point(113, 0);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(173, 21);
            this.btnSkip.TabIndex = 26;
            this.btnSkip.Text = "Skip, I\'ll confirm later";
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            this.btnSkip.MouseLeave += new System.EventHandler(this.btnSkip_MouseLeave);
            this.btnSkip.MouseHover += new System.EventHandler(this.btnSkip_MouseHover);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(btnOpenEmail);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 470);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 60);
            this.panel9.TabIndex = 27;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(380, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(20, 60);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 60);
            this.panel10.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 530);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 40);
            this.panel12.TabIndex = 28;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnSkip);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 570);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(400, 21);
            this.panel13.TabIndex = 29;
            // 
            // frmCheckEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 800);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckEmail";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinisize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnSkip;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}