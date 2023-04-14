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
    public partial class frmCreateClassSection : Form
    {
        public frmCreateClassSection()
        {
            InitializeComponent();
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignGV_Click(object sender, EventArgs e)
        {
            frmAssignTeacher frm = new frmAssignTeacher();
            frm.MaHP = tbMaHP.Text;
            frm.TenMH = tbTenMH.Texts;
            frm.ShowDialog();
        }
    }
}
