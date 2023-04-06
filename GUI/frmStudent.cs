using GUI.MyUserControls;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmStudent : Form
    {
        private enum SelectionState
        {
            Home,
            DailySchoolSchedule,
            WeeklySchoolSchedule,
            ViewHomeRoomClass
        }

        #region danh sách UC bỏ vào các tab
        UC_DailySchoolSchedule dailySchoolSchedule;
        UC_WeeklySchoolSchedule weeklySchoolSchedule;
        UC_ViewHomeRoomClass viewHomeRoomClass;
        SelectionState state;
        #endregion

        public frmStudent()
        {
            InitializeComponent();
            state = SelectionState.Home;
        }

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
                btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingClass = false;
            }
            else
            {
                for (int i = 53; i <= 153; i++)
                    panelLop.Height = i;
                timerExpandClass.Stop();
                btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
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
                btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingCalendar = false;
            }
            else
            {
                for (int i = 53; i <= 156; i++)
                    panelCalendar.Height = i;
                timerExpandCalendar.Stop();
                btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
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
                panelMenuTong.Width = 63;
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MinimumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MinimumSize.Height;
                panelShowDetail.Location = new Point(panelShowDetail.Location.X - (237 - 63), panelShowDetail.Location.Y);
                panelShowDetail.Width += (237 - 63);
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
                panelShowDetail.Location = new Point(panelShowDetail.Location.X + (237 - 63), panelShowDetail.Location.Y);
                panelShowDetail.Width -= (237 - 63);
            }
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
                panelShowDetail.Controls.Add(uC_StudentInfo);
                uC_StudentInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                uC_StudentInfo.Location = new Point(0, 0);
                uC_StudentInfo.Width = panelShowDetail.Width - 30;
                if (panelShowDetail.Height > 950)
                    uC_StudentInfo.Height = panelShowDetail.Height + 30;
                else uC_StudentInfo.Height = 950;
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
            this.Close();
            Thread t = new Thread(() =>
            {
                Application.Run(new frmLogin());
            });

            //Thiết lập trạng thái của tiến trình mới là STA (Single-Threaded Apartment)
            //để yêu cầu tiến trình mới được chạy trên một luồng riêng biệt, do đó nó không
            //bị ảnh hưởng bởi việc đóng form hiện tại
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
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
                    weeklySchoolSchedule.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(weeklySchoolSchedule);
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
                    viewHomeRoomClass.Dock = DockStyle.Fill;
                }
                panelShowDetail.Controls.Add(viewHomeRoomClass);
            }
        }
    }
}
