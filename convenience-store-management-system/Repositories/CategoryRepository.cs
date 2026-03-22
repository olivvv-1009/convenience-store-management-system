using Microsoft.Data.SqlClient;
using CSMS.Database;
using convenience_store_management_system.Models;
using System.Collections.Generic;

namespace convenience_store_management_system.Repositories
{
    public class CategoryRepository
    {
        private readonly DbConnectionHelper db = new DbConnectionHelper();

        // ================= GET ALL =================
        public List<Category> GetAllCategories()
        {
            List<Category> list = new List<Category>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT CategoryId, CategoryName FROM Categories";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Category
                        {
                            Id = reader["CategoryId"] != DBNull.Value
                                ? Convert.ToInt32(reader["CategoryId"])
                                : 0,

                            Name = reader["CategoryName"] != DBNull.Value
                                ? reader["CategoryName"].ToString()
                                : ""
                        });
                    }
                }
            }

            return list;
        }

        // ================= GET BY ID =================
        public Category GetById(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT CategoryId, CategoryName 
                                 FROM Categories 
                                 WHERE CategoryId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Category
                            {
                                Id = Convert.ToInt32(reader["CategoryId"]),
                                Name = reader["CategoryName"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        // ================= EXISTS =================
        public bool Exists(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Categories WHERE CategoryId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}