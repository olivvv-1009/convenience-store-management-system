using System;
using CSMS.Core.Models;
using CSMS.Database;
using Microsoft.Data.SqlClient;

namespace CSMS.Core.Repositories
{
    public class UserRepository
    {
        DbConnectionHelper db = new DbConnectionHelper();
        public User? GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            User? user = null;

            using (SqlConnection conn = db.GetConnection())
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