using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Khoa_DAL
    {
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

        public List<KHOA> GetAllKhoa()
        {
            using (var db = new PBL3Entities())
            {
                return db.KHOAs.ToList();
            }
        }
    }
}
