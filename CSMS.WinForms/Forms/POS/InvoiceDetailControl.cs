using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CSMS.Database;

namespace CSMS.WinForms.Forms.POS
{
    public partial class InvoiceDetailForm : Form
    {
        int invoiceId;
        DbConnectionHelper db = new DbConnectionHelper();

        public InvoiceDetailForm(int id)
        {
            InitializeComponent();

            invoiceId = id;

            LoadInvoiceInfo();
            LoadInvoiceItems();
        }

        private void LoadInvoiceInfo()
        {
            string query = @"SELECT 
                            i.InvoiceId,
                            i.CreatedAt,
                            m.FullName AS CustomerName,
                            m.Phone,
                            p.PaymentMethod,
                            i.TotalAmount
                            FROM Invoices i
                            LEFT JOIN Members m ON i.MemberId = m.MemberId
                            LEFT JOIN Payments p ON i.InvoiceId = p.InvoiceId
                            WHERE i.InvoiceId = @InvoiceId";

            using SqlConnection conn = db.GetConnection();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblNameInvoice.Text = "Complete information for INV-" + reader["InvoiceId"];
                lblInvoiceIdValue.Text = "INV-" + reader["InvoiceId"];

                lblDateTimeValue.Text = Convert.ToDateTime(reader["CreatedAt"])
                    .ToString("yyyy-MM-dd HH:mm");

                lblCustomerName.Text = reader["CustomerName"].ToString();
                lblPhoneNumber.Text = reader["Phone"].ToString();

                lblPaymentMethod.Text = reader["PaymentMethod"] == DBNull.Value
                    ? "N/A"
                    : reader["PaymentMethod"].ToString();

                lblTotal.Text = Convert.ToDecimal(reader["TotalAmount"]).ToString("C");
            }
        }

        private void LoadInvoiceItems()
        {
            string query = @"SELECT
                            p.ProductName,
                            d.Quantity,
                            d.UnitPrice,
                            d.SubTotal
                            FROM InvoiceDetails d
                            JOIN Products p ON d.ProductId = p.ProductId
                            WHERE d.InvoiceId = @InvoiceId";

            using SqlConnection conn = db.GetConnection();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvItems.DataSource = dt;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hóa đơn đã được in thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}