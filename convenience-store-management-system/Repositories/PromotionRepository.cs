using convenience_store_management_system.Models;
using CSMS.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CSMS.Repositories
{
    public class PromotionRepository
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        public List<Promotion> GetAll()
        {
            var list = new List<Promotion>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT PromotionId, PromotionName, DiscountPercent, StartDate, EndDate, 1 as IsActive FROM Promotions";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var p = new Promotion
                        {
                            PromotionId = Convert.ToInt32(reader["PromotionId"]),
                            PromotionName = reader["PromotionName"]?.ToString(),
                            DiscountPercent = reader["DiscountPercent"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DiscountPercent"]),
                            StartDate = reader["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["StartDate"]),
                            EndDate = reader["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["EndDate"]),
                            IsActive = reader["IsActive"] == DBNull.Value ? true : Convert.ToBoolean(reader["IsActive"])
                        };
                        list.Add(p);
                    }
                }
            }
            return list;
        }

        public Promotion? GetById(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT PromotionId, PromotionName, DiscountPercent, StartDate, EndDate FROM Promotions WHERE PromotionId = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Promotion
                            {
                                PromotionId = Convert.ToInt32(reader["PromotionId"]),
                                PromotionName = reader["PromotionName"]?.ToString(),
                                DiscountPercent = reader["DiscountPercent"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DiscountPercent"]),
                                StartDate = reader["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["StartDate"]),
                                EndDate = reader["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["EndDate"]),
                                IsActive = true
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Insert(Promotion p)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Promotions (PromotionName, DiscountPercent, StartDate, EndDate) VALUES (@name, @discount, @start, @end)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", p.PromotionName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@discount", p.DiscountPercent);
                    cmd.Parameters.AddWithValue("@start", p.StartDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", p.EndDate ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Promotion p)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Promotions SET PromotionName=@name, DiscountPercent=@discount, StartDate=@start, EndDate=@end WHERE PromotionId=@id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", p.PromotionName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@discount", p.DiscountPercent);
                    cmd.Parameters.AddWithValue("@start", p.StartDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", p.EndDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", p.PromotionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SetActive(int id, bool isActive)
        {
            // There's no IsActive column in DB; we'll emulate by adjusting EndDate for deactivation
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = isActive ?
                    @"UPDATE Promotions SET EndDate = @end WHERE PromotionId = @id" :
                    @"UPDATE Promotions SET EndDate = @end WHERE PromotionId = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (isActive)
                        cmd.Parameters.AddWithValue("@end", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@end", DateTime.Now.AddDays(-1));
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
