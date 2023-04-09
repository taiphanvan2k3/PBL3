using BLL;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmForgetPass : Form
    {
        public frmForgetPass()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Dispose();
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
            if(txtEmail.Texts.ToString() == "")
            {
                MessageBox.Show("Please fill in at least one field\r\nFill in at least one field to search for your account");
            }
            else
            {
                var acc = ForgetPass_BLL.Instance.ResetPasswordByEmail(txtEmail.Texts.ToString());
                if (acc == null)
                {
                    MessageBox.Show("Địa chỉ id không hợp lệ");
                }
                else
                {
                    UtilityClass.sendEmail(txtEmail.Texts.ToString(), acc.MaXacThucDeLayLaiMK);
                    // Lưu thời điểm hiện tại vào biến lastUpdateTime
                    DateTime lastUpdateTime = DateTime.Now;

                    // Tạo một Timer với khoảng thời gian là 1 phút
                    Timer timer = new Timer();
                    timer.Interval = 60000;

                    // Xử lý sự kiện Tick của Timer
                    timer.Tick += (s, e1) =>
                    {
                        // Kiểm tra xem đã đủ khoảng thời gian để cập nhật dữ liệu chưa
                        if (DateTime.Now.Subtract(lastUpdateTime).TotalMinutes >= 1)
                        {
                            // Thực hiện cập nhật dữ liệu bằng Entity Framework
                            ForgetPass_BLL.Instance.resetVerification_BLL(txtEmail.Texts.ToString());

                            // Lưu thời điểm hiện tại để tính thời điểm cập nhật tiếp theo
                            lastUpdateTime = DateTime.Now;
                        }
                    };

                    // Bắt đầu chạy Timer
                    timer.Start();
                    MessageBox.Show("Đã gửi mã thành công");
                    frmEnterDigitCode frm = new frmEnterDigitCode(acc);
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Dispose();
                }
            }
        }

       
    }
}
