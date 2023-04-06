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
    public partial class frmEnterMaXacNhan : Form
    {
        public frmEnterMaXacNhan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin   = new frmLogin();   
           frmLogin.ShowDialog();
            this.Dispose();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
