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
                OrderBy(sv => sv.MaSV).ToList();
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
                    nd.EmailCaNhan = sv.EmailCaNhan;
                if (sv.Sdt != "")
                    nd.Sdt = sv.Sdt;
                if (sv.NoiSinh != "")
                    nd.NoiSinh = sv.NoiSinh;
                if (sv.DanToc != "")
                    nd.DanToc = sv.DanToc;
                if (sv.QuocTich != "")
                    nd.QuocTich = sv.QuocTich;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        #region Các hàm xử lí chức năng xem lịch học trong ngày, trong tuần
        public static int GetKiHocHienTai(string MaSV)
        {
            //Kì học đếm như sau: 1,2,3,4,5,6,7,8|,9,10
            int KiHocHienTai = db.SINHVIEN_LOPHOCPHAN.Where(p => p.MaSV == MaSV)
                .GroupJoin(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    Hocphan_tmp = hp.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.Hocphan_tmp.Select(i2 => new
                {
                    i2.KiHoc
                })).OrderByDescending(i => i.KiHoc).Select(i => i.KiHoc).FirstOrDefault();
            return KiHocHienTai;
        }

        public static List<LopHocPhan_DTO>GetLichHocTrongTuan(string MaSV,int KiHoc)
        {
            //Một khi đã thêm được sv vào lớp học phần thì lúc này chắc chắn đã phân công GV rồi
            //nên không sợ chưa có GiangVien, đỡ phải GroupJoin với GIANG_VIEN. Và một khi phân công được
            //giảng viên thì chứng tỏ đã có dữ liệu về TKB rồi
            var li = db.SINHVIEN_LOPHOCPHAN.Where(i => i.MaSV == MaSV)
                .GroupJoin(db.LOP_HOC_PHAN, svhp => svhp.MaLopHP, hp => hp.MaLopHP, (svhp, hp) => new
                {
                    Hocphan_tmp = hp.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.Hocphan_tmp.Select(i2 => new
                {
                    i2.MaLopHP,
                    i2.MON_HOC.TenMH,
                    i2.MON_HOC.SoTC,
                    i2.KiHoc,
                    HoTenGV = i2.GIANG_VIEN.NGUOI_DUNG.Ho + " " + i2.GIANG_VIEN.NGUOI_DUNG.Ten
                }))
                .Where(i => i.KiHoc == KiHoc)
                .Join(db.THOI_KHOA_BIEU, hp => hp.MaLopHP, tkb => tkb.MaLopHP, (hp, tkb) => new LopHocPhan_DTO()
                {
                    MaHP = hp.MaLopHP,
                    TenHP = hp.TenMH,
                    TenGV = hp.HoTenGV,
                    SoTC = hp.SoTC,
                    KiHoc = hp.KiHoc,
                    tkb = new ThoiKhoaBieu_DTO()
                    { Thu = tkb.Thu, TietBD = tkb.TietBD, TietKT = tkb.TietKetThuc, Phong = tkb.MaPhongHoc }
                }).ToList();
            return li;
        }
        #endregion
    }
}
