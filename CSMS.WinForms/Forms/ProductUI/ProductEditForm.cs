using System;
using System.Windows.Forms;
using convenience_store_management_system.Models;
using CSMS.Models;
using CSMS.Services;

namespace CSMS.WinForms.Forms.ProductUI
{
    public partial class ProductEditForm : Form
    {
        private bool isEditMode;
        private string productId;
        private Product product;

        private ProductService service = new ProductService();
        private CategoryService categoryService = new CategoryService();

        // ================= ADD =================
        public ProductEditForm()
        {
            InitializeComponent();
            isEditMode = false;

            product = new Product();

            LoadCategories();
            SetupUI();
        }

        // ================= EDIT =================
        public ProductEditForm(string id)
        {
            InitializeComponent();
            isEditMode = true;

            productId = id;

            LoadCategories();
            LoadProduct();
            SetupUI();
        }

        // ================= UI =================
        private void SetupUI()
        {
            if (isEditMode)
            {
                this.Text = "Edit Product";
                btnUpdate.Text = "Update Product";

                txtId.Enabled = false; // không cho sửa ID
            }
            else
            {
                this.Text = "Add New Product";
                btnUpdate.Text = "Add Product";

                txtId.Enabled = true;
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtStock.Text = "0";
                dtpExpiry.Value = DateTime.Now;
            }
        }

        // ================= LOAD PRODUCT =================
        private void LoadProduct()
        {
            product = service.GetProductById(productId);

            if (product == null)
            {
                MessageBox.Show("Product not found!");
                this.Close();
                return;
            }

            txtId.Text = product.ProductId;
            txtName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString("0.##");
            txtStock.Text = product.Stock.ToString();
            dtpExpiry.Value = product.ExpiryDate;

            cbCategory.SelectedValue = product.CategoryId;
        }

        // ================= LOAD CATEGORY =================
        private void LoadCategories()
        {
            cbCategory.DataSource = categoryService.GetAllCategories();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }

        // ================= SAVE (ADD / EDIT) =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Product Code is required!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required!");
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Invalid stock!");
                    return;
                }

                product.ProductId = txtId.Text.Trim();
                product.ProductName = txtName.Text.Trim();
                product.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                product.Price = price;
                product.Stock = stock;
                product.ExpiryDate = dtpExpiry.Value;

                if (isEditMode)
                {
                    service.UpdateProduct(product);
                    MessageBox.Show("Updated successfully!");
                }
                else
                {
                    service.AddProduct(product);
                    MessageBox.Show("Added successfully!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}