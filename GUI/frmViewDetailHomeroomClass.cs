using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmViewDetailHomeroomClass : Form
    {
        public string MaLopSH { get; set; }
        private LopSinhHoat_AdminEdit lsh;

        private List<SinhVienLSH_View> li;
        private const int MaxRow = 8;
        private int CurrentPage;
        private int MaxPage;
        private SplitPageHelper<SinhVienLSH_View> helper;

        // Khai báo delegate và event
        public delegate void DataAddedSuccessHandler();
        public event DataAddedSuccessHandler DataAddedSuccessEvent;
        public frmViewDetailHomeroomClass()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, labelTitle);
            MaLopSH = "21CNTT - CLC1";
        }
        public frmViewDetailHomeroomClass(string MaLopSH)
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, labelTitle);
            this.MaLopSH = MaLopSH;
        }

        private void LoadData()
        {
            lsh = LopSinhHoat_BLL.Instance.GetInforOfHomeroomClass(MaLopSH);
            if (lsh != null)
            {
                lblMaLopSH.Text = lsh.MaLopSH;
                lblTenKhoa.Text = lsh.TenKhoa;
                lblMaGVCN.Text = lsh.MaGVCN;
                lblGVCN.Text = lsh.TenGVCN;
                txtSoLuongSVMax.Texts = lsh.SoLuongToiDa.ToString();
            }
        }

        private void LoadDTGV()
        {
            li = SinhVien_BLL.GetSinhVienInLopSH(MaLopSH);
            CurrentPage = 1;
            if (li.Count == 0)
                lblCurrentPage.Visible = false;
            else lblCurrentPage.Visible = true;
            MaxPage = (int)Math.Ceiling(li.Count * 1.0 / MaxRow);
            helper = new SplitPageHelper<SinhVienLSH_View>(MaxRow, li);
            dtgv.DataSource = helper.GetRecords(1);
            ChangePropertiesForColumns();
        }


        private void frmViewDetailHomeroomClass_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDTGV();
        }

        private void ChangePropertiesForColumns()
        {
            UtilityClass.SetAlignmentMiddleCenterForColumns(dtgv, dtgv.RowCount);
            dtgv.Columns["STT"].Width = 60;
            dtgv.Columns["MaSV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["Sdt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                List<SinhVienLSH_View> tmp = helper.GetRecords(CurrentPage);
                dtgv.DataSource = tmp;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                List<SinhVienLSH_View> tmp = helper.GetRecords(CurrentPage);
                dtgv.DataSource = tmp;
            }
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            ChangePropertiesForColumns();
            lblCurrentPage.Text = "Trang " + CurrentPage + " /" + MaxPage;
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lsh.MaGVCN))
            {
                frmAddStudentIntoHomeroomClass frm = new frmAddStudentIntoHomeroomClass(lsh.MaLopSH, (int)lsh.SoLuongToiDa);
                frm.reloadDTGV += new frmAddStudentIntoHomeroomClass.ReloadParentForm(LoadDTGV);
                frm.ShowDialog();
            }
            else
            {
                CustomMessageBox.Show("Bạn cần phân công giảng viên chủ nhiệm trước khi thêm sinh viên");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgv.SelectedRows.Count > 0)
            {
                List<string> li = new List<string>();
                foreach (DataGridViewRow r in dtgv.SelectedRows)
                {
                    li.Add(r.Cells["MaSV"].Value.ToString());
                }
                DialogResult result = CustomMessageBox.Show("Các sinh viên này sẽ bị xoá khỏi lớp học phần." +
                        "\nBạn có chắc chắn không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int num = LopSinhHoat_BLL.Instance.DeleteStudent(li);
                    if (num > 0)
                    {
                        CustomMessageBox.Show("Đã xoá thành công " + num + " sinh viên.");
                        LoadDTGV();
                    }
                }
                else
                    CustomMessageBox.Show("Thao tác xoá đã bị huỷ.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmViewDetailHomeroomClass_Load(sender, e);
        }

        private void btnPhanCongGV_Click(object sender, EventArgs e)
        {
            //Đang cân nhắc có cần chức năng phân công giảng viên chủ nhiệm hay
            //là phân công giảng viên ngay lúc tạo lớp sinh hoạt luôn
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update số lượng sinh viên tối đa
            if (txtSoLuongSVMax.Texts != "")
            {
                try
                {

                    int NewNumberOfStudent = Convert.ToInt32(txtSoLuongSVMax.Texts);
                    txtSoLuongSVMax.BackColor = Color.White;
                    txtSoLuongSVMax.ForeColor = Color.Black;
                    if (lsh.SoLuongToiDa != null && lsh.SoLuongToiDa != NewNumberOfStudent)
                    {
                        lsh.SoLuongToiDa = NewNumberOfStudent;
                        if (LopSinhHoat_BLL.Instance.UpdateMaxStudentInClass(MaLopSH, NewNumberOfStudent))
                            CustomMessageBox.Show("Cập nhật thành công",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CustomMessageBox.Show("Dữ liệu đã được cập nhật trước đó",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    CustomMessageBox.Show("Giá trị không phù hợp để cập nhật dữ liệu",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuongSVMax.BackColor = Color.Red;
                    txtSoLuongSVMax.ForeColor = Color.White;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
            DataAddedSuccessEvent?.Invoke();
        }
    }
}
