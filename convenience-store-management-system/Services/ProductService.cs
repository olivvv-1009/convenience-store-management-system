using System;
using System.Collections.Generic;
using CSMS.Database;
using CSMS.Models;
using Microsoft.Data.SqlClient;

namespace CSMS.Services
{
    public class ProductService
    {
        private DbConnectionHelper dbHelper = new DbConnectionHelper();

        // ================= GET ALL =================
        public List<Product> GetAllProducts()
        {
            var list = new List<Product>();

            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
SELECT p.ProductId, p.ProductName, p.Price, p.ExpiryDate, p.Status,
       p.CategoryId,
       ISNULL(i.Quantity, 0) AS Stock,
       c.CategoryName
FROM Products p
LEFT JOIN Categories c ON p.CategoryId = c.CategoryId
LEFT JOIN Inventory i ON p.ProductId = i.ProductId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product
                        {
                            ProductId = reader["ProductId"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            CategoryId = Convert.ToInt32(reader["CategoryId"]),
                            CategoryName = reader["CategoryName"]?.ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]),
                            Status = reader["Status"]?.ToString()
                        });
                    }
                }
            }

            return list;
        }

        // ================= GET BY ID =================
        public Product GetProductById(string id)
        {
            return GetAllProducts().Find(p => p.ProductId == id);
        }

        // ================= EXISTS =================
        public bool Exists(string id)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Products WHERE ProductId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // ================= CREATE =================
        public void AddProduct(Product p)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query1 = @"
INSERT INTO Products 
(ProductId, ProductName, Price, CategoryId, Status, ExpiryDate)
VALUES (@id, @name, @price, @CategoryId, @status, @expiry)";

                    using (SqlCommand cmd1 = new SqlCommand(query1, conn, tran))
                    {
                        cmd1.Parameters.AddWithValue("@id", p.ProductId);
                        cmd1.Parameters.AddWithValue("@name", p.ProductName);
                        cmd1.Parameters.AddWithValue("@price", p.Price);
                        cmd1.Parameters.AddWithValue("@CategoryId", p.CategoryId);
                        cmd1.Parameters.AddWithValue("@status", "Active");
                        cmd1.Parameters.AddWithValue("@expiry", p.ExpiryDate);

                        cmd1.ExecuteNonQuery();
                    }

                    string query2 = @"
INSERT INTO Inventory(ProductId, Quantity, MinimumStock)
VALUES (@id, @stock, 10)";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conn, tran))
                    {
                        cmd2.Parameters.AddWithValue("@id", p.ProductId);
                        cmd2.Parameters.AddWithValue("@stock", p.Stock);

                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // ================= UPDATE =================
        public void UpdateProduct(Product p)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
UPDATE Products 
SET ProductName = @name,
    CategoryId = @CategoryId,
    Price = @price,
    ExpiryDate = @expiry
WHERE ProductId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.ProductId);
                    cmd.Parameters.AddWithValue("@name", p.ProductName);
                    cmd.Parameters.AddWithValue("@CategoryId", p.CategoryId);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.Parameters.AddWithValue("@expiry", p.ExpiryDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ================= DELETE =================
        public void DeleteProduct(string id)
        {
            using (var conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Products WHERE ProductId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ================= POS =================
        public List<Product> GetProductsForPOS()
        {
            return GetAllProducts().FindAll(p => p.Stock > 0);
        }
    }
}