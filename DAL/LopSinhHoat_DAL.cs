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

        public int GetNumberOfStudent(string MaLopSH)
        {
            return db.LOP_SINH_HOAT.Where(lsh => lsh.MaLopSH == MaLopSH).Select(lsh => lsh.SINH_VIEN.Count).FirstOrDefault();
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
    }
}
