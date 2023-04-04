using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmExam : Form
    {
        private Size formOriginalSize;
        UC_Calendar calendar = new UC_Calendar();
        Label lblHome = new Label();
        Color backColor = Color.White;
        Color DarkColor = Color.FromArgb(36, 37, 38);
        public frmExam()
        {
            InitializeComponent();
            CollapseMenu();
            formOriginalSize = this.Size;
        }
        
        private void Init()
        {
            lblHome.Text = "Home";
            lblHome.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = backColor;
        }
        private void btnMenu_Click(object sender, EventArgs e)
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
                //panelProfile.Size = new Size(1350, 400);
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                pnlMain.Width += 100;
                pnlMain.Location = new Point(pnlMain.Location.X - 100, pnlMain.Location.Y);
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
                pnlMain.Width -= 100;
                pnlMain.Location = new Point(pnlMain.Location.X + 100, pnlMain.Location.Y);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(lblHome);
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(calendar);   
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if(backColor == Color.White)
            {
                backColor = DarkColor;
                calendar.ColorBack = DarkColor;
                pnlMain.BackColor = DarkColor;
                panel1.BackColor = DarkColor;
                this.BackColor = DarkColor;
            }
            else if(backColor == DarkColor)
            {
                backColor = Color.White;
                calendar.ColorBack = Color.White;
                pnlMain.BackColor = Color.White;
                panel1.BackColor = Color.White;
                this.BackColor = Color.White;
            }
        }

        private void frmExam_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            pnlMain.Size = new Size((int)(pnlMain.Width * xRatio), (int)(pnlMain.Height * yRatio));
            panelMenu.Location = new Point((int)(panelMenu.Location.X * xRatio), (int)(panelMenu.Location.Y * yRatio));
            calendar.Size = new Size((int)(calendar.Width * xRatio), (int)(calendar.Height * yRatio));
            calendar.Location = new Point((int)(calendar.Location.X * xRatio), (int)(calendar.Location.Y * yRatio));
            calendar.LoadDays();
            formOriginalSize = this.Size;
        }

    }
}
