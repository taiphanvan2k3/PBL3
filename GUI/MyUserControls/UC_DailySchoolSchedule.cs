using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DailySchoolSchedule : UserControl
    {
        public string MSSV { get; set; }
        public UC_DailySchoolSchedule()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
        }
        private void lblShowDateTime_Click(object sender, EventArgs e)
        {
            dateTimePicker.Select();
            SendKeys.Send("%{Down}");
        }

        private string GetDayOfWeek(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "CN -";
            DayOfWeek[] ds = { DayOfWeek.Sunday,DayOfWeek.Sunday,DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
                                DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };
            string res = null;
            for (int i = 2; i <= 7; i++)
            {
                if (dt.DayOfWeek == ds[i])
                    res = "T" + i + " -";
            }
            return res;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            lblShowDateTime.Text = GetDayOfWeek(date) + " " + dateTimePicker.Value.ToShortDateString();
        }

        private void LoadData()
        {
            //Hàm này sẽ được dùng khi có dữ liệu về lớp học phần
            string Thu = GetDayOfWeek(dateTimePicker.Value);
            //int kiHienTai = LopHocPhan_BLL.Instance.GetKiHocHienTai(MSSV);
            //List<LopHocPhan_DTO> li = LopHocPhan_BLL.Instance.GetDailySchoolSchedule(MSSV, Thu,
            //                                                  kiHienTai, DateTime.Now.Year);
            //MessageBox.Show("Số bản ghi trả về: " + li.Count);
            //dtgv.DataSource = li;
        }
        private void btnXemLich_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
