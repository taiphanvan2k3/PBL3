using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Khoa_DAL
    {
        private PBL3Entities db;
        private static Khoa_DAL _Instance;
        public static Khoa_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Khoa_DAL();
                return _Instance;
            }
        }

        private Khoa_DAL()
        {
            db = new PBL3Entities();
        }

        public List<KHOA> GetAllKhoa()
        {
            return db.KHOAs.ToList();
        }
    }
}
