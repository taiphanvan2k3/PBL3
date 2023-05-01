using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public frmAdmin()
        {
            InitializeComponent();
            hideSubMenu();
            CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                if (this.panelMenu.Width > 200)
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                }
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (this.panelMenu.Width > 200)
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                }
                currentBtn.BackColor = Color.FromArgb(0, 28, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                leftBorderBtn.Visible = false;


            }
        }

        private void hideSubMenu()
        {
            panelAdd.Visible = false;
            panelClass.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }




        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            //..
            //your codes
            //..
            openChildForm(new frmDesignDashboard());
            hideSubMenu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panelAdd);
        }


        private void btnExpandMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelAdd.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelClass.Controls.OfType<Button>())
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
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString() + "    ";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in panelAdd.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString() + "    ";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in panelClass.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString() + "    ";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelClass);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }

        // gắn datasource
        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewListAccAndClass(GetInformationAcc_BLL.Instance.GetAccountStudentList().Cast<object>().ToList(), 0));
        }
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewListAccAndClass(GetInformationAcc_BLL.Instance.GetAccountTeacherList().Cast<object>().ToList(), 1));

        }


        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnHomeroomClass_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewListAccAndClass(LopSinhHoat_BLL.Instance.GetInformationClasses().Cast<object>().ToList(), 2));
        }

        private void btnModuleClass_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewListAccAndClass(LopHocPhan_BLL.Instance.getInformation().Cast<object>().ToList(), 3));
        }
    }
}
