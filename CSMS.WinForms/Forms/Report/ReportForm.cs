using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CSMS.Database;
using CSMS.Services;

namespace CSMS.WinForms.Forms.Report
{
    public partial class ReportForm : UserControl
    {
        private DashboardService dashboardService = new DashboardService();
        private DbConnectionHelper db = new DbConnectionHelper();

        public ReportForm()
        {
            InitializeComponent();
            this.Load += ReportForm_Load;

            cboReportType.Items.AddRange(new object[] { "Revenue Report", "Orders Report" });
            cboReportType.SelectedIndex = 0;

            cboPeriod.Items.AddRange(new object[] { "Last 7 Days", "Last 30 Days" });
            cboPeriod.SelectedIndex = 0;
            cboPeriod.SelectedIndexChanged += (s, e) => LoadReport();

            btnExport.Click += BtnExport_Click;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                decimal revenue = dashboardService.GetTotalRevenue();
                lblTotalRevenue.Text = revenue.ToString("N0") + " đ";

                int totalOrders = GetTotalOrdersLastNDays(7);
                lblTotalOrders.Text = totalOrders.ToString("N0");

                decimal avgOrder = totalOrders == 0 ? 0 : revenue / totalOrders;
                lblAverageOrder.Text = avgOrder.ToString("N2") + " đ";

                lblProfitMargin.Text = "32.5%";

                LoadReportChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load report failed: " + ex.Message);
            }
        }

        private int GetTotalOrdersLastNDays(int days)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string q = $"SELECT COUNT(*) FROM Invoices WHERE CreatedAt >= DATEADD(DAY, -{days - 1}, GETDATE())";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(q, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void LoadReportChart()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    CONVERT(DATE, CreatedAt) AS SaleDate,
                    SUM(TotalAmount) AS Revenue,
                    COUNT(*) AS Orders
                FROM Invoices
                WHERE CreatedAt >= DATEADD(DAY, -6, GETDATE())
                GROUP BY CONVERT(DATE, CreatedAt)
                ORDER BY SaleDate";

                var da = new Microsoft.Data.SqlClient.SqlDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);

                chartReport.Series.Clear();
                chartReport.ChartAreas.Clear();

                var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                chartReport.ChartAreas.Add(area);

                var sRevenue = new System.Windows.Forms.DataVisualization.Charting.Series("Revenue")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.RoyalBlue,
                    MarkerStyle = MarkerStyle.Circle,  
                    MarkerSize = 8
                };

                var sOrders = new System.Windows.Forms.DataVisualization.Charting.Series("Orders")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 3,
                    Color = Color.SeaGreen,
                    YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary,
                    MarkerStyle = MarkerStyle.Circle,  
                    MarkerSize = 8
                };


                if (dt.Rows.Count == 0)
                {
                    chartReport.Series.Add(sRevenue);
                    chartReport.Series.Add(sOrders);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["SaleDate"]);
                    decimal rev = Convert.ToDecimal(row["Revenue"]);
                    int orders = Convert.ToInt32(row["Orders"]);

                    sRevenue.Points.AddXY(date.ToString("MM-dd"), (double)rev);
                    sOrders.Points.AddXY(date.ToString("MM-dd"), orders);
                }

                chartReport.Series.Add(sRevenue);
                chartReport.Series.Add(sOrders);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = "report.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportReportCsv(sfd.FileName);
                        MessageBox.Show("Exported successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void ExportReportCsv(string path)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT CreatedAt, TotalAmount FROM Invoices ORDER BY CreatedAt";

                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                using (var sw = new System.IO.StreamWriter(path))
                {
                    sw.WriteLine("CreatedAt,TotalAmount");

                    while (reader.Read())
                    {
                        sw.WriteLine($"{reader.GetDateTime(0):yyyy-MM-dd HH:mm:ss},{reader.GetDecimal(1)}");
                    }
                }
            }
        }
    }
}