using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ValidLogin
    {
        private static ValidLogin _Instance;
        public static ValidLogin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ValidLogin();
                }
                return _Instance;
            }
        }

        private  PBL3Entities modelPBL3Entities1 = new PBL3Entities();

        public THONG_TIN_DANG_NHAP_DTO login(string username, string password)
        {
            var account = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.MkUngDung))
                    return new THONG_TIN_DANG_NHAP_DTO(account.TaiKhoan, account.MkUngDung, account.VaiTro, account.MaXacThucDeLayLaiMK);
            }
            return null;
        }


    }
}
