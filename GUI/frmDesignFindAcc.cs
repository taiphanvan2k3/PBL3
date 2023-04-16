using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDesignFindAcc : Form
    {
        public frmDesignFindAcc()
        {
            InitializeComponent();
            btnSend.Enabled = false; // Không cho phép nhấn nút
            this.ActiveControl = label1;

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSend_Click(object sender, EventArgs e)

        {
            if (txtEmail.Texts.ToString() == "")
            {
                lbMessagebox.Text = "Vui lòng không bỏ trống!!!";
                lbMessagebox.Visible = true;
            }
            else
            {
                var acc = ForgetPass_BLL.Instance.ResetPasswordByEmail(txtEmail.Texts.ToString());
                if (acc == null)
                {
                    lbMessagebox.Text = "Không tìm thấy tài khoản!!!";
                    lbMessagebox.Visible = true;
                }
                else
                {
                    UtilityClass.OpenNewForm(this, new frmDesinEnterDigitCode(acc, txtEmail.Texts.ToString()));
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            string input = txtEmail.Texts.ToString();
            if (input.Contains("@emailling.xyz"))
            {
                // chuỗi có chứa "@email.com"
                btnSend.Enabled = true; // Cho phép nhấn nút
            }
            else
            {
                btnSend.Enabled = false;
            }
        }
    }
}
