using System;
using Microsoft.Data.SqlClient;
using CSMS.Core.Models;

namespace CSMS.Core.Repositories
{
    public class UserRepository
    {
        private string connectionString = "YOUR_CONNECTION_STRING";

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
                        Id = Convert.ToInt32(reader["Id"]),
                        Username = reader["Username"].ToString() ?? "",
                        Password = reader["Password"].ToString() ?? "",
                        Role = reader["Role"].ToString() ?? "",
                        IsActive = Convert.ToBoolean(reader["IsActive"])
                    };
                }
            }

            return user;
        }
    }
}