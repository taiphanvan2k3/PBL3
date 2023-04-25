using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public string GetMaKhoaOfGV(string MaGVCN)
        {
            return db.GIANG_VIEN.Where(gv => gv.MaGV == MaGVCN).Select(p => p.MaKhoa).FirstOrDefault();
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
                     .Select(g => new AssignTeacher { MaGV = g.Key.MaGV, TenGV = g.Key.HoTen, SDT = g.Key.Sdt, SoLuongHPPhuTrach = g.Count() })
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
            var query = db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == maLHP).FirstOrDefault();
            query.MaGV = id;
            var RecordToDelete = db.THOI_KHOA_BIEU.FirstOrDefault(x => x.LOP_HOC_PHAN.MaLopHP == maLHP);
            if (RecordToDelete != null)
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
        public void AssignTeacherNoChangeSchedule(string id, string maLHP)
        {
            var query = db.LOP_HOC_PHAN.Where(lhp => lhp.MaLopHP == maLHP).FirstOrDefault();
            query.MaGV = id;
            db.SaveChanges();
        }
        public string GetMaKhoaByMaLHP(string maLHP)
        {
            return db.LOP_HOC_PHAN
                   .Join(db.MON_HOC, lhp => lhp.MaMH, mh => mh.MaMH, (lhp,mh) => new
                   {
                       lhp.MaLopHP,
                       mh.MaMH,
                       mh.MaKhoa
                   }).Where(p=>p.MaLopHP == maLHP).Select(p=>p.MaKhoa).FirstOrDefault();
        }
        #region Ver2
        public List<AssignTeacher> GetGVPhuHopTKB(string MaLHP, string Thu, int? TietBD, int? TietKT)
        {
            string MaKhoa = GetMaKhoaByMaLHP(MaLHP);
             List<string> li1 = db.GIANG_VIEN.Where(gv => gv.MaKhoa == MaKhoa).Select(p => p.MaGV).ToList();

             List<string>li2=db.GIANG_VIEN.Where(gv=>gv.MaKhoa==MaKhoa)
                .Join(db.LOP_HOC_PHAN, gv => gv.MaGV, lhp => lhp.MaGV, (gv, lhp) => new
                {
                    gv.MaGV,
                    lhp.MaLopHP
                })
                .Join(db.THOI_KHOA_BIEU,gv=>gv.MaLopHP,tkb=>tkb.MaLopHP,(gv,tkb)=> new
                {
                    gv.MaGV,
                    tkb.Thu,
                    tkb.TietBD,
                    tkb.TietKetThuc
                }).Where(p=>p.Thu==Thu && !(p.TietBD>TietKT || p.TietKetThuc<TietBD)).Select(p=>p.MaGV).ToList();
            List<string> li = li1.Except(li2).ToList();
            return db.GIANG_VIEN
                .Join(db.NGUOI_DUNG, gv => gv.MaGV, nd => nd.MaNguoiDung, (gv, nd) => new
                {
                    GiangVien = gv,
                    NguoiDung = nd
                })
                .GroupJoin(db.LOP_HOC_PHAN, gv => gv.GiangVien.MaGV, lhp => lhp.MaGV, (gv, lhp) => new
                {
                    GiangVien = gv,
                    LopHocPhan = lhp
                })
                .SelectMany(x => x.LopHocPhan.DefaultIfEmpty(), (x, sublhp) => new { x.GiangVien, LopHocPhan = sublhp })
                .Where(p => li.Contains(p.GiangVien.GiangVien.MaGV))
                .GroupBy(x => new { x.GiangVien.GiangVien.MaGV, x.GiangVien.NguoiDung.Ho, x.GiangVien.NguoiDung.Ten, x.GiangVien.NguoiDung.Sdt })
                .Select(grp => new AssignTeacher
                {
                    MaGV = grp.Key.MaGV,
                    TenGV = grp.Key.Ho + " " + grp.Key.Ten,
                    SDT = grp.Key.Sdt,
                    SoLuongHPPhuTrach = grp.Count(x => x.LopHocPhan != null)
                }).ToList();
        }
        #endregion
    }
}
