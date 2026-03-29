using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

using CSMS.Services;
using CSMS.Database;

namespace CSMS.WinForms.Forms.DashBoard
{
    public partial class DashBoardForm : UserControl
    {
        private DashboardService service = new DashboardService();
        private DbConnectionHelper db = new DbConnectionHelper();

        public DashBoardForm()
        {
            InitializeComponent();
            this.Load += DashBoardForm_Load;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadRevenueChart();
        }

        // ================= DASHBOARD =================
        private void LoadDashboard()
        {
            LoadRevenue();
            LoadProducts();
            LoadLowStock();
            LoadOrders();
        }

        private void LoadRevenue()
        {
            decimal revenue = service.GetTotalRevenue();
            lblRevenue.Text = revenue.ToString("N0") + " đ";

            lblrevenuecomp.Text = "+20.1% from last month";
            lblrevenuecomp.ForeColor = Color.Green;
        }

        private void LoadProducts()
        {
            lblTotalProduct.Text = service.GetTotalProducts().ToString("N0");
        }

        private void LoadLowStock()
        {
            int lowStock = service.GetLowStockProducts();
            lblLowStock.Text = lowStock.ToString();
            lblLowStock.ForeColor = Color.DarkOrange;
        }

        private void LoadOrders()
        {
            lblOrders.Text = service.GetTodayOrders().ToString();

            label14.Text = "+12% from yesterday";
            label14.ForeColor = Color.Green;
        }

        // ================= CHART =================
        private void LoadRevenueChart()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
    SELECT 
        CONVERT(DATE, CreatedAt) AS SaleDate,
        SUM(TotalAmount) AS Revenue
    FROM Invoices
    WHERE CreatedAt >= DATEADD(DAY, -6, GETDATE())
    GROUP BY CONVERT(DATE, CreatedAt)
    ORDER BY SaleDate";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // ===== RESET =====
                chartRevenue.Series.Clear();
                chartRevenue.ChartAreas.Clear();

                // ===== AREA =====
                ChartArea area = new ChartArea();
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

                chartRevenue.ChartAreas.Add(area);

                // ===== SERIES =====
                Series series = new Series
                {
                    Name = "Revenue",
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    Color = Color.RoyalBlue
                };

                // ===== DATA =====
                foreach (DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["SaleDate"]);
                    decimal revenue = Convert.ToDecimal(row["Revenue"]);
                    if (revenue == 0) continue;
                    DataPoint point = new DataPoint();
                    point.AxisLabel = date.ToString("dd/MM");
                    point.YValues = new double[] { (double)revenue };
                    point.ToolTip = "Revenue: " + revenue.ToString("N0");

                    series.Points.Add(point);
                }

                chartRevenue.Series.Add(series);
            }
        }
    }
}