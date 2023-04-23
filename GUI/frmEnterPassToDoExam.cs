using FontAwesome.Sharp;
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
    public partial class frmEnterPassToDoExam : Form
    {
        public frmEnterPassToDoExam()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            btnShowPass.IconChar = IconChar.Eye;
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            btnShowPass.IconChar = IconChar.EyeSlash;
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
