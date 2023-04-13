using DTO;
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
        public static List<AssignTeacher> GetGiangVienWithNumberLHP()
        {
            /*var li = db.GIANG_VIEN.Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new { GIANG_VIEN = gv, NGUOI_DUNG = nd })
                                   .Join(db.LOP_HOC_PHAN, p => p.GIANG_VIEN.MaGV, lhp => lhp.MaGV, (p,lhp) => new 
                                   {
                                     MaGV = lhp.MaGV,
                                     TenGV = p.NGUOI_DUNG.Ho + " " + p.NGUOI_DUNG.Ten,
                                     SDT = p.NGUOI_DUNG.Sdt,
                                     SoLuongHPPhuTrach = 
                                   })*/
            var li = db.GIANG_VIEN
                     .Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new { GiangVien = gv, NguoiDung = nd })
                     .Join(db.LOP_HOC_PHAN, j => j.GiangVien.MaGV, lhp => lhp.MaGV, (j, lhp) => new { GiangVien = j.GiangVien, NguoiDung = j.NguoiDung, LopHocPhan = lhp })
                     .GroupBy(j => new { j.GiangVien.MaGV, HoTen = j.NguoiDung.Ho + " " + j.NguoiDung.Ten, j.NguoiDung.Sdt })
                     .Select(g => new AssignTeacher{ MaGV = g.Key.MaGV, TenGV = g.Key.HoTen, SDT = g.Key.Sdt, SoLuongHPPhuTrach = g.Count() })
                     .ToList();
            return li;
        }
    }
}
