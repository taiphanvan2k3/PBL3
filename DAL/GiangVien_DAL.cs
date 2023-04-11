using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public static List<string> GetMaLopHPByID(string id)
        {
            return db.LOP_HOC_PHAN.
                      Join(
                            db.GIANG_VIEN,
                            lhp => lhp.MaGV,
                            gv => gv.MaGV,
                            (lhp, gv) => new { lhp, gv }
                      ).Where(x => x.gv.MaGV == id)
                      .Select(x => x.lhp.MaLopHP).ToList();

        }
    }
}
