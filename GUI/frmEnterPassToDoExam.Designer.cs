namespace GUI
{
    partial class frmEnterPassToDoExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterPassToDoExam));
            this.label1 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnShowPass = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.customButton2 = new GUI.MyCustomControl.CustomButton();
            this.btnLamBai = new GUI.MyCustomControl.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu bài kiểm tra";
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(12, 44);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(672, 1);
            this.separator.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(119, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(29, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(589, 37);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShowPass.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPass.IconSize = 35;
            this.btnShowPass.Location = new System.Drawing.Point(618, 97);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(49, 31);
            this.btnShowPass.TabIndex = 7;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(639, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Crimson;
            this.customButton2.BackGroundColor = System.Drawing.Color.Crimson;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 25;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.Location = new System.Drawing.Point(168, 153);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(91, 40);
            this.customButton2.TabIndex = 10;
            this.customButton2.Text = "Thoát";
            this.customButton2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLamBai
            // 
            this.btnLamBai.BackColor = System.Drawing.Color.Blue;
            this.btnLamBai.BackGroundColor = System.Drawing.Color.Blue;
            this.btnLamBai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLamBai.BorderRadius = 25;
            this.btnLamBai.BorderSize = 0;
            this.btnLamBai.FlatAppearance.BorderSize = 0;
            this.btnLamBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamBai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamBai.Location = new System.Drawing.Point(29, 153);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(107, 40);
            this.btnLamBai.TabIndex = 9;
            this.btnLamBai.Text = "Làm bài";
            this.btnLamBai.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamBai.UseVisualStyleBackColor = false;
            this.btnLamBai.Click += new System.EventHandler(this.btnLamBai_Click);
            // 
            // frmEnterPassToDoExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(691, 221);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.btnLamBai);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEnterPassToDoExam";
            this.Text = "frmEnterPassToDoExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private FontAwesome.Sharp.IconButton btnShowPass;
        private FontAwesome.Sharp.IconButton btnClose;
        private MyCustomControl.CustomButton btnLamBai;
        private MyCustomControl.CustomButton customButton2;
    }
}