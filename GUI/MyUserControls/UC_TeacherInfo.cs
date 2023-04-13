using BLL;
using DTO;
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
        public UC_TeacherInfo()
        {
            InitializeComponent();
            
        }
        #region Properites
        public string IdTeacher
        {
            get => lbIdGV.Text;
            set => lbIdGV.Text = value;
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
            get => tbDanToc.Texts;
            set => tbDanToc.Texts = value;
        }
        public string QuocTich
        {
            get => tbQuocTich.Texts; 
            set => tbQuocTich.Texts = value;
        }
        public string NoiSinh
        {
            get => tbNoiSinh.Texts;
            set => tbNoiSinh.Texts = value;
        }
        public string CCCD
        { 
            get => tbCCCD.Texts; 
            set => tbCCCD.Texts = value;
        }
        public void SetDiaChi(string address)
        {
            if(address != null)
            {
                string[] parts = UtilityClass.SplitAddress(address);
                uc_Address.TinhThanhPho = parts[0];
                uc_Address.QuanHuyen = parts[1];
                uc_Address.XaPhuong = parts[2];
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
