using Microsoft.Data.SqlClient;

namespace CSMS.Database
{
    public class DbConnectionHelper
    {
        private string connectionString =
        "Server=.;Database=CSMS_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}