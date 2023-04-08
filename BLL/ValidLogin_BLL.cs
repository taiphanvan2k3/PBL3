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
        public void UpdateAllCodesToNull_BLL()
        {
            ValidLogin_BLL.Instance.UpdateAllCodesToNull_BLL();
        }

    }
}
