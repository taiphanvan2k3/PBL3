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

        public InformationStudent_DTO GetInformationStudentByID(string id)
        {
            return GetInformationAcc_DAL.Instance.GetInformationStudentByID(id);
        }

        public InformationTeacher_DTO GetInformationTeacherByID(string id)
        {
            return GetInformationAcc_DAL.Instance.GetInformationTeacherByID(id);
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


        public int getTheNumberOfStudentByFaculty(string maKhoa, string year)
        {
            return GetInformationAcc_DAL.Instance.getTheNumberOfStudentByFaculty(maKhoa, year);
        }
        public int getTheNumberOfTeacherByFaculty(string maKhoa)
        {
            return GetInformationAcc_DAL.Instance.getTheNumberOfTeacherByFaculty(maKhoa);
        }


        public bool InsertData(THONG_TIN_DANG_NHAP_DTO loginInfo, NguoiDung_DTO userInfo, object specificInfo)
        {

            THONG_TIN_DANG_NHAP tndn = new THONG_TIN_DANG_NHAP
            {
                TaiKhoan = loginInfo.TaiKhoan,
                VaiTro = loginInfo.VaiTro,
                MkUngDung = loginInfo.MkUngDung,
                MaXacThucDeLayLaiMK = loginInfo.MaXacThucDeLayLaiMK,
                ThoiGianTao = loginInfo.ThoiGianTao
               
            };
            NGUOI_DUNG nd = new NGUOI_DUNG()
            {
                MaNguoiDung = userInfo.MaNguoiDung,
                Ho = userInfo.Ho,
                Ten = userInfo.Ten,
                MaCCCD = userInfo.MaCCCD,
                AnhCaNhan = userInfo.AnhCaNhan,
                NgaySinh = userInfo.NgaySinh,
                GioiTinh = userInfo.GioiTinh,
                DanToc = userInfo.DanToc,
                QuocTich = userInfo.QuocTich,
                NoiSinh = userInfo.NoiSinh,
                DiaChi = userInfo.DiaChi,
                Sdt = userInfo.Sdt,
                EmailCaNhan = userInfo.EmailCaNhan,
                EmailTruongCap = userInfo.EmailTruongCap,
                MkEmailTruongCap = userInfo.MkEmailTruongCap
            };

            if (specificInfo.GetType() == typeof(SinhVien_DTO))
            {
                SinhVien_DTO svDt = new SinhVien_DTO();
                svDt = (SinhVien_DTO)specificInfo;
                SINH_VIEN sv = new SINH_VIEN()
                {
                    MaSV = svDt.MaNguoiDung,
                    MaLopSH = svDt.MaLopSH,
                    MaCTDT = svDt.MaCTDT
                };
                specificInfo = sv;
            }
            else if (specificInfo.GetType() == typeof(GiangVien_DTO))
            {
                GiangVien_DTO gtDt = new GiangVien_DTO();
                gtDt = (GiangVien_DTO)specificInfo;
                GIANG_VIEN gv = new GIANG_VIEN()
                {
                    MaGV = gtDt.MaNguoiDung,
                    TrinhDo = gtDt.TrinhDo,
                    Luong = gtDt.Luong,
                    MaKhoa = gtDt.MaKhoa
                };
                specificInfo = gv;
            }
            return GetInformationAcc_DAL.Instance.InsertData(tndn, nd, specificInfo);
        }

        public bool UpdateData(string taiKhoan, THONG_TIN_DANG_NHAP_DTO newLoginInfo, NguoiDung_DTO newUserInfo, object newSpecificInfo)
        {

            THONG_TIN_DANG_NHAP tndn = new THONG_TIN_DANG_NHAP
            {
                TaiKhoan = newLoginInfo.TaiKhoan,
                VaiTro = newLoginInfo.VaiTro,
                MkUngDung = newLoginInfo.MkUngDung,
                MaXacThucDeLayLaiMK = newLoginInfo.MaXacThucDeLayLaiMK
            };
            NGUOI_DUNG nd = new NGUOI_DUNG()
            {
                MaNguoiDung = newUserInfo.MaNguoiDung,
                Ho = newUserInfo.Ho,
                Ten = newUserInfo.Ten,
                MaCCCD = newUserInfo.MaCCCD,
                AnhCaNhan = newUserInfo.AnhCaNhan,
                NgaySinh = newUserInfo.NgaySinh,
                GioiTinh = newUserInfo.GioiTinh,
                DanToc = newUserInfo.DanToc,
                QuocTich = newUserInfo.QuocTich,
                NoiSinh = newUserInfo.NoiSinh,
                DiaChi = newUserInfo.DiaChi,
                Sdt = newUserInfo.Sdt,
                EmailCaNhan = newUserInfo.EmailCaNhan,
                EmailTruongCap = newUserInfo.EmailTruongCap,
                MkEmailTruongCap = newUserInfo.MkEmailTruongCap
            };

            if (newSpecificInfo.GetType() == typeof(SinhVien_DTO))
            {
                SinhVien_DTO svDt = new SinhVien_DTO();
                svDt = (SinhVien_DTO)newSpecificInfo;
                SINH_VIEN sv = new SINH_VIEN()
                {
                    MaSV = svDt.MaNguoiDung,
                    MaLopSH = svDt.MaLopSH,
                    MaCTDT = svDt.MaCTDT
                };
                newSpecificInfo = sv;
            }
            else if (newSpecificInfo.GetType() == typeof(GiangVien_DTO))
            {
                GiangVien_DTO gtDt = new GiangVien_DTO();
                gtDt = (GiangVien_DTO)newSpecificInfo;
                GIANG_VIEN gv = new GIANG_VIEN()
                {
                    MaGV = gtDt.MaNguoiDung,
                    TrinhDo = gtDt.TrinhDo,
                    Luong = gtDt.Luong,
                    MaKhoa = gtDt.MaKhoa
                };
                newSpecificInfo = gv;
            }
            return GetInformationAcc_DAL.Instance.UpdateData(taiKhoan, tndn, nd, newSpecificInfo);
        }


        public bool DeleteData(int role, string maTaiKhoan)
        {
            return GetInformationAcc_DAL.Instance.DeleteData(role, maTaiKhoan);
        }

        public bool DeleteStudent(string maSV)
        {
               return GetInformationAcc_DAL.Instance.DeleteStudent(maSV);   
        }

        public bool DeleteUser(string maSV)
        {
            return GetInformationAcc_DAL.Instance.DeleteUser(maSV);

        }

        public bool DeleteLoginInfo(string maSV)
        {
            return GetInformationAcc_DAL.Instance.DeleteLoginInfo(maSV);

        }

        public int CountCHUONG_TRINH_DAO_TAO()
        {
            return GetInformationAcc_DAL.Instance.CountCHUONG_TRINH_DAO_TAO();
        }
        public int CountNGUOI_DUNG()
        {
            return GetInformationAcc_DAL.Instance.CountNGUOI_DUNG();

        }
        public int CountGIANG_VIEN()
        {
            return GetInformationAcc_DAL.Instance.CountGIANG_VIEN();
        }
        public int CountSINH_VIEN()
        {
            return GetInformationAcc_DAL.Instance.CountSINH_VIEN();
        }
        public int CountKHOA()
        {
            return GetInformationAcc_DAL.Instance.CountKHOA();
        }
        public List<KeyValuePair<string, int>> StuentByYearList()
        {
            return GetInformationAcc_DAL.Instance.StuentByYearList();
        }
        public List<KeyValuePair<string, int>> StudentCountByFaculty()
        {
            return GetInformationAcc_DAL.Instance.StudentCountByFaculty();

        }
        public List<KeyValuePair<string, int>> LevelOfTeacherList()
        {
            return GetInformationAcc_DAL.Instance.LevelOfTeacherList();
        }
        public List<string> GetAllUser()
        {
            return GetInformationAcc_DAL.Instance.GetAllUser();
        }

    }
}
