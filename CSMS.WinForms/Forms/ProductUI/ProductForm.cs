using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using convenience_store_management_system.Models;
using CSMS.Models;
using CSMS.Services;

namespace CSMS.WinForms.Forms.ProductUI
{
    public partial class ProductForm : UserControl
    {
        private List<Product> products = new List<Product>();
        private ProductService service = new ProductService();
        private CategoryService categoryService = new CategoryService();
        private List<Category> categories = new List<Category>();

        public ProductForm()
        {
            InitializeComponent();

            SetupUI();
            LoadCategories();
            BindCategories();
            LoadProducts();
        }

        // ================= UI =================
        private void SetupUI()
        {
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.AutoGenerateColumns = false;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
        }

        // ================= LOAD PRODUCTS =================
        private void LoadProducts()
        {
            products = service.GetAllProducts();

            dgvProducts.Columns.Clear();
            SetupColumns();

            dgvProducts.DataSource = products;
        }

        // ================= SETUP COLUMNS =================
        private void SetupColumns()
        {
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductId",
                HeaderText = "ID",
                DataPropertyName = "ProductId"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Name",
                DataPropertyName = "ProductName"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Category",
                DataPropertyName = "CategoryName"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = { Format = "C2" } // decimal hiển thị đẹp
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Stock",
                DataPropertyName = "Stock"
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dgvProducts.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "✏ Edit",
                UseColumnTextForButtonValue = true
            });

            dgvProducts.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "🗑 Delete",
                UseColumnTextForButtonValue = true
            });
        }

        // ================= CATEGORY =================
        private void LoadCategories()
        {
            categories = categoryService.GetAllCategories();
            categories.Insert(0, new Category(0, "All Categories"));
        }

        private void BindCategories()
        {
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        // ================= SEARCH =================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            dgvProducts.DataSource = products
                .Where(p => (p.ProductName ?? "").ToLower().Contains(keyword)
                         || (p.ProductId ?? "").ToLower().Contains(keyword))
                .ToList();
        }

        // ================= FILTER =================
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Category)cbCategory.SelectedItem;

            if (selected.Id == 0)
                dgvProducts.DataSource = products;
            else
                dgvProducts.DataSource = products
                    .Where(p => (p.CategoryName ?? "").ToLower() == selected.Name.ToLower())
                    .ToList();
        }

        // ================= ACTION (EDIT / DELETE) =================
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var p = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

            // EDIT
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Edit")
            {
                ProductEditForm form = new ProductEditForm(p.ProductId);
                form.ShowDialog();

                LoadProducts();
            }

            // DELETE
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show(
                    "Delete this product?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    service.DeleteProduct(p.ProductId);
                    LoadProducts();
                }
            }
        }

        // ================= ADD =================
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductEditForm form = new ProductEditForm();
            form.ShowDialog();

            LoadProducts();
        }
    }
}