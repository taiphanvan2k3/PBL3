using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Form này dùng để hiển thị ra thông tin chi tiết của một lớp học phần nào đó.
    /// Ở đây có thể edit các thông tin của lớp học phần, xem danh sách sinh viên của lớp
    /// học phần đó, phân công giảng viên,...
    /// </summary>
    public partial class frmViewDetailModuleClass : Form
    {
        public string MaHP { get; set; }
        private LopHocPhan_AdminEdit lhp;
        private List<SinhVienLHP_View> li;
        private const int MaxRow = 8;
        private int CurrentPage = 1;
        private int MaxPage;
        private SplitPageHelper<SinhVienLHP_View> helper;
        public frmViewDetailModuleClass()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, labelTitle);
        }

        private void ChangeColumnProperties(int NumberOfRow)
        {
            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["MSSV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["LopSH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Height = dtgv.ColumnHeadersHeight + NumberOfRow * dtgv.RowTemplate.Height;
        }

        private void LoadDataGridView()
        {
            CurrentPage = 1;
            li = LopHocPhan_BLL.Instance.GetSinhVienInLHP(MaHP);
            MaxPage = (int)Math.Ceiling(li.Count * 1.0 / MaxRow);
            helper = new SplitPageHelper<SinhVienLHP_View>(MaxRow, li);
            dtgv.Columns.Clear();
            dtgv.DataSource = helper.GetRecords(CurrentPage);
            ChangeColumnProperties(MaxRow);
        }
        public void LoadData()
        {
            MaHP = "OOAD21.13";
            lhp = LopHocPhan_BLL.Instance.GetLopHocPhanByMaHP(MaHP);
            txtMaHP.Text = lhp.MaHP;
            txtTenMH.Texts = lhp.TenHP;
            cbbSoTC.SelectedItem = lhp.SoTc;
            txtHocKy.Text = lhp.KiHoc.ToString();
            txtNamHoc.Text = lhp.NamHoc.ToString();
            //Nếu đã phân công giảng viên dạy rồi
            if (!string.IsNullOrEmpty(lhp.MaGV))
            {
                txtMaGV.Text = lhp.MaGV;
                txtTenGV.Texts = lhp.HoTenGV;
            }


            if (!string.IsNullOrEmpty(lhp.Thu))
            {
                //Nếu đã xếp lịch dạy
                lblThu.Text = lhp.Thu;
                lblPhong.Text = lhp.MaPhong;
                lblTietBD.Text = "Tiết " + lhp.TietBD;
                lblTietKT.Text = "Tiết " + lhp.TietKT;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_ViewDetailModuleClass_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataGridView();
        }

        private void btnPhanCongGV_Click(object sender, EventArgs e)
        {
            frmAssignTeacher frm = new frmAssignTeacher();
            frm.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                List<SinhVienLHP_View> tmp = helper.GetRecords(CurrentPage);
                dtgv.DataSource = tmp;
                ChangeColumnProperties(tmp.Count);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                List<SinhVienLHP_View> tmp = helper.GetRecords(CurrentPage);
                dtgv.DataSource = tmp;
                ChangeColumnProperties(tmp.Count);
            }
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            lblCurrentPage.Text = "Trang " + CurrentPage + " /" + MaxPage;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //Lấy lại dữ liệu cũ trước khi edit
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbbSoTC.SelectedIndex >= 0)
            {
                int SoTC = Convert.ToInt32(cbbSoTC.SelectedItem);
                if (SoTC != lhp.SoTc)
                    LopHocPhan_BLL.Instance.UpdateSoTC(MaHP, SoTC);
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (lhp.Thu != "")
            {
                //Chỉ có thể thêm sinh viên khi lớp học phần này đã được xếp thời khoá biểu
                //Một khi đã có thứ trong tuần thì chắc chắn đã có TietBD,TietKT nên có thể ép
                //kiểu int? thành int
                frmAddStudent frm = new frmAddStudent(lhp.MaHP, lhp.KiHoc, lhp.Thu,
                    (int)lhp.TietBD, (int)lhp.TietKT);
                frm.reloadDTGV += new frmAddStudent.ReloadParentForm(LoadDataGridView);
                frm.ShowDialog();
            }
            else
            {
                CustomMessageBox.Show("Lớp học phần chưa được xếp thời khoá biểu.\nKhông thể thêm sinh viên",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}