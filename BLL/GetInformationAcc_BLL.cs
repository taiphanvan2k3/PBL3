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

        public void InsertLoginInfo(THONG_TIN_DANG_NHAP_DTO newLoginInfo)
        {
            THONG_TIN_DANG_NHAP ttdn = new THONG_TIN_DANG_NHAP();
            ttdn.TaiKhoan = newLoginInfo.TaiKhoan;
            ttdn.MkUngDung = newLoginInfo.MkUngDung;
            ttdn.VaiTro = newLoginInfo.VaiTro;
            ttdn.MaXacThucDeLayLaiMK = newLoginInfo.MaXacThucDeLayLaiMK;
            GetInformationAcc_DAL.Instance.InsertLoginInfo(ttdn);
        }

        public bool InsertData(THONG_TIN_DANG_NHAP_DTO loginInfo, NguoiDung_DTO userInfo, object specificInfo)
        {

            THONG_TIN_DANG_NHAP tndn = new THONG_TIN_DANG_NHAP
            {
                TaiKhoan = loginInfo.TaiKhoan,
                VaiTro = loginInfo.VaiTro,
                MkUngDung = loginInfo.MkUngDung,
                MaXacThucDeLayLaiMK = loginInfo.MaXacThucDeLayLaiMK
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
                QuocTich = userInfo.QuocTinh,
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

        public bool DeleteData(int role, string maTaiKhoan)
        {
            return GetInformationAcc_DAL.Instance.DeleteData(role, maTaiKhoan);
        }

    }
}
