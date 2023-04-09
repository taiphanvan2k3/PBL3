using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhuHuynh_DAL
    {
        private static PBL3Entities db = new PBL3Entities();
        public static List<PHU_HUYNH> GetPhuHuynhByIdStudent(string mssv)
        {
            //Sắp xếp theo MoiQuanHe để Cha - Con trả về trước Mẹ - Con
            return db.PHU_HUYNH.Where(ph => ph.MaSV == mssv).OrderBy(ph => ph.MoiQuanHe).ToList();
        }
    }
}
