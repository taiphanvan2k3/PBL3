using BLL;
using DTO;
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
    public partial class frmDesinEnterDigitCode : Form
    {
        private Timer countdownTimer;
        private int duration = 120;
        private THONG_TIN_DANG_NHAP_DTO acc;
        private string email;
        public frmDesinEnterDigitCode(THONG_TIN_DANG_NHAP_DTO acc, string email)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            this.acc = acc;
            this.email = email;
            btnContinue.Enabled = false;

            // Khởi tạo Timer với khoảng thời gian là 1 giây
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;

            // Xử lý sự kiện Tick của Timer
            countdownTimer.Tick += (s, e) =>
            {
                if (duration > 0)
                {
                    duration--;
                    lbCountdown.Text = duration.ToString();
                }
                else
                {
                    // Khi đếm ngược hoàn thành, dừng Timer
                    countdownTimer.Stop();

                    // Thực hiện cập nhật dữ liệu bằng Entity Framework
                    ForgetPass_BLL.Instance.resetVerification_BLL(email);
                }
            };

        }

        private void frmDesinEnterDigitCode_Load(object sender, EventArgs e)
        {
            // Bắt đầu đếm ngược khi Form được load
            countdownTimer.Start();

        }

        private void TextBoxOnlyAllowNumeric(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã nhập đúng mã xác thực chưa
            if (ForgetPass_BLL.Instance.CheckValid(acc.TaiKhoan, txtNumberCode.Texts.ToString()))
            {
                UtilityClass.OpenNewForm(this, new frmDesignEnterNewPass(acc, email));
            }
            else
            {
                CustomMessageBox.Show("Bạn đã nhập sai mã xác thực!", "Lỗi");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignFindAcc());
        }

        private void txtNumberCode__TextChanged(object sender, EventArgs e)
        {
            if (txtNumberCode.Texts.ToString().Length == 6)
            {
                btnContinue.Enabled = true;
            }
        }

        private void btnForgetPass_MouseHover(object sender, EventArgs e)
        {
            btnSendBackAgain.Font = new Font(btnSendBackAgain.Font, FontStyle.Underline);
            btnSendBackAgain.ForeColor = Color.HotPink;
        }

        private void btnForgetPass_MouseLeave(object sender, EventArgs e)
        {
            btnSendBackAgain.Font = new Font(btnSendBackAgain.Font, FontStyle.Regular);
            btnSendBackAgain.ForeColor = Color.White;
        }

        private void btnSendBackAgain_Click(object sender, EventArgs e)
        {
            // Reset lại đồng hồ đếm ngược
            ForgetPass_BLL.Instance.ResetPasswordByEmail(email);
            duration = 120;
            lbCountdown.Text = duration.ToString();

            // Thực hiện gửi mail
            UtilityClass.sendEmail(email, acc.MaXacThucDeLayLaiMK);

            // Khởi động lại đồng hồ đếm ngược
            countdownTimer.Start();
        }
    }
}
