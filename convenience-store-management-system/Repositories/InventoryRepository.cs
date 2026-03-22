using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Models;
using Microsoft.Data.SqlClient;

namespace CSMS.Repositories
{
    public class InventoryRepository
    {
        private DbConnectionHelper dbHelper = new DbConnectionHelper();

        public void ImportStock(InventoryItem inventory)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertBatch = @"
INSERT INTO Batches(ProductId,UnitCost,Quantity,ExpiryDate,Supplier,BatchNumber)
VALUES(@ProductId,@UnitCost,@Quantity,@ExpiryDate,@Supplier,@BatchNumber)";

                    SqlCommand cmdBatch = new SqlCommand(insertBatch, conn, transaction);

                    cmdBatch.Parameters.AddWithValue("@ProductId", inventory.ProductId);
                    cmdBatch.Parameters.AddWithValue("@UnitCost", inventory.UnitCost);
                    cmdBatch.Parameters.AddWithValue("@Quantity", inventory.Quantity);
                    cmdBatch.Parameters.AddWithValue("@ExpiryDate", inventory.ExpiryDate);
                    cmdBatch.Parameters.AddWithValue("@Supplier", inventory.Supplier);
                    cmdBatch.Parameters.AddWithValue("@BatchNumber", inventory.BatchNumber);

                    cmdBatch.ExecuteNonQuery();

                    string updateInventory = @"
                    UPDATE Inventory
                    SET Quantity = Quantity + @Quantity,
                        LastUpdated = GETDATE()
                    WHERE ProductId = @ProductId";

                    SqlCommand cmdInventory = new SqlCommand(updateInventory, conn, transaction);
                    cmdInventory.Parameters.AddWithValue("@ProductId", inventory.ProductId);
                    cmdInventory.Parameters.AddWithValue("@Quantity", inventory.Quantity);

                    cmdInventory.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public decimal? GetLastUnitCost(string productId, string supplier)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"
        SELECT TOP 1 UnitCost
        FROM Batches
        WHERE ProductId = @ProductId
        AND Supplier = @Supplier
        ORDER BY ImportedDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@Supplier", supplier);

                conn.Open();

                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToDecimal(result);

                return null;
            }
        }
        public List<StockView> GetStockList()
        {
            List<StockView> list = new List<StockView>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT 
                        p.ProductId,
                        p.ProductName,
                        c.CategoryName,
                        i.Quantity,
                        i.MinimumStock
                        FROM Products p
                        JOIN Categories c ON p.CategoryId = c.CategoryId
                        JOIN Inventory i ON p.ProductId = i.ProductId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int current = Convert.ToInt32(reader["Quantity"]);
                    int min = Convert.ToInt32(reader["MinimumStock"]);

                    list.Add(new StockView
                    {
                        ProductCode = reader["ProductId"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        CategoryName = reader["CategoryName"].ToString(),
                        CurrentStock = current,
                        MinStock = min,
                        Status = current < min ? "Low Stock" : "Active"
                    });
                }
            }

            return list;
        }
        public List<ExpiredProduct> GetExpiredProducts()
        {
            List<ExpiredProduct> list = new List<ExpiredProduct>();

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string query = @"
SELECT
b.BatchNumber,
p.ProductId,
p.ProductName,
c.CategoryNameName AS CategoryName,
b.Quantity AS Stock,
b.ExpiryDate,
DATEDIFF(DAY, b.ExpiryDate, GETDATE()) AS DaysOverdue,
'Expired' AS Status
FROM Batches b
JOIN Products p ON b.ProductId = p.ProductId
JOIN Categories c ON p.CategoryId = c.CategoryId
WHERE b.ExpiryDate <= GETDATE()
";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ExpiredProduct
                    {
                        BatchNumber = reader["BatchNumber"].ToString(),
                        ProductCode = reader["ProductId"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        CategoryName = reader["CategoryName"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]),
                        DaysOverdue = Convert.ToInt32(reader["DaysOverdue"]),
                        Status = reader["Status"].ToString()
                    });
                }
            }

            return list;
        }

    }
}