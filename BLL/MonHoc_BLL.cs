using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class MonHoc_BLL
    {
        private static MonHoc_BLL _Instance;
        public static MonHoc_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MonHoc_BLL();
                return _Instance;
            }
        }

        private MonHoc_BLL() { }

        private MON_HOC ConvertDTOToEntity(MonHoc_DTO mh)
        {
            return new MON_HOC()
            {
                MaMH = mh.MaMH,
                TenMH = mh.TenMH,
                MaKhoa = mh.MaKhoa,
                SoTC = (byte)mh.SoTC,
                CtTinhDiem = mh.CtTinhDiem
            };
        }

        public int InsertSubject(MonHoc_DTO mh)
        {
            bool IsExist = MonHoc_DAL.Instance.CheckHadSubject(mh.MaMH);
            if (IsExist)
                return -1;
            MON_HOC NewSubject = ConvertDTOToEntity(mh);
            if (MonHoc_DAL.Instance.InsertSubject(NewSubject))
                return 1;
            return 0;
        }

        public List<CBBItem> GetAllMonHoc()
        {
            List<MON_HOC> li = MonHoc_DAL.Instance.GetAllMonHoc();
            List<CBBItem> res = new List<CBBItem>();
            foreach (MON_HOC mh in li)
            {
                res.Add(new CBBItem()
                {
                    Id = mh.MaMH,
                    Value = mh.TenMH
                });
            }
            return res;
        }
    }
}
