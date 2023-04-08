using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private PBL3Entities modelPBL3Entities1 = new PBL3Entities();



        public THONG_TIN_DANG_NHAP SendPass(string email)
        {
            var user = modelPBL3Entities1.NGUOI_DUNG.SingleOrDefault(p => p.EmailTruongCap.Equals(email));
            if (user != null)
            {
                var account = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(user.MaNguoiDung));
                if (account != null)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(100000, 999999);
                    account.MaXacThucDeLayLaiMK = randomNumber.ToString();
                    modelPBL3Entities1.SaveChanges();
                    return account;
                }
                else
                    return null;
            }
            return null;
        }

        public bool isValid(string username, string maXacThuc)
        {
            var thongTinDangNhap = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
            if (thongTinDangNhap == null) return false;
            return thongTinDangNhap.MaXacThucDeLayLaiMK.Equals(maXacThuc);
        }

        public bool updatePass(string username,string pass)
        {
            var thongTinDangNhap = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
            if (thongTinDangNhap != null) {
                thongTinDangNhap.MkUngDung = BCrypt.Net.BCrypt.HashString(pass);
                modelPBL3Entities1.SaveChanges();
                return true;
            }
            return false;
        }

        public bool resetVerification(string email)
        {
            THONG_TIN_DANG_NHAP userInfo = SendPass(email);
            if (userInfo != null)
            {
                userInfo.MaXacThucDeLayLaiMK = null;
                modelPBL3Entities1.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
