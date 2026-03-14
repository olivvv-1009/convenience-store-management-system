using System;
using Microsoft.Data.SqlClient;
using CSMS.Core.Models;

namespace CSMS.Core.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=CSMS_DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public User? GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            User? user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT u.UserId, u.Username, u.PasswordHash, r.RoleName, u.IsLocked
                    FROM Users u
                    JOIN Roles r ON u.RoleId = r.RoleId
                    WHERE u.Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Id = Convert.ToInt32(reader["UserId"]),
                                Username = reader["Username"]?.ToString() ?? "",
                                Password = reader["PasswordHash"]?.ToString() ?? "",
                                Role = reader["RoleName"]?.ToString() ?? "",
                                IsActive = !Convert.ToBoolean(reader["IsLocked"])
                            };
                        }
                    }
                }
            }

            return user;
        }
    }
}