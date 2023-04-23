using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class Khoa_BLL
    {
        private static Khoa_BLL _Instance;
        public static Khoa_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Khoa_BLL();
                return _Instance;
            }
        }

        private Khoa_BLL() { }

        public List<CBBItem> GetAllKhoa()
        {
            List<KHOA> li = Khoa_DAL.Instance.GetAllKhoa();
            List<CBBItem> res = new List<CBBItem>();
            foreach (KHOA k in li)
            {
                res.Add(new CBBItem()
                {
                    Id = k.MaKhoa,
                    Value = k.TenKhoa
                });
            }
            return res;
        }
    }
}
