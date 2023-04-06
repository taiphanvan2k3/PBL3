using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class ResetPassword
    {
        private static ResetPassword _Instance;
        public static ResetPassword Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ResetPassword();
                }
                return _Instance;
            }
        }

        private PBL3Entities modelPBL3Entities1 = new PBL3Entities();

        public string ResetPasswordByEmail(string username)
        {
            var account = modelPBL3Entities1.THONG_TIN_DANG_NHAP.SingleOrDefault(p => p.TaiKhoan.Equals(username));
            if (account != null)
            {
                string randomCode = GenerateRandomCode();
                account.MaXacThucDeLayLaiMK = randomCode;
                modelPBL3Entities1.SaveChanges();
                return randomCode;
            }
            return null;
        }

        private string GenerateRandomCode()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
