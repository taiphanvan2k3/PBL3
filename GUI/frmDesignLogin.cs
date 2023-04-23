using BLL;
using GUI.MyCustomControl;
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
    public partial class frmDesignLogin : Form
    {

        public static DataRow dataUser = null;
        Form frm = null;

        public frmDesignLogin()
        {
            InitializeComponent();
            btnSignIn.Enabled = false;
        }


        private void frmDesignLogin_Load(object sender, EventArgs e)
        {
            // Đặt thuộc tính KeyPreview của form thành true
            this.KeyPreview = true;
        }


        private void Login()
        {
            var account = ValidLogin_BLL.Instance.CheckUsername(txtUsername.Texts);
            if (account == null)
                CustomMessageBox.Show("Tài khoản không tồn tại.");
            else
            {
                var accountValid = ValidLogin_BLL.Instance.login(txtUsername.Texts, txtPassword.Texts);
                if (accountValid != null)
                {
                    if (account.VaiTro == "Giáo viên")
                    {
                        //102BK0001 123456
                        CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Giảng viên");
                        frm = new frmTeacher(txtUsername.Texts);
                    }
                    else if (account.VaiTro == "Sinh Viên")
                    {
                        //101190001 123Abc
                        //101180002 123457
                        //101180003 123458
                        CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Sinh viên");
                        frm = new frmStudent(account.TaiKhoan);
                    }
                    else
                    {
                        CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Quản trị viên");
                        frm = new frmAdmin();
                    }
                    UtilityClass.OpenNewForm(this, frm);
                }
                else CustomMessageBox.Show("Mật khẩu không chính xác.", "Lỗi");
            }
        }
        private void frmDesignLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là phím Enter và control đang được focus là username hoặc password
            if (e.KeyCode == Keys.Enter && (txtUsername.Focused || txtPassword.Focused))
            {
                // Thực hiện hành động đăng nhập
                Login();
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }




        #region Xử lý button quên mật khẩu
        private void btnForgetPass_MouseHover(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Underline);
            btnForgetPass.ForeColor = Color.HotPink;
        }

        private void btnForgetPass_MouseLeave(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Regular);
            btnForgetPass.ForeColor = Color.White;
        }
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignFindAcc());
        }

        #endregion

        #region Di chuyển form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region Kiểm tra xem textbox đã được nhập đủ thông tin hay chưa
        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            CheckIfBothTextBoxesHaveText();

        }
        private void txtUsername__TextChanged(object sender, EventArgs e)
        {
            CheckIfBothTextBoxesHaveText();
        }

        // Kiểm tra xem 2 ô textbox đã được nhập hay chưa
        private void CheckIfBothTextBoxesHaveText()
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Texts) && !string.IsNullOrWhiteSpace(txtPassword.Texts))
            {
                btnSignIn.Enabled = true;
            }
            else
            {
                btnSignIn.Enabled = false;
            }
        }
        #endregion





    }
}
