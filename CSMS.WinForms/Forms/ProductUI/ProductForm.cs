using convenience_store_management_system.Models;
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
            List<Product> products = new List<Product>();

            public ProductForm()
            {
                InitializeComponent();

                LoadProducts();
                LoadCategories();
                BindCategories();
            //ShowProducts();
        }

        ProductService service = new ProductService();

        private void LoadProducts()
        {
            List<Product> products = service.GetAllProducts();

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
        private void LoadCategories()
        {
            categories.Add(new Category(0, "All Categories"));
            categories.Add(new Category(1, "Beverages"));
            categories.Add(new Category(2, "Snacks"));
            categories.Add(new Category(3, "Frozen"));
            categories.Add(new Category(4, "Dairy"));
            categories.Add(new Category(5, "Bakery"));
        }
        private void BindCategories()
        {
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selected = (Category)cbCategory.SelectedItem;

            MessageBox.Show("Category: " + selected.Name);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
