using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_XemKetQuaHocTap : UserControl
    {
        public string MaSV { get; set; }

        //Sử dụng List cục bộ này để mỗi lần lựa chọn trên combobox thì lọc trên List này, đỡ phải vào CSDL
        private List<KetQuaHocTap> kqHocTap;
        public UC_XemKetQuaHocTap()
        {
            InitializeComponent();
        }

        private void UC_XemKetQuaHocTap_Load(object sender, EventArgs e)
        {
            kqHocTap = SinhVien_BLL.GetKetQuaHocTap(MaSV);
            cbbKiHoc.Items.Add("Xem tất cả");
            cbbKiHoc.Items.AddRange(SinhVien_BLL.GetListKiHocLoadCBB(MaSV).ToArray());
            cbbKiHoc.SelectedIndex = 0;
        }

        private void SetIdForRows(List<KetQuaHocTap> li)
        {
            for (int i = 0; i < li.Count; i++)
                li[i].STT = i + 1;
        }

        private void cbbKiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKiHoc.SelectedIndex >= 0)
            {
                int idx = cbbKiHoc.SelectedIndex;
                List<KetQuaHocTap> li = kqHocTap;
                if (idx >= 1)
                    li = kqHocTap.Where(i => i.KiHoc == idx).ToList();
                SetIdForRows(li);
                dtgv.DataSource = li;
            }
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            dtgv.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["TenMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
