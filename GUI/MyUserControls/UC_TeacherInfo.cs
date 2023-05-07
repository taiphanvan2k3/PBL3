using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_TeacherInfo : UserControl
    {
        private Image CurrentImage { get; set; }
        private byte[] bytesImage = null;
        public UC_TeacherInfo()
        {
            InitializeComponent();
            LoadCBBNoiSinh();
            LoadCBBDanToc_QuocTich();
        }
        #region Properites
        public string IdTeacher
        {
            get => lbIdGV.Text;
            set => lbIdGV.Text = value;
        }
        public Image Avatar
        {
            set
            {
                pcbImageGV.Image = value;
                CurrentImage = value;
            }
        }
        public string Name
        {
            get => lbName.Text;
            set => lbName.Text = value;
        }
        public string Khoa
        {
            get => lbNameKhoa.Text;
            set => lbNameKhoa.Text = value;
        }
        public string NgaySinh
        {
            get => lbNgaySinh.Text;
            set => lbNgaySinh.Text = value;
        }
        public string GioiTinh
        {
            get => lbGioiTinh.Text; 
            set => lbGioiTinh.Text = value;
        }
        public string TrinhDo
        {
            get => lbTrinhDo.Text;
            set => lbTrinhDo.Text = value;
        }
        public string Luong
        {
            get => lbLuong.Text; 
            set => lbLuong.Text = value;
        }
        public string EmailCaNhan
        {
            get => tbEmailCaNhan.Texts;
            set => tbEmailCaNhan.Texts = value;
        }
        public string EmailTruongCap
        {
            get => tbEmailTruongCap.Texts; 
            set => tbEmailTruongCap.Texts = value;
        }
        public string SDT
        {
            get => tbSDT.Texts;
            set => tbSDT.Texts = value;
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

        public string QuocTich
        {
            get
            {
                if (cbbQuocTich.SelectedIndex >= 0)
                    return cbbQuocTich.Text;
                return "empty";
            }
            set => cbbQuocTich.SelectedItem = value;
        }
        /*public string NoiSinh
        {
            get => tbNoiSinh.Texts;
            set => tbNoiSinh.Texts = value;
        }*/
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
        public string CCCD
        { 
            get => tbCCCD.Texts; 
            set => tbCCCD.Texts = value;
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
            //string[] parts = UtilityClass.SplitAddress(address);
            //uc_Address.TinhThanhPho = parts[0];
            //uc_Address.QuanHuyen = parts[1];
            //uc_Address.XaPhuong = parts[2];
            UC_Address.SetDiaChi(address);
        }

        private void pnlRight_Resize(object sender, EventArgs e)
        {
            //int offset = gbTTLienHe.Location.Y;
            //int heightRemains = pnlRight.Height - gbTTLienHe.Height
            //                                      - pnlAddress.Height - pnlInfoAnother.Height;
            //gbTTLienHe.Width = pnlRight.Width - 10;
            //gbTTLienHe.Height += (heightRemains - 4 * offset) / 3;

            ////Không thay đổi chiều cao cho pnlDiaChi, vì thay đổi nữa thì khoảng trống dư quá nhiều
            //pnlAddress.Width = gbTTLienHe.Width;

            //pnlInfoAnother.Width = gbTTLienHe.Width;
            //pnlInfoAnother.Height += (heightRemains - 4 * offset) / 3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GiangVien_DTO gv = new GiangVien_DTO();
            gv.MaNguoiDung = IdTeacher;
            string address = "";
            if (UC_Address.TinhThanhPho != "" && UC_Address.QuanHuyen != "" && UC_Address.XaPhuong != "")
            {
                address += UC_Address.TinhThanhPho + " - " + UC_Address.QuanHuyen + " - " + UC_Address.XaPhuong;
                gv.DiaChi = address;
            }
            else
            {
                CustomMessageBox.Show("Phần thông tin địa chỉ không được lưu vì chưa nhập đầy đủ.");
                gv.DiaChi = "";
            }
            gv.EmailCaNhan = tbEmailCaNhan.Text;
            gv.Sdt = tbSDT.Text;
            if (cbbNoiSinh.SelectedIndex >= 0)
                gv.NoiSinh = cbbNoiSinh.SelectedItem.ToString();
            else gv.NoiSinh = "";

            if (cbbDanToc.SelectedIndex >= 0)
                gv.DanToc = cbbDanToc.SelectedItem.ToString();
            else gv.DanToc = "";

            if (cbbQuocTich.SelectedIndex >= 0)
                gv.QuocTich = cbbQuocTich.SelectedItem.ToString();
            else gv.QuocTich = "";

            if (bytesImage != null)
                gv.AnhCaNhan = bytesImage;
            if (GiangVien_BLL.Instance.UpdateTeacherInfo(gv))
            {
                CurrentImage = pcbImageGV.Image;
                CustomMessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbbNoiSinh_Click(object sender, EventArgs e)
        {
            if (cbbNoiSinh.Items.Count == 0)
                LoadCBBNoiSinh();
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
                pcbImageGV.Image = img;
                bytesImage = UtilityClass.ConvertImageToByteArray(img);
            }
        }
        #endregion
        /*void LoadInfo(string Account)
        {
            GiangVien_DTO gv = GiangVienBLL.Instance.GetGiangVienById(Account);
            lbName.Text = gv.Ten;
            lbIdGV.Text = gv.MaNguoiDung;
            lbNameKhoa.Text = gv.Khoa;
            lbNgaySinh.Text = gv.NgaySinh.ToShortDateString();
            lbGioiTinh.Text = (gv.GioiTinh) ? "Nam" : "Nữ";
            lbTrinhDo.Text = gv.TrinhDo;
            lbLuong.Text = gv.Luong.ToString();
            tbEmailCaNhan.Texts = gv.EmailCaNhan;
            tbEmailTruongCap.Texts = gv.EmailTruongCap;
            tbSDT.Texts = gv.Sdt;
            tbDanToc.Texts = gv.DanToc;
            tbQuocTich.Texts = gv.QuocTinh;
            tbNoiSinh.Texts = gv.NoiSinh;
            tbCCCD.Texts = gv.MaCCCD;
            SetDiaChi(gv.DiaChi);
        }*/
    }
}
