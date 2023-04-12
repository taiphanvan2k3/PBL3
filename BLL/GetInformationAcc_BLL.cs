using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GetInformationAcc_BLL
    {
        private static GetInformationAcc_BLL _Instance;
        public static GetInformationAcc_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GetInformationAcc_BLL();
                return _Instance;
            }
        }

        public List<InformationStudent_DTO> GetAccountStudentList()
        {
            return GetInformationAcc_DAL.Instance.GetAccountStudentList(); 
        }
        public List<InformationTeacher_DTO> GetAccountTeacherList()
        {
            return GetInformationAcc_DAL.Instance.GetAccountTeacherList();
        }
        public List<CHUONG_TRINH_DAO_TAO_DTO> GetListEducationProgram()
        {
            List<CHUONG_TRINH_DAO_TAO_DTO> newList = new List<CHUONG_TRINH_DAO_TAO_DTO>();
            foreach (CHUONG_TRINH_DAO_TAO item in GetInformationAcc_DAL.Instance.GetListEducationProgram())
            {
                CHUONG_TRINH_DAO_TAO_DTO ctdt = new CHUONG_TRINH_DAO_TAO_DTO
                {
                    MaCTDT = item.MaCTDT,
                    TenCTDT = item.TenCTDT,
                    MaKhoa = item.MaKhoa,
                };
                newList.Add(ctdt);
            }
            return newList;
        }

        public List<KHOA_DTO> GetListFaculty()
        {
            List<KHOA_DTO> newList = new List<KHOA_DTO>();
            foreach (KHOA item in GetInformationAcc_DAL.Instance.GetListFaculty())
            {
                KHOA_DTO ctdt = new KHOA_DTO
                {
                    
                    MaKhoa = item.MaKhoa,
                    TenKhoa = item.TenKhoa,
                };
                newList.Add(ctdt);
            }
            return newList;
        }

        public int GetCountStudent()
        {
           return GetInformationAcc_DAL.Instance.GetCountStudent();
        }
        public int GetCountTeacher()
        {
            return GetInformationAcc_DAL.Instance.GetCountTeacher();
        }
    }
}
