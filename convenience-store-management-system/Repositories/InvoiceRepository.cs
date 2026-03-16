using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;
using CSMS.Database;

namespace convenience_store_management_system.Repositories
{
    public class InvoiceRepository
    {
        DbConnectionHelper db = new DbConnectionHelper();
        private List<Invoice> invoices = new List<Invoice>();

        public void Save(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public List<Invoice> GetAll()
        {
            return invoices;
        }
        public DataTable SearchInvoices(string phone, string customerName, string invoiceId,
                                DateTime? dateFrom, DateTime? dateTo)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
        SELECT i.InvoiceId, m.FullName, m.Phone, i.TotalAmount, i.CreatedAt
        FROM Invoices i
        LEFT JOIN Members m ON i.MemberId = m.MemberId
        WHERE 1=1
        ";

                if (!string.IsNullOrEmpty(phone))
                    query += " AND m.Phone LIKE @phone";

                if (!string.IsNullOrEmpty(customerName))
                    query += " AND m.FullName LIKE @name";

                if (!string.IsNullOrEmpty(invoiceId))
                    query += " AND i.InvoiceId = @invoiceId";

                if (dateFrom != null)
                    query += " AND i.CreatedAt >= @dateFrom";

                if (dateTo != null)
                    query += " AND i.CreatedAt <= @dateTo";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(phone))
                    cmd.Parameters.AddWithValue("@phone", "%" + phone + "%");

                if (!string.IsNullOrEmpty(customerName))
                    cmd.Parameters.AddWithValue("@name", "%" + customerName + "%");

                if (!string.IsNullOrEmpty(invoiceId))
                    cmd.Parameters.AddWithValue("@invoiceId", invoiceId);

                if (dateFrom != null)
                    cmd.Parameters.AddWithValue("@dateFrom", dateFrom);

                if (dateTo != null)
                    cmd.Parameters.AddWithValue("@dateTo", dateTo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }
    }
}
