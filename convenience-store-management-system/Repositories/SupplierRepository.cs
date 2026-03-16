using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Models;
using Microsoft.Data.SqlClient;

namespace CSMS.Repositories
{
    public class SupplierRepository
    {
        private DbConnectionHelper dbHelper = new DbConnectionHelper();

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT SupplierId, SupplierName FROM Suppliers";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    suppliers.Add(new Supplier
                    {
                        SupplierId = reader["SupplierId"].ToString(),
                        SupplierName = reader["SupplierName"].ToString()
                    });
                }
            }

            return suppliers;
        }
    }
}