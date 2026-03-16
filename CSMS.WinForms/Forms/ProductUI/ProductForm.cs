using convenience_store_management_system.Models;
using convenience_store_management_system.Services;
using CSMS.Models;
using CSMS.Services;
using CSMS.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS.WinForms.Forms.ProductUI
{
    public partial class ProductForm : UserControl
    {
        string connectionString =
            "Server=LAPTOP-7A534JGV\\SQLEXPRESS;Database=CSMS_DB;Trusted_Connection=True;TrustServerCertificate=True";
        List<Product> products = new List<Product>();

        public ProductForm()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            LoadProducts();
            LoadCategories();
            BindCategories();
            //ShowProducts();
            dgvProducts.Visible = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        ProductService service = new ProductService();

        private void LoadProducts()
        {
            products = service.GetAllProducts();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        /*private void ShowProducts()
            {
                flowProducts.Controls.Clear();

                foreach (var p in products)
                {
                    ProductItemControl item = new ProductItemControl(p);
                    flowProducts.Controls.Add(item);
                }
            }*/
        List<Category> categories = new List<Category>();
        CategoryService categoryService = new CategoryService();
        private void LoadCategories()
        {
            categories = categoryService.GetAllCategories();

            categories.Insert(0, new Category(0, "All Categories"));
        }
        private void BindCategories()
        {
            cbCategory.DataSource = null;
            cbCategory.DataSource = categories;

            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selected = (Category)cbCategory.SelectedItem;

            if (selected != null)
            {
                MessageBox.Show("Category: " + selected.Name);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var filtered = products
                .Where(p => p.ProductName.ToLower().Contains(keyword))
                .ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filtered;
        }
        private void ShowProducts()
        {
            flowProducts.Controls.Clear();

            foreach (var p in products)
            {
                ProductItemControl item = new ProductItemControl(p);
                flowProducts.Controls.Add(item);
            }
        }
        private void ReturnToProductScreen()
        {
            LoadProducts();
            dgvProducts.Visible = true;// ẩn card

            flowProducts.Controls.Clear();
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Edit")
            {
                Product p = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

                ProductItemControl card = new ProductItemControl(p);

                card.OnClose += ReturnToProductScreen;

                dgvProducts.Visible = false;

                flowProducts.Controls.Clear();
                flowProducts.Controls.Add(card);
            }
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Delete")
            {
                Product p = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show(
                    "Delete this product?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    service.DeleteProduct(p.ProductId);

                    LoadProducts();
                }
            }
        }

        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Category selected = (Category)cbCategory.SelectedItem;

            if (selected.Id == 0)
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;
            }
            else
            {
                var filtered = products
                    .Where(p => p.Category.Trim().ToLower() == selected.Name.Trim().ToLower())
                    .ToList();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = filtered;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            ProductItemControl card = new ProductItemControl(newProduct);
            card.OnClose += ReturnToProductScreen;
            dgvProducts.Visible = false;
            flowProducts.Controls.Clear();
            flowProducts.Controls.Add(card);
        }
    }
}  
