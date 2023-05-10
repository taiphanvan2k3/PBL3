using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_WeeklyWorkSchedule : UserControl
    {
        public string MaGV { get; set; }
        private List<KeyValuePair<int, int>> li;
        public UC_WeeklyWorkSchedule()
        {
            InitializeComponent();
            ViewWorkScheduleHelper helper = new ViewWorkScheduleHelper(dtgv);
            helper.del_ViewListStudent += new ViewWorkScheduleHelper.ViewListStudent(HandleEventViewListStudentInModuleClass);
            helper.del_SendNotification += new ViewWorkScheduleHelper.SendNotification(HandleEventSendNotificationToModuleClass);
        }

        private void UC_WeeklyWorkSchedule_Load(object sender, EventArgs e)
        {
            MaGV = "102BK0001";
            li = GiangVien_BLL.Instance.GetAllKiHocNamHocGVDay(MaGV);
            foreach (KeyValuePair<int, int> item in li)
            {
                string tmp = "Kì " + item.Key + " Năm học " + item.Value + "-" + (item.Value + 1);
                cbbHocKy.Items.Add(tmp);
            }
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            if (cbbHocKy.SelectedIndex >= 0)
            {
                KeyValuePair<int, int> pair = li[cbbHocKy.SelectedIndex];
                dtgv.Columns.Clear();
                dtgv.DataSource = GiangVien_BLL.Instance.GetWorkScheduleInWeek(MaGV, pair.Value, pair.Key % 2 == 0);
            }
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
                Width = 950,
                Height = 735,
                Text = "Thông báo đến lớp học phần " + MaLopHP,
                StartPosition = FormStartPosition.CenterScreen,
                AutoScaleMode = AutoScaleMode.None,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.WhiteSmoke
            };
            UC_SendNoticeToModuleClass uC_SendNotification = new UC_SendNoticeToModuleClass()
            {
                MaGV = this.MaGV,
                IsNoticeToSpecificModuleClass = true,
                MaLopHP = MaLopHP,
            };
            uC_SendNotification.HideRefreshButton();
            uC_SendNotification.Dock = DockStyle.Fill;
            frmSendNotification.Controls.Add(uC_SendNotification);
            frmSendNotification.ShowDialog();
        }
    }
}
