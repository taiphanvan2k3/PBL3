using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Chỉ có nhiệm vụ show ra danh sách sinh viên của 1 lớp học phần nào đó
    /// </summary>
    public partial class frmShowListStudentInModuleClass : Form
    {
        public string MaHP { get; set; }
        private List<SinhVienLHP_View> li;
        private const int MaxRow = 10;
        private int MaxPage;
        private int CurrentPage = 1;

        private SplitPageHelper<SinhVienLHP_View> helper;
        public frmShowListStudentInModuleClass()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, lblTitle);
        }

        private void frmShowListStudentInModuleClass_Load(object sender, EventArgs e)
        {
            li = LopHocPhan_BLL.Instance.GetSinhVienInLHP(MaHP);
            helper = new SplitPageHelper<SinhVienLHP_View>(MaxRow, li);
            if (li.Count > 0)
            {
                lblSoLuongSV.Text += " " + li.Count + " sinh viên";
                MaxPage = (int)Math.Ceiling(li.Count * 1.0 / MaxRow);
            }
            lblTitle.Text += " " + MaHP;
            dtgv.DataSource = helper.GetRecords(1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                dtgv.DataSource = helper.GetRecords(CurrentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                dtgv.DataSource = helper.GetRecords(CurrentPage);
            }
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            dtgv.Height = dtgv.ColumnHeadersHeight + dtgv.RowCount * dtgv.RowTemplate.Height;
        }
    }
}
