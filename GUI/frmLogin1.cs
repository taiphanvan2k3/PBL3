using BLL;
using GUI.MyCustomControl;
using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {

            InitializeComponent();
            btnDoNotShow.BringToFront();
        }

        // Custom Minisize and Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ẩn hiện pasword
        private void btnDoNotShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar)
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(!txtPassword.PasswordChar)
            {
                btnDoNotShow.BringToFront();
                txtPassword.PasswordChar = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
            btnDoNotShow.BringToFront();
        }
        // Nút quên mật khẩu
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            frmForgetPass f = new frmForgetPass();
            f.ShowDialog();
            this.Close();
        }

        private void btnForgetPass_MouseHover(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Underline);
            btnForgetPass.ForeColor = Color.HotPink;
        }

        private void btnForgetPass_MouseLeave(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Regular);
            btnForgetPass.ForeColor = Color.Black;
        }
        // Đăng nhập
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts.ToString() == "" || txtPassword.Texts.ToString() == "")
            {
                MessageBox.Show("Please fill in at least one field\r\nFill in at least one field to search for your account");
            }
            else
            {
                CheckLoginBLL checkLoginBLL = new CheckLoginBLL();
                int count = checkLoginBLL.Check(txtUsername.Texts.ToString(), txtPassword.Texts.ToString());
                switch (count)
                {
                    case -1:
                        MessageBox.Show("Check your username and password");
                        break;
                    case 0:
                        MessageBox.Show("Đăng nhập với tư cách giáo viên");
                        break;
                    case 1:
                        MessageBox.Show("Đăng nhập với tư cách sinh viên");
                        break;

                }
            }
        }


    }
}
