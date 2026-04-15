using CSMS.Database;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Repositories
{
    public class ReportRepository
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        // ===== SAFE DATE =====
        private DateTime SafeDate(DateTime d)
        {
            if (d < new DateTime(1753, 1, 1))
                return new DateTime(1753, 1, 1);
            return d;
        }

        // ===== KPI =====
        public decimal GetTotalRevenue(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT SUM(TotalAmount) 
                                 FROM Invoices 
                                 WHERE CreatedAt >= @start AND CreatedAt <= @end";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                object result = cmd.ExecuteScalar();
                if (result == DBNull.Value) return 0;

                return Convert.ToDecimal(result);
            }
        }

        public int GetTotalOrders(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT COUNT(*) 
                                 FROM Invoices 
                                 WHERE CreatedAt >= @start AND CreatedAt <= @end";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                return (int)cmd.ExecuteScalar();
            }
        }

        public decimal GetAverageOrder(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT AVG(TotalAmount) 
                                 FROM Invoices 
                                 WHERE CreatedAt >= @start AND CreatedAt <= @end";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                object result = cmd.ExecuteScalar();
                if (result == DBNull.Value) return 0;

                return Convert.ToDecimal(result);
            }
        }

        public decimal GetProfitMargin(DateTime start, DateTime end)
        {
            decimal revenue = GetTotalRevenue(start, end);
            return revenue * 0.3m;
        }

        // ===== REVENUE TREND =====
        public DataTable GetRevenueTrend(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    CAST(CreatedAt AS DATE) AS Date,
                    SUM(TotalAmount) AS Revenue,
                    COUNT(*) AS Orders
                FROM Invoices
                WHERE CreatedAt >= @start AND CreatedAt <= @end
                GROUP BY CAST(CreatedAt AS DATE)
                ORDER BY Date";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ===== PRODUCT =====
        public DataTable GetBestSellingProducts(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY SUM(id.Quantity) DESC) AS Rank,
                    p.ProductName,
                    c.CategoryName,
                    SUM(id.Quantity) AS UnitsSold,
                    SUM(id.SubTotal) AS Revenue
                FROM InvoiceDetails id
                JOIN Products p ON id.ProductId = p.ProductId
                JOIN Categories c ON p.CategoryId = c.CategoryId
                JOIN Invoices i ON id.InvoiceId = i.InvoiceId
                WHERE i.CreatedAt >= @start AND i.CreatedAt <= @end
                GROUP BY p.ProductName, c.CategoryName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ===== CATEGORY =====
        public DataTable GetCategoryReport(DateTime start, DateTime end)
        {
            start = SafeDate(start);

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                     c.CategoryName AS Category,
                     SUM(id.SubTotal) AS Revenue,
                     COUNT(DISTINCT i.InvoiceId) AS Orders,
                     CAST(
                     SUM(id.SubTotal) * 100.0 /
                     NULLIF(
                     (SELECT SUM(id2.SubTotal)
                 FROM InvoiceDetails id2
                 JOIN Invoices i2 ON id2.InvoiceId = i2.InvoiceId
                 WHERE i2.CreatedAt >= @start AND i2.CreatedAt <= @end),
                 0
                )
                 AS DECIMAL(5,2)) AS Percentage
                FROM InvoiceDetails id
                JOIN Products p ON id.ProductId = p.ProductId
                JOIN Categories c ON p.CategoryId = c.CategoryId
                JOIN Invoices i ON id.InvoiceId = i.InvoiceId
                WHERE i.CreatedAt >= @start AND i.CreatedAt <= @end
                GROUP BY c.CategoryName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
    
}