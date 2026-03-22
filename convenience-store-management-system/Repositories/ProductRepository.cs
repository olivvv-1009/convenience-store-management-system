using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CSMS.Repositories
{
    public class ProductRepository
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        // ================= GET ALL PRODUCTS =================
        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
SELECT 
    p.ProductId,
    p.ProductName,
    p.Price,
    c.CategoryName,
    p.ExpiryDate,
    ISNULL(s.TotalStock,0) AS Stock,
    CASE
        WHEN p.ExpiryDate < GETDATE() THEN 'Expired'
        WHEN ISNULL(s.TotalStock,0) <= i.MinimumStock THEN 'LowStock'
        ELSE 'Active'
    END AS Status
FROM Products p
LEFT JOIN Categories c ON p.CategoryId = c.CategoryId
LEFT JOIN
(
    SELECT ProductId, SUM(Quantity) AS TotalStock
    FROM Inventory
    GROUP BY ProductId
) s ON p.ProductId = s.ProductId
LEFT JOIN Inventory i ON p.ProductId = i.ProductId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product
                    {
                        ProductId = reader["ProductId"]?.ToString(),
                        ProductName = reader["ProductName"]?.ToString(),
                        CategoryName = reader["CategoryName"]?.ToString(),
                        Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0,
                        Stock = Convert.ToInt32(reader["Stock"]),
                        ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]),
                        Status = reader["Status"]?.ToString()
                    };

                    list.Add(p);
                }
            }

            return list;
        }

        // ================= ADD PRODUCT =================
        
        public void AddProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. Insert Product
                    string query1 = @"
INSERT INTO Products(ProductId, ProductName, Price, CategoryId, ExpiryDate, Status)
VALUES(@id, @name, @price, @CategoryName, @expiry, @status)";

                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", product.ProductId);
                    cmd1.Parameters.AddWithValue("@name", product.ProductName);
                    cmd1.Parameters.AddWithValue("@price", product.Price);
                    cmd1.Parameters.AddWithValue("@CategoryName", product.CategoryId);
                    cmd1.Parameters.AddWithValue("@expiry", product.ExpiryDate);
                    cmd1.Parameters.AddWithValue("@status", product.Status);

                    cmd1.ExecuteNonQuery();

                    // 2. THÊM INVENTORY (FIX CHÍNH)
                    string query2 = @"
INSERT INTO Inventory(ProductId, Quantity, MinimumStock)
VALUES(@id, 0, 10)";

                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", product.ProductId);

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // ================= UPDATE PRODUCT =================
        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query1 = @"
UPDATE Products
SET ProductName = @name,
    Price = @price,
    CategoryId = @Category,
    ExpiryDate = @expiry
WHERE ProductId = @id";

                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", product.ProductId);
                    cmd1.Parameters.AddWithValue("@name", product.ProductName);
                    cmd1.Parameters.AddWithValue("@price", product.Price);
                    cmd1.Parameters.AddWithValue("@CategoryName", product.CategoryId);
                    cmd1.Parameters.AddWithValue("@expiry", product.ExpiryDate);

                    cmd1.ExecuteNonQuery();

                    string query2 = @"
UPDATE Inventory
SET Quantity = @stock
WHERE ProductId = @id";

                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);

                    cmd2.Parameters.AddWithValue("@id", product.ProductId);
                    cmd2.Parameters.AddWithValue("@stock", product.Stock);

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // ================= DELETE =================
        public void DeleteProduct(string productId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Products WHERE ProductId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();
            }
        }

        // ================= EXISTS =================
        public bool Exists(string productId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Products WHERE ProductId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // ================= POS =================
        public List<ProductPOS> GetProductsForPOS()
        {
            List<ProductPOS> list = new List<ProductPOS>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
SELECT p.ProductId, p.ProductName, p.Price,
       ISNULL(i.Quantity,0) AS Stock
FROM Products p
LEFT JOIN Inventory i ON p.ProductId = i.ProductId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductPOS p = new ProductPOS
                    {
                        ProductId = reader["ProductId"]?.ToString(),
                        ProductName = reader["ProductName"]?.ToString(),
                        Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0,
                        Stock = Convert.ToInt32(reader["Stock"])
                    };

                    list.Add(p);
                }
            }

            return list;
        }

        // ================= UPDATE STOCK =================
        public void UpdateStock(string productId, int quantitySold)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
UPDATE Inventory
SET Quantity = Quantity - @qty
WHERE ProductId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@qty", quantitySold);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}