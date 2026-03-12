using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSMS.WinForms.Forms.DashBoard
{
    public partial class DashBoardForm : UserControl
    {
        public DashBoardForm()
        {
            InitializeComponent();

            // Bo tròn avatar
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
            lblAvatar.Region = new Region(gp);

            // Tải dữ liệu người dùng
            LoadUserData();
            // Kiểm tra đúng tên Panel của bạn ở Design (có thể là panel6 hoặc pnlChartArea)
            pnlChartArea.Paint += (s, e) => {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.FromArgb(28, 98, 242), 3);

                List<int> data = GetRevenueData();
                if (data.Count < 2) return;

                List<Point> points = new List<Point>();
                for (int i = 0; i < data.Count; i++)
                {
                    int x = 50 + (i * 100);
                    // Tính tọa độ Y dựa trên chiều cao thực tế của panel
                    int y = pnlChartArea.Height - 50 - (data[i] / 50);
                    points.Add(new Point(x, y));
                }

                g.DrawCurve(pen, points.ToArray());

                foreach (var p in points)
                {
                    g.FillEllipse(Brushes.White, p.X - 5, p.Y - 5, 10, 10);
                    g.DrawEllipse(pen, p.X - 5, p.Y - 5, 10, 10);
                }
            };

            // CHỖ QUAN TRỌNG: Lệnh vẽ biểu đồ uốn lượn
            pnlChartArea.Paint += (s, e) => {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.FromArgb(28, 98, 242), 3); // Màu xanh Figma

                List<int> data = GetRevenueData(); // Gọi hàm lấy số từ SQL
                if (data.Count < 2) return;

                List<Point> points = new List<Point>();
                for (int i = 0; i < data.Count; i++)
                {
                    int x = 50 + (i * 100);
                    // Tọa độ y (Lấy chiều cao panel trừ đi giá trị tiền đã chia tỉ lệ)
                    int y = pnlChartArea.Height - 50 - (data[i] / 50);
                    points.Add(new Point(x, y));
                }

                g.DrawCurve(pen, points.ToArray()); // Vẽ đường cong uốn lượn

                foreach (var p in points)
                {
                    g.FillEllipse(Brushes.White, p.X - 5, p.Y - 5, 10, 10);
                    g.DrawEllipse(pen, p.X - 5, p.Y - 5, 10, 10);
                }
            };
        }

        public void LoadUserData()
        {
            string connectionString = @"Server=.;Database=CSMS_DB;Trusted_Connection=True;Encrypt=False";
            string query = @"SELECT U.FullName, R.RoleName 
                             FROM Users U 
                             JOIN Roles R ON U.RoleId = R.RoleId 
                             WHERE U.UserId = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblFullName.Text = reader["FullName"].ToString();
                        lblRole.Text = reader["RoleName"].ToString();
                        string name = reader["FullName"].ToString();
                        lblAvatar.Text = name.Substring(0, 1).ToUpper();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy dữ liệu người dùng: " + ex.Message);
                }
            }
        }

        // HÀM LẤY DỮ LIỆU SQL (Chỉ giữ lại 1 hàm duy nhất)
        private List<int> GetRevenueData()
        {
            List<int> values = new List<int>();
            string connStr = @"Server=.;Database=CSMS_DB;Trusted_Connection=True;Encrypt=False";
            string sql = "SELECT TOP 7 TotalAmount FROM Invoices ORDER BY InvoiceDate DESC";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            values.Add(Convert.ToInt32(rdr["TotalAmount"]));
                        }
                    }
                }
                catch
                {
                    // Dữ liệu giả nếu SQL lỗi để bạn vẫn thấy biểu đồ chạy
                    return new List<int> { 1000, 2000, 1500, 3500, 2500, 4500, 4000 };
                }
            }
            return values;
        }
        // Dán các hàm trống này vào cuối file để "xoa dịu" hệ thống
        private void DashBoardForm_Load(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
        private void button8_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }

}