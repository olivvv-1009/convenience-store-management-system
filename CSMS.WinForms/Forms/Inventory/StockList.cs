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
    public partial class StockList : UserControl
    {
        InventoryService inventoryService = new InventoryService();
        public StockList()
        {
            InitializeComponent();
            this.Load += StockList_Load;
        }
        private void LoadStockList()
        {
            var list = inventoryService.GetStockList();

            dgvStock.DataSource = list;

            // style bảng
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.RowHeadersVisible = false;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.ReadOnly = true;

            // font
            dgvStock.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStock.RowTemplate.Height = 35;

            // header style
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // border
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // đổi tên header
            dgvStock.Columns["ProductCode"].HeaderText = "Product Code";
            dgvStock.Columns["ProductName"].HeaderText = "Product Name";
            dgvStock.Columns["Category"].HeaderText = "Category";
            dgvStock.Columns["CurrentStock"].HeaderText = "Current Stock";
            dgvStock.Columns["MinStock"].HeaderText = "Min Stock";
            dgvStock.Columns["Status"].HeaderText = "Status";

            // căn giữa số
            dgvStock.Columns["CurrentStock"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvStock.Columns["MinStock"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // đổi màu Low Stock
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "Low Stock")
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }
        private void StockList_Load(object sender, EventArgs e)
        {
            LoadStockList();
            LoadLowStockAlert();
        }
        private void LoadLowStockAlert()
        {
            var lowStock = inventoryService.GetLowStockProducts();

            if (lowStock.Count == 0)
            {
                lblLowStock.Text = "All products have sufficient stock.";
                return;
            }

            string message = lowStock.Count + " products are running low on stock:\n\n";

            foreach (var p in lowStock)
            {
                message += $"{p.ProductName} (Current: {p.CurrentStock} | Min: {p.MinStock})\n";
            }

            lblLowStock.Text = message;
        }
    }
}
