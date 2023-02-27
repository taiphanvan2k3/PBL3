using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        private UC_DanhSachLopSH lopSH;
        public Home()
        {
            InitializeComponent();
        }


        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.ForeColor = Color.Black;
            item.BackColor = Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
        }

        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            item.ForeColor = Color.Red;
            item.BackColor = Color.White;
        }

        private void MenuItemThanNhan_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(UC_StudentInfo);
        }

        private void menuItemLichHoc_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }

        private void menuItemKqHocTap_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }

        private void menuItemTKB_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }

        private void menuItemDanhSachSV_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (lopSH == null)
            {
                lopSH = new UC_DanhSachLopSH();
                this.lopSH.Size = new System.Drawing.Size(1218, 539);
            }        
            panel.Controls.Add(lopSH);
        }
    }
}
