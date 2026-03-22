using convenience_store_management_system.Models;
using convenience_store_management_system.Services;
using CSMS.Models;
using CSMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CSMS.WinForms.Controls
{
    public partial class ProductItemControl : UserControl
    {
        Product product;
        ProductService service = new ProductService();
        public ProductItemControl(Product p)
        {
            InitializeComponent();
            product = p;
            CategoryService categoryService = new CategoryService();
            List<Category> categories = categoryService.GetAllCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            this.Dock = DockStyle.Fill;
            LoadProduct();
        }
        public event Action? OnClose;
        private void LoadProduct()
        {
            txtCode.Text = product.ProductId;
            txtName.Text = product.ProductName;
            cbCategory.Text = product.CategoryName;
            txtPrice.Text = product.Price.ToString();

            numStock.Value = Math.Min(
        Math.Max(product.Stock, numStock.Minimum),
        numStock.Maximum
    );

            DateTime expiry = product.ExpiryDate;

            if (expiry < dtExpiry.MinDate || expiry > dtExpiry.MaxDate)
            {
                dtExpiry.Value = DateTime.Now;
            }
            else
            {
                dtExpiry.Value = expiry;
            }
        }
        private void ProductItemControl_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke(); // quay lại màn hình product
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product.ProductId = txtCode.Text;
            product.ProductName = txtName.Text;
            product.CategoryName = cbCategory.Text;
            product.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);

            product.Price = Convert.ToDecimal(txtPrice.Text); 

            product.Stock = Convert.ToInt32(numStock.Value);
            product.ExpiryDate = dtExpiry.Value;

            if (service.Exists(product.ProductId))
            {
                service.UpdateProduct(product);
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                service.AddProduct(product);
                MessageBox.Show("Product added successfully!");
            }

            OnClose?.Invoke();
        }
    }
}
