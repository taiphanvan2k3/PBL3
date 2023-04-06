using BLL;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                ResetPassword resetPassword = new ResetPassword();
                string result = resetPassword.ResetPasswordByEmail(txtEmail.Texts.ToString());
                if (result == null)
                {
                    MessageBox.Show("Địa chỉ id không hợp lệ");
                }
                else
                {
                    MessageBox.Show("Đã gửi mã thành công");
                    frmCheckEmail frm = new frmCheckEmail();
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Dispose();
                }
            }
        }

       
    }
}
