using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class SinhVien_DAL
    {
        private static PBL3Entities db = new PBL3Entities();

        public static List<string> GetAllTinhThanh()
        {
            return db.cities.Select(p => p.tinhThanhPho).ToList();
        }

        public static bool CheckIdStudentExist(string MSSV)
        {
            return db.THONG_TIN_DANG_NHAP.Where(p => p.TaiKhoan == MSSV
                                          && p.VaiTro == "Sinh Viên").FirstOrDefault() != null;
        }

        public static string GetNameOfHomeroomClass(string MSSV)
        {
            return db.SINH_VIEN.Where(sv => sv.MaSV == MSSV).Select(sv => sv.MaLopSH).FirstOrDefault();
        }
        public static SINH_VIEN GetSinhVienById(string id)
        {
            #region Trước đó
            //return db.SINH_VIEN.Where(p => p.MaSV == id).Include(sv => sv.NGUOI_DUNG).
            //    Include(sv => sv.CHUONG_TRINH_DAO_TAO).Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA).SingleOrDefault();
            #endregion

            //Do hầu như lấy hết tất cả cột của bảng NguoiDung và Khoa nên mới dùng Include trong trường hợp này
            //Ko cần phải Include(sv => sv.CHUONG_TRINH_DAO_TAO) vì đã có trong
            //Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA)
            return db.SINH_VIEN.Where(p => p.MaSV == id).Include(sv => sv.NGUOI_DUNG)
                .Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA).SingleOrDefault();
        }

        public static List<SINH_VIEN> GetSinhVienInLopSH(string MaLopSH)
        {
            return db.SINH_VIEN.Where(p => p.MaLopSH == MaLopSH).Include(sv => sv.PHU_HUYNH).
                OrderBy(sv => sv.NGUOI_DUNG.Ten).ToList();
        }

        public static bool UpdateStudentInfo(SinhVien_DTO sv)
        {
            //Hàm này dùng trong frmStudent để cập nhật thông tin cá nhân
            NGUOI_DUNG nd = db.NGUOI_DUNG.Where(p => p.MaNguoiDung == sv.MaNguoiDung).FirstOrDefault();
            if (nd != null)
            {
                if (sv.DiaChi != "")
                    nd.DiaChi = sv.DiaChi;
                if (sv.EmailCaNhan != "")
                    nd.EmailTruongCap = sv.EmailCaNhan;
                if (sv.Sdt != "")
                    nd.Sdt = sv.Sdt;
                if (sv.NoiSinh != "")
                    nd.NoiSinh = sv.NoiSinh;
                if (sv.DanToc != "")
                    nd.DanToc = sv.DanToc;
                if (sv.QuocTinh != "")
                    nd.QuocTich = sv.QuocTinh;
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
