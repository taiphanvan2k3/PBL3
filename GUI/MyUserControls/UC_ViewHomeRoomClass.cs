using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ViewHomeRoomClass : UserControl
    {
        public string MaLopSH { get; set; }
        private const int maxRow = 10;
        private int currentPage, maxPage;
        private List<SinhVienLSH_View> li;
        public UC_ViewHomeRoomClass()
        {
            InitializeComponent();
        }

        private void changePropertiesForColumns()
        {
            dtgv.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dtgv.Columns["MaSV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["MaSV"].Width = 200;

            dtgv.Columns["HoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgv.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SDT"].Width = 150;

            dtgv.Columns["SdtNguoiThan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SdtNguoiThan"].Width = 230;

            dtgv.Columns["EmailCaNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;    
        }

        public void LoadData()
        {
            //Hàm này sẽ được gọi thủ công sau khi UC này được add vào panel
            li = SinhVien_BLL.GetSinhVienInLopSH(MaLopSH);
            //Test di chuyển trang
            li.AddRange(li);
            li.AddRange(li);
            li.AddRange(li);
            li.AddRange(li);
            li.AddRange(li);
            lblSoLuongSV.Text = "Danh sách này có: " + li.Count + " sinh viên.";

            //Hiển thị dữ liệu lên datagridview
            maxPage = (int)Math.Ceiling(li.Count * 1.0 / maxRow);
            currentPage = 1;
            ShowPage(currentPage);
        }

        #region Không còn dùng
        private void UC_ViewHomeRoomClass_Load(object sender, EventArgs e)
        {
            //Nếu dùng Load thì có thể sẽ không nhất quán dữ liệu vì hàm load chỉ được gọi duy nhất một lần
        }

        private void UC_ViewHomeRoomClass_Paint(object sender, PaintEventArgs e)
        {
            //Nếu dùng hàm Paint thì mỗi lần phóng to, thu nhỏ nó lại gọi lại hàm Paint này nên việc
            //load lại data là không cần thiết
        }
        #endregion

        private void ShowPage(int page)
        {
            lbCurrentPage.Text = "Trang " + page + "/" + maxPage;
            int start = (page - 1) * maxRow;
            int num = 10;
            if (start + maxRow > li.Count)
                num = li.Count % maxRow;

            dtgv.DataSource = li.GetRange(start, num);
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            changePropertiesForColumns();
            dtgv.Height = dtgv.ColumnHeadersHeight + num * dtgv.RowTemplate.Height;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ShowPage(currentPage);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            ShowPage(1);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            currentPage = maxPage;
            ShowPage(maxPage);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                ShowPage(currentPage);
            }
        }
    }
}
