using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        private static LoginDAL _Instance;
        public static LoginDAL Instance
        {
            get
            {
                if (_Instance == null) 
                    _Instance = new LoginDAL();
                return _Instance;
            }
        }
        public DataTable getUser(string username)
        {
            string query = "SELECT * FROM dbo.THONG_TIN_DANG_NHAP WHERE dbo.THONG_TIN_DANG_NHAP.TaiKhoan = '" + username + /*"'AND dbo.THONG_TIN_DANG_NHAP.MkUngDung = '" + txtPassword.Texts.ToString() + */"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
