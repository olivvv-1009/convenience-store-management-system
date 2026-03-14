using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using convenience_store_management_system.Repositories;

namespace CSMS.WinForms.Forms.POS
{
    public partial class InvoiceHistory : UserControl
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSMS_DB;Integrated Security=True";

        public InvoiceHistory()
        {
            InitializeComponent();

            this.Load += InvoiceHistory_Load;

            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
        }

        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            string query = @"SELECT 
                    i.InvoiceId,
                    i.CreatedAt,
                    m.FullName AS CustomerName,
                    m.Phone,
                    i.TotalAmount
                    FROM Invoices i
                    LEFT JOIN Members m ON i.MemberId = m.MemberId
                    ORDER BY i.CreatedAt DESC";

            using SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dgvInvoices.DataSource = dt;

            // đổi tên cột
            dgvInvoices.Columns["InvoiceId"].HeaderText = "Invoice ID";
            dgvInvoices.Columns["CreatedAt"].HeaderText = "Created Date";
            dgvInvoices.Columns["CustomerName"].HeaderText = "Customer Name";
            dgvInvoices.Columns["Phone"].HeaderText = "Phone Number";
            dgvInvoices.Columns["TotalAmount"].HeaderText = "Total Amount";

            // style bảng
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.AllowUserToAddRows = false;

            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvInvoices.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvInvoices.ColumnHeadersHeight = 40;

            lblInvoiceResults.Text = $"Invoice Results ({dt.Rows.Count} found)";
        }

        // double click mở chi tiết hóa đơn
        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int invoiceId = Convert.ToInt32(
                    dgvInvoices.Rows[e.RowIndex].Cells["InvoiceId"].Value);

                InvoiceDetailForm form = new InvoiceDetailForm(invoiceId);
                form.ShowDialog();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            string name = txtName.Text.Trim();
            string invoiceId = txtId.Text.Trim();

            DateTime? from = datefrom.Value;
            DateTime? to = dateto.Value;

            InvoiceRepository repo = new InvoiceRepository();

            dgvInvoices.DataSource =
                repo.SearchInvoices(phone, name, invoiceId, from, to);
        }

        private void resetfilter_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            txtName.Clear();
            txtId.Clear();

            datefrom.Value = DateTime.Today;
            dateto.Value = DateTime.Today;

            LoadInvoices();
        }
    }
}