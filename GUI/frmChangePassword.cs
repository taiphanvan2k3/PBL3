using BLL;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class frmChangePassword : Form
    {

        private string MSSV { get; set; }
        private bool isValidPassword = false;

        public frmChangePassword(string MSSV)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(panelLogin);
            btnDoNotShow.BringToFront();
            btnNotShow2.BringToFront();
            btnUnShowPassOld.BringToFront();
            btnContinue.Enabled = isValidPassword;
            this.MSSV = MSSV;
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
        private void btnShowPassOld_Click(object sender, EventArgs e)
        {
            if (!txtOldPass.PasswordChar)
            {
                btnUnShowPassOld.BringToFront();
                txtOldPass.PasswordChar = true;
            }
        }

        private void btnUnShowPassOld_Click(object sender, EventArgs e)
        {
            if (txtOldPass.PasswordChar)
            {
                btnShowPassOld.BringToFront();
                txtOldPass.PasswordChar = false;
            }
        }

        #endregion

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var accountValid = ValidLogin_BLL.Instance.login(MSSV, txtOldPass.Texts);
            if (accountValid != null)
            {
                if (ForgetPass_BLL.Instance.updatePass(MSSV, txtNewPass.Texts.ToString()))
                {
                    CustomMessageBox.Show("Bạn đã thay đổi mật khẩu thành công!", "Thông báo");
                    this.Dispose();
                }
                else
                {
                    CustomMessageBox.Show("Bạn đã thay đổi mật khẩu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CustomMessageBox.Show("Vui òng nhập đúng mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
