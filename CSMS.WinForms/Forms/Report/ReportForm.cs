using System;
using System.Windows.Forms;
using CSMS.Services;
using CSMS.Database;
using CSMS.WinForms.Forms.Main;

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

            // wire events for controls created in designer
            if (this.Controls.Find("cboReportType", true).Length > 0)
            {
                var cbo = this.Controls.Find("cboReportType", true)[0] as ComboBox;
                cbo.Items.AddRange(new object[] { "Revenue Report", "Orders Report" });
                cbo.SelectedIndex = 0;
            }

            if (this.Controls.Find("cboPeriod", true).Length > 0)
            {
                var cbo = this.Controls.Find("cboPeriod", true)[0] as ComboBox;
                cbo.Items.AddRange(new object[] { "Last 7 Days", "Last 30 Days" });
                cbo.SelectedIndex = 0;
                cbo.SelectedIndexChanged += (s, e) => LoadReport();
            }

            if (this.Controls.Find("btnExport", true).Length > 0)
            {
                var btn = this.Controls.Find("btnExport", true)[0] as Button;
                btn.Click += BtnExport_Click;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                var lblTotalRevenue = this.Controls.Find("lblTotalRevenue", true)[0] as Label;
                lblTotalRevenue.Text = revenue.ToString("N0") + " đ";

               
                int totalOrders = GetTotalOrdersLastNDays(7);
                var lblTotalOrders = this.Controls.Find("lblTotalOrders", true)[0] as Label;
                lblTotalOrders.Text = totalOrders.ToString("N0");

                decimal avgOrder = totalOrders == 0 ? 0 : revenue / totalOrders;
                var lblAverageOrder = this.Controls.Find("lblAverageOrder", true)[0] as Label;
                lblAverageOrder.Text = avgOrder.ToString("N2") + " đ";

               
                var lblProfitMargin = this.Controls.Find("lblProfitMargin", true)[0] as Label;
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
                var dt = new System.Data.DataTable();
                da.Fill(dt);

                var chart = this.Controls.Find("chartReport", true)[0] as System.Windows.Forms.DataVisualization.Charting.Chart;
                chart.Series.Clear();
                chart.ChartAreas.Clear();

                var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
                chart.ChartAreas.Add(area);

                var sRevenue = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Revenue",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,
                    MarkerSize = 8,
                    Color = Color.RoyalBlue
                };

                var sOrders = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Orders",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle,
                    MarkerSize = 8,
                    Color = Color.SeaGreen,
                    YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
                };

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["SaleDate"]);
                    decimal rev = Convert.ToDecimal(row["Revenue"]);
                    int orders = Convert.ToInt32(row["Orders"]);

                    var p = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                    p.AxisLabel = date.ToString("MMM d");
                    p.YValues = new double[] { (double)rev };
                    sRevenue.Points.Add(p);

                    var p2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                    p2.AxisLabel = date.ToString("MMM d");
                    p2.YValues = new double[] { orders };
                    sOrders.Points.Add(p2);
                }

                chart.Series.Add(sRevenue);
                chart.Series.Add(sOrders);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    sfd.FileName = "report.csv";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportReportCsv(sfd.FileName);
                        MessageBox.Show("Exported report to " + sfd.FileName);
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
                        var dt = reader.GetDateTime(0);
                        var amt = reader.GetDecimal(1);
                        sw.WriteLine($"{dt:yyyy-MM-dd HH:mm:ss},{amt}");
                    }
                }
            }
        }
    }
}