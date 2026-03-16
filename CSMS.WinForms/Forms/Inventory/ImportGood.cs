using System;
using System.Windows.Forms;
using convenience_store_management_system.Services;
using CSMS.Models;
using CSMS.Services;

namespace CSMS.WinForms.Forms.Inventory
{
    public partial class ImportGood : UserControl
    {
        private InventoryService inventoryService = new InventoryService();

        public ImportGood()
        {
            InitializeComponent();
        }

        private void ImportGood_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSuppliers();
            GenerateBatchNumber();
        }

        private void LoadProducts()
        {
            ProductService productService = new ProductService();

            cmbProduct.DataSource = productService.GetAllProducts();
            cmbProduct.DisplayMember = "DisplayName";
            cmbProduct.ValueMember = "ProductId";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null || cmbSupplier.SelectedValue == null)
                return;

            string productId = cmbProduct.SelectedValue.ToString();
            string supplier = cmbSupplier.Text;

            decimal? cost = inventoryService.GetLastUnitCost(productId, supplier);

            if (cost != null)
                txtUnitCost.Text = cost.ToString();

            GenerateBatchNumber();
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedValue == null)
                {
                    MessageBox.Show("Please select product");
                    return;
                }

                string batchNumber = txtBatchNumber.Text;

                InventoryItem inventory = new InventoryItem
                {
                    ProductId = cmbProduct.SelectedValue.ToString(),
                    Quantity = (int)numQuantity.Value,
                    ExpiryDate = dtpExpiryDate.Value,
                    Supplier = cmbSupplier.Text,
                    UnitCost = Convert.ToDecimal(txtUnitCost.Text),
                    BatchNumber = batchNumber
                };

                inventoryService.ImportStock(inventory);

                MessageBox.Show("Import goods successfully!");

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null || cmbSupplier.SelectedValue == null)
                return;

            string productId = cmbProduct.SelectedValue.ToString();
            string supplier = cmbSupplier.Text;

            decimal? cost = inventoryService.GetLastUnitCost(productId, supplier);

            if (cost != null)
                txtUnitCost.Text = cost.ToString();
        }

        private void ClearForm()
        {
            numQuantity.Value = 1;
            txtUnitCost.Clear();
            txtBatchNumber.Clear();
        }
        private void GenerateBatchNumber()
        {
            if (cmbProduct.SelectedValue == null)
                return;

            string productId = cmbProduct.SelectedValue.ToString();

            string batchNumber = "BATCH-" +
                                 productId + "-" +
                                 dtpExpiryDate.Value.ToString("yyyyMMdd");

            txtBatchNumber.Text = batchNumber;
        }
        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            GenerateBatchNumber();
        }
        private void LoadSuppliers()
        {
            SupplierService supplierService = new SupplierService();

            cmbSupplier.DataSource = supplierService.GetAllSuppliers();
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
        }
    }
}