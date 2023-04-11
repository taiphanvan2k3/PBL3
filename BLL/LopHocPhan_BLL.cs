using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class LopHocPhan_BLL
    {
        private static LopHocPhan_BLL _Instance;
        public static LopHocPhan_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LopHocPhan_BLL();
                return _Instance;
            }
        }

        public int GetKiHocHienTai(string MSSV)
        {
            return LopHocPhan_DAL.Instance.GetKiHocHienTai(MSSV);
        }

        public List<LopHocPhan_DTO> GetDailySchoolSchedule(string MSSV, string Thu, int KiHoc, int NamHoc)
        {
            List<LopHocPhan_DTO> li = LopHocPhan_DAL.Instance.GetListHocPhanOfStudent(MSSV, KiHoc, NamHoc);
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();
            foreach (LopHocPhan_DTO lhp in li)
            {
                if (lhp.tkb != null && lhp.tkb.Thu == Thu)
                    res.Add(lhp);
            }
            return res;
        }

        public List<LopHocPhan_DTO> GetWeeklySchoolSchedule(string MSSV, int KiHoc, int NamHoc)
        {
            return LopHocPhan_DAL.Instance.GetListHocPhanOfStudent(MSSV, KiHoc, NamHoc);
        }
    }
}
