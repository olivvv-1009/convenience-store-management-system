using CSMS.Database;
using CSMS.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CSMS.Repositories
{
    public class InventoryRepository
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        public List<Inventory> GetInventory()
        {
            List<Inventory> list = new List<Inventory>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Inventory";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Inventory inv = new Inventory
                        {
                            InventoryId = Convert.ToInt32(reader["InventoryId"]),
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            MinimumStock = Convert.ToInt32(reader["MinimumStock"]),
                            LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
                        };

                        list.Add(inv);
                    }
                }
            }

            return list;
        }

        public Inventory GetByProductId(int productId)
        {
            Inventory inv = null;

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Inventory WHERE ProductId=@productId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@productId", SqlDbType.Int).Value = productId;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        inv = new Inventory
                        {
                            InventoryId = Convert.ToInt32(reader["InventoryId"]),
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            MinimumStock = Convert.ToInt32(reader["MinimumStock"]),
                            LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
                        };
                    }
                }
            }

            return inv;
        }

        public void UpdateStock(int productId, int quantity)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Inventory
                                 SET Quantity = Quantity + @qty,
                                     LastUpdated = GETDATE()
                                 WHERE ProductId=@productId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = quantity;
                    cmd.Parameters.Add("@productId", SqlDbType.Int).Value = productId;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}