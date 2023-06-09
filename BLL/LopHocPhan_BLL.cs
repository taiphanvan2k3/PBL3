using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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

        public int GetNumberOfStudentInClass(string MaLopHP)
        {
            return LopHocPhan_DAL.Instance.GetNumberOfStudentInClass(MaLopHP);
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

        /// <summary>
        /// Trả về các thông tin cần như: mã HP, tênHP,SoTC,MaGV,HoGV,KiHoc,NamHoc,Thu,TietBD,TietKT
        /// </summary>
        /// <param name="MaHP"></param>
        /// <returns></returns>
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

        #region các hàm dùng trong việc add,delete lớp học phần
        public int InsertModuleClass(LopHocPhan_AdminEdit lhp)
        {
            bool CheckIsExist = GetLopHocPhanByMaHP(lhp.MaHP) != null;
            if (!CheckIsExist)
            {
                LOP_HOC_PHAN NewModuleClass = new LOP_HOC_PHAN()
                {
                    MaMH = lhp.MaMH,
                    MaLopHP = lhp.MaHP,
                    NamHoc = lhp.NamHoc,
                    KiHoc = lhp.KiHoc,
                    SoLuongToiDa = lhp.SoLuongMax
                };

                //1: thêm thành công, 0: thêm thất bại
                if (LopHocPhan_DAL.Instance.InsertModuleClass(NewModuleClass))
                    return 1;
                return 0;
            }
            //Đã có lớp học phần này rồi
            return -1;
        }
        #endregion


        public List<InformationClass_DTO> GetInformationClasses()
        {
            return LopHocPhan_DAL.Instance.GetInformationClasses();
        }

        public int CountMoudleClass()
        {
            return LopHocPhan_DAL.Instance.CountModuleClass();
        }

        public List<ThongBao_DTO> GetNotificationsInSpecificBound(string MaSV, DateTime StartDateFilter)
        {
            return LopHocPhan_DAL.Instance.GetNotificationsInSpecificBound(MaSV, StartDateFilter);
        }

        public bool DeleteMoudleClass(string idClass)
        {
            return LopHocPhan_DAL.Instance.DeleteModuleClass(idClass);
        }
        public List<InformationSubject_DTO> getListSubjects()
        {
            return LopHocPhan_DAL.Instance.getListSubjects();
        }

        public List<string> getListStudent(string maKhoa, string maLHP)
        {
            return LopHocPhan_DAL.Instance.getListStudent(maKhoa, maLHP);
        }

        public LopHocPhan_DTO GetTenMonHocByMaLHP(string MaLHP)
        {
            return LopHocPhan_DAL.Instance.GetInfoLopHocPhanByMaLHP(MaLHP);
        }
    }
}
