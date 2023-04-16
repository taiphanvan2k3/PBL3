namespace GUI
{
    partial class frmCreateClassSection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new GUI.MyCustomControl.CustomButton();
            this.btnAddSV = new GUI.MyCustomControl.CustomButton();
            this.btnAssignGV = new GUI.MyCustomControl.CustomButton();
            this.tbMaHP = new GUI.MyCustomControl.CustomTextBox();
            this.tbTenMH = new GUI.MyCustomControl.CustomTextBox();
            this.tbTietBD = new GUI.MyCustomControl.CustomTextBox();
            this.tbTietKT = new GUI.MyCustomControl.CustomTextBox();
            this.tbThu = new GUI.MyCustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiết bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiết kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thứ";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnCreate.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnCreate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreate.BorderRadius = 40;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(320, 374);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAddSV.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAddSV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddSV.BorderRadius = 40;
            this.btnAddSV.BorderSize = 0;
            this.btnAddSV.FlatAppearance.BorderSize = 0;
            this.btnAddSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSV.Location = new System.Drawing.Point(561, 280);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(150, 40);
            this.btnAddSV.TabIndex = 6;
            this.btnAddSV.Text = "Thêm SV";
            this.btnAddSV.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // btnAssignGV
            // 
            this.btnAssignGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAssignGV.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(173)))));
            this.btnAssignGV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAssignGV.BorderRadius = 40;
            this.btnAssignGV.BorderSize = 0;
            this.btnAssignGV.FlatAppearance.BorderSize = 0;
            this.btnAssignGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignGV.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAssignGV.Location = new System.Drawing.Point(561, 155);
            this.btnAssignGV.Name = "btnAssignGV";
            this.btnAssignGV.Size = new System.Drawing.Size(150, 40);
            this.btnAssignGV.TabIndex = 7;
            this.btnAssignGV.Text = "Phân công GV";
            this.btnAssignGV.TextColor = System.Drawing.SystemColors.Window;
            this.btnAssignGV.UseVisualStyleBackColor = false;
            this.btnAssignGV.Click += new System.EventHandler(this.btnAssignGV_Click);
            // 
            // tbMaHP
            // 
            this.tbMaHP.BackColor = System.Drawing.SystemColors.Window;
            this.tbMaHP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbMaHP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMaHP.BorderRadius = 8;
            this.tbMaHP.BorderSize = 2;
            this.tbMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHP.ForeColor = System.Drawing.Color.DimGray;
            this.tbMaHP.Location = new System.Drawing.Point(173, 40);
            this.tbMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHP.MaxLength = 32767;
            this.tbMaHP.Multiline = false;
            this.tbMaHP.Name = "tbMaHP";
            this.tbMaHP.Padding = new System.Windows.Forms.Padding(7);
            this.tbMaHP.PasswordChar = false;
            this.tbMaHP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbMaHP.PlaceholderText = "";
            this.tbMaHP.Size = new System.Drawing.Size(211, 35);
            this.tbMaHP.TabIndex = 8;
            this.tbMaHP.Texts = "";
            this.tbMaHP.UnderlinedStyle = false;
            // 
            // tbTenMH
            // 
            this.tbTenMH.BackColor = System.Drawing.SystemColors.Window;
            this.tbTenMH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTenMH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTenMH.BorderRadius = 8;
            this.tbTenMH.BorderSize = 2;
            this.tbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMH.ForeColor = System.Drawing.Color.DimGray;
            this.tbTenMH.Location = new System.Drawing.Point(173, 100);
            this.tbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenMH.MaxLength = 32767;
            this.tbTenMH.Multiline = false;
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Padding = new System.Windows.Forms.Padding(7);
            this.tbTenMH.PasswordChar = false;
            this.tbTenMH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTenMH.PlaceholderText = "";
            this.tbTenMH.Size = new System.Drawing.Size(211, 35);
            this.tbTenMH.TabIndex = 9;
            this.tbTenMH.Texts = "";
            this.tbTenMH.UnderlinedStyle = false;
            // 
            // tbTietBD
            // 
            this.tbTietBD.BackColor = System.Drawing.SystemColors.Window;
            this.tbTietBD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTietBD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTietBD.BorderRadius = 8;
            this.tbTietBD.BorderSize = 2;
            this.tbTietBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTietBD.ForeColor = System.Drawing.Color.DimGray;
            this.tbTietBD.Location = new System.Drawing.Point(173, 160);
            this.tbTietBD.Margin = new System.Windows.Forms.Padding(4);
            this.tbTietBD.MaxLength = 32767;
            this.tbTietBD.Multiline = false;
            this.tbTietBD.Name = "tbTietBD";
            this.tbTietBD.Padding = new System.Windows.Forms.Padding(7);
            this.tbTietBD.PasswordChar = false;
            this.tbTietBD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTietBD.PlaceholderText = "";
            this.tbTietBD.Size = new System.Drawing.Size(211, 35);
            this.tbTietBD.TabIndex = 10;
            this.tbTietBD.Texts = "";
            this.tbTietBD.UnderlinedStyle = false;
            // 
            // tbTietKT
            // 
            this.tbTietKT.BackColor = System.Drawing.SystemColors.Window;
            this.tbTietKT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbTietKT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbTietKT.BorderRadius = 8;
            this.tbTietKT.BorderSize = 2;
            this.tbTietKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTietKT.ForeColor = System.Drawing.Color.DimGray;
            this.tbTietKT.Location = new System.Drawing.Point(173, 220);
            this.tbTietKT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTietKT.MaxLength = 32767;
            this.tbTietKT.Multiline = false;
            this.tbTietKT.Name = "tbTietKT";
            this.tbTietKT.Padding = new System.Windows.Forms.Padding(7);
            this.tbTietKT.PasswordChar = false;
            this.tbTietKT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbTietKT.PlaceholderText = "";
            this.tbTietKT.Size = new System.Drawing.Size(211, 35);
            this.tbTietKT.TabIndex = 11;
            this.tbTietKT.Texts = "";
            this.tbTietKT.UnderlinedStyle = false;
            // 
            // tbThu
            // 
            this.tbThu.BackColor = System.Drawing.SystemColors.Window;
            this.tbThu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbThu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbThu.BorderRadius = 8;
            this.tbThu.BorderSize = 2;
            this.tbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThu.ForeColor = System.Drawing.Color.DimGray;
            this.tbThu.Location = new System.Drawing.Point(173, 280);
            this.tbThu.Margin = new System.Windows.Forms.Padding(4);
            this.tbThu.MaxLength = 32767;
            this.tbThu.Multiline = false;
            this.tbThu.Name = "tbThu";
            this.tbThu.Padding = new System.Windows.Forms.Padding(7);
            this.tbThu.PasswordChar = false;
            this.tbThu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbThu.PlaceholderText = "";
            this.tbThu.Size = new System.Drawing.Size(211, 35);
            this.tbThu.TabIndex = 12;
            this.tbThu.Texts = "";
            this.tbThu.UnderlinedStyle = false;
            // 
            // frmCreateClassSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbThu);
            this.Controls.Add(this.tbTietKT);
            this.Controls.Add(this.tbTietBD);
            this.Controls.Add(this.tbTenMH);
            this.Controls.Add(this.tbMaHP);
            this.Controls.Add(this.btnAssignGV);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateClassSection";
            this.Text = "CreateClassSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MyCustomControl.CustomButton btnCreate;
        private MyCustomControl.CustomButton btnAddSV;
        private MyCustomControl.CustomButton btnAssignGV;
        private MyCustomControl.CustomTextBox tbMaHP;
        private MyCustomControl.CustomTextBox tbTenMH;
        private MyCustomControl.CustomTextBox tbTietBD;
        private MyCustomControl.CustomTextBox tbTietKT;
        private MyCustomControl.CustomTextBox tbThu;
    }
}