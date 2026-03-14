using System.Data.SqlClient;

namespace convenience_store_management_system.Repositories
{
    public class Database
    {
        string connectionString =
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSMS_DB;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}