using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GetInformationAcc_DAL
    {
        private static GetInformationAcc_DAL _Instance;
        public static GetInformationAcc_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new GetInformationAcc_DAL();
                return _Instance;
            }
        }
        public List<InformationAcc_DTO> GetAccountRoleList()
        {
            using (var context = new PBL3Entities())
            {
                var query = from tt in context.THONG_TIN_DANG_NHAP
                            join nd in context.NGUOI_DUNG on tt.TaiKhoan equals nd.MaNguoiDung
                            join sv in context.SINH_VIEN on nd.MaNguoiDung equals sv.MaSV
                            select new InformationAcc_DTO
                            {
                                TaiKhoan = tt.TaiKhoan,
                                VaiTro = tt.VaiTro,
                                Ten = nd.Ho + " " + nd.Ten,
                                MaCCCD = nd.MaCCCD,
                                EmailTruongCap = nd.EmailTruongCap,
                                MaCTDT = sv.MaCTDT
                            };
                return query.ToList();
            }
        }

        public List<CHUONG_TRINH_DAO_TAO> GetListEducationProgram()
        {
            using(var context = new PBL3Entities()) { 
                var info = context.CHUONG_TRINH_DAO_TAO.ToList();
                return info;
            }
        }

        public int GetCountStudent()
        {
            using (var context = new PBL3Entities())
            {
                var soLuongBanGhi = context.SINH_VIEN.Count();
                return soLuongBanGhi;
            }
        }

        //public List<InformationAcc_DTO> GetAccountRoleList()
        //{
        //    using (var context = new PBL3Entities())
        //    {
        //        var accountRoles = new List<InformationAcc_DTO>();
        //        var loginInfos = context.THONG_TIN_DANG_NHAP.ToList();
        //        foreach (var loginInfo in loginInfos)
        //        {
        //            var userInfo = context.NGUOI_DUNG.FirstOrDefault(u => u.MaNguoiDung == loginInfo.TaiKhoan);
        //            if (userInfo != null)
        //            {
        //                var svInfo = context.SINH_VIEN.FirstOrDefault(sv => sv.MaSV == userInfo.MaNguoiDung);
        //                var accountRole = new InformationAcc_DTO
        //                {
        //                    TaiKhoan = loginInfo.TaiKhoan,
        //                    VaiTro = loginInfo.VaiTro,
        //                    Ten = userInfo.Ho + " " + userInfo.Ten,
        //                    MaCCCD = userInfo.MaCCCD,
        //                    EmailTruongCap = userInfo.EmailTruongCap,
        //                    MaCTDT = svInfo?.MaCTDT
        //                };
        //                accountRoles.Add(accountRole);
        //            }
        //        }
        //        return accountRoles;
        //    }
        //}



    }
}
