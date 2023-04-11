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

        public List<InformationAcc_DTO> GetAccountRoleList()
        {
            return GetInformationAcc_DAL.Instance.GetAccountRoleList(); 
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

        public int GetCountStudent()
        {
           return GetInformationAcc_DAL.Instance.GetCountStudent();
        }
    }
}
