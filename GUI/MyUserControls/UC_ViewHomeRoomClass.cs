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
        public UC_ViewHomeRoomClass()
        {
            InitializeComponent();
        }

        private void changePropertiesForColumns()
        {
            dtgv.Columns["MaSV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["MaSV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dtgv.Columns["HoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgv.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dtgv.Columns["SdtNguoiThan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SdtNguoiThan"].Width = 150;

            dtgv.Columns["EmailCaNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void UC_ViewHomeRoomClass_Load(object sender, EventArgs e)
        {
            List<SinhVienLSH_View> li = SinhVien_BLL.GetSinhVienInLopSH(MaLopSH);
            dtgv.DataSource = li;
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            changePropertiesForColumns();
        }
    }
}
