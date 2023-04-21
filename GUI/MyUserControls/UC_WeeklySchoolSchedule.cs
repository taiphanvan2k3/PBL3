using BLL;
using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_WeeklySchoolSchedule : UserControl
    {
        public string MSSV { get; set; }
        private int NamNhapHoc;
        public UC_WeeklySchoolSchedule()
        {
            InitializeComponent();
        }

        private void LoadCBB()
        {
            NamNhapHoc = Convert.ToInt32(MSSV.Substring(3, 2)) + 2000;
            int stt = 0;
            for (int i = NamNhapHoc; i <= DateTime.Now.Year - 1; i++)
            {
                string str1 = "Học kỳ " + (++stt) + " ( năm học " + i + "-" + (i + 1) + " )";
                stt++;
                string str2 = "Học kỳ " + stt + " ( năm học " + i + "-" + (i + 1) + " )";
                cbbHocKy.Items.AddRange(new string[]
                {
                    str1,str2
                });
            }
        }
        private void UC_WeeklySchoolSchedule_Load(object sender, EventArgs e)
        {
            LoadCBB();
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

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            if (cbbHocKy.SelectedIndex >= 0)
            {
                int KiHoc = cbbHocKy.SelectedIndex + 1;
                var li = SinhVien_BLL.GetLichHocTrongTuan(MSSV, KiHoc);
                for (int i = 0; i < li.Count; i++)
                    li[i].STT = i + 1;
                dtgv.DataSource = li;
            }
        }
    }
}
