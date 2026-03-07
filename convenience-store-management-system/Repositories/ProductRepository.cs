using CSMS.Database;
using CSMS.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CSMS.Repositories
{
    public class ProductRepository
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Products";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product p = new Product
                        {
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            ProductName = reader["ProductName"].ToString(),
                            Barcode = reader["Barcode"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            CategoryId = Convert.ToInt32(reader["CategoryId"]),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        };

                        list.Add(p);
                    }
                }
            }

            return list;
        }

        public void AddProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Products
                                (ProductName,Barcode,Price,CategoryId)
                                VALUES
                                (@name,@barcode,@price,@category)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.ProductName;
                    cmd.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = product.Barcode;
                    cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                    cmd.Parameters.Add("@category", SqlDbType.Int).Value = product.CategoryId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Products
                                 SET ProductName=@name,
                                     Barcode=@barcode,
                                     Price=@price,
                                     CategoryId=@category
                                 WHERE ProductId=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.ProductName;
                    cmd.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = product.Barcode;
                    cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                    cmd.Parameters.Add("@category", SqlDbType.Int).Value = product.CategoryId;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = product.ProductId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Products WHERE ProductId=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}