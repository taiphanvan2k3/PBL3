namespace GUI.MyUserControls
{
    partial class UC_SendNoticeToModuleClass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbLHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTieuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNoiDung = new GUI.MyCustomControl.CustomTextBox();
            this.btnLamMoi = new GUI.MyCustomControl.CustomButton();
            this.btnGui = new GUI.MyCustomControl.CustomButton();
            this.SuspendLayout();
            // 
            // cbbLHP
            // 
            this.cbbLHP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLHP.BorderRadius = 8;
            this.cbbLHP.BorderThickness = 2;
            this.cbbLHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLHP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLHP.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbbLHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLHP.ItemHeight = 30;
            this.cbbLHP.Items.AddRange(new object[] {
            "Danh sách LHP"});
            this.cbbLHP.Location = new System.Drawing.Point(131, 50);
            this.cbbLHP.Name = "cbbLHP";
            this.cbbLHP.Size = new System.Drawing.Size(176, 36);
            this.cbbLHP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // tbTieuDe
            // 
            this.tbTieuDe.BorderRadius = 10;
            this.tbTieuDe.BorderThickness = 2;
            this.tbTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTieuDe.DefaultText = "Tiêu đề";
            this.tbTieuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTieuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTieuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTieuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTieuDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTieuDe.ForeColor = System.Drawing.Color.Silver;
            this.tbTieuDe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTieuDe.Location = new System.Drawing.Point(306, 110);
            this.tbTieuDe.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTieuDe.Name = "tbTieuDe";
            this.tbTieuDe.PasswordChar = '\0';
            this.tbTieuDe.PlaceholderText = "";
            this.tbTieuDe.SelectedText = "";
            this.tbTieuDe.Size = new System.Drawing.Size(623, 38);
            this.tbTieuDe.TabIndex = 3;
            this.tbTieuDe.Enter += new System.EventHandler(this.tbTieuDe_Enter);
            this.tbTieuDe.Leave += new System.EventHandler(this.tbTieuDe_Leave);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.BackColor = System.Drawing.SystemColors.Window;
            this.tbNoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.tbNoiDung.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.tbNoiDung.BorderRadius = 15;
            this.tbNoiDung.BorderSize = 2;
            this.tbNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.ForeColor = System.Drawing.Color.Silver;
            this.tbNoiDung.Location = new System.Drawing.Point(306, 187);
            this.tbNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbNoiDung.MaxLength = 32767;
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Padding = new System.Windows.Forms.Padding(7, 10, 7, 7);
            this.tbNoiDung.PasswordChar = false;
            this.tbNoiDung.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNoiDung.PlaceholderText = "";
            this.tbNoiDung.Size = new System.Drawing.Size(623, 301);
            this.tbNoiDung.TabIndex = 7;
            this.tbNoiDung.Texts = "Nội dung";
            this.tbNoiDung.UnderlinedStyle = false;
            this.tbNoiDung.Enter += new System.EventHandler(this.tbNoiDung_Enter);
            this.tbNoiDung.Leave += new System.EventHandler(this.tbNoiDung_Leave);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Black;
            this.btnLamMoi.BackGroundColor = System.Drawing.Color.Black;
            this.btnLamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLamMoi.BorderRadius = 20;
            this.btnLamMoi.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamMoi.Location = new System.Drawing.Point(766, 515);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 40);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGui.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGui.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGui.BorderRadius = 20;
            this.btnGui.BorderSize = 0;
            this.btnGui.FlatAppearance.BorderSize = 0;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGui.Location = new System.Drawing.Point(347, 515);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(125, 40);
            this.btnGui.TabIndex = 5;
            this.btnGui.Text = "Gửi";
            this.btnGui.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // UC_SendNoticeToModuleClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.tbTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLHP);
            this.Name = "UC_SendNoticeToModuleClass";
            this.Size = new System.Drawing.Size(1119, 663);
            this.Load += new System.EventHandler(this.UC_SendAnnounceToModuleClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbLHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbTieuDe;
        private MyCustomControl.CustomButton btnGui;
        private MyCustomControl.CustomButton btnLamMoi;
        private MyCustomControl.CustomTextBox tbNoiDung;
    }
}
