using Microsoft.Data.SqlClient;
using System;

namespace CSMS.Database
{
    public class DbConnectionHelper
    {
        private readonly string connectionString;

        public DbConnectionHelper()
        {
            // Prefer environment variable for portability across devices
            var env = Environment.GetEnvironmentVariable("CSMS_CONNECTION");
            if (!string.IsNullOrWhiteSpace(env))
            {
                connectionString = env;
            }
            else
            {
                // Fallback to LocalDB which is commonly available on developer machines
                connectionString = "Data Source=LAPTOP-7A534JGV\\SQLEXPRESS;Initial Catalog=CSMS_DB;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
