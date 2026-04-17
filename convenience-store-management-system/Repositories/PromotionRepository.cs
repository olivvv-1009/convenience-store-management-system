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

        // GET ALL
        public List<Promotion> GetAll()
        {
            var list = new List<Promotion>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT PromotionId, Code, PromotionName, DiscountPercent, Type,
                           StartDate, EndDate, IsActive
                    FROM Promotions";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(Map(reader));
                    }
                }
            }

            return list;
        }

        // GET BY ID
        public Promotion? GetById(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT PromotionId, Code, PromotionName, DiscountPercent, Type,
                           StartDate, EndDate, IsActive
                    FROM Promotions
                    WHERE PromotionId = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return Map(reader);
                    }
                }
            }

            return null;
        }

        // GET BY CODE
        public Promotion? GetByCode(string code)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 PromotionId, Code, PromotionName, DiscountPercent, Type,
                                 StartDate, EndDate, IsActive
                    FROM Promotions
                    WHERE Code = @code";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return Map(reader);
                    }
                }
            }

            return null;
        }

        // INSERT
        public void Insert(Promotion p)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO Promotions (Code, PromotionName, DiscountPercent, Type, StartDate, EndDate, IsActive)
                    VALUES (@code, @name, @discount, @type, @start, @end, @active)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", p.Code ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@name", p.PromotionName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@discount", p.DiscountPercent);
                    cmd.Parameters.AddWithValue("@type", p.Type ?? "Percentage");
                    cmd.Parameters.AddWithValue("@start", p.StartDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", p.EndDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@active", p.IsActive);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE
        public void Update(Promotion p)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE Promotions
                    SET Code = @code,
                        PromotionName = @name,
                        DiscountPercent = @discount,
                        Type = @type,
                        StartDate = @start,
                        EndDate = @end,
                        IsActive = @active
                    WHERE PromotionId = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", p.Code ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@name", p.PromotionName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@discount", p.DiscountPercent);
                    cmd.Parameters.AddWithValue("@type", p.Type ?? "Percentage");
                    cmd.Parameters.AddWithValue("@start", p.StartDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", p.EndDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@active", p.IsActive);
                    cmd.Parameters.AddWithValue("@id", p.PromotionId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE (soft delete)
        public void SetActive(int id, bool isActive)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Promotions SET IsActive = @active WHERE PromotionId = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@active", isActive);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // MAP FUNCTION
        private Promotion Map(SqlDataReader reader)
        {
            return new Promotion
            {
                PromotionId = Convert.ToInt32(reader["PromotionId"]),
                Code = reader["Code"]?.ToString(),
                PromotionName = reader["PromotionName"]?.ToString(),
                DiscountPercent = reader["DiscountPercent"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DiscountPercent"]),
                Type = reader["Type"]?.ToString(),
                StartDate = reader["StartDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["StartDate"]),
                EndDate = reader["EndDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["EndDate"]),
                IsActive = reader["IsActive"] != DBNull.Value && Convert.ToBoolean(reader["IsActive"])
            };
        }
    }
}