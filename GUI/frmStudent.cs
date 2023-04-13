using BLL;
using DTO;
using GUI.MyUserControls;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmStudent : Form
    {
        public string MSSV { get; set; }
        private SinhVien_DTO sv { get; set; }
        public frmStudent()
        {
            InitializeComponent();
            uC_StudentInfoNew = new UC_StudentInfoNew();
            MSSV = "101190001";
            state = SelectionState.Home;
        }

        public frmStudent(string MSSV)
        {
            InitializeComponent();
            uC_StudentInfoNew = new UC_StudentInfoNew();
            this.MSSV = MSSV;
            state = SelectionState.Home;
        }
        private enum SelectionState
        {
            Home,
            DailySchoolSchedule,
            WeeklySchoolSchedule,
            ViewHomeRoomClass
        }

        #region Danh sách UC bỏ vào các tab
        UC_StudentInfoNew uC_StudentInfoNew;
        UC_DailySchoolSchedule dailySchoolSchedule;
        UC_WeeklySchoolSchedule weeklySchoolSchedule;
        UC_ViewHomeRoomClass viewHomeRoomClass;
        SelectionState state;
        #endregion

        #region Event menu trái
        private void btnLopArrowDown_Click(object sender, EventArgs e)
        {
            timerExpandClass.Start();
        }

        private void timerExpandClass_Tick(object sender, EventArgs e)
        {
            if (panelLop.Height == 153)
            {
                for (int i = 153; i >= 53; i--)
                    panelLop.Height = i;
                timerExpandClass.Stop();
                //btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingClass = false;
            }
            else
            {
                for (int i = 53; i <= 153; i++)
                    panelLop.Height = i;
                timerExpandClass.Stop();
                //btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                isExpandingClass = true;
            }
        }

        private void btnCalendarExpand_Click(object sender, EventArgs e)
        {
            timerExpandCalendar.Start();
        }

        private void timerExpandCalendar_Tick(object sender, EventArgs e)
        {
            if (panelCalendar.Height == 156)
            {
                for (int i = 156; i >= 53; i--)
                    panelCalendar.Height = i;
                timerExpandCalendar.Stop();
                //btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingCalendar = false;
            }
            else
            {
                for (int i = 53; i <= 156; i++)
                    panelCalendar.Height = i;
                timerExpandCalendar.Stop();
                //btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                isExpandingCalendar = true;
            }
        }

        private Point originalLocationOfBtnMenuExpand;

        //Hai biến bool này để lưu trạng thái đóng mở của panelLop, panelCalendar
        //để khi panelMenuTong đưa về trạng thái mở rộng ban đầu thì hiển thị lại trạng thái đóng, mở tương
        //ứng đó
        private bool isExpandingClass = false;
        private bool isExpandingCalendar = false;
        private void btnExpandMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuTong.Width == 237)
            {
                originalLocationOfBtnMenuExpand = btnExpandMenu.Location;
                pictureBoxMenu.Visible = false;
                btnExpandMenu.Location = pictureBoxMenu.Location;
                panelMenuTong.Width = 58;
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MinimumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MinimumSize.Height;
                panelShowDetail.Location = new Point(panelShowDetail.Location.X - (237 - 58), panelShowDetail.Location.Y);
                panelShowDetail.Width += (237 - 58);
            }
            else
            {
                panelMenuTong.Width = 237;
                pictureBoxMenu.Visible = true;
                btnExpandMenu.Location = originalLocationOfBtnMenuExpand;
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MaximumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MaximumSize.Height;
                panelShowDetail.Location = new Point(panelShowDetail.Location.X + (237 - 58), panelShowDetail.Location.Y);
                panelShowDetail.Width -= (237 - 58);
            }
        }
        #endregion


        private void btnXemLichTrongNgay_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.DailySchoolSchedule)
            {
                state = SelectionState.DailySchoolSchedule;
                panelShowDetail.Controls.Clear();
                if (dailySchoolSchedule == null)
                {
                    dailySchoolSchedule = new UC_DailySchoolSchedule();
                    dailySchoolSchedule.MSSV = MSSV;
                    dailySchoolSchedule.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(dailySchoolSchedule);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.Home)
            {
                state = SelectionState.Home;
                panelShowDetail.Controls.Clear();
                panelShowDetail.Controls.Add(uC_StudentInfoNew);
            }
        }

        private void btnLopSH_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.ViewHomeRoomClass)
            {
                state = SelectionState.ViewHomeRoomClass;
                panelShowDetail.Controls.Clear();
                if (viewHomeRoomClass == null)
                {
                    viewHomeRoomClass = new UC_ViewHomeRoomClass();
                    viewHomeRoomClass.MaLopSH = sv.MaLopSH;
                    viewHomeRoomClass.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(viewHomeRoomClass);
                //Gọi thủ công hàm LoadData để load lại dữ liệu tránh trường hợp sinh viên khác thay đổi
                //thông tin của họ rồi mà vẫn lấy lại dữ liệu cũ trên datagridview lớp sinh hoạt
                viewHomeRoomClass.LoadData();
            }
        }

        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.WeeklySchoolSchedule)
            {
                state = SelectionState.WeeklySchoolSchedule;
                panelShowDetail.Controls.Clear();
                if (weeklySchoolSchedule == null)
                {
                    weeklySchoolSchedule = new UC_WeeklySchoolSchedule();
                    weeklySchoolSchedule.MSSV = MSSV;
                    weeklySchoolSchedule.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(weeklySchoolSchedule);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            /*
             * Khi gọi this.Close() thì đóng form hiện tại do đó giả sử
             * gọi MessageBox.Show("abc"); thì MessageBox.Show("abc"); không thực hiện được
             * Bởi vì form đã bị đóng nên các thao tác trên form không còn được hỗ trợ nữa,
             * và chú ý là Close() thôi chứ chưa Dispose() nên vd ở 1 lớp nào đó vẫn có thể truy cập
             * đến thuộc tính của form này thông qua đối tượng của form
             */
            UtilityClass.OpenNewForm(this, new frmLogin());
        }

        private void LoadStudentInfo()
        {
            sv = SinhVien_BLL.GetSinhVienById(MSSV);
            uC_StudentInfoNew.LabelMSSV = sv.MaNguoiDung;
            uC_StudentInfoNew.HoVaTen = sv.Ho + " " + sv.Ten;
            lblAvatar.Text = sv.Ho + " " + sv.Ten;
            uC_StudentInfoNew.GioiTinh = sv.GioiTinh;
            uC_StudentInfoNew.NgaySinh = sv.NgaySinh.ToShortDateString();
            uC_StudentInfoNew.NoiSinh = sv.NoiSinh;
            uC_StudentInfoNew.CCCD = sv.MaCCCD;
            if (sv.NoiSinh != "")
            {
                uC_StudentInfoNew.LoadCBBNoiSinh();
                uC_StudentInfoNew.NoiSinh = sv.NoiSinh;
            }

            if (sv.DanToc != "")
                uC_StudentInfoNew.DanToc = sv.DanToc;

            if (sv.QuocTinh != "")
                uC_StudentInfoNew.QuocTinh = sv.QuocTinh;
            uC_StudentInfoNew.Khoa = sv.Khoa;
            uC_StudentInfoNew.ChuongTrinhDaoTao = sv.TenCTDT;
            uC_StudentInfoNew.LopSinhHoat = sv.MaLopSH;
            uC_StudentInfoNew.EmailCaNhan = sv.EmailCaNhan;
            uC_StudentInfoNew.EmailTruongCap = sv.EmailTruongCap;
            uC_StudentInfoNew.SoDienThoai = sv.Sdt;
            if (sv.DiaChi != "")
            {
                uC_StudentInfoNew.SoDuong = sv.DiaChi.Substring(0, sv.DiaChi.IndexOf(" - "));
                uC_StudentInfoNew.SetDiaChi(sv.DiaChi);
            }
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
            panelShowDetail.Controls.Clear();
            uC_StudentInfoNew.MSSV = MSSV;
            uC_StudentInfoNew.Dock = DockStyle.Fill;
            panelShowDetail.Controls.Add(uC_StudentInfoNew);
        }
    }
}
