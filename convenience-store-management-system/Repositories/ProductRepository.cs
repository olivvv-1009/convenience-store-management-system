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

        // Lấy tất cả sản phẩm
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
    c.CategoryName,
    p.Price,
    p.ExpiryDate,
    ISNULL(i.Quantity,0) AS Stock,

    CASE
        WHEN p.ExpiryDate < GETDATE() THEN 'Expired'
        WHEN ISNULL(i.Quantity,0) <= ISNULL(i.MinimumStock,0) THEN 'LowStock'
        ELSE 'Active'
    END AS Status

FROM Products p
LEFT JOIN Categories c 
ON p.CategoryId = c.CategoryId
LEFT JOIN Inventory i 
ON p.ProductId = i.ProductId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();

                    p.ProductId = reader["ProductId"].ToString();
                    p.ProductName = reader["ProductName"].ToString();
                    p.Category = reader["CategoryName"].ToString();
                    p.Price = Convert.ToDouble(reader["Price"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);
                    p.ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]);
                    p.Status = reader["Status"].ToString();

                    list.Add(p);
                }
            }

            return list;
        }


        // Thêm sản phẩm
        public void AddProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query1 =
                    @"INSERT INTO Products(ProductId,ProductName,Price,CategoryId,ExpiryDate)
                 VALUES(@id,@name,@price,@category,@expiry)";

                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", product.ProductId);
                    cmd1.Parameters.AddWithValue("@name", product.ProductName);
                    cmd1.Parameters.AddWithValue("@price", product.Price);
                    cmd1.Parameters.AddWithValue("@category", product.CategoryId);
                    cmd1.Parameters.AddWithValue("@expiry", product.ExpiryDate);

                    cmd1.ExecuteNonQuery();

                    string query2 =
                    @"INSERT INTO Inventory(ProductId, Quantity)
                 VALUES(@id,@stock)";

                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);

                    cmd2.Parameters.AddWithValue("@id", product.ProductId);
                    cmd2.Parameters.AddWithValue("@stock", product.Stock);

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                }
            }
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query1 = @"UPDATE Products
                              SET ProductName = @name,
                                  Price = @price,
                                  CategoryId = @category,
                                  ExpiryDate = @expiry
                              WHERE ProductId = @id";

                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", product.ProductId);
                    cmd1.Parameters.AddWithValue("@name", product.ProductName);
                    cmd1.Parameters.AddWithValue("@price", product.Price);
                    cmd1.Parameters.AddWithValue("@category", product.CategoryId);
                    cmd1.Parameters.AddWithValue("@expiry", product.ExpiryDate);

                    cmd1.ExecuteNonQuery();

                    string query2 = @"UPDATE Inventory
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

        // Xóa sản phẩm
        public void DeleteProduct(string productId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string query1 = "DELETE FROM Inventory WHERE ProductId = @id";

                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", productId);

                    cmd1.ExecuteNonQuery();

                    string query2 = "DELETE FROM Products WHERE ProductId = @id";
                    SqlCommand cmd2 = new SqlCommand(query2, conn, tran);

                    cmd2.Parameters.AddWithValue("@id", productId);

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
                catch 
                {
                    tran.Rollback();
                }
                }
        }

        public bool Exists(string productId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Products WHERE ProductId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        // Lấy sản phẩm cho POS (có Stock + Status)
        public List<ProductPOS> GetProductsForPOS()
        {
            List<ProductPOS> list = new List<ProductPOS>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query =
                @"SELECT p.ProductId, p.ProductName, p.Price, c.CategoryName, p.CategoryId, p.ExpiryDate,
                  ISNULL(i.Quantity,0) AS Stock,
                  CASE
                    WHEN p.ExpiryDate < GETDATE() THEN 'Expired'
                    WHEN i.Quantity <= i.MinimumStock THEN 'LowStock'
                    ELSE 'Active'
                  END AS Status
                  FROM Products p
                  LEFT JOIN Inventory i ON p.ProductId = i.ProductId
                  LEFT JOIN Categories c ON p.CategoryId = c.CategoryId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductPOS p = new ProductPOS();

                    p.ProductId = reader["ProductId"].ToString();
                    p.ProductName = reader["ProductName"].ToString();
                    p.Price = Convert.ToDecimal(reader["Price"]);
                    p.Stock = Convert.ToInt32(reader["Stock"]);

                    list.Add(p);
                }
            }

            return list;
        }

        // Cập nhật tồn kho sau khi bán
        public void UpdateStock(string productId, int quantitySold)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query =
                "UPDATE Inventory SET Quantity = Quantity - @qty WHERE ProductId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@qty", quantitySold);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}