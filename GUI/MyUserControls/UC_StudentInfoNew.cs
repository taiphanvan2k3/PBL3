using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_StudentInfoNew : UserControl
    {
        public string MSSV { get; set; }
        public UC_ParentInfo nextPage { get; set; }
        #region Properties
        public string LabelMSSV
        {
            get => lblMSSV.Text;
            set => lblMSSV.Text = value;
        }
        public string HoVaTen
        {
            get => lblHoVaTen.Text;
            set => lblHoVaTen.Text = value;
        }

        public string NgaySinh
        {
            get => lblNgaySinh.Text;
            set => lblNgaySinh.Text = value;
        }

        public string NoiSinh
        {
            get
            {
                if (cbbNoiSinh.SelectedIndex >= 0)
                    return cbbNoiSinh.Text;
                return "empty";
            }
            set => cbbNoiSinh.SelectedItem = value;
        }

        public string DanToc
        {
            get
            {
                if (cbbDanToc.SelectedIndex >= 0)
                    return cbbDanToc.Text;
                return "empty";
            }
            set => cbbDanToc.SelectedItem = value;
        }

        public string QuocTinh
        {
            get
            {
                if (cbbQuocTich.SelectedIndex >= 0)
                    return cbbQuocTich.Text;
                return "empty";
            }
            set => cbbQuocTich.SelectedItem = value;
        }

        public string CCCD
        {
            get => lblCCCD.Text;
            set => lblCCCD.Text = value;
        }

        public bool GioiTinh
        {
            get
            {
                if (lblGioiTinh.Text == "" || lblGioiTinh.Text == "Nam")
                    return true;
                return false;
            }
            set
            {
                if (value)
                    lblGioiTinh.Text = "Nam";
                else lblGioiTinh.Text = "Nữ";
            }
        }

        public string Khoa
        {
            get => txtKhoa.Text;
            set => txtKhoa.Text = value;
        }

        public string ChuongTrinhDaoTao
        {
            get => txtCTDT.Text;
            set => txtCTDT.Text = value;
        }

        public string LopSinhHoat
        {
            get => txtLopSH.Text;
            set => txtLopSH.Text = value;
        }

        public string SoDuong
        {
            get => txtSoDuong.Text;
            set => txtSoDuong.Text = value;
        }

        public string SoDienThoai
        {
            get => txtSDT.Text;
            set => txtSDT.Text = value;
        }

        public string EmailCaNhan
        {
            get => txtEmailCaNhan.Text;
            set => txtEmailCaNhan.Text = value;
        }

        public string EmailTruongCap
        {
            get => txtEmailTruongCap.Text;
            set => txtEmailTruongCap.Text = value;
        }

        public void LoadCBBNoiSinh()
        {
            cbbNoiSinh.Items.AddRange(AddressSelection_BLL.Instance.GetAllTinhThanh().ToArray());
        }

        private void LoadCBBDanToc_QuocTich()
        {
            cbbDanToc.Items.AddRange(UtilityClass.GetDanToc());
            cbbQuocTich.Items.AddRange(UtilityClass.GetQuocTich());
        }
        public void SetDiaChi(string address)
        {
            //string[] tmp = UtilityClass.SplitAddress(address);
            //uC_AddressSelection.Init();
            //uC_AddressSelection.TinhThanhPho = tmp[0];
            //uC_AddressSelection.QuanHuyen = tmp[1];
            //uC_AddressSelection.XaPhuong = tmp[2];
            uC_AddressSelection.SetDiaChi(address);
        }
        #endregion
        public UC_StudentInfoNew()
        {
            InitializeComponent();
            LoadCBBDanToc_QuocTich();
        }

        private void flowLayoutRight_Resize(object sender, EventArgs e)
        {
            //Khi flowpanel thay đổi kích thước thì phải thay đổi là kích thước của các panel bên trong
            //vì các panel trong flowpanel không thể tự Anchor

            //offset là khoảng cách giữa các panel với nhau trong flowpanel
            int offset = pnlThongTinDaoTao.Location.Y;
            int heightRemains = flowLayoutRight.Height - pnlThongTinDaoTao.Height
                                                  - pnlDiaChi.Height - pnlThongTinLienLac.Height;
            pnlThongTinDaoTao.Width = flowLayoutRight.Width - 10;
            pnlThongTinDaoTao.Height += (heightRemains - 4 * offset) / 3;

            //Không thay đổi chiều cao cho pnlDiaChi, vì thay đổi nữa thì khoảng trống dư quá nhiều
            pnlDiaChi.Width = pnlThongTinDaoTao.Width;

            pnlThongTinLienLac.Width = pnlThongTinDaoTao.Width;
            pnlThongTinLienLac.Height += (heightRemains - 4 * offset) / 3;
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (nextPage == null)
            {
                nextPage = new UC_ParentInfo();
                nextPage.MSSV = MSSV;
                nextPage.previousPage = this;
                nextPage.Dock = DockStyle.Fill;
                //Load dữ liệu 1 lần thôi, nếu cứ mỗi lần add Control Parent lại load thì rất lag
                nextPage.LoadData();
            }
            if (Parent is Panel)
            {
                Panel pnl = Parent as Panel;
                pnl.Controls.Clear();
                pnl.Controls.Add(nextPage);
            }
        }

        private void cbbNoiSinh_Click(object sender, EventArgs e)
        {
            if (cbbNoiSinh.Items.Count == 0)
                LoadCBBNoiSinh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.MaNguoiDung = MSSV;
            string address = "";
            if (txtSoDuong.Text != "" && uC_AddressSelection.TinhThanhPho != ""
                && uC_AddressSelection.QuanHuyen != ""
                && uC_AddressSelection.XaPhuong != "")
            {
                address += txtSoDuong.Text + " - " + uC_AddressSelection.TinhThanhPho + " - " +
                    uC_AddressSelection.QuanHuyen + " - " + uC_AddressSelection.XaPhuong;
                sv.DiaChi = address;
            }
            else
            {
                CustomMessageBox.Show("Phần thông tin địa chỉ không được lưu vì chưa nhập đầy đủ.");
                sv.DiaChi = "";
            }
            sv.EmailCaNhan = txtEmailCaNhan.Text;
            sv.Sdt = txtSDT.Text;
            if (cbbNoiSinh.SelectedIndex >= 0)
                sv.NoiSinh = cbbNoiSinh.SelectedItem.ToString();
            else sv.NoiSinh = "";

            if (cbbDanToc.SelectedIndex >= 0)
                sv.DanToc = cbbDanToc.SelectedItem.ToString();
            else sv.DanToc = "";

            if (cbbQuocTich.SelectedIndex >= 0)
                sv.QuocTinh = cbbQuocTich.SelectedItem.ToString();
            else sv.QuocTinh = "";
            if (SinhVien_BLL.UpdateStudentInfo(sv))
                CustomMessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
