using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class AddressSelection_DAL
    {
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

        public List<string> GetAllTinhThanh()
        {
            using (var db = new PBL3Entities())
            {
                return db.cities.Select(p => p.tinhThanhPho).ToList();
            }
        }

        public List<city> GetAllCities()
        {
            using (var db = new PBL3Entities())
            {
                return db.cities.Select(p => p).ToList();
            }
        }
        public List<district> GetDistrictRecords(int id_city)
        {
            using (var db = new PBL3Entities())
            {
                return db.districts.Where(p => p.city_id == id_city).ToList();
            }
        }
        public List<ward> GetWardRecords(int district_id)
        {
            using (var db = new PBL3Entities())
            {
                return db.wards.Where(p => p.district_id == district_id).ToList();
            }
        }
    }
}
