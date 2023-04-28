using GUI.MyUserControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmExam : Form
    {
        public string MaSV { get; set; }
        private string _TenSV { get; set; }

        public string TenSV
        {
            get => _TenSV;
            set
            {
                _TenSV = value;
                lblAvatar.Text = value;
                int width = lblAvatar.Width;
                lblAvatar.Location = new Point(avatarTopRight.Location.X - width - 10, lblAvatar.Location.Y);
                lblXinChao.Location = new Point(lblAvatar.Location.X, lblXinChao.Location.Y);
            }
        }

        public string MaLopSH { get; set; }
        enum SelectionState
        {
            Home,
            DoExam,
            ViewHistoryDoExam
        }

        private SelectionState CurrentState;
        UC_Calendar_New NewCalendar;
        UC_DoExam DoExam;
        UC_ViewHistoryDoExam viewHistoryDoExam;

        private Size formOriginalSize;

        Color backColor = Color.White;
        Color DarkColor = Color.FromArgb(36, 37, 38);

        public frmExam()
        {
            InitializeComponent();
            formOriginalSize = this.Size;
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

        private void frmExam_Load(object sender, EventArgs e)
        {
            CurrentState = SelectionState.Home;
            if (NewCalendar == null)
            {
                NewCalendar = new UC_Calendar_New();
                NewCalendar.Dock = DockStyle.Fill;
            }
            pnlMain.Controls.Add(NewCalendar);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (CurrentState != SelectionState.Home)
            {
                CurrentState = SelectionState.Home;
                pnlMain.Controls.Clear();
                if (NewCalendar == null)
                {
                    NewCalendar = new UC_Calendar_New();
                    NewCalendar.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Add(NewCalendar);
            }
        }

        private void btnDoExam_Click(object sender, EventArgs e)
        {
            if (CurrentState != SelectionState.DoExam)
            {
                CurrentState = SelectionState.DoExam;
                pnlMain.Controls.Clear();
                if (DoExam == null)
                {
                    DoExam = new UC_DoExam()
                    {
                        MaSV = this.MaSV,
                        TenSV = this.TenSV,
                        LopSH = this.MaLopSH
                    };
                    DoExam.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Add(DoExam);
            }
        }

        private void btnHistoryDoExam_Click(object sender, EventArgs e)
        {
            if (CurrentState != SelectionState.ViewHistoryDoExam)
            {
                CurrentState = SelectionState.ViewHistoryDoExam;
                pnlMain.Controls.Clear();
                if (viewHistoryDoExam == null)
                {
                    viewHistoryDoExam = new UC_ViewHistoryDoExam();
                    viewHistoryDoExam.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Add(viewHistoryDoExam);
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            /*
            if (backColor == Color.White)
            {
                backColor = DarkColor;
                calendar.ColorBack = DarkColor;
                pnlMain.BackColor = DarkColor;
                panel1.BackColor = DarkColor;
                this.BackColor = DarkColor;
            }
            else if (backColor == DarkColor)
            {
                backColor = Color.White;
                calendar.ColorBack = Color.White;
                pnlMain.BackColor = Color.White;
                panel1.BackColor = Color.White;
                this.BackColor = Color.White;
            }*/
        }

        private void frmExam_Resize(object sender, EventArgs e)
        {
            /*
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            pnlMain.Size = new Size((int)(pnlMain.Width * xRatio), (int)(pnlMain.Height * yRatio));
            panelMenu.Location = new Point((int)(panelMenu.Location.X * xRatio), (int)(panelMenu.Location.Y * yRatio));
            calendar.Size = new Size((int)(calendar.Width * xRatio), (int)(calendar.Height * yRatio));
            calendar.Location = new Point((int)(calendar.Location.X * xRatio), (int)(calendar.Location.Y * yRatio));
            calendar.LoadDays();
            formOriginalSize = this.Size;*/
        }

        private void avatarTopRight_Click(object sender, EventArgs e)
        {
            if (!panelDangXuat.Visible)
            {
                panelDangXuat.Visible = true;
                timerCheckClick.Start();
            }
        }

        private void timerCheckClick_Tick(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (!panelDangXuat.ContainsFocus)
                {
                    panelDangXuat.Visible = false;
                    timerCheckClick.Stop();
                }
            }
        }

        private void btnBackFrmStudent_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
