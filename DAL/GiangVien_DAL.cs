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
        private PBL3Entities db;
        private static GiangVien_DAL _Instance;
        public static GiangVien_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GiangVien_DAL();
                return _Instance;
            }
        }

        private GiangVien_DAL()
        {
            db = new PBL3Entities();
        }
        public List<string> GetAllTinhThanh()
        {
            return db.cities.Select(p => p.tinhThanhPho).ToList();
        }
        public GIANG_VIEN GetGiangVienByID(string id)
        {
            return db.GIANG_VIEN.Where(p => p.MaGV == id).Include(gv => gv.NGUOI_DUNG).
                Include(gv => gv.KHOA).SingleOrDefault();
        }
        public List<string> GetMaLopHPByID(string id)
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
        public List<AssignTeacher> GetGiangVienWithNumberLHP()
        {
            var li = db.GIANG_VIEN
                     .Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new { GiangVien = gv, NguoiDung = nd })
                     .Join(db.LOP_HOC_PHAN, j => j.GiangVien.MaGV, lhp => lhp.MaGV, (j, lhp) => new { GiangVien = j.GiangVien, NguoiDung = j.NguoiDung, LopHocPhan = lhp })
                     .GroupBy(j => new { j.GiangVien.MaGV, HoTen = j.NguoiDung.Ho + " " + j.NguoiDung.Ten, j.NguoiDung.Sdt })
                     .Select(g => new AssignTeacher{ MaGV = g.Key.MaGV, TenGV = g.Key.HoTen, SDT = g.Key.Sdt, SoLuongHPPhuTrach = g.Count() })
                     .ToList();
            return li;
        }
        public bool CheckTKBGiangVienConflict(string id, string thu, int TietBD, int TietKT)
        {
            var li = db.THOI_KHOA_BIEU
                     .Join(db.LOP_HOC_PHAN, tkb => tkb.MaLopHP, lhp => lhp.MaLopHP, (tkb, lhp) => new { TKB = tkb, LHP = lhp })
                     .Join(db.GIANG_VIEN, x => x.LHP.MaGV, gv => gv.MaGV, (x, gv) => new { x.TKB, x.LHP, GV = gv })
                     .Where(x => x.GV.MaGV == id && x.TKB.Thu == thu && ((x.TKB.TietBD >= TietBD && x.TKB.TietBD <= TietKT) || (x.TKB.TietKetThuc >= TietBD && x.TKB.TietKetThuc <= TietKT)))
                     .Select(x => x.TKB).ToList();
            //Nếu list rỗng thì không có xung đột trả về true
            return (li.Count == 0 ? true : false);
        }
        public void AssignTeacherToSectionClass(string id, string thu, int TietBD, int TietKT, string phong, string maLHP)
        {
            /*var query = db.THOI_KHOA_BIEU
                        .Join(db.LOP_HOC_PHAN, tkb => tkb.MaLopHP, lhp => lhp.MaLopHP, (tkb, lhp) => new { TKB = tkb, LHP = lhp })
                        .Where(x => x.LHP.MaLopHP == maLHP);
            foreach(var i in query)
            {
                i.LHP.MaGV = id;
                i.TKB.Thu = thu;
                i.TKB.TietBD = Convert.ToByte(TietBD);
                i.TKB.TietKetThuc = Convert.ToByte(TietKT);
                i.TKB.MaPhongHoc = phong;
            }*/
            var query = db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == maLHP).FirstOrDefault();
            query.MaGV = id;
            var RecordToDelete = db.THOI_KHOA_BIEU.FirstOrDefault(x => x.LOP_HOC_PHAN.MaLopHP == maLHP);
            if(RecordToDelete != null )
            {
                db.THOI_KHOA_BIEU.Remove(RecordToDelete);
                db.SaveChanges();  
            }
            var NewRecord = new THOI_KHOA_BIEU
            {
                MaLopHP = maLHP,
                MaPhongHoc = phong,
                Thu = thu,
                TietBD = Convert.ToByte(TietBD),
                TietKetThuc = Convert.ToByte(TietKT)
            };
            db.THOI_KHOA_BIEU.Add(NewRecord);
            db.SaveChanges();
        }
    }
}
