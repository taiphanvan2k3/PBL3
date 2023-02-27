using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class AddressSelectionBLL
    {
        private static AddressSelectionBLL _Instance;

        public static AddressSelectionBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddressSelectionBLL();
                return _Instance;
            }
        }
        public List<CBBAddressItem> GetCityRecords()
        {
            //Mục đích DAL là trả về DataTable còn việc xử lí như nào với dữ liệu
            //trả về là việc của BLL
            DataTable dt = AddressSelectionDAL.Instance.GetAllCities();
            List<CBBAddressItem> ds = new List<CBBAddressItem>();
            foreach(DataRow row in dt.Rows)
            {
                ds.Add(new CBBAddressItem()
                {
                    Id = Convert.ToInt32(row["city_id"].ToString()),
                    Value = row["tinhThanhPho"].ToString()
                });
            }
            return ds;
        }

        public List<CBBAddressItem> GetDistrictRecords(int city_id)
        {
            DataTable dt = AddressSelectionDAL.Instance.GetAllDistrict(city_id);
            List<CBBAddressItem> ds = new List<CBBAddressItem>();
            foreach (DataRow row in dt.Rows)
            {
                ds.Add(new CBBAddressItem()
                {
                    Id = Convert.ToInt32(row["district_id"].ToString()),
                    Value = row["huyenQuan"].ToString()
                });
            }
            return ds;
        }

        public List<CBBAddressItem> GetWardRecords(int district_id)
        {
            DataTable dt = AddressSelectionDAL.Instance.GetAllWards(district_id);
            List<CBBAddressItem> ds = new List<CBBAddressItem>();
            foreach (DataRow row in dt.Rows)
            {
                ds.Add(new CBBAddressItem()
                {
                    Id = Convert.ToInt32(row["ward_id"].ToString()),
                    Value = row["xaPhuong"].ToString()
                });
            }
            return ds;
        }
    }
}
