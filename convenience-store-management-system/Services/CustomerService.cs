using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using CustomerModel = convenience_store_management_system.Models.Customers;

namespace CSMS.Services
{
    public class CustomerService
    {
        private readonly DbConnectionHelper db = new DbConnectionHelper();

        // GET ALL
        public List<Customers> GetAllCustomers()
        {
            var list = new List<Customers>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT MemberId, FullName, Phone, Points, TotalSpent FROM Members";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Customers
                    {
                        MemberId = (int)reader["MemberId"],
                        FullName = reader["FullName"]?.ToString() ?? "",
                        Phone = reader["Phone"]?.ToString() ?? "",
                        Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"],
                        TotalSpent = reader["TotalSpent"] == DBNull.Value ? 0 : (decimal)reader["TotalSpent"]
                    });
                }
            }

            return list;
        }

        // ADD
        public void AddCustomer(Customers c)
        {
            if (IsPhoneExists(c.Phone, c.FullName))
                throw new Exception("Phone already exists!");

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Members(FullName, Phone, Points, TotalSpent)
                                 VALUES(@name,@phone,@points,@spent)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", c.FullName);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cmd.Parameters.AddWithValue("@points", c.Points);
                cmd.Parameters.AddWithValue("@spent", c.TotalSpent);

                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public void UpdateCustomer(CustomerModel c)
        {

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                // 1. lấy phone cũ trong DB
                string getOldPhoneQuery = "SELECT Phone FROM Members WHERE MemberId = @id";
                SqlCommand getCmd = new SqlCommand(getOldPhoneQuery, conn);
                getCmd.Parameters.AddWithValue("@id", c.MemberId);

                string oldPhone = getCmd.ExecuteScalar()?.ToString();

                // 2. CHỈ check nếu phone bị đổi
                if (oldPhone != c.Phone)
                {
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM Members 
                WHERE Phone = @phone 
                AND MemberId <> @id";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@phone", c.Phone);
                    checkCmd.Parameters.AddWithValue("@id", c.MemberId);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                        throw new Exception("Phone already exists!");
                }

                // 3. update bình thường
                string query = @"UPDATE Members
                         SET FullName=@name,
                             Phone=@phone,
                             Points=@points
                         WHERE MemberId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", c.FullName);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cmd.Parameters.AddWithValue("@points", c.Points);
                cmd.Parameters.AddWithValue("@id", c.MemberId);

                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void DeleteCustomer(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Members WHERE MemberId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void AddPoints(int customerId, int points)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Members
                         SET Points = ISNULL(Points,0) + @pts
                         WHERE MemberId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pts", points);
                cmd.Parameters.AddWithValue("@id", customerId);

                cmd.ExecuteNonQuery();
            }
        }

        public void UsePoints(int customerId, int points)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Members
                         SET Points =
                         CASE
                            WHEN ISNULL(Points,0) - @pts < 0 THEN 0
                            ELSE Points - @pts
                         END
                         WHERE MemberId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pts", points);
                cmd.Parameters.AddWithValue("@id", customerId);

                cmd.ExecuteNonQuery();
            }
        }

        public Customers GetMemberByPhone(string phone)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT MemberId, FullName, Phone, Points, TotalSpent FROM Members WHERE Phone = @phone";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phone", phone);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Customers
                    {
                        MemberId = (int)reader["MemberId"],
                        FullName = reader["FullName"]?.ToString() ?? "",
                        Phone = reader["Phone"]?.ToString() ?? "",
                        Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"],
                        TotalSpent = reader["TotalSpent"] == DBNull.Value ? 0 : (decimal)reader["TotalSpent"]
                    };
                }

                return null;
            }
        }
        public bool IsPhoneExists(string phone, string fullName, int? excludeMemberId = null)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = excludeMemberId == null
                    ? @"SELECT COUNT(*) FROM Members 
                WHERE Phone = @phone OR FullName = @name"
                    : @"SELECT COUNT(*) FROM Members 
                WHERE (Phone = @phone OR FullName = @name)
                AND MemberId <> @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@name", fullName);

                if (excludeMemberId != null)
                    cmd.Parameters.AddWithValue("@id", excludeMemberId);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}