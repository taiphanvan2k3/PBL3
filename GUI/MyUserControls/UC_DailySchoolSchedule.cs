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

        //Đặt làm phương thức để truy vấn duy nhất 1 lần để lấy ra KiHocHienTai ở mỗi phiên đăng nhập
        private int KiHocHienTai = 0;
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

        /// <summary>
        /// Hiển thị thứ dưới dạng T2,T3,...,CN lên lblShowDateTime
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string GetDayOfWeek(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "CN";
            DayOfWeek[] ds = { DayOfWeek.Sunday,DayOfWeek.Sunday,DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
                                DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };
            string res = null;
            for (int i = 2; i <= 7; i++)
            {
                if (dt.DayOfWeek == ds[i])
                    res = "T" + i;
            }
            return res;
        }

        /// <summary>
        /// Trả về thứ trong tuần (Thứ hai, Thứ ba,...,Chủ nhật) 
        /// </summary>
        /// <param name="dow"></param>
        /// <returns></returns>
        private string GetDayOfWeekLongString(string dow)
        {
            if (dow == "CN")
                return "Chủ nhật";
            string[] ds = new string[]
            {
                "","","hai","ba","tư","năm","sáu","bảy"
            };
            for (int i = 2; i <= 7; i++)
            {
                string tmp = i + "";
                if (dow.Contains(tmp))
                    return "Thứ " + ds[i];
            }
            return "";
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            lblShowDateTime.Text = GetDayOfWeek(date) + " - " + dateTimePicker.Value.ToShortDateString();
        }

        private void LoadData()
        {
            string Thu = GetDayOfWeekLongString(GetDayOfWeek(dateTimePicker.Value));
            if (KiHocHienTai == 0)
                KiHocHienTai = SinhVien_BLL.GetKiHocHienTai(MSSV);
            
            //Chỉ hiển thị lịch học trong ngày khi sinh viên đã học một môn nào đó
            if (KiHocHienTai != 0)
            {
                List<LopHocPhan_DTO> li = SinhVien_BLL.GetLichHocTrongNgay(MSSV, KiHocHienTai, Thu);
                for (int i = 0; i < li.Count; i++)
                    li[i].STT = i + 1;
                dtgv.DataSource = li;
            }
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeColumnProperties()
        {
            UtilityClass.SetAlignmentMiddleCenterForColumns(dtgv, dtgv.RowCount);
            dtgv.Columns["STT"].Width = 80;
            dtgv.Columns["MaHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["SoTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["tkb"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            ChangeColumnProperties();
        }
    }
}
