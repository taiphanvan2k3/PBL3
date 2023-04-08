using System;

namespace DTO
{
    public class NguoiDung_DTO
    {
        public string MaNguoiDung { get; set; }
        public string MaCCCD { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public byte[] AnhCaNhan { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string QuocTinh { get; set; }
        public string NoiSinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string EmailCaNhan { get; set; }
        public string EmailTruongCap { get; set; }
        public string MkEmailTruongCap { get; set; }
        public NguoiDung_DTO() { }

        public NguoiDung_DTO(string maNguoiDung, string maCCCD, string ho, string ten, byte[] anhCaNhan,
            DateTime ngaySinh, bool gioiTinh, string danToc, string quocTinh, string noiSinh, string diaChi,
            string sdt, string emailCaNhan, string emailTruongCap, string mkEmailTruongCap)
        {
            MaNguoiDung = maNguoiDung;
            MaCCCD = maCCCD;
            Ho = ho;
            Ten = ten;
            AnhCaNhan = anhCaNhan;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DanToc = danToc;
            QuocTinh = quocTinh;
            NoiSinh = noiSinh;
            DiaChi = diaChi;
            Sdt = sdt;
            EmailCaNhan = emailCaNhan;
            EmailTruongCap = emailTruongCap;
            MkEmailTruongCap = mkEmailTruongCap;
        }
    }
}
