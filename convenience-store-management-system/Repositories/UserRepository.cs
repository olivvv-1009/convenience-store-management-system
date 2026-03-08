using System;
using Microsoft.Data.SqlClient;
using CSMS.Core.Models;

namespace CSMS.Core.Repositories
{
    public class UserRepository
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CSMS_DB;Trusted_Connection=True;";

        public User? GetUserByUsername(string username)
{
    if (string.IsNullOrWhiteSpace(username))
        return null;

    User? user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        Username = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        RoleId = Convert.ToInt32(reader["RoleId"]),
                        IsLocked = Convert.ToBoolean(reader["IsLocked"])
                    };
                }
            }

            return user;
        }
    }
}