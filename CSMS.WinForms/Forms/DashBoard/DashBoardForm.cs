using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CSMS.Database;

namespace CSMS.WinForms.Forms.DashBoard
{
    public partial class DashBoardForm : UserControl
    {
        private DbConnectionHelper db = new DbConnectionHelper();

        public DashBoardForm()
        {
            InitializeComponent();

            MakeAvatarRound();

            LoadUserData();

            pnlChartArea.Paint += PnlChartArea_Paint;
        }

        // Bo tròn avatar
        private void MakeAvatarRound()
        {
            System.Drawing.Drawing2D.GraphicsPath gp =
                new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, lblAvatar.Width, lblAvatar.Height);
            lblAvatar.Region = new Region(gp);
        }

        // Lấy dữ liệu người dùng
        private void LoadUserData()
        {
            string query = @"SELECT U.FullName, R.RoleName
                             FROM Users U
                             JOIN Roles R ON U.RoleId = R.RoleId
                             WHERE U.UserId = 1";

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["FullName"].ToString();

                        lblFullName.Text = name;
                        lblRole.Text = reader["RoleName"].ToString();
                        lblAvatar.Text = name.Substring(0, 1).ToUpper();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy dữ liệu người dùng: " + ex.Message);
                }
            }
        }

        // Lấy dữ liệu doanh thu
        private List<int> GetRevenueData()
        {
            List<int> values = new List<int>();

            string sql =
                "SELECT TOP 7 TotalAmount FROM Invoices ORDER BY InvoiceDate DESC";

            using (SqlConnection conn = db.GetConnection())
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
                    // dữ liệu giả nếu SQL lỗi
                    return new List<int> { 1000, 2000, 1500, 3500, 2500, 4500, 4000 };
                }
            }

            return values;
        }

        // Vẽ biểu đồ
        private void PnlChartArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.FromArgb(28, 98, 242), 3);

            List<int> data = GetRevenueData();

            if (data.Count < 2)
                return;

            List<Point> points = new List<Point>();

            int spacing = pnlChartArea.Width / (data.Count + 1);

            for (int i = 0; i < data.Count; i++)
            {
                int x = spacing * (i + 1);

                int y =
                    pnlChartArea.Height - 50 - (data[i] / 50);

                points.Add(new Point(x, y));
            }

            g.DrawCurve(pen, points.ToArray());

            foreach (var p in points)
            {
                g.FillEllipse(Brushes.White, p.X - 5, p.Y - 5, 10, 10);
                g.DrawEllipse(pen, p.X - 5, p.Y - 5, 10, 10);
            }
        }
    }
}