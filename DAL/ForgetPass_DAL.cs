using System;
using System.Linq;

namespace DAL
{
    public class ForgetPass_DAL
    {
        private static ForgetPass_DAL _Instance;
        public static ForgetPass_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ForgetPass_DAL();
                }
                return _Instance;
            }
        }

        // Gửi 1 mã đến mail 
        public THONG_TIN_DANG_NHAP SendPass(string email)
        {
            using (var context = new PBL3Entities())
            {
                //Kiểm tra có tài khoản người dùng này trong hệ thống hay không rồi mới thực hiện
                //gửi mã xác thực đến
                var user = context.NGUOI_DUNG.SingleOrDefault(p => p.EmailTruongCap.Equals(email));
                if (user != null)
                {
                    //Đang cần trả về 1 đối tượng THONG_TIN_DANG_NHAP nên tiếp tục truy vấn để lấy ra
                    //bản ghi THONG_TIN_DANG_NHAP của NGUOI_DUNG đó
                    var account = context.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(user.MaNguoiDung));
                    if (account != null)
                    {
                        //Tạo ra 1 mã xác thực mới và lưu vào CSDL
                        Random random = new Random();
                        int randomNumber = random.Next(100000, 999999);
                        account.MaXacThucDeLayLaiMK = randomNumber.ToString();
                        context.SaveChanges();
                        return account;
                    }
                    else
                        return null;
                }
                return null;
            }
        }

        /// <summary>
        /// Kiểm tra người dùng đã nhập đúng mã xác thực gửi về email hay chưa
        /// </summary>
        /// <param name="username"></param>
        /// <param name="maXacThuc"></param>
        /// <returns></returns>
        public bool isValid(string username, string maXacThuc)
        {
            using (var context = new PBL3Entities())
            {
                var thongTinDangNhap = context.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
                if (thongTinDangNhap == null) 
                    return false;
                else if (thongTinDangNhap.MaXacThucDeLayLaiMK == null) 
                    return false;
                return thongTinDangNhap.MaXacThucDeLayLaiMK.Equals(maXacThuc);
            }
        }

        // Cập nhật lại mật khẩu
        public bool updatePass(string username, string pass)
        {
            using (var context = new PBL3Entities())
            {
                var thongTinDangNhap = context.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
                if (thongTinDangNhap != null)
                {
                    thongTinDangNhap.MkUngDung = BCrypt.Net.BCrypt.HashString(pass);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        // Hàm này sẽ reset lại mã xác nhận thành null khi đổi mật khẩu thành công hoặc sau 120s kể từ lúc gửi mã
        public bool resetVerification(string email)
        {
            using (var context = new PBL3Entities())
            {
                //THONG_TIN_DANG_NHAP userInfo = SendPass(email);
                string taiKhoan = SendPass(email).TaiKhoan.ToString();
                var userInfo = context.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(taiKhoan));
                if (userInfo != null)
                {
                    userInfo.MaXacThucDeLayLaiMK = null;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}