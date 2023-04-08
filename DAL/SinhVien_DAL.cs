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

        public static SINH_VIEN GetSinhVienById(string id)
        {
            return db.SINH_VIEN.Where(p => p.MaSV == id).Include(sv => sv.NGUOI_DUNG).
                Include(sv => sv.CHUONG_TRINH_DAO_TAO).Include(sv => sv.CHUONG_TRINH_DAO_TAO.KHOA).SingleOrDefault();
        }
    }
}
