using Microsoft.Data.SqlClient;
using CSMS.Database;
using convenience_store_management_system.Models;
using System.Collections.Generic;

namespace convenience_store_management_system.Repositories
{
    public class CategoryRepository
    {
        DbConnectionHelper db = new DbConnectionHelper();

        public List<Category> GetAllCategories()
        {
            List<Category> list = new List<Category>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT CategoryId, CategoryName FROM Categories";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category c = new Category();

                    c.Id = (int)reader["CategoryId"];
                    c.Name = reader["CategoryName"].ToString();

                    list.Add(c);
                }
            }

            return list;
        }
    }
}