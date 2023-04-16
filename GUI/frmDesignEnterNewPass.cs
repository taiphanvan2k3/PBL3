using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class frmDesignEnterNewPass : Form
    {

        private bool isValidPassword = false;
        private THONG_TIN_DANG_NHAP_DTO acc;
        private string email;

        public frmDesignEnterNewPass(THONG_TIN_DANG_NHAP_DTO acc, string email)
        {
            InitializeComponent();
            btnDoNotShow.BringToFront();
            btnNotShow2.BringToFront();
            btnContinue.Enabled = isValidPassword;
            this.acc = acc;
            this.email = email;
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

        private void txtNewPass__TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPass.Texts.ToString();
            isValidPassword = Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$");
            if (isValidPassword)
            {
                // Chuỗi mật khẩu hợp lệ
                txtNewPass.ForeColor = Color.Silver; // Đổi màu chữ thành Bạc
            }
            else
            {
                // Chuỗi mật khẩu không hợp lệ
                txtNewPass.ForeColor = Color.Red; // Đổi màu chữ thành đỏ
            }
        }

       
        private void txtConfirmPass__TextChanged(object sender, EventArgs e)
        {
            string password = txtNewPass.Texts.ToString();
            isValidPassword = txtConfirmPass.Texts.ToString().Equals(password);
            if (isValidPassword)
            {
                // Chuỗi mật khẩu xác nhận hợp lệ với chuỗi trên
                txtConfirmPass.ForeColor = Color.Silver; // Đổi màu chữ thành Bạc
            }
            else
            {
                // Chuỗi mật khẩu không hợp lệ
                txtConfirmPass.ForeColor = Color.Red; // Đổi màu chữ thành đỏ
            }
            btnContinue.Enabled = isValidPassword;

        }

        #region Ẩn hiện passsword
        private void btnDoNotShow_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar)
            {
                btnShow.BringToFront();
                txtNewPass.PasswordChar = false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!txtNewPass.PasswordChar)
            {
                btnDoNotShow.BringToFront();
                txtNewPass.PasswordChar = true;
            }
        }
        private void btnShow1_Click(object sender, EventArgs e)
        {
            if (!txtConfirmPass.PasswordChar)
            {
                btnNotShow2.BringToFront();
                txtConfirmPass.PasswordChar = true;
            }
        }

        private void btnNotShow2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar)
            {
                btnShow1.BringToFront();
                txtConfirmPass.PasswordChar = false;
            }
        }
        #endregion
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (ForgetPass_BLL.Instance.updatePass(acc.TaiKhoan, txtNewPass.Texts.ToString()))
            {
                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công!\nQuay trở lại trang chủ để tiến hành đăng nhập!");
                ForgetPass_BLL.Instance.resetVerification_BLL(email);
                UtilityClass.OpenNewForm(this, new frmDesignLogin());
            }
            else
            {
                MessageBox.Show("Bạn đã thay đổi mật khẩu không thành công");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }
    }
}
