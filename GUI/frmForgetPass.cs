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
            frmLogin1 frm = new frmLogin1();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtEmail.Texts.ToString() == "")
            {
                MessageBox.Show("Please fill in at least one field\r\nFill in at least one field to search for your account");
            }
            else
            {
                frmCheckEmail frm = new frmCheckEmail();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
