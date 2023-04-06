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
    public partial class frmCheckEmail : Form
    {
        public frmCheckEmail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSkip_MouseHover(object sender, EventArgs e)
        {
            btnSkip.Font = new Font(btnSkip.Font, FontStyle.Underline);
            btnSkip.ForeColor = Color.HotPink;

        }

        private void btnSkip_MouseLeave(object sender, EventArgs e)
        {
            btnSkip.Font = new Font(btnSkip.Font, FontStyle.Regular);
            btnSkip.ForeColor = Color.FromArgb(162, 162, 162);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin1 = new frmLogin(); 
            frmLogin1.ShowDialog();
            this.Dispose();
        }

        private void btnOpenEmail_Click(object sender, EventArgs e)
        {
           frmValidPass frmValidPass = new frmValidPass();
            frmValidPass.ShowDialog();
            this.Dispose();
        }
    }
}
