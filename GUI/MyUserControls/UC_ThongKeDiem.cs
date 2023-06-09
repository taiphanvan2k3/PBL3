using BLL;
using DTO;
using System;
using System.Text;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ThongKeDiem : UserControl
    {
        enum StateButtonColumn
        {
            NotExist,
            Exist
        }

        private StateButtonColumn state = StateButtonColumn.NotExist;
        public string MaGV { get; set; }
        public UC_ThongKeDiem()
        {
            InitializeComponent();
        }

        private void LoadComboBoxLopHP()
        {
            cbbLopHocPhan.Items.AddRange(GiangVien_BLL.Instance.GetClassSectionByID(MaGV).ToArray());
        }

        private void UC_ThongKeDiem_Load(object sender, EventArgs e)
        {
            LoadComboBoxLopHP();
        }

        private void cbbLopHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi click vào combobox này thì sẽ load ra các bài kiểm tra của lớp học phần đó
            if (cbbLopHocPhan.SelectedIndex >= 0)
            {
                string MaLopHP = cbbLopHocPhan.SelectedItem.ToString();
                cbbBaiKiemTra.Items.Clear();

                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();

                cbbBaiKiemTra.Items.AddRange(BaiKiemTra_BLL.Instance.GetAllExamsInSpecificModuleClass(MaLopHP).ToArray());
                if (cbbBaiKiemTra.Items.Count > 0 && state == StateButtonColumn.Exist)
                {
                    state = StateButtonColumn.NotExist;
                }
            }
        }

        private void cbbBaiKiemTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBaiKiemTra.SelectedIndex >= 0)
            {
                CBBItem selectedItem = cbbBaiKiemTra.SelectedItem as CBBItem;
                int maBaiKiemTra = Convert.ToInt32(selectedItem.Id);
                dataGridView.DataSource = BaiKiemTra_BLL.Instance.GetKetQuaKiemTra_LHP(maBaiKiemTra);
                dataGridView.Columns["maBaiKiemTra"].Visible = false;
            }
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (!(state == StateButtonColumn.Exist))
            {
                dataGridView.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Xem chi tiết", Name = "xemChiTiet" });
                state = StateButtonColumn.Exist;
                new PaintColumnButtonHelper(dataGridView, "Xem");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                int maBaiKiemTra = Convert.ToInt32(row.Cells["MaBaiKiemTra"].Value);
                string[] kqLamBai = row.Cells["SoCauDung"].Value.ToString().Split('/');
                string maLHP = cbbLopHocPhan.SelectedItem.ToString();

                string[] tenBaiKiemTra = cbbBaiKiemTra.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                LopHocPhan_DTO lhp = LopHocPhan_BLL.Instance.GetTenMonHocByMaLHP(maLHP);

                StringBuilder tenBaiKiemTraShow = new StringBuilder();
                if (tenBaiKiemTra[0] == "Test")
                    tenBaiKiemTraShow.Append("Bài Test ");
                else
                    tenBaiKiemTraShow.Append("Thi " + tenBaiKiemTra[0]);
                tenBaiKiemTraShow.Append(" kỳ " + lhp.KiHoc);
                tenBaiKiemTraShow.Append(" năm học (" + lhp.NamHoc + " - " + (lhp.NamHoc + 1) + " )");
                tenBaiKiemTraShow.Append(" " + lhp.TenHP);

                frmPhucKhao frm = new frmPhucKhao()
                {
                    MaBaiKiemTra = maBaiKiemTra,
                    TenBaiKiemTra = tenBaiKiemTraShow.ToString(),
                    TenHP = lhp.TenHP,
                    MaSV = row.Cells["MaSV"].Value.ToString(),
                    LopSH = row.Cells["LopSH"].Value.ToString(),
                    HoTen = row.Cells["HoTenSV"].Value.ToString(),
                    MaHP = cbbLopHocPhan.SelectedItem.ToString(),
                    StartTime = Convert.ToDateTime(row.Cells["ThoiGianLamBai"].Value),
                    SubmitTime = Convert.ToDateTime(row.Cells["ThoiGianNopBai"].Value),
                    SoLuongCauHoi = Convert.ToInt32(kqLamBai[1]),
                    Diem = Convert.ToDouble(row.Cells["Diem"].Value),
                    SoCauDung = Convert.ToInt32(kqLamBai[0])
                };
                frm.ShowDialog();
            }
        }
    }
}
