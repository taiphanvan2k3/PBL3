﻿namespace GUI
{
    partial class frmAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelClass = new System.Windows.Forms.Panel();
            this.btnAcitivityClass = new FontAwesome.Sharp.IconButton();
            this.btnClassSection = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnTeacher = new FontAwesome.Sharp.IconButton();
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelClass.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panelClass);
            this.panelMenu.Controls.Add(this.btnClass);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panelAdd);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 673);
            this.panelMenu.TabIndex = 0;
            // 
            // panelClass
            // 
            this.panelClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.panelClass.Controls.Add(this.btnAcitivityClass);
            this.panelClass.Controls.Add(this.btnClassSection);
            this.panelClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClass.Location = new System.Drawing.Point(0, 360);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(250, 121);
            this.panelClass.TabIndex = 15;
            // 
            // btnAcitivityClass
            // 
            this.btnAcitivityClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcitivityClass.FlatAppearance.BorderSize = 0;
            this.btnAcitivityClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcitivityClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcitivityClass.ForeColor = System.Drawing.Color.White;
            this.btnAcitivityClass.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            this.btnAcitivityClass.IconColor = System.Drawing.Color.White;
            this.btnAcitivityClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcitivityClass.IconSize = 30;
            this.btnAcitivityClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcitivityClass.Location = new System.Drawing.Point(0, 60);
            this.btnAcitivityClass.Name = "btnAcitivityClass";
            this.btnAcitivityClass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAcitivityClass.Size = new System.Drawing.Size(250, 60);
            this.btnAcitivityClass.TabIndex = 13;
            this.btnAcitivityClass.Tag = "Lớp sinh hoạt";
            this.btnAcitivityClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcitivityClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcitivityClass.UseVisualStyleBackColor = true;
            // 
            // btnClassSection
            // 
            this.btnClassSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClassSection.FlatAppearance.BorderSize = 0;
            this.btnClassSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassSection.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassSection.ForeColor = System.Drawing.Color.White;
            this.btnClassSection.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            this.btnClassSection.IconColor = System.Drawing.Color.White;
            this.btnClassSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClassSection.IconSize = 30;
            this.btnClassSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassSection.Location = new System.Drawing.Point(0, 0);
            this.btnClassSection.Name = "btnClassSection";
            this.btnClassSection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClassSection.Size = new System.Drawing.Size(250, 60);
            this.btnClassSection.TabIndex = 12;
            this.btnClassSection.Tag = "Lớp học phần";
            this.btnClassSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassSection.UseVisualStyleBackColor = true;
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnClass.IconColor = System.Drawing.Color.White;
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 30;
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 300);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(250, 60);
            this.btnClass.TabIndex = 14;
            this.btnClass.Tag = "Lớp học ";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 30;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 623);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 50);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Tag = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.panelAdd.Controls.Add(this.btnTeacher);
            this.panelAdd.Controls.Add(this.btnStudent);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(0, 180);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(250, 120);
            this.panelAdd.TabIndex = 12;
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btnTeacher.IconColor = System.Drawing.Color.White;
            this.btnTeacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeacher.IconSize = 30;
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(0, 60);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTeacher.Size = new System.Drawing.Size(250, 60);
            this.btnTeacher.TabIndex = 13;
            this.btnTeacher.Tag = "Giảng viên";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnStudent.IconColor = System.Drawing.Color.White;
            this.btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudent.IconSize = 30;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(250, 60);
            this.btnStudent.TabIndex = 12;
            this.btnStudent.Tag = "Sinh viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(250, 60);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Tag = "Tài khoản";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 60);
            this.btnHome.TabIndex = 10;
            this.btnHome.Tag = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 33;
            this.btnMenu.Location = new System.Drawing.Point(190, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnExpandMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._338313717_162862019998089_3577123447925415259_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1012, 673);
            this.panelChildForm.TabIndex = 2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelClass.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelAdd;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton btnStudent;
        private System.Windows.Forms.Panel panelClass;
        private FontAwesome.Sharp.IconButton btnClassSection;
        private FontAwesome.Sharp.IconButton btnTeacher;
        private FontAwesome.Sharp.IconButton btnAcitivityClass;
    }
}