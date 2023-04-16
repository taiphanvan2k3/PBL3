﻿using BLL;
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
        private SplitPageHelper<SinhVienLSH_View> helper;
        public UC_ViewHomeRoomClass()
        {
            InitializeComponent();
        }

        private void changePropertiesForColumns(int NumberOfRow = maxRow)
        {
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgv.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dtgv.Columns["MaSV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["MaSV"].Width = 180;

            dtgv.Columns["HoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgv.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SDT"].Width = 150;

            dtgv.Columns["SdtNguoiThan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SdtNguoiThan"].Width = 230;

            dtgv.Columns["EmailCaNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Height = dtgv.ColumnHeadersHeight + NumberOfRow * dtgv.RowTemplate.Height;
        }

        public void LoadData()
        {
            //Hàm này sẽ được gọi thủ công sau khi UC này được add vào panel
            li = SinhVien_BLL.GetSinhVienInLopSH(MaLopSH);
            lblSoLuongSV.Text = "Danh sách này có: " + li.Count + " sinh viên.";

            //Hiển thị dữ liệu lên datagridview
            maxPage = (int)Math.Ceiling(li.Count * 1.0 / maxRow);
            currentPage = 1;
            helper = new SplitPageHelper<SinhVienLSH_View>(maxRow, li);
            dtgv.DataSource = helper.GetRecords(currentPage);
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
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            dtgv.DataSource = helper.GetRecords(currentPage);
        }

        private void btnLastPage(object sender, EventArgs e)
        {
            currentPage = maxPage;
            dtgv.DataSource = helper.GetRecords(currentPage);
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            lbCurrentPage.Text = "Trang " + currentPage + "/" + maxPage;
            changePropertiesForColumns(dtgv.RowCount);
        }
    }
}
