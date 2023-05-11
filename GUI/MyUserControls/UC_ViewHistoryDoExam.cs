using BLL;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ViewHistoryDoExam : UserControl
    {
        // Phục vụ tìm kiếm
        private AutoCompleteStringCollection AutoCompleteText;

        private SplitPageHelper<KetQuaLamKiemTra> helper;
        private const int maxRow = 8;
        private int currentPage, maxPage;

        private List<KetQuaLamKiemTra> kqLamBai;
        public string MaSV { get; set; }
        public UC_ViewHistoryDoExam()
        {
            InitializeComponent();
        }

        #region Các event liên quan đến giao diện
        private void btnExpandPanelSearch_Click(object sender, EventArgs e)
        {
            if (btnExpandPanelSearch.IconChar == IconChar.AngleDown)
            {
                btnExpandPanelSearch.IconChar = IconChar.AngleUp;
                panelSearch.Height = panelSearch.MaximumSize.Height;
            }
            else
            {
                btnExpandPanelSearch.IconChar = IconChar.AngleDown;
                panelSearch.Height = panelSearch.MinimumSize.Height;
            }
        }

        private void btnExpandPanelShow_Click(object sender, EventArgs e)
        {
            if (btnExpandPanelShow.IconChar == IconChar.AngleDown)
            {
                btnExpandPanelShow.IconChar = IconChar.AngleUp;
                panelShow.Height = panelShow.MaximumSize.Height;
            }
            else
            {
                btnExpandPanelShow.IconChar = IconChar.AngleDown;
                panelShow.Height = panelShow.MinimumSize.Height;
            }
        }

        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            //Do các control bên trong flowLayout không thể tự anchor nên phải resize thủ công
            panelSearch.Width = flowLayoutPanelMain.Width - 20;
            panelShow.Width = flowLayoutPanelMain.Width - 20;
        }

        private void panelDTGV_SizeChanged(object sender, EventArgs e)
        {
            //Do các control bên trong flowLayout không thể tự anchor nên phải resize thủ công
            dtgv.Width = panelDTGV.Width - 20;
        }
        #endregion

        public void LoadData()
        {
            kqLamBai = BaiKiemTra_BLL.Instance.GetAllKetQuaLamBai(MaSV);
            if (kqLamBai.Count > 0)
            {
                AutoCompleteText = new AutoCompleteStringCollection();
                AutoCompleteText.AddRange(kqLamBai.Select(p => p.TenMH + " - " + p.MaHP).Distinct().ToArray());
                txtTenHP.AutoCompleteCustomSource = AutoCompleteText;
            }
            cbbKiHoc.Items.Clear();
            cbbKiHoc.Items.Add("Xem tất cả");
            cbbKiHoc.Items.AddRange(SinhVien_BLL.GetListKiHocLoadCBB(MaSV).ToArray());

            //Hiển thị dữ liệu lên datagridview
            maxPage = (int)Math.Ceiling(kqLamBai.Count * 1.0 / maxRow);
            currentPage = 1;
            helper = new SplitPageHelper<KetQuaLamKiemTra>(maxRow, kqLamBai);
            cbbKiHoc.SelectedIndex = 0;
        }

        private void UC_ViewHistoryDoExam_Load(object sender, EventArgs e)
        {
            //Tạo riêng ra phương thức LoadData mà không viết vào event load vì
            //event load chỉ gọi duy nhất 1 lần lúc tạo user control, nhưng muốn mỗi lần chuyển tab
            //thì cập nhật lại giao diện nên sẽ gọi phương thức này mỗi khi bấm vào tab xem lịch sử
            LoadData();
        }

        private void cbbKiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbbKiHoc.SelectedIndex;
            List<KetQuaLamKiemTra> li;
            if (idx == 0)
                li = kqLamBai;
            else
                li = kqLamBai.Where(i => i.KiHoc == idx).ToList();
            ChangeListOfSplitPageHelper(li);
            dtgv.Columns["TenMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv.Columns["ThoiGianLamBai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv.Columns["ThoiGianNopBai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv.Columns["TenBaiKiemTra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv.Columns["SoLanViPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void ChangeListOfSplitPageHelper(List<KetQuaLamKiemTra> li)
        {
            //Vì lúc này kết quả sau khi lọc đã không còn giống với List kqLamBai
            //nên phải thay đổi List mà helper đang giữ để di chuyển trang đúng trên danh sách
            //vừa lọc ra
            helper.ChangeList(li);
            currentPage = 1;
            if (li.Count != 0)
            {
                maxPage = (int)Math.Ceiling(li.Count * 1.0 / maxRow);
                dtgv.DataSource = helper.GetRecords(currentPage);
            }
            else
            {
                maxPage = 1;

                //Biết li.Count==0 rồi nhưng vẫn gán vào DataSource để cập nhật lại
                //dtgv và label trang
                dtgv.DataSource = li;
            }
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            lblPage.Text = "Trang " + currentPage + "/" + maxPage;
            int CurrentRow = dtgv.RowCount;
            if (CurrentRow < 5)
                CurrentRow = 5;
            dtgv.Height = dtgv.ColumnHeadersHeight + CurrentRow * dtgv.RowTemplate.Height;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTenHP.Text != "")
            {
                //Nếu combobox đang là xem tất cả thì IsFilterAll = true
                bool IsFilterAll = true;
                if (cbbKiHoc.SelectedIndex > 0)
                    IsFilterAll = false;
                string[] ds = txtTenHP.Text.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                var li = kqLamBai.Where(p => p.TenMH == ds[0] && p.MaHP == ds[1]
                && (IsFilterAll || p.KiHoc == cbbKiHoc.SelectedIndex)).ToList();
                ChangeListOfSplitPageHelper(li);
            }
            else
            {
                //Nếu như textbox trống thì lọc theo combobox
                cbbKiHoc_SelectedIndexChanged(sender, e);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                dtgv.DataSource = helper.GetRecords(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                dtgv.DataSource = helper.GetRecords(currentPage);
            }
        }
    }
}
