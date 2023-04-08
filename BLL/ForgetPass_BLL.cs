using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class ForgetPass_BLL
    {
        private static ForgetPass_BLL _Instance;
        public static ForgetPass_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ForgetPass_BLL(); 
                }
                return _Instance;
            }
        }

        public THONG_TIN_DANG_NHAP_DTO ResetPasswordByEmail(string email)
        {
            THONG_TIN_DANG_NHAP account = ForgetPass_DAL.Instance.SendPass(email);
            if (account != null)
            {
                return new THONG_TIN_DANG_NHAP_DTO(account.TaiKhoan, account.MkUngDung, account.VaiTro, account.MaXacThucDeLayLaiMK);
            }
            return null;
        }

       
        public bool CheckValid(string user, string code)
        {
            if (ForgetPass_DAL.Instance.isValid(user, code))
            {
                return true;
            }
            return false;
        }

        public bool updatePass(string user, string pass) {
            if (ForgetPass_DAL.Instance.updatePass(user, pass))
            {
                return true;
            }
            return false;
        }

        public bool resetVerification_BLL(string emai)
        {
            if (ForgetPass_DAL.Instance.resetVerification(emai))
            {
                return true;
            }
            return false;
        }
    }
}
