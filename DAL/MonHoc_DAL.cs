using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class MonHoc_DAL
    {
        private PBL3Entities db;
        private static MonHoc_DAL _Instance;
        public static MonHoc_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MonHoc_DAL();
                return _Instance;
            }
        }

        private MonHoc_DAL()
        {
            db = new PBL3Entities();
        }

        public List<MON_HOC> GetAllMonHoc()
        {
            return db.MON_HOC.ToList();
        }
        public MON_HOC GetMonHocById(string MaMH)
        {
            return db.MON_HOC.Where(p => p.MaMH == MaMH).FirstOrDefault();
        }

        public bool UpdateSoTC(string MaMH, int SoTC)
        {
            MON_HOC mh = GetMonHocById(MaMH);
            mh.SoTC = (byte)SoTC;
            return db.SaveChanges() > 0;
        }

        public bool CheckHadSubject(string MaMH)
        {
            return db.MON_HOC.Where(mh => mh.MaMH.Equals(MaMH, 
                                    StringComparison.OrdinalIgnoreCase)).FirstOrDefault() != null;
        }
        public bool InsertSubject(MON_HOC mh)
        {
            db.MON_HOC.Add(mh);
            return db.SaveChanges() > 0;
        }
    }
}
