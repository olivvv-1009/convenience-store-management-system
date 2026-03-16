using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.Services;

namespace CSMS.WinForms.Forms.Inventory
{
    public partial class ExpiredProducts : UserControl
    {
        public ExpiredProducts()
        {
            InitializeComponent();
            this.Load += ExpiredProducts_Load;
        }

        InventoryService inventoryService = new InventoryService();

        private void ExpiredProducts_Load(object sender, EventArgs e)
        {
            LoadExpiredProducts();
        }

        private void LoadExpiredProducts()
        {
            var list = inventoryService.GetExpiredProducts();
            dgvExpiredProducts.DataSource = list;

            dgvExpiredProducts.Columns["BatchNumber"].HeaderText = "Batch";
            dgvExpiredProducts.Columns["ProductCode"].HeaderText = "Product Code";
            dgvExpiredProducts.Columns["ProductName"].HeaderText = "Product Name";
            dgvExpiredProducts.Columns["Category"].HeaderText = "Category";
            dgvExpiredProducts.Columns["Stock"].HeaderText = "Stock";
            dgvExpiredProducts.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            dgvExpiredProducts.Columns["DaysOverdue"].HeaderText = "Days Overdue";
            dgvExpiredProducts.Columns["Status"].HeaderText = "Status";

            dgvExpiredProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvExpiredProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvExpiredProducts.Columns[e.ColumnIndex].Name == "DaysOverdue")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            if (dgvExpiredProducts.Columns[e.ColumnIndex].Name == "Status")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }
    }
}
