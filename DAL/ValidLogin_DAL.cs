using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public THONG_TIN_DANG_NHAP CheckUsernameExist(string username)
        {
            //Kiểm tra username có tồn tại hay không trước khi check mk
            using (PBL3Entities db = new PBL3Entities())
            {
                //null nếu không tồn tại
                return db.THONG_TIN_DANG_NHAP.Find(username);
            }
        }

        public void UpdateAllCodesToNull()
        {
            
                var userInfoList = modelPBL3Entities1.THONG_TIN_DANG_NHAP.ToList();

                foreach (var userInfo in userInfoList)
                {
                    userInfo.MaXacThucDeLayLaiMK = null;
                }

            modelPBL3Entities1.SaveChanges();
            }
        
    }
}
