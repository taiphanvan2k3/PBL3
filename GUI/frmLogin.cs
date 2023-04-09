using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //2 button nằm cùng 1 vị trí nhưng ban đầu cho buttonDoNotShow lên trước nên mới dùng BringToFont 
            btnDoNotShow.BringToFront();
        }

        public static DataRow dataUser = null;

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
            if (!txtPassword.PasswordChar)
            {
                btnDoNotShow.BringToFront();
                txtPassword.PasswordChar = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            //Edit:2/3/2023 by Tai
            //Khi bấm vào lại textbox username thì ẩn mật khẩu đi
            //và hiện tại btnShow nằm chồng lên btnDoNotShow nên phải mang nó lên trước 
            txtPassword.PasswordChar = true;
            btnDoNotShow.BringToFront();
        }
        // Nút quên mật khẩu
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            frmForgetPass f = new frmForgetPass();
            this.Visible = false;
            f.ShowDialog();
            this.Dispose();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts.ToString() == "" || txtPassword.Texts.ToString() == "")
            {
                MessageBox.Show("Please fill in at least one field\r\nFill in at least one field to search for your account");
            }
            else
            {
                #region Phần của Ngân
                /*
                 * ValidLogin validLogin = new ValidLogin();
                var account = validLogin.login(txtUsername.Texts.ToString(), txtPassword.Texts.ToString());
                if (account != null)
                {
                    if (account.VaiTro == "Quản trị viên")
                        MessageBox.Show("1 " + account.VaiTro);
                    else if (account.VaiTro == "Sinh Viên")
                        MessageBox.Show("2 " + account.VaiTro);
                    else if (account.VaiTro == "Giáo viên")
                        MessageBox.Show("3 " + account.VaiTro);
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
                 */
                #endregion

                THONG_TIN_DANG_NHAP_DTO account = ValidLogin_BLL.Instance.CheckUsername(txtUsername.Texts);
                if (account == null)
                    CustomMessageBox.Show("Tài khoản không tồn tại.");
                else
                {
                    bool checkLoginSuccess = ValidLogin_BLL.Instance.CheckCorrectPassword(txtPassword.Texts, account);
                    if (checkLoginSuccess)
                    {
                        Form frm = null;
                        if (account.VaiTro == "Giáo viên")
                        {
                            //102BK0001 123456
                            CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Giảng viên");
                            frm = new frmTeacher(txtUsername.Texts);
                        }
                        else if (account.VaiTro == "Sinh Viên")
                        {
                            //101190001 123456
                            CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Sinh viên");
                            frm = new frmStudent();
                        }
                        else
                        {
                            CustomMessageBox.Show("Bạn đang đăng nhập với vai trò Quản trị viên");
                            frm = new frmAdmin();
                        }
                        UtilityClass.OpenNewForm(this, frm);
                    }
                    else CustomMessageBox.Show("Mật khẩu không chính xác.","Lỗi");
                }
            }
        }

        #region các thuộc tính xử lí form di chuyển
        private bool move;
        private int moveX, moveY;
        #endregion
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //Chỉ xử lí việc di chuyển form khi nhấn chuột trái
            if (e.Button == MouseButtons.Left)
            {
                move = true;
                moveX = e.X;
                moveY = e.Y;
            }
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                //set lại vị trí của form trên màn hình
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
