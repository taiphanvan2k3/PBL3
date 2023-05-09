using System.Linq;

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

        public THONG_TIN_DANG_NHAP login(string username, string password)
        {
            using (var context = new PBL3Entities())
            {
                var account = context.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
                if (account != null)
                {
                    if (BCrypt.Net.BCrypt.Verify(password, account.MkUngDung))
                        return account;
                }
                return null;
            }
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
            using (var context = new PBL3Entities())
            {
                var userInfoList = context.THONG_TIN_DANG_NHAP.ToList();

                foreach (var userInfo in userInfoList)
                {
                    userInfo.MaXacThucDeLayLaiMK = null;
                }
                context.SaveChanges();
            }
        }

    }
}
