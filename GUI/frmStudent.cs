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
            //MSSV = "101180002";
            MSSV = "102210043";
            state = SelectionState.Home;
        }

        public frmStudent(string MSSV)
        {
            InitializeComponent();
            uC_StudentInfoNew = new UC_StudentInfoNew();
            this.MSSV = MSSV;
            state = SelectionState.Home;
        }

        //Dùng enum để lưu lại trạng thái user control nào đang được add vào panel để show
        private enum SelectionState
        {
            Home,
            DailySchoolSchedule,
            WeeklySchoolSchedule,
            ViewHomeRoomClass,
            ViewListModuleClass,
            ViewNotifications,
            ViewResultOfLearning
        }

        #region Danh sách UC bỏ vào các tab
        UC_StudentInfoNew uC_StudentInfoNew;
        UC_DailySchoolSchedule dailySchoolSchedule;
        UC_WeeklySchoolSchedule weeklySchoolSchedule;
        UC_ViewHomeRoomClass viewHomeRoomClass;
        UC_ViewListModuleClass_SVRole viewListModuleClass;
        UC_ViewListNotifications viewListNotifications;
        UC_XemKetQuaHocTap viewResultOfLearning;
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
        //ứng của 2 panel đó
        private bool isExpandingClass = false;
        private bool isExpandingCalendar = false;
        private void btnExpandMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuTong.Width == 237)
            {
                //Khi menu trái có chiều rộng 237 và thực hiện nhấn vào button expand menu thì
                //thực hiện thu hẹp menu trái
                originalLocationOfBtnMenuExpand = btnExpandMenu.Location;
                pictureBoxMenu.Visible = false;
                btnExpandMenu.Location = pictureBoxMenu.Location;
                panelMenuTong.Width = 58;

                //Khi thu hẹp menu trái thì đồng thời thu gọn lại trạng thái xổ xuống của tab "Xem lịch" và "Lớp"
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MinimumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MinimumSize.Height;

                //Di chuyển panel về phía bên trái vì lúc này menu đã được thu gọn
                //và khoảng dịch chuyển cũng chính là offset = "chiều rộng ban đầu" - "chiều rộng sau thu hẹp"
                panelShowDetail.Location = new Point(panelShowDetail.Location.X - (237 - 58), 
                                                panelShowDetail.Location.Y);
                panelShowDetail.Width += (237 - 58);
            }
            else
            {
                //Thực hiện mở rộng menu trái
                panelMenuTong.Width = 237;
                pictureBoxMenu.Visible = true;
                btnExpandMenu.Location = originalLocationOfBtnMenuExpand;

                //Do có lưu lại trạng thái đóng mở của các tab nên khi mở rộng lại menu trái thì dựa
                //vào trạng thái đó mà thực hiện xổ xuống các tab "Xem lịch", "Lớp"
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MaximumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MaximumSize.Height;

                panelShowDetail.Location = new Point(panelShowDetail.Location.X + (237 - 58), 
                                           panelShowDetail.Location.Y);
                panelShowDetail.Width -= (237 - 58);
            }
        }

        private void lblAvatar_TextChanged(object sender, EventArgs e)
        {
            //Thay đổi lại vị trí của label hiển thị tên sv ở góc trên bên phải để tránh tràn nội dung
            //qua avatar góc trên bên phải
            int width = TextRenderer.MeasureText(lblAvatar.Text, lblAvatar.Font).Width;
            lblAvatar.Location = new Point(avatarTopRight.Location.X - width - 20, lblAvatar.Location.Y);
            lblXinChao.Location = new Point(lblAvatar.Location.X, lblXinChao.Location.Y);
        }
        #endregion

        private void LoadStudentInfo()
        {
            sv = SinhVien_BLL.GetSinhVienById(MSSV);
            uC_StudentInfoNew.LabelMSSV = sv.MaNguoiDung;
            uC_StudentInfoNew.HoVaTen = sv.Ho + " " + sv.Ten;
            lblAvatar.Text = sv.Ho + " " + sv.Ten;
            uC_StudentInfoNew.GioiTinh = sv.GioiTinh;
            if (sv.AnhCaNhan == null)
            {
                //Nếu sinh viên chưa có ảnh thì lấy ảnh mặc định bỏ vào
                if (sv.GioiTinh)
                    avatarTopRight.Image = GUI.Properties.Resources.studentAvatar;
                else
                    avatarTopRight.Image = GUI.Properties.Resources.GirlStudentDefault;
            }
            else
            {
                avatarTopRight.Image = UtilityClass.ConvertByteArrayToImage(sv.AnhCaNhan);
            }
            uC_StudentInfoNew.Avatar = avatarTopRight.Image;

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

            if (sv.QuocTich != "")
                uC_StudentInfoNew.QuocTinh = sv.QuocTich;

            //Truyền các dữ liệu đã truy vấn được ở đây qua user control để đỡ phải truy vấn lại
            //từ đầu -> Cải thiện hiệu suất hơn
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
            //Ban đầu khi mới chạy chương trình thì UC_StudentInfo sẽ được add vào đầu tiên,
            //kèm với load dữ liệu vào user control đó
            LoadStudentInfo();
            panelShowDetail.Controls.Clear();
            uC_StudentInfoNew.MSSV = MSSV;
            uC_StudentInfoNew.Dock = DockStyle.Fill;
            panelShowDetail.Controls.Add(uC_StudentInfoNew);
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

        private void btnLopHP_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.ViewListModuleClass)
            {
                state = SelectionState.ViewListModuleClass;
                panelShowDetail.Controls.Clear();
                if (viewListModuleClass == null)
                {
                    viewListModuleClass = new UC_ViewListModuleClass_SVRole() { MaSV = this.MSSV };
                    viewListModuleClass.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(viewListModuleClass);
            }
        }

        private void btnDoExam_Click(object sender, EventArgs e)
        {
            UtilityClass.OpenNewForm(this, new frmExam()
            {
                MaSV = this.MSSV,
                TenSV = sv.Ho + " " + sv.Ten,
                MaLopSH = sv.MaLopSH,
                Avatar = avatarTopRight.Image
            });
        }

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

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.ViewNotifications)
            {
                state = SelectionState.ViewNotifications;
                panelShowDetail.Controls.Clear();
                if (viewListNotifications == null)
                {
                    viewListNotifications = new UC_ViewListNotifications(MSSV);
                    viewListNotifications.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(viewListNotifications);
            }
        }

        private void btnXemKqHocTap_Click(object sender, EventArgs e)
        {
            if (state != SelectionState.ViewResultOfLearning)
            {
                btnExpandMenu_Click(sender, e);
                state = SelectionState.ViewResultOfLearning;
                panelShowDetail.Controls.Clear();
                if (viewResultOfLearning == null)
                {
                    viewResultOfLearning = new UC_XemKetQuaHocTap() { MaSV = this.MSSV };
                    viewResultOfLearning.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(viewResultOfLearning);
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
            UtilityClass.OpenNewForm(this, new frmDesignLogin());
        }

        public void ChangeAvatarTopRight(Image img)
        {
            avatarTopRight.Image = img;
        }
    }
}
