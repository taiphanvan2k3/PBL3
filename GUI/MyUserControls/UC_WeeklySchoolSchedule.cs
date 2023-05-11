using BLL;
using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_WeeklySchoolSchedule : UserControl
    {
        public string MSSV { get; set; }
        public UC_WeeklySchoolSchedule()
        {
            InitializeComponent();
        }

        private void LoadCBB()
        {
            cbbHocKy.Items.AddRange(SinhVien_BLL.GetListKiHocLoadCBB(MSSV).ToArray());
            cbbHocKy.SelectedIndex = cbbHocKy.Items.Count - 1;
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
                dtgv.DataSource = li;
            }
        }
    }
}
