using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class AddressSelection_BLL
    {
        private static AddressSelection_BLL _Instance;

        public static AddressSelection_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddressSelection_BLL();
                return _Instance;
            }
        }

        public List<CBBItem> GetAllCities()
        {
            List<city> li = AddressSelection_DAL.Instance.GetAllCities();
            List<CBBItem> res = new List<CBBItem>();
            foreach (city i in li)
            {
                res.Add(new CBBItem()
                {
                    Id = i.city_id.ToString(),
                    Value = i.tinhThanhPho
                });
            }
            return res;
        }

        public List<CBBItem> GetDistrictRecords(int city_id)
        {
            List<district> li = AddressSelection_DAL.Instance.GetDistrictRecords(city_id);
            List<CBBItem> res = new List<CBBItem>();
            foreach (district i in li)
            {
                res.Add(new CBBItem()
                {
                    Id = i.district_id.ToString(),
                    Value = i.huyenQuan
                });
            }
            return res;
        }

        public List<CBBItem> GetWardRecords(int district_id)
        {
            List<ward> li = AddressSelection_DAL.Instance.GetWardRecords(district_id);
            List<CBBItem> res = new List<CBBItem>();
            foreach (var i in li)
            {
                res.Add(new CBBItem()
                {
                    Id = i.ward_id.ToString(),
                    Value = i.xaPhuong
                });
            }
            return res;
        }
    }
}
