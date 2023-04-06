using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmValidPass : Form
    {
        public frmValidPass()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Dispose();
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
