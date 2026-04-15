using convenience_store_management_system.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Services
{
    public class ReportService
    {
        private ReportRepository repo = new ReportRepository();

        public decimal GetTotalRevenue(DateTime s, DateTime e) => repo.GetTotalRevenue(s, e);
        public int GetTotalOrders(DateTime s, DateTime e) => repo.GetTotalOrders(s, e);
        public decimal GetAverageOrder(DateTime s, DateTime e) => repo.GetAverageOrder(s, e);
        public decimal GetProfitMargin(DateTime s, DateTime e) => repo.GetProfitMargin(s, e);

        public DataTable GetRevenueTrend(DateTime s, DateTime e) => repo.GetRevenueTrend(s, e);
        public DataTable GetBestSellingProducts(DateTime s, DateTime e) => repo.GetBestSellingProducts(s, e);
        public DataTable GetCategoryReport(DateTime s, DateTime e) => repo.GetCategoryReport(s, e);
    }
}
