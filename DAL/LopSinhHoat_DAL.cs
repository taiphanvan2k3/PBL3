using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class LopSinhHoat_DAL
    {
        private PBL3Entities db;
        private static LopSinhHoat_DAL _Instance;
        public static LopSinhHoat_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LopSinhHoat_DAL();
                return _Instance;
            }
        }

        private LopSinhHoat_DAL()
        {
            db = new PBL3Entities();
        }

        public string GetMaKhoaOfLSH(string MaLopSH)
        {
            string MaGVCN = db.LOP_SINH_HOAT.Where(p => p.MaLopSH == MaLopSH).Select(p => p.MaGVCN).FirstOrDefault();
            if (!string.IsNullOrEmpty(MaGVCN))
                return GiangVien_DAL.Instance.GetMaKhoaOfGV(MaGVCN);
            return "";
        }

        public LopSinhHoat_AdminEdit GetInforOfHomeroomClass(string MaLopSH)
        {
            var li = db.LOP_SINH_HOAT.Where(lsh => lsh.MaLopSH == MaLopSH)
                .GroupJoin(db.GIANG_VIEN, lsh => lsh.MaGVCN, gv => gv.MaGV, (lsh, gv) => new
                {
                    LopSH = lsh,
                    GiangVien_tmp = gv.DefaultIfEmpty()
                })
                .SelectMany(i1 => i1.GiangVien_tmp.Select(i2 => new LopSinhHoat_AdminEdit
                {
                    MaLopSH = i1.LopSH.MaLopSH,
                    MaGVCN = i2.MaGV,
                    TenGVCN = i2.NGUOI_DUNG.Ho + " " + i2.NGUOI_DUNG.Ten,
                    TenKhoa = i2.KHOA.TenKhoa,
                    SoLuongToiDa = i1.LopSH.SoLuongToiDa
                })).FirstOrDefault();
            return li;
        }

        public int GetNumberOfStudent(string MaLopSH)
        {
            return db.LOP_SINH_HOAT.Where(lsh => lsh.MaLopSH == MaLopSH).Select(lsh => lsh.SINH_VIEN.Count).FirstOrDefault();
        }

        public bool UpdateMaxStudentInClass(string MaLopSH, int num)
        {
            LOP_SINH_HOAT lsh = db.LOP_SINH_HOAT.Where(p => p.MaLopSH == MaLopSH).FirstOrDefault();
            if (lsh != null)
            {
                lsh.SoLuongToiDa = num;
                return db.SaveChanges() > 0;
            }
            return false;
        }
        public bool InsertStudentIntoClass(string MaLopSH, string MSSV)
        {
            SINH_VIEN sv = db.SINH_VIEN.Where(p => p.MaSV == MSSV).FirstOrDefault();
            if (sv != null)
            {
                sv.MaLopSH = MaLopSH;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public int DeleteStudent(List<string> li)
        {
            foreach (string MaSV in li)
            {
                SINH_VIEN sv = db.SINH_VIEN.Where(p => p.MaSV == MaSV).FirstOrDefault();
                if (sv != null)
                    sv.MaLopSH = null;
            }
            return db.SaveChanges();
        }
    }
}
