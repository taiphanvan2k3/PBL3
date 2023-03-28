using GUI.MyUserControls;
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
    public partial class frmTeacher : Form
    {
        //Fields
        public frmTeacher()
        {
            InitializeComponent();
            CollapseMenu();
            UC_DisplayInformation uC_DisplayInformation = new UC_DisplayInformation();
            addUC(uC_DisplayInformation);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void addUC(UserControl uc) {
            panelProfile.Controls.Clear();
            panelProfile.Controls.Add(uc);
            uc.BringToFront();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                //panelProfile.Size = new Size(1350, 400);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 250;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                //panelProfile.Size = new Size(1200, 400);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }




    }
}