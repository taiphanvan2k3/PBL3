using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_EditTeacher : UserControl
    {
        public UC_EditTeacher()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            int x = pnlMenu.Width;
            if(pnlMenu.Width >= 149)
            {
                //for(int i = 150;i > 60;i--)
                //    pnlMenu.Width = i;
                pnlMenu.Width = 60;
                foreach (var btn in pnlMenu.Controls.OfType<Button>())
                    btn.Text = string.Empty;
            }
            else
            {
                //for (int i = 60; i < 150; i++)
                //    pnlMenu.Width = i;
                pnlMenu.Width = 150;
                bool check = true;
                foreach (var btn in pnlMenu.Controls.OfType<Button>().Where(a=>a.Name != "btnMenu"))
                {
                    // Có một số sự cố nên mình mới đặt biến check kiểm tra ntn, do vòng lặp foreach bắt đầu từ "Exit" nhưng nó lại lặp lại 
                    // "Exit" lần 2 nên mới phải đặt đk kiểm tra Tag của btn == "Home" ( là btn cuối trong vòng lặp trước khi lặp lại exit) 
                    // [Đình Mạnh] viết nên có gì muốn thêm button thì chỉnh lại theo cách như trên. Nhớ dùng debug để kiểm tra.
                    if(!check && btn.Tag.ToString() == "Home")
                    {
                        btn.Text = btn.Tag.ToString();
                        break;
                    }
                    btn.Text = btn.Tag.ToString();
                    if (btn.Tag.ToString() == "Exit")
                        check = false; 
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
