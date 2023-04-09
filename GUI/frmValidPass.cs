using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmValidPass : Form
    {
        private THONG_TIN_DANG_NHAP_DTO acc;
        public frmValidPass(THONG_TIN_DANG_NHAP_DTO acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            if (txtConfirmPass.Texts == null || txtNewPass.Texts == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else if (!txtConfirmPass.Texts.ToString().Equals(txtNewPass.Texts.ToString()))
            {
                MessageBox.Show("Vui lòng nhập chính xác ở cả 2 ô");
            }
            else
            {
                if (ForgetPass_BLL.Instance.updatePass(acc.TaiKhoan, txtNewPass.Texts.ToString()))
                {
                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                    frmLogin frm = new frmLogin();
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Bạn đã thay đổi mật khẩu không thành công");
                }           
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
