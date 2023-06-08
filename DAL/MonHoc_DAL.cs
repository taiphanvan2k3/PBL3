using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class MonHoc_DAL
    {
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


        public List<MON_HOC> GetAllMonHoc()
        {
            using (var db = new PBL3Entities())
            {
                return db.MON_HOC.ToList();
            }
        }
        public MON_HOC GetMonHocById(string MaMH)
        {
            using (var db = new PBL3Entities())
            {
                return db.MON_HOC.Where(p => p.MaMH == MaMH).FirstOrDefault();
            }
        }

        public bool UpdateSoTC(string MaMH, int SoTC)
        {
            using (var db = new PBL3Entities())
            {
                MON_HOC mh = GetMonHocById(MaMH);
                mh.SoTC = (byte)SoTC;
                return db.SaveChanges() > 0;
            }
        }

        public bool CheckHadSubject(string MaMH)
        {
            using (var db = new PBL3Entities())
            {
                return db.MON_HOC.Where(mh => mh.MaMH.Equals(MaMH,
                                    StringComparison.OrdinalIgnoreCase)).FirstOrDefault() != null;
            }
        }
        public bool InsertSubject(MON_HOC mh)
        {
            using (var db = new PBL3Entities())
            {
                db.MON_HOC.Add(mh);
                return db.SaveChanges() > 0;
            }
        }
    }
}
