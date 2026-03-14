using System.Data.SqlClient;
using CSMS.Models;

namespace CSMS.Services
{
    public class MemberService
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSMS_DB;Integrated Security=True";

        public Member GetMemberByPhone(string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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
                        Phone = reader["Phone"].ToString()
                    };
                }

                return null;
            }
        }
    }
}