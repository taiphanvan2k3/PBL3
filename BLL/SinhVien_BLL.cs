using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public class SinhVien_BLL
    {

        public static bool ValidateIDStudent(string MSSV)
        {
            string pattern = "1[0-9]{8}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(MSSV);
            if (match.Success)
            {
                return SinhVien_DAL.CheckIdStudentExist(MSSV);
            }
            return false;
        }

        public static string GetNameOfHomeroomClass(string MSSV)
        {
            return SinhVien_DAL.GetNameOfHomeroomClass(MSSV);
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
                    QuocTich = nd.QuocTich,
                    MaCCCD = nd.MaCCCD,
                    Khoa = khoa.TenKhoa,
                    TenCTDT = ctdt.TenCTDT,
                    MaLopSH = sv.MaLopSH,
                    EmailCaNhan = nd.EmailCaNhan,
                    EmailTruongCap = nd.EmailTruongCap,
                    Sdt = nd.Sdt,
                    DiaChi = nd.DiaChi
                };
            }
            return null;
        }

        public static List<SinhVienLSH_View> GetSinhVienInLopSH(string MaLopSH)
        {
            List<SINH_VIEN> li = SinhVien_DAL.GetSinhVienInLopSH(MaLopSH);
            List<SinhVienLSH_View> res = new List<SinhVienLSH_View>();
            int stt = 1;
            foreach (SINH_VIEN sv in li)
            {
                NGUOI_DUNG nd = sv.NGUOI_DUNG;
                SinhVienLSH_View svView = new SinhVienLSH_View()
                {
                    STT = stt,
                    MaSV = sv.MaSV,
                    HoTen = nd.Ho + " " + nd.Ten,
                    SDT = nd.Sdt,
                    EmailCaNhan = nd.EmailCaNhan
                };
                if (sv.PHU_HUYNH.Count > 0)
                    svView.SdtNguoiThan = sv.PHU_HUYNH.FirstOrDefault().Sdt;
                res.Add(svView);
                stt++;
            }
            return res;
        }

        public static bool UpdateStudentInfo(SinhVien_DTO sv)
        {
            return SinhVien_DAL.UpdateStudentInfo(sv);
        }

        #region Các hàm xử lí chức năng xem lịch học trong ngày
        public static int GetKiHocHienTai(string MaSV)
        {
            //Nếu sinh viên chưa học môn nào cả thì KiHoc = 0
            return SinhVien_DAL.GetKiHocHienTai(MaSV);
        }

        public static List<LopHocPhan_DTO> GetLichHocTrongTuan(string MaSV, int KiHoc)
        {
            return SinhVien_DAL.GetLichHocTrongTuan(MaSV, KiHoc);
        }
        public static List<LopHocPhan_DTO> GetLichHocTrongNgay(string MaSV, int KiHoc, string Thu)
        {
            var li= SinhVien_DAL.GetLichHocTrongTuan(MaSV, KiHoc);
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();
            foreach(LopHocPhan_DTO lhp in li)
            {
                if (lhp.tkb.Thu == Thu)
                    res.Add(lhp);
            }
            return res;
        }
        #endregion

    }
}
