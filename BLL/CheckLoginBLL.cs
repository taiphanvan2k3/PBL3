using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class CheckLoginBLL
    {
        private static CheckLoginBLL _Instance;
        public static CheckLoginBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CheckLoginBLL();
                }
                return _Instance;
            }
        }
        public int Check(string user, string pass) {
            DataTable dtbl = LoginDAL.Instance.getUser(user);
            if (dtbl.Rows.Count == 1 && BCrypt.Net.BCrypt.Verify(pass, dtbl.Rows[0]["MkUngDung"].ToString()) == true)
            {
                if (dtbl.Rows[0]["VaiTro"].ToString() == "GV")
                {
                    return 0;
                }
                else if (dtbl.Rows[0]["VaiTro"].ToString() == "SV")
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
