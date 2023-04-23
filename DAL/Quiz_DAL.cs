using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Quiz_DAL
    {
        private PBL3Entities db;
        private static Quiz_DAL _Instance;
        public static Quiz_DAL Instance
        {
            get 
            { 
                if(_Instance == null)
                    _Instance = new Quiz_DAL();
                return _Instance;
            }
        }
        private Quiz_DAL()
        {
            db = new PBL3Entities();
        }

        public List<CAU_HOI> GetListCauHoi(string IDMonHoc)
        {
            return db.CAU_HOI.Where(x => x.MaMH == IDMonHoc).ToList();
        }
    }
}
