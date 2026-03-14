using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace CSMS.WinForms.Forms.POS
{
    public partial class InvoiceDetailForm : Form
    {
        int invoiceId;

        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSMS_DB;Integrated Security=True";

        public InvoiceDetailForm(int id)
        {
            InitializeComponent();

            invoiceId = id;

            LoadInvoiceInfo();   // thông tin đơn hàng
            LoadInvoiceItems();  // danh sách sản phẩm
        }

        // ⭐ Lấy thông tin đơn hàng
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

            using SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblNameInvoice.Text = "Complete information for INV-" + reader["InvoiceId"].ToString();
                lblInvoiceIdValue.Text = "INV-" + reader["InvoiceId"].ToString();

                lblDateTimeValue.Text = Convert.ToDateTime(reader["CreatedAt"])
                    .ToString("yyyy-MM-dd HH:mm");

                lblCustomerName.Text = reader["CustomerName"].ToString();

                lblPhoneNumber.Text = reader["Phone"].ToString();

                lblPaymentMethod.Text = reader["PaymentMethod"] == DBNull.Value
                    ? "N/A"
                    : reader["PaymentMethod"].ToString();

                lblTotal.Text = Convert.ToDecimal(reader["TotalAmount"])
                    .ToString("C");
            }

            conn.Close();
        }

        // ⭐ Lấy danh sách sản phẩm trong hóa đơn
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

            using SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvItems.DataSource = dt;

            // style bảng
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.AllowUserToAddRows = false;

            dgvItems.Columns["ProductName"].HeaderText = "Product Name";
            dgvItems.Columns["Quantity"].HeaderText = "Quantity";
            dgvItems.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgvItems.Columns["SubTotal"].HeaderText = "Total";

            // ⭐ tính subtotal
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }

            lblSubTotal.Text = subtotal.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Đã in hóa đơn thành công!",
        "Thông báo",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );
        }
    }
}