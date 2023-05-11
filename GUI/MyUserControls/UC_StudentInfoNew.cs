using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_StudentInfoNew : UserControl
    {
        public string MSSV { get; set; }

        //UC_StudentInfoNew sẽ lưu UC_ParentInfo (đóng vai trò như trang sau),
        //còn UC_ParentInfo sẽ lưu UC_StudentInfoNew (đóng vai trò như trang trước) để việc di chuyển
        //giữa hai trang này nhanh chóng, đỡ phải tạo lại user control rồi load lên giao diện
        public UC_ParentInfo nextPage { get; set; }

        //CurrentImage chính là ảnh lưu trong CSDL
        private Image CurrentImage { get; set; }

        //bytesImage lưu một mảng các byte của ảnh được chọn từ OpenFileDialog, để lát gán vào sv.AnhCaNhan
        private byte[] bytesImage = null;
        #region Properties
        public string LabelMSSV
        {
            get => lblMSSV.Text;
            set => lblMSSV.Text = value;
        }

        public Image Avatar
        {
            set
            {
                pictureBox1.Image = value;
                CurrentImage = value;
            }
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
            /*
            string[] tmp = UtilityClass.SplitAddress(address);
            uC_AddressSelection.Init();
            uC_AddressSelection.TinhThanhPho = tmp[0];
            uC_AddressSelection.QuanHuyen = tmp[1];
            uC_AddressSelection.XaPhuong = tmp[2];
            */

            //Chuyển tiếp địa chỉ từ frmStudent qua uc_AddressSelection để load lên các combobox
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
            //vì các panel trong flowpanel tuy đã Anchor nhưng không tự động resize

            //offset là khoảng cách giữa các panel với nhau trong flowpanel
            int offset = pnlThongTinDaoTao.Location.Y;
            int heightRemains = flowLayoutRight.Height - pnlThongTinDaoTao.Height
                                                  - pnlDiaChi.Height - pnlThongTinLienLac.Height;
            pnlThongTinDaoTao.Width = flowLayoutRight.Width - 10;

            //flowpanel gồm 4 panel bên trong và giữa chúng có các offset nên để tính toán xem
            //chiều cao của mỗi panel sẽ tăng bao nhiều thì sử dụng (heightRemains - 4 * offset) / 3;
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
                //Lấy ra panel chứa this, xoá toàn bộ controls trong panel đó rồi add UC_ParentInfo vào
                Panel pnl = Parent as Panel;
                pnl.Controls.Clear();
                pnl.Controls.Add(nextPage);
            }
        }

        private void cbbNoiSinh_Click(object sender, EventArgs e)
        {
            //Nếu trước đó chưa có dữ liệu về nơi sinh của sinh viên thì hiện tại cbbNoiSinh đang trống
            //Nên bây giờ khi click vào combobox này thì load danh sách nơi sinh ra
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
                sv.QuocTich = cbbQuocTich.SelectedItem.ToString();
            else sv.QuocTich = "";

            if (bytesImage != null)
                sv.AnhCaNhan = bytesImage;
            if (SinhVien_BLL.UpdateStudentInfo(sv))
            {
                //Nếu đã cập nhật xong thì CurrentImage chính là ảnh lưu trong CSDL
                CurrentImage = pictureBox1.Image;

                //Sau khi cập nhật ảnh cá nhân ở user control này thì lấy ra ParentForm của nó để thay đổi
                //avatar góc trên bên phải
                frmStudent frm = this.ParentForm as frmStudent;
                frm.ChangeAvatarTopRight(CurrentImage);
                CustomMessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUploadAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Image files(*.jpg;.*png)|*.jpg;*.png",
                Multiselect = false
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                pictureBox1.Image = img;
                bytesImage = UtilityClass.ConvertImageToByteArray(img);
            }
        }

        private void UC_StudentInfoNew_ParentChanged(object sender, EventArgs e)
        {
            //Làm như này để giả sử đã mở file chọn ảnh lên rồi nhưng chưa bấm nút lưu thì khi chuyển lại tab
            //này thì vẫn giữ lại ảnh cũ trước khi chọn ảnh mới
            pictureBox1.Image = CurrentImage;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(MSSV);
            frmChangePassword.ShowDialog();
        }
    }
}
