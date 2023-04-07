using DAL;
using DTO;

namespace BLL
{
    public class ValidLogin_BLL
    {
        private static ValidLogin_BLL _Instance;
        public static ValidLogin_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ValidLogin_BLL();
                }
                return _Instance;
            }
        }

        private ValidLogin_BLL()
        {

        }
        //private  PBL3Entities modelPBL3Entities1 = new PBL3Entities();

        //public THONG_TIN_DANG_NHAP_DTO login(string username, string password)
        //{
        //    var account = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
        //    if (account != null)
        //    {
        //        if (BCrypt.Net.BCrypt.Verify(password, account.MkUngDung))
        //            return new THONG_TIN_DANG_NHAP_DTO(account.TaiKhoan, account.MkUngDung, account.VaiTro, account.MaXacThucDeLayLaiMK);
        //    }
        //    return null;
        //}

        public THONG_TIN_DANG_NHAP_DTO login(string username, string password)
        {
            THONG_TIN_DANG_NHAP account = ValidLogin_DAL.Instance.login(username, password);
            if(account != null)
            {
                return new THONG_TIN_DANG_NHAP_DTO(account.TaiKhoan, account.MkUngDung, account.VaiTro, 
                                                    account.MaXacThucDeLayLaiMK);
            }
            return null;
        }

        public THONG_TIN_DANG_NHAP_DTO CheckUsername(string username)
        {
            THONG_TIN_DANG_NHAP account=ValidLogin_DAL.Instance.CheckUsernameExist(username);
            if (account != null)
            {
                return new THONG_TIN_DANG_NHAP_DTO(account.TaiKhoan, account.MkUngDung, account.VaiTro,
                                                    account.MaXacThucDeLayLaiMK);
            }
            return null;
        }

        public bool CheckCorrectPassword(string passwordInput, THONG_TIN_DANG_NHAP_DTO account)
        {
            //Kiểm tra xem có trùng với mật khẩu đã lưu trong CSDL?
            return BCrypt.Net.BCrypt.Verify(passwordInput, account.MkUngDung);
        }
    }
}
