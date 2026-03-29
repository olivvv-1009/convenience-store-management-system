using Microsoft.Data.SqlClient;
using CSMS.Models;
using System.Collections.Generic;
using CSMS.Database;

namespace CSMS.Services
{
    public class MemberService
    {
        private readonly DbConnectionHelper db = new DbConnectionHelper();

        public Member GetMemberByPhone(string phone)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Members WHERE Phone = @phone";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phone", phone);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Member
                    {
                        MemberId = (int)reader["MemberId"],
                        FullName = reader["FullName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"]
                    };
                }

                return null;
            }
        }

        public List<Member> GetAllMembers()
        {
            var list = new List<Member>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT MemberId, FullName, Phone, Points FROM Members";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Member
                    {
                        MemberId = (int)reader["MemberId"],
                        FullName = reader["FullName"]?.ToString(),
                        Phone = reader["Phone"]?.ToString(),
                        Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"]
                    });
                }
            }

            return list;
        }

        public void AddMember(Member m)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Members(FullName, Phone, Points) VALUES(@name,@phone,@points)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", m.FullName ?? "");
                cmd.Parameters.AddWithValue("@phone", m.Phone ?? "");
                cmd.Parameters.AddWithValue("@points", m.Points);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMember(Member m)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Members SET FullName=@name, Phone=@phone, Points=@points WHERE MemberId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", m.FullName ?? "");
                cmd.Parameters.AddWithValue("@phone", m.Phone ?? "");
                cmd.Parameters.AddWithValue("@points", m.Points);
                cmd.Parameters.AddWithValue("@id", m.MemberId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMember(int memberId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Members WHERE MemberId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", memberId);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddPoints(int memberId, int points)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Members SET Points = ISNULL(Points,0) + @pts WHERE MemberId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pts", points);
                cmd.Parameters.AddWithValue("@id", memberId);
                cmd.ExecuteNonQuery();
            }
        }

        public void UsePoints(int memberId, int points)
        {
            if (points <= 0) return;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Members SET Points = CASE WHEN ISNULL(Points,0) - @pts < 0 THEN 0 ELSE Points - @pts END WHERE MemberId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pts", points);
                cmd.Parameters.AddWithValue("@id", memberId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
