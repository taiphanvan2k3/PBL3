using System.Data;

namespace DAL
{
    public class AddressSelectionDAL
    {
        private static AddressSelectionDAL _Instance;

        public static AddressSelectionDAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddressSelectionDAL();
                return _Instance;
            }
        }

        public DataTable GetAllCities()
        {
            string query = "select *from city";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetAllDistrict(int city_id)
        {
            string query = "select * from district " +
                        "where city_id = " + city_id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetAllWards(int district_id)
        {
            string query = "select * from ward " +
                        "where district_id = " + district_id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
