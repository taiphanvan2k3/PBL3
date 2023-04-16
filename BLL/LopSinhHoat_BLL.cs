using DAL;

namespace BLL
{
    public class LopSinhHoat_BLL
    {
        private static LopSinhHoat_BLL _Instance;
        public static LopSinhHoat_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new LopSinhHoat_BLL();
                return _Instance;
            }
        }
        private LopSinhHoat_BLL() { }

        public string GetMaKhoaOfLSH(string MaLopSH)
        {
            return LopSinhHoat_DAL.Instance.GetMaKhoaOfLSH(MaLopSH);
        }

        public int GetNumberOfStudent(string MaLopSH)
        {
            return LopSinhHoat_DAL.Instance.GetNumberOfStudent(MaLopSH);
        }

        public bool InsertStudentIntoClass(string MaLopSH, string MSSV)
        {
            return LopSinhHoat_DAL.Instance.InsertStudentIntoClass(MaLopSH, MSSV);
        }
    }
}
