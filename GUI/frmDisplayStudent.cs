using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDisplayStudent : Form
    {
        public frmDisplayStudent()
        {
            InitializeComponent();
            UC_Student uc = new UC_Student();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ptnContainer.Controls.Clear();
            ptnContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void btnInfomation_Click(object sender, EventArgs e)
        {
            UC_Student uc = new UC_Student();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Class uc = new UC_Class();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }
    }
}
