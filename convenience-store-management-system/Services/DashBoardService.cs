using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CSMS.Database;

namespace CSMS.Services
{
    public class DashboardService
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        public decimal GetTotalRevenue()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(TotalAmount) FROM Invoices";

                object result = new SqlCommand(query, conn).ExecuteScalar();

                return Convert.ToDecimal(new SqlCommand(query, conn).ExecuteScalar());
            }
        }

        public int GetTotalProducts()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Products";

                return (int)new SqlCommand(query, conn).ExecuteScalar();
            }
        }

        public int GetLowStockProducts()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT COUNT(*) 
            FROM Inventory 
            WHERE Quantity <= MinimumStock";

                return (int)new SqlCommand(query, conn).ExecuteScalar();
            }
        }

        public int GetTodayOrders()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT COUNT(*) 
            FROM Invoices
            WHERE CAST(CreatedAt AS DATE) = CAST(GETDATE() AS DATE)";

                return (int)new SqlCommand(query, conn).ExecuteScalar();
            }
        }
    }
}