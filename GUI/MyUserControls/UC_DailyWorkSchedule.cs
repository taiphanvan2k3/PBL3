using BLL;
using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DailyWorkSchedule : UserControl
    {
        public string MaGV { get; set; }
        public UC_DailyWorkSchedule()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;

            //Các event liên quan đến DataGridView đã được gôm vào xử lí ở lớp ViewWorkSchedueHelper
            ViewWorkScheduleHelper helper = new ViewWorkScheduleHelper(dtgv);
            helper.del_ViewListStudent += new ViewWorkScheduleHelper.ViewListStudent(HandleEventViewListStudentInModuleClass);
            helper.del_SendNotification += new ViewWorkScheduleHelper.SendNotification(HandleEventSendNotificationToModuleClass);
        }


        private void lblShowDateTime_Click(object sender, EventArgs e)
        {
            dateTimePicker.Select();
            SendKeys.Send("%{Down}");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            lblShowDateTime.Text = UtilityClass.GetDayOfWeekVietnameseShortString(date) + " - " +
                dateTimePicker.Value.ToShortDateString();
        }

        private void UC_DailyWorkSchedule_Load(object sender, EventArgs e)
        {
            MaGV = "102BK0001";
            btnXemLichDay_Click(sender, e);
        }

        private void LoadWorkScheduleByDayOfWeek(string Thu)
        {
            bool IsKiChan = false;
            int NamHoc = DateTime.Now.Year;
            if (DateTime.Now.Month >= 2 && DateTime.Now.Month <= 7)
            {
                //Nếu đang ở trong thời điểm này thì đây là giai đoạn học của kì 2 năm học đó
                //Vd năm hiện tại là 2023, kì 2 thì năm học là 2022-2023.
                //Nếu là năm học 2022-2023 thì chỉ lấy ra các HP ở kì hiện tại thôi chứ không lấy cả 2 kì
                NamHoc--;
                IsKiChan = true;
            }
            dtgv.Columns.Clear();
            dtgv.DataSource = GiangVien_BLL.Instance.GetWorkScheduleByDateOfWeek(MaGV, NamHoc, Thu, IsKiChan);
        }

        private void btnXemLichDay_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            string DateShortString = UtilityClass.GetDayOfWeekVietnameseShortString(date);
            string Thu = UtilityClass.GetDayOfWeekVietNameseLongString(DateShortString);
            LoadWorkScheduleByDayOfWeek(Thu);
        }

        private void HandleEventViewListStudentInModuleClass(string MaLopHP)
        {
            frmShowListStudentInModuleClass frm = new frmShowListStudentInModuleClass()
            {
                MaHP = MaLopHP
            };
            frm.ShowDialog();
        }

        private void HandleEventSendNotificationToModuleClass(string MaLopHP)
        {
            Form frmSendNotification = new Form()
            {
                Width = 1175,
                Height = 700,
                Text = "Thông báo đến lớp học phần " + MaLopHP,
                StartPosition = FormStartPosition.CenterScreen
            };
            UC_SendNoticeToModuleClass uC_SendNotification = new UC_SendNoticeToModuleClass()
            {
                MaGV = this.MaGV,
                IsNoticeToSpecificModuleClass = true,
                MaLopHP = MaLopHP,
            };
            uC_SendNotification.Dock = DockStyle.Fill;
            frmSendNotification.Controls.Add(uC_SendNotification);
            frmSendNotification.ShowDialog();
        }
    }
}
