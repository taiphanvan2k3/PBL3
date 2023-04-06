using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ValidLogin_DAL
    {

        private static ValidLogin_DAL _Instance;
        public static ValidLogin_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ValidLogin_DAL();
                return _Instance;
            }
        }

        private PBL3Entities modelPBL3Entities1 = new PBL3Entities();

        public THONG_TIN_DANG_NHAP login(string username, string password)
        {
            var account = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.MkUngDung))
                    return account;
            }
            return null;
        }
    }
}
