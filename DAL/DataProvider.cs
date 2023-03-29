using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider _Instance;
        private string connectionString = @"Data Source=(local);Initial Catalog=PBL3;Integrated Security=True";
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DataProvider();
                return _Instance;
            }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection cnn= new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd= new SqlCommand(query,cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
