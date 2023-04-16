using DAL;
using DTO;
using System.Collections.Generic;
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

        #region Xử lí bên giao diện sinh viên
        /*public int GetKiHocHienTai(string MSSV)
        {
            return LopHocPhan_DAL.Instance.GetKiHocHienTai(MSSV);
        }*/

        /*public List<LopHocPhan_DTO> GetDailySchoolSchedule(string MSSV, string Thu, int KiHoc, int NamHoc)
        {
            List<LopHocPhan_DTO> li = LopHocPhan_DAL.Instance.GetListHocPhanOfStudent(MSSV, KiHoc, NamHoc);
            List<LopHocPhan_DTO> res = new List<LopHocPhan_DTO>();
            foreach (LopHocPhan_DTO lhp in li)
            {
                if (lhp.tkb != null && lhp.tkb.Thu == Thu)
                    res.Add(lhp);
            }
            return res;
        }*/

        /*public List<LopHocPhan_DTO> GetWeeklySchoolSchedule(string MSSV, int KiHoc, int NamHoc)
        {
            return LopHocPhan_DAL.Instance.GetListHocPhanOfStudent(MSSV, KiHoc, NamHoc);
        }*/
        #endregion

        public LopHocPhan_AdminEdit GetLopHocPhanByMaHP(string MaHP)
        {
            return LopHocPhan_DAL.Instance.GetHocPhanByMaHP(MaHP);
        }

        public List<SinhVienLHP_View> GetSinhVienInLHP(string MaHP)
        {
            List<SinhVienLHP_View> li = LopHocPhan_DAL.Instance.GetSinhVienInLHP(MaHP);
            int stt = 1;
            foreach (var sv in li)
                sv.STT = stt++;
            return li;
        }

        public bool UpdateSoTC(string MaHP, int SoTC)
        {
            return LopHocPhan_DAL.Instance.UpdateSoTC(MaHP, SoTC);
        }

        /// <summary>
        /// Hàm này trả về 3 trường hợp:
        /// null -> không va chạm;
        /// not null nhưng Count == 0 -> sv này đã được thêm vào lớp HP. 
        /// Và trường hợp còn lại là va chạm lịch học
        /// </summary>
        /// <param name="MaHP"></param>
        /// <param name="MaSV"></param>
        /// <param name="KiHoc"></param>
        /// <param name="Thu"></param>
        /// <param name="TietBD"></param>
        /// <param name="TietKT"></param>
        /// <returns></returns>
        public List<LopHocPhan_AdminEdit> GetListHocPhanConflictOfStudent(string MaHP, string MaSV, int KiHoc,
                                                                        string Thu, int TietBD, int TietKT)
        {
            List<LopHocPhan_AdminEdit> li = LopHocPhan_DAL.Instance.GetListHocPhanOfStudent_AddSV(MaSV, KiHoc);
            List<LopHocPhan_AdminEdit> conflict = null;
            foreach (LopHocPhan_AdminEdit lhp in li)
            {
                if (lhp.MaHP == MaHP)
                {
                    //Thể hiện là đã có sinh viên này trong lớp HP
                    return new List<LopHocPhan_AdminEdit>();
                }
                if (lhp.Thu == Thu && !(TietKT < lhp.TietBD || TietBD > lhp.TietKT))
                {
                    //Đã xảy ra va chạm lịch
                    if (conflict == null)
                        conflict = new List<LopHocPhan_AdminEdit>();
                    conflict.Add(lhp);
                }
            }
            //Trả về danh sách các lớp HP bị va chạm
            return conflict;
        }

        public void AddStudentIntoClass(string MaHP, string MaSV)
        {
            LopHocPhan_DAL.Instance.AddStudentIntoClass(MaHP, MaSV);
        }

        public bool DeleteStudent(string MaHP, List<string> liMSSV)
        {
            return LopHocPhan_DAL.Instance.DeleteStudent(MaHP, liMSSV);
        }

        public string GetMaKhoaOfLHP(string MaHP)
        {
            return LopHocPhan_DAL.Instance.GetMaKhoaOfLHP(MaHP);
        }
    }
}
