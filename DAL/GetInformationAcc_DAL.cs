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
        public List<InformationStudent_DTO> GetAccountStudentList()
        {
            using (var context = new PBL3Entities())
            {
                var query = from tt in context.THONG_TIN_DANG_NHAP
                            join nd in context.NGUOI_DUNG on tt.TaiKhoan equals nd.MaNguoiDung
                            join sv in context.SINH_VIEN on nd.MaNguoiDung equals sv.MaSV
                            select new InformationStudent_DTO
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

        public List<InformationTeacher_DTO> GetAccountTeacherList()
        {
            using (var context = new PBL3Entities())
            {
                var query = from tt in context.THONG_TIN_DANG_NHAP
                            join nd in context.NGUOI_DUNG on tt.TaiKhoan equals nd.MaNguoiDung
                            join gv in context.GIANG_VIEN on nd.MaNguoiDung equals gv.MaGV
                            select new InformationTeacher_DTO
                            {
                                TaiKhoan = tt.TaiKhoan,
                                VaiTro = tt.VaiTro,
                                Ten = nd.Ho + " " + nd.Ten,
                                MaCCCD = nd.MaCCCD,
                                EmailTruongCap = nd.EmailTruongCap,
                                TrinhDo = gv.TrinhDo
                            };
                return query.ToList();
            }
        }

        public List<CHUONG_TRINH_DAO_TAO> GetListEducationProgram()
        {
            using (var context = new PBL3Entities())
            {
                var info = context.CHUONG_TRINH_DAO_TAO.ToList();
                return info;

            }
        }
        public List<KHOA> GetListFaculty()
        {
            using (var context = new PBL3Entities())
            {
                var info = context.KHOAs.ToList();

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
        public int GetCountTeacher()
        {
            using (var context = new PBL3Entities())
            {
                var soLuongBanGhi = context.GIANG_VIEN.Count();
                return soLuongBanGhi;

            }
        }
        public void InsertLoginInfo(THONG_TIN_DANG_NHAP newLoginInfo)
        {
            using (var context = new PBL3Entities())
            {
                context.THONG_TIN_DANG_NHAP.Add(newLoginInfo);
                context.SaveChanges();
            }
        }

        public void InsertLoginInfo(NGUOI_DUNG newLoginInfo)
        {
            using (var context = new PBL3Entities())
            {
                context.NGUOI_DUNG.Add(newLoginInfo);
                context.SaveChanges();
            }
        }

        public bool InsertData(THONG_TIN_DANG_NHAP loginInfo, NGUOI_DUNG userInfo, object specificInfo)
        {
            bool success = false;
            using (PBL3Entities context = new PBL3Entities())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Lưu thông tin đăng nhập vào bảng Thong_Tin_Dang_Nhap trước
                        context.THONG_TIN_DANG_NHAP.Add(loginInfo);
                        context.SaveChanges();

                        // Trích xuất MaNguoiDung từ khóa chính TaiKhoan trong bảng Thong_Tin_Dang_Nhap
                        string maNguoiDung = context.THONG_TIN_DANG_NHAP
                            .Where(t => t.TaiKhoan == loginInfo.TaiKhoan)
                            .Select(t => t.TaiKhoan)
                            .FirstOrDefault();

                        // Lưu thông tin người dùng vào bảng Nguoi_Dung với MaNguoiDung trích xuất được
                        userInfo.MaNguoiDung = maNguoiDung;
                        context.NGUOI_DUNG.Add(userInfo);
                        context.SaveChanges();

                        if (specificInfo.GetType() == typeof(SINH_VIEN))
                        {
                            var studentInfo = (SINH_VIEN)specificInfo;
                            studentInfo.MaSV = userInfo.MaNguoiDung;
                            context.SINH_VIEN.Add(studentInfo);
                        }
                        else if (specificInfo.GetType() == typeof(GIANG_VIEN))
                        {
                            var teacherInfo = (GIANG_VIEN)specificInfo;
                            teacherInfo.MaGV = userInfo.MaNguoiDung;
                            context.GIANG_VIEN.Add(teacherInfo);
                        }
                        context.SaveChanges();
                        // Lưu các thay đổi vào database
                        transaction.Commit();
                        success = true;
                    }
                    catch
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        success = false;
                    }
                }
            }
            return success;
        }

        public bool DeleteData(int role, string maTaiKhoan)
        {
            bool success = false;
            using (PBL3Entities context = new PBL3Entities())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Xóa các bảng ghi Sinh_Vien trước
                        if (role == 0)
                        {
                            // Xóa bản ghi trong bảng SINH_VIEN với MaSV = MaNguoiDung vừa lấy được
                            var studentInfo = context.SINH_VIEN.SingleOrDefault(s => s.MaSV == maTaiKhoan);
                            context.SINH_VIEN.Remove(studentInfo);
                        }
                        else if (role == 1)
                        {
                            // Xóa bản ghi trong bảng GIANG_VIEN với MaGV = MaNguoiDung vừa lấy được
                            var teacherInfo = context.GIANG_VIEN.SingleOrDefault(t => t.MaGV == maTaiKhoan);
                            context.GIANG_VIEN.Remove(teacherInfo);
                        }
                        context.SaveChanges();

                        //  Xóa các bảng ghi Nguoi_Dung
                        var userToDelete = context.NGUOI_DUNG.SingleOrDefault(u => u.MaNguoiDung == maTaiKhoan);
                        context.NGUOI_DUNG.Remove(userToDelete);
                        context.SaveChanges();

                        // Xóa các bảng ghi Thong_Tin_Dang_Nhap
                        var loginToDelete = context.THONG_TIN_DANG_NHAP.SingleOrDefault(t => t.TaiKhoan == maTaiKhoan);
                        context.THONG_TIN_DANG_NHAP.Remove(loginToDelete);
                        context.SaveChanges();

                        // Lưu các thay đổi vào database
                        transaction.Commit();
                        success = true;
                    }
                    catch
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        success = false;
                    }
                }
            }
            return success;
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
