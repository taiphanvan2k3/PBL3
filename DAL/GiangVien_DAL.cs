using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiangVien_DAL
    {
        private static PBL3Entities db = new PBL3Entities();
        public static List<string> GetAllTinhThanh()
        {
            return db.cities.Select(p => p.tinhThanhPho).ToList();
        }
        public static GIANG_VIEN GetGiangVienByID(string id)
        {
            return db.GIANG_VIEN.Where(p => p.MaGV == id).Include(gv => gv.NGUOI_DUNG).
                Include(gv => gv.KHOA).SingleOrDefault();
        }
    }
}
