using DTO;
using System.Collections.Generic;
using System.Linq;

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
        // Lấy danh sách sinh viên
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
        // Lấy danh sách giảng viên
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

        // Lấy thông tin 1 tài khoản giảng viên theo ID
        public InformationTeacher_DTO GetInformationTeacherByID(string id)
        {
            using (var context = new PBL3Entities())
            {
                var query = from tt in context.THONG_TIN_DANG_NHAP
                            join nd in context.NGUOI_DUNG on tt.TaiKhoan equals nd.MaNguoiDung
                            join gv in context.GIANG_VIEN on nd.MaNguoiDung equals gv.MaGV
                            where tt.TaiKhoan == id
                            select new InformationTeacher_DTO
                            {
                                TaiKhoan = tt.TaiKhoan,
                                VaiTro = tt.VaiTro,
                                Ten = nd.Ho + " " + nd.Ten,
                                MaCCCD = nd.MaCCCD,
                                NgaySinh = nd.NgaySinh,
                                GioiTinh = nd.GioiTinh,
                                EmailTruongCap = nd.EmailTruongCap,
                                TrinhDo = gv.TrinhDo,
                                MaKhoa = gv.MaKhoa
                            };
                return query.FirstOrDefault();
            }
        }


        // Lấy thông tin 1 tài khoản sinh viên theo ID
        public InformationStudent_DTO GetInformationStudentByID(string id)
        {
            using (var context = new PBL3Entities())
            {
                var query = from tt in context.THONG_TIN_DANG_NHAP
                            join nd in context.NGUOI_DUNG on tt.TaiKhoan equals nd.MaNguoiDung
                            join sv in context.SINH_VIEN on nd.MaNguoiDung equals sv.MaSV
                            where tt.TaiKhoan == id
                            select new InformationStudent_DTO
                            {
                                TaiKhoan = tt.TaiKhoan,
                                VaiTro = tt.VaiTro,
                                Ten = nd.Ho + " " + nd.Ten,
                                MaCCCD = nd.MaCCCD,
                                NgaySinh = nd.NgaySinh,
                                GioiTinh = nd.GioiTinh,
                                EmailTruongCap = nd.EmailTruongCap,
                                MaCTDT = sv.MaCTDT
                            };
                return query.FirstOrDefault();
            }
        }

        // Lấy danh sách chương trình đào tạo
        public List<CHUONG_TRINH_DAO_TAO> GetListEducationProgram()
        {
            using (var context = new PBL3Entities())
            {
                var info = context.CHUONG_TRINH_DAO_TAO.ToList();
                return info;

            }
        }

        // Lấy danh sách khoa
        public List<KHOA> GetListFaculty()
        {
            using (var context = new PBL3Entities())
            {
                var info = context.KHOAs.ToList();

                return info;
            }
        }

        // Đếm số lượng sinh viên theo từng khoa và khóa
        public int getTheNumberOfStudentByFaculty(string maKhoa, string year)
        {
            using (var context = new PBL3Entities())
            {
                var query = from sv in context.SINH_VIEN
                            where sv.MaSV.StartsWith(maKhoa) && sv.MaSV.Substring(3, 2).Equals(year)
                            select (sv.MaSV.Substring(5));
                string result = query.DefaultIfEmpty("0").Max();
                return int.Parse(result);
            }

            //using (var db = new PBL3Entities())
            //{
            //    var result = from sv in db.SINH_VIEN
            //                 join ctdt in db.CHUONG_TRINH_DAO_TAO on sv.MaCTDT equals ctdt.MaCTDT
            //                 where ctdt.MaKhoa == maKhoa && sv.MaSV.Substring(3, sv.MaSV.Length - 7) == year
            //                 group sv by ctdt.MaKhoa into g
            //                 select new { MaKhoa = g.Key, SoLuongSinhVien = g.Count() };
            //    var singleResult = result.SingleOrDefault(); // lấy ra đối tượng duy nhất trong result
            //    if (singleResult != null)
            //    {
            //        return singleResult.SoLuongSinhVien;
            //    }
            //    return 0;
            //}
        }
        // Đếm số lượng giảng viên theo khoa
        public int getTheNumberOfTeacherByFaculty(string maKhoa)
        {
            using (var db = new PBL3Entities())
            {
                //var result = (from gv in db.GIANG_VIEN
                //              where gv.MaKhoa == maKhoa
                //              select gv).Count();
                //return result;
                var query = from gv in db.GIANG_VIEN
                            where gv.MaGV.StartsWith(maKhoa)
                            select (gv.MaGV.Substring(5));
                string result = query.DefaultIfEmpty("0").Max();
                return int.Parse(result);
            }
        }


        // Thêm tài khoản mới
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
        public bool UpdateData(string taiKhoan, THONG_TIN_DANG_NHAP newLoginInfo, NGUOI_DUNG newUserInfo, object newSpecificInfo)
        {
            bool success = false;
            using (PBL3Entities context = new PBL3Entities())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        THONG_TIN_DANG_NHAP oldLoginInfo = context.THONG_TIN_DANG_NHAP.FirstOrDefault(t => t.TaiKhoan == taiKhoan);
                        if (oldLoginInfo != null)
                        {
                            // Cập nhật thông tin đăng nhập
                            oldLoginInfo.MkUngDung = newLoginInfo.MkUngDung;
                            context.SaveChanges();
                            var oldUserInfo = context.NGUOI_DUNG.FirstOrDefault(t => t.MaNguoiDung == oldLoginInfo.TaiKhoan);
                            if (oldUserInfo != null)
                            {
                                oldUserInfo.Ho = newUserInfo.Ho;
                                oldUserInfo.Ten = newUserInfo.Ten;
                                oldUserInfo.NgaySinh = newUserInfo.NgaySinh;
                                oldUserInfo.GioiTinh = newUserInfo.GioiTinh;
                                context.SaveChanges();
                                if (newSpecificInfo.GetType() == typeof(SINH_VIEN))
                                {
                                    var oldStudentInfo = context.SINH_VIEN.FirstOrDefault(t => t.MaSV == oldUserInfo.MaNguoiDung);
                                    if (oldStudentInfo != null)
                                    {
                                        var studentInfo = (SINH_VIEN)newSpecificInfo;
                                        oldStudentInfo.MaCTDT = studentInfo.MaCTDT;
                                        context.SaveChanges();
                                    }

                                }
                                else if (newSpecificInfo.GetType() == typeof(GIANG_VIEN))
                                {
                                    var oldTeacherInfo = context.GIANG_VIEN.FirstOrDefault(t => t.MaGV == oldUserInfo.MaNguoiDung);
                                    if (oldTeacherInfo != null)
                                    {
                                        var teacherInfo = (GIANG_VIEN)newSpecificInfo;
                                        oldTeacherInfo.MaKhoa = teacherInfo.MaKhoa;
                                        oldTeacherInfo.TrinhDo = teacherInfo.TrinhDo;
                                        context.SaveChanges();
                                    }
                                }
                            }
                        }
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


        public bool DeleteStudent(string maSV)
        {
            bool success = false;
            using (var context = new PBL3Entities())
            {
                var student = context.SINH_VIEN.FirstOrDefault(s => s.MaSV == maSV);
                if (student != null)
                {
                    context.SINH_VIEN.Remove(student);
                    context.SaveChanges();
                    success = true;
                }
            }
            return success;
        }

        public bool DeleteUser(string maSV)
        {
            bool success = false;
            using (var context = new PBL3Entities())
            {
                var user = context.NGUOI_DUNG.FirstOrDefault(u => u.MaNguoiDung == maSV);
                if (user != null)
                {
                    context.NGUOI_DUNG.Remove(user);
                    context.SaveChanges();
                    success = true;
                }
            }
            return success;
        }

        public bool DeleteLoginInfo(string maSV)
        {
            bool success = false;
            using (var context = new PBL3Entities())
            {
                var loginInfo = context.THONG_TIN_DANG_NHAP.FirstOrDefault(l => l.TaiKhoan == maSV);
                if (loginInfo != null)
                {
                    context.THONG_TIN_DANG_NHAP.Remove(loginInfo);
                    context.SaveChanges();
                    success = true;
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

        public int CountCHUONG_TRINH_DAO_TAO()
        {
            using (var dbContext = new PBL3Entities())
            {
                return dbContext.CHUONG_TRINH_DAO_TAO.Count();
            }
        }
        public int CountNGUOI_DUNG()
        {
            using (var dbContext = new PBL3Entities())
            {
                return dbContext.NGUOI_DUNG.Count();
            }
        }
        public int CountGIANG_VIEN()
        {
            using (var dbContext = new PBL3Entities())
            {
                return dbContext.GIANG_VIEN.Count();
            }
        }
        public int CountSINH_VIEN()
        {
            using (var dbContext = new PBL3Entities())
            {
                return dbContext.SINH_VIEN.Count();
            }
        }
        public int CountKHOA()
        {
            using (var dbContext = new PBL3Entities())
            {
                return dbContext.KHOAs.Count();
            }
        }



        // Lấy ra số học sinh theo năm 
        public List<KeyValuePair<string, int>> StuentByYearList()
        {
            using (var context = new PBL3Entities())
            {
                var studentCounts = context.SINH_VIEN
                    .GroupBy(sv => sv.MaSV.Substring(3, 2))
                    .Select(g => new { Khoa = g.Key, SoSinhVien = g.Count() })
                    .ToDictionary(x => x.Khoa, x => x.SoSinhVien)
                    .Select(x => new KeyValuePair<string, int>("20" + x.Key, x.Value))
                    .ToList();

                return studentCounts;
            }
        }

        public List<KeyValuePair<string, int>> StudentCountByFaculty()
        {
            using (var context = new PBL3Entities())
            {
                var sinhvienCounts = context.SINH_VIEN
                    .Join(context.KHOAs, sv => sv.MaSV.Substring(0, 3), kh => kh.MaKhoa, (sv, kh) => new { SV = sv, KH = kh })
                    .GroupBy(x => x.KH.TenKhoa)
                    .Select(g => new { TenKhoa = g.Key, SoSinhVien = g.Count() })
                    .ToDictionary(x => x.TenKhoa, x => x.SoSinhVien)
                    .Select(x => new KeyValuePair<string, int>(x.Key, x.Value))
                    .ToList();

                return sinhvienCounts;
            }
        }

        public List<KeyValuePair<string, int>> LevelOfTeacherList()
        {
            using (var context = new PBL3Entities())
            {
                var studentCounts = context.GIANG_VIEN
                    .GroupBy(gv => gv.TrinhDo)
                    .Select(g => new { TrinhDo = g.Key, SoSinhVien = g.Count() })
                    .ToDictionary(x => x.TrinhDo, x => x.SoSinhVien)
                    .Select(x => new KeyValuePair<string, int>(x.Key, x.Value))
                    .ToList();
                return studentCounts;
            }
        }
        public List<string> GetAllUser()
        {
            using (var contex = new PBL3Entities())
            {
                var nguoiDungList = contex.NGUOI_DUNG.Select(nd => nd.MaNguoiDung + " - " + nd.Ho + " " + nd.Ten).ToList();
                return nguoiDungList;
            }
        }

    }
}
