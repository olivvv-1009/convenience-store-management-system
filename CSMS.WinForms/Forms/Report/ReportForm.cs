using convenience_store_management_system.Services;
using CSMS.Database;
using CSMS.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSMS.WinForms.Forms.Report
{
    public partial class ReportForm : UserControl
    {
        private DbConnectionHelper db = new DbConnectionHelper();
        ReportService service = new ReportService();

        DateTime startDate;
        DateTime endDate;

        public ReportForm()
        {
            InitializeComponent();

            // ===== COMBO =====
            cmbReportType.Items.AddRange(new string[]
            {
                "Revenue Report",
                "Product Report",
                "Category Report"
            });

            cmbTimeRange.Items.AddRange(new string[]
            {
                "Last 7 Days",
                "Last 30 Days",
                "Last 12 Months"
            });

            cmbReportType.SelectedIndex = 0;
            cmbTimeRange.SelectedIndex = 1;

            // ===== EVENT =====
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            cmbTimeRange.SelectedIndexChanged += cmbTimeRange_SelectedIndexChanged;

            SetDateRange();
            LoadReport();
        }

        // ===== DATE RANGE =====
        private void SetDateRange()
        {
            endDate = DateTime.Today;

            switch (cmbTimeRange.Text)
            {
                case "Last 7 Days":
                    startDate = endDate.AddDays(-7);
                    break;

                case "Last 30 Days":
                    startDate = endDate.AddDays(-30);
                    break;

                case "Last 12 Months":
                    startDate = endDate.AddMonths(-12);
                    break;

                default:
                    startDate = endDate.AddDays(-7); // fallback
                    break;
            }
        }

        // ===== GROWTH =====
        private double Growth(decimal current, decimal prev)
        {
            if (prev == 0) return 0;
            return (double)((current - prev) / prev * 100);
        }

        // ===== MAIN LOAD =====
        private void LoadReport()
        {

            // reset UI

            dgvReport.DataSource = null;
            chartMain.Series.Clear();
            chartMain.ChartAreas.Clear();
            chartMain.ChartAreas.Add("Main");

            dgvReport.Visible = false;
            chartMain.Visible = false;
            tlpInfoPanels.Visible = false;

            string type = cmbReportType.Text;

            if (type == "Revenue Report")
            {
                tlpInfoPanels.Visible = true;
                tlpMain.RowStyles[2].SizeType = SizeType.Absolute;
                tlpMain.RowStyles[2].Height = 100;

                tlpMain.RowStyles[3].Height = 80;
                tlpMain.RowStyles[4].Height = 0;

                chartMain.Visible = true;

                LoadRevenue();
            }
            else if (type == "Product Report")
            {
                tlpMain.RowStyles[2].Height = 0;

                tlpMain.RowStyles[3].Height = 0;
                tlpMain.RowStyles[4].Height = 100;

                dgvReport.Visible = true;

                LoadProduct();
            }
            else
            {
                tlpMain.RowStyles[2].Height = 0;

                tlpMain.RowStyles[3].Height = 50;
                tlpMain.RowStyles[4].Height = 50;

                chartMain.Visible = true;
                dgvReport.Visible = true;

                LoadCategory();
            }
        }

        // ===== REVENUE =====
        private void LoadRevenue()
        {
            chartMain.Visible = true;
            tlpInfoPanels.Visible = true;

            // layout FULL chart
            tlpMain.RowStyles[3].Height = 100;
            tlpMain.RowStyles[4].Height = 0;

            // chart
            var revenue = chartMain.Series.Add("Revenue");
            revenue.ChartType = SeriesChartType.Line;
            revenue.BorderWidth = 3;

            var orders = chartMain.Series.Add("Orders");
            orders.ChartType = SeriesChartType.Line;

            DataTable dt = service.GetRevenueTrend(startDate, endDate);

            foreach (DataRow r in dt.Rows)
            {
                revenue.Points.AddXY(r["Date"], r["Revenue"]);
                orders.Points.AddXY(r["Date"], r["Orders"]);
            }

            // KPI
            LoadRevenuePanels();
        }

        private void LoadRevenuePanels()
        {
            decimal revenue = service.GetTotalRevenue(startDate, endDate);
            decimal prevRevenue = service.GetTotalRevenue(startDate.AddDays(-7), startDate);

            int orders = service.GetTotalOrders(startDate, endDate);
            int prevOrders = service.GetTotalOrders(startDate.AddDays(-7), startDate);

            decimal avg = service.GetAverageOrder(startDate, endDate);
            decimal prevAvg = service.GetAverageOrder(startDate.AddDays(-7), startDate);

            decimal profit = service.GetProfitMargin(startDate, endDate);
            decimal prevProfit = service.GetProfitMargin(startDate.AddDays(-7), startDate);

            lblRevenueAmount.Text = revenue.ToString("N0");
            lblRevenuePercent.Text = Growth(revenue, prevRevenue).ToString("0.##") + "%";

            lblOrdersAmount.Text = orders.ToString();
            lblOrdersPercent.Text = Growth(orders, prevOrders).ToString("0.##") + "%";

            lblAvgOrderAmount.Text = avg.ToString("N0");
            lblAvgOrderPercent.Text = Growth(avg, prevAvg).ToString("0.##") + "%";

            lblProfitAmount.Text = profit.ToString("N0");
            lblProfitPercent.Text = Growth(profit, prevProfit).ToString("0.##") + "%";

            // màu
            lblRevenuePercent.ForeColor = (Growth(revenue, prevRevenue) >= 0) ? Color.Green : Color.Red;
        }

        // ===== PRODUCT =====
        private void LoadProduct()
        {
            dgvReport.Visible = true;

            // layout FULL table
            tlpMain.RowStyles[3].Height = 0;
            tlpMain.RowStyles[4].Height = 100;

            dgvReport.DataSource = service.GetBestSellingProducts(startDate, endDate);
        }

        // ===== CATEGORY =====
        private void LoadCategory()
        {
            chartMain.Visible = true;
            dgvReport.Visible = true;

            // layout split
            tlpMain.RowStyles[3].Height = 50;
            tlpMain.RowStyles[4].Height = 50;

            var s = chartMain.Series.Add("Revenue");
            s.ChartType = SeriesChartType.Column;

            DataTable dt = service.GetCategoryReport(startDate, endDate);

            foreach (DataRow r in dt.Rows)
            {
                s.Points.AddXY(r["Category"], r["Revenue"]);
            }

            dgvReport.DataSource = dt;
        }

        // ===== EVENTS =====
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDateRange();
            LoadReport();
        }

        private void cmbTimeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDateRange();
            LoadReport();
        }
    }
}