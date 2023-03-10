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
            DataTable dt;
            string s = "NULL";
            if (dtbl.Rows.Count == 1 && BCrypt.Net.BCrypt.Verify(pass, dtbl.Rows[0]["MkUngDung"].ToString()) == true)
            {
                if (dtbl.Rows[0]["VaiTro"].ToString() == "GV")
                {
                    //dt = LoginDAL.Instance.getUser(user, 0);
                    //s = "Giáo viên " + dt.Rows[0]["Ho"].ToString() + " " + dt.Rows[0]["Ten"].ToString();
                    return 1;
                }
                else if (dtbl.Rows[0]["VaiTro"].ToString() == "SV")
                {
                    //dt = LoginDAL.Instance.getUser(user, 1);
                    //s = "Sinh viên " + dt.Rows[0]["Ho"].ToString() + " " + dt.Rows[0]["Ten"].ToString();
                    return 2;
                }
            }
            return -1;
        }
    }
}
