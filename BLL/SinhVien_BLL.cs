using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class SinhVien_BLL
    {
        public static List<string> GetNoiSinh()
        {
            return SinhVien_DAL.GetAllTinhThanh();
        }

        public static SinhVien_DTO GetSinhVienById(string id)
        {
            SINH_VIEN sv = SinhVien_DAL.GetSinhVienById(id);
            if (sv != null)
            {
                NGUOI_DUNG nd = sv.NGUOI_DUNG;
                CHUONG_TRINH_DAO_TAO ctdt = sv.CHUONG_TRINH_DAO_TAO;
                KHOA khoa = ctdt.KHOA;
                return new SinhVien_DTO()
                {
                    MaNguoiDung = nd.MaNguoiDung,
                    Ho = nd.Ho,
                    Ten = nd.Ten,
                    NgaySinh = nd.NgaySinh,
                    NoiSinh = nd.NoiSinh,
                    GioiTinh = nd.GioiTinh,
                    DanToc = nd.DanToc,
                    QuocTinh = nd.QuocTinh,
                    MaCCCD = nd.MaCCCD,
                    Khoa = khoa.TenKhoa,
                    TenCTDT = ctdt.TenCTDT,
                    MaLopSH = sv.MaLopSH,
                    EmailCaNhan = nd.EmailCaNhan,
                    Sdt = nd.Sdt,
                    DiaChi = nd.DiaChi
                };
            }
            return null;
        }
    }
}
