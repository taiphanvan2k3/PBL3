namespace GUI
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemRoot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemThanNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLichHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTKB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKqHocTap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRoot2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.UC_StudentInfo = new GUI.MyUserControls.uC_StudentInfo();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRoot1,
            this.menuItemRoot2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemRoot1
            // 
            this.menuItemRoot1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemThanNhan,
            this.menuItemLichHoc,
            this.menuItemTKB,
            this.menuItemKqHocTap});
            this.menuItemRoot1.ForeColor = System.Drawing.Color.Black;
            this.menuItemRoot1.Name = "menuItemRoot1";
            this.menuItemRoot1.Size = new System.Drawing.Size(76, 24);
            this.menuItemRoot1.Text = "Cá nhân";
            this.menuItemRoot1.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.menuItemRoot1.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // MenuItemThanNhan
            // 
            this.MenuItemThanNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuItemThanNhan.Name = "MenuItemThanNhan";
            this.MenuItemThanNhan.Size = new System.Drawing.Size(224, 26);
            this.MenuItemThanNhan.Text = "Thông tin nhân thân";
            this.MenuItemThanNhan.Click += new System.EventHandler(this.MenuItemThanNhan_Click);
            this.MenuItemThanNhan.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.MenuItemThanNhan.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // menuItemLichHoc
            // 
            this.menuItemLichHoc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuItemLichHoc.Name = "menuItemLichHoc";
            this.menuItemLichHoc.Size = new System.Drawing.Size(224, 26);
            this.menuItemLichHoc.Text = "Lịch học trong ngày";
            this.menuItemLichHoc.Click += new System.EventHandler(this.menuItemLichHoc_Click);
            this.menuItemLichHoc.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.menuItemLichHoc.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // menuItemTKB
            // 
            this.menuItemTKB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuItemTKB.Name = "menuItemTKB";
            this.menuItemTKB.Size = new System.Drawing.Size(224, 26);
            this.menuItemTKB.Text = "Thời khoá biểu";
            this.menuItemTKB.Click += new System.EventHandler(this.menuItemTKB_Click);
            // 
            // menuItemKqHocTap
            // 
            this.menuItemKqHocTap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuItemKqHocTap.Name = "menuItemKqHocTap";
            this.menuItemKqHocTap.Size = new System.Drawing.Size(224, 26);
            this.menuItemKqHocTap.Text = "Kết quả học tập";
            this.menuItemKqHocTap.Click += new System.EventHandler(this.menuItemKqHocTap_Click);
            this.menuItemKqHocTap.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.menuItemKqHocTap.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // menuItemRoot2
            // 
            this.menuItemRoot2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDanhSach});
            this.menuItemRoot2.ForeColor = System.Drawing.Color.Black;
            this.menuItemRoot2.Name = "menuItemRoot2";
            this.menuItemRoot2.Size = new System.Drawing.Size(48, 24);
            this.menuItemRoot2.Text = "Lớp";
            this.menuItemRoot2.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.menuItemRoot2.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // menuItemDanhSach
            // 
            this.menuItemDanhSach.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuItemDanhSach.Name = "menuItemDanhSach";
            this.menuItemDanhSach.Size = new System.Drawing.Size(221, 26);
            this.menuItemDanhSach.Text = "Danh sách sinh viên";
            this.menuItemDanhSach.Click += new System.EventHandler(this.menuItemDanhSachSV_Click);
            this.menuItemDanhSach.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.menuItemDanhSach.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.UC_StudentInfo);
            this.panel.Location = new System.Drawing.Point(0, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1240, 520);
            this.panel.TabIndex = 1;
            // 
            // UC_StudentInfo
            // 
            this.UC_StudentInfo.Location = new System.Drawing.Point(3, 0);
            this.UC_StudentInfo.Name = "UC_StudentInfo";
            this.UC_StudentInfo.Size = new System.Drawing.Size(1218, 990);
            this.UC_StudentInfo.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1240, 560);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemRoot1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThanNhan;
        private System.Windows.Forms.ToolStripMenuItem menuItemLichHoc;
        private System.Windows.Forms.ToolStripMenuItem menuItemKqHocTap;
        private System.Windows.Forms.ToolStripMenuItem menuItemRoot2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhSach;
        private System.Windows.Forms.Panel panel;
        private MyUserControls.uC_StudentInfo UC_StudentInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemTKB;
    }
}