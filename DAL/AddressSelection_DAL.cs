using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class AddressSelection_DAL
    {
        private PBL3Entities db;
        private static AddressSelection_DAL _Instance;
        public static AddressSelection_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddressSelection_DAL();
                return _Instance;
            }
        }

        private AddressSelection_DAL()
        {
            db = new PBL3Entities();
        }

        public List<city> GetAllCities()
        {
            return db.cities.Select(p => p).ToList();
        }
        public List<CBBItem> GetCBBCity() 
        {
            var li1 = db.cities.Select(p => p).ToList();
            MessageBox.Show(li1.Count.ToString());
            var li = new List<CBBItem>()
            {
                new CBBItem
                {
                    Id = "01",
                    Value = "test"
                },
                new CBBItem
                {
                    Id = "02",
                    Value = "test1"
                }
            };
            /*List<CBBItem> res = new List<CBBItem>();
            foreach(var i in li)
            {
                res.Add(new CBBItem
                {
                    Id = i.city_id.ToString(),
                    Value = i.tinhThanhPho
                });
            }*/
            return li;
        }
        public List<district> GetDistrictRecords(int id_city)
        {
            return db.districts.Where(p => p.city_id == id_city).ToList();
        }

        public List<ward> GetWardRecords(int district_id)
        {
            return db.wards.Where(p => p.district_id == district_id).ToList();
        }
    }
}
