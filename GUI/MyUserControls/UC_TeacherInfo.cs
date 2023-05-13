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
        public string TenGV
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
            get => tbEmailCaNhan.Text;
            set => tbEmailCaNhan.Text = value;
        }
        public string EmailTruongCap
        {
            get => tbEmailTruongCap.Text; 
            set => tbEmailTruongCap.Text = value;
        }
        public string SDT
        {
            get => tbSDT.Text;
            set => tbSDT.Text = value;
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
        #endregion
        #region Methods
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
            UC_Address.SetDiaChi(address);
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

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(IdTeacher);
            frmChangePassword.ShowDialog();
        }


        #endregion
    }
}
