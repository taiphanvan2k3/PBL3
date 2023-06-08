using BLL;
using DTO;
using GUI.MyUserControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTeacher : Form
    {
        private string ButtonClicked = "";
        public frmTeacher()
        {
            InitializeComponent();
            CollapseMenu();
            Info = new UC_TeacherInfo();
            ID = "102BK0001";
            LoadInfo(ID);
        }
        public frmTeacher(string account)
        {
            InitializeComponent();
            CollapseMenu();
            Info = new UC_TeacherInfo();
            ID = account;
            LoadInfo(ID);
        }
        #region List đối tượng menu
        private UC_TeacherInfo Info;
        private UC_CreateExam CreateExam;
        private UC_DailyWorkSchedule DailySchedule;
        private UC_WeeklyWorkSchedule WeeklySchedule;
        private UC_ViewHomeRoomClass HomeRoomClass;
        private UC_SendNoticeToModuleClass SendNoticeToModuleClass;
        private UC_ThongKeDiem uC_ThongKeDiem;
        #endregion
        #region Properties
        string ID { get; set; }
        #endregion
        #region Methods
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
                foreach (Button menuButton in flPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    //menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(29);
                }
                foreach (Button menuButton in pnlManageClass.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    //menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(29);
                }
                foreach (Button menuButton in pnlViewCalendar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    //menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(29);
                }
                pnlMain.Width += 150;
                pnlMain.Location = new Point(pnlMain.Location.X - 150, pnlMain.Location.Y);
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
                foreach (Button menuButton in flPanel.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in pnlManageClass.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in pnlViewCalendar.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                pnlMain.Width -= 150;
                pnlMain.Location = new Point(pnlMain.Location.X + 150, pnlMain.Location.Y);
            }
        }
        void LoadInfo(string Account)
        {
            GiangVien_DTO gv = GiangVien_BLL.Instance.GetGiangVienById(Account);
            Info.TenGV = gv.Ho + " " + gv.Ten;
            Info.IdTeacher = gv.MaNguoiDung;
            Info.Khoa = gv.MaKhoa;
            Info.NgaySinh = gv.NgaySinh.ToShortDateString();
            Info.GioiTinh = (gv.GioiTinh) ? "Nam" : "Nữ";
            Info.TrinhDo = gv.TrinhDo;
            Info.Luong = gv.Luong.ToString();
            Info.EmailCaNhan = gv.EmailCaNhan;
            Info.EmailTruongCap = gv.EmailTruongCap;
            Info.SDT = gv.Sdt;
            Info.DanToc = gv.DanToc;
            Info.QuocTich = gv.QuocTich;
            Info.NoiSinh = gv.NoiSinh;
            Info.CCCD = gv.MaCCCD;
            Info.SetDiaChi(gv.DiaChi);
            if (gv.AnhCaNhan == null)
            {
                if (gv.GioiTinh)
                    Info.Avatar = GUI.Properties.Resources.studentAvatar;
                else
                    Info.Avatar = GUI.Properties.Resources.GirlStudentDefault;

            }
            else
            {
                Info.Avatar = UtilityClass.ConvertByteArrayToImage(gv.AnhCaNhan);
            }
            if (ButtonClicked != "Home")
            {
                ButtonClicked = "Home";
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(Info);
            }
        }
        #endregion
        #region Events
        private void frmTeacher_Load(object sender, EventArgs e)
        {
            Info.Dock = DockStyle.Fill;
            CollapseMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //Clear hết control trong panel chứa các chức năng trên màn hình
            if (ButtonClicked != "Home")
            {
                ButtonClicked = "Home";
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(Info);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            if (pnlManageClass.Height < 69)
            {
                pnlManageClass.Height = 408;
            }
            else
            {
                pnlManageClass.Height = 68;
            }
            if (pnlViewCalendar.Height >= 69)
            {
                pnlViewCalendar.Height = 68;
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (pnlViewCalendar.Height < 69)
            {
                pnlViewCalendar.Height = 204;
            }
            else
            {
                pnlViewCalendar.Height = 68;
            }
            if (pnlManageClass.Height >= 69)
            {
                pnlManageClass.Height = 68;
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Nền tối")
            {
                ButtonClicked = "Nền tối";
                pnlMain.Controls.Clear();
            }
        }

        private void btnViewListDoExam_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "ViewListDoExam")
            {
                ButtonClicked = "ViewListDoExam";
                if (uC_ThongKeDiem == null)
                {
                    uC_ThongKeDiem = new UC_ThongKeDiem() { MaGV = ID };
                    uC_ThongKeDiem.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(uC_ThongKeDiem);
            }
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            frmTaoCauHoiNew f = new frmTaoCauHoiNew();
            f.MaGV = ID;
            f.ShowDialog();
        }

        private void btnSendAnnounce_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Gửi thông báo")
            {
                ButtonClicked = "Gửi thông báo";
                if (SendNoticeToModuleClass == null)
                {
                    SendNoticeToModuleClass = new UC_SendNoticeToModuleClass();
                    SendNoticeToModuleClass.Dock = DockStyle.Fill;
                    SendNoticeToModuleClass.MaGV = ID;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(SendNoticeToModuleClass);
            }
        }

        private void btnHomeRoomClass_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Lớp sinh hoạt")
            {
                ButtonClicked = "Lớp sinh hoạt";
                if (HomeRoomClass == null)
                {
                    HomeRoomClass = new UC_ViewHomeRoomClass();
                    HomeRoomClass.ListMaLSH = GiangVien_BLL.Instance.GetMaLSHForGiangVien(ID);
                    HomeRoomClass.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(HomeRoomClass);
            }
        }
        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Tạo bài kiểm tra")
            {
                ButtonClicked = "Tạo bài kiểm tra";
                if (CreateExam == null)
                {
                    CreateExam = new UC_CreateExam(ID);
                    CreateExam.MaGV = ID;
                    CreateExam.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(CreateExam);
            }
        }

        private void btnCalendarDays_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Lịch theo ngày")
            {
                ButtonClicked = "Lịch theo ngày";
                if (DailySchedule == null)
                {
                    DailySchedule = new UC_DailyWorkSchedule();
                    DailySchedule.MaGV = ID;
                    DailySchedule.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(DailySchedule);
            }
        }

        private void btnCalendarWeek_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != "Lịch theo tuần")
            {
                ButtonClicked = "Lịch theo tuần";
                if (WeeklySchedule == null)
                {
                    WeeklySchedule = new UC_WeeklyWorkSchedule();
                    WeeklySchedule.MaGV = ID;
                    WeeklySchedule.Dock = DockStyle.Fill;
                }
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(WeeklySchedule);
            }
        }
        #endregion
    }
}
