using BLL;
using DTO;
using System;
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
    }
}
