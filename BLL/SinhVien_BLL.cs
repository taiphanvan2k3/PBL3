using DAL;
using DTO;
using System.Collections.Generic;
using System;
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
                    AnhCaNhan = nd.AnhCaNhan,
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
            return SinhVien_DAL.GetSinhVienInLopSH(MaLopSH);
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
            List<LopHocPhan_DTO> li = SinhVien_DAL.GetLichHocTrongTuan(MaSV, KiHoc);
            for (int i = 0; i < li.Count; i++)
                li[i].STT = i + 1;
            return li;
        }

        public static List<LopHocPhan_DTO> GetLichHocTrongNgay(string MaSV, int KiHoc, string Thu)
        {
            //Tận dụng lại lịch học trong tuần để lấy ra lịch học trong ngày
            var li = SinhVien_DAL.GetLichHocTrongTuan(MaSV, KiHoc);
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();
            foreach (LopHocPhan_DTO lhp in li)
            {
                if (lhp.tkb.Thu == Thu)
                    res.Add(lhp);
            }
            return res;
        }
        #endregion

        public static List<KetQuaHocTap> GetKetQuaHocTap(string MaSV)
        {
            return SinhVien_DAL.GetKetQuaHocTap(MaSV);
        }

        public static List<string> GetListKiHocLoadCBB(string MaSV)
        {
            List<string>res= new List<string>();
            int NamNhapHoc = Convert.ToInt32(MaSV.Substring(3, 2)) + 2000;
            int NamHienTai = DateTime.Now.Year;
            int stt = 1;
            for (int i = NamNhapHoc; i <= NamHienTai - 1; i++)
            {
                string str1 = "Học kỳ " + (stt++) + " ( năm học " + i + "-" + (i + 1) + " )";
                string str2 = "Học kỳ " + (stt++) + " ( năm học " + i + "-" + (i + 1) + " )";
                res.AddRange(new string[]
                {
                    str1,str2
                });
            }

            int CurrentMonth = DateTime.Now.Month;
            if (CurrentMonth >= 8 && CurrentMonth <= 11)
                res.Add("Học kỳ " + stt + " ( năm học " + NamHienTai + "-" + (NamHienTai + 1) + " )");
            return res;
        }
    }
}
