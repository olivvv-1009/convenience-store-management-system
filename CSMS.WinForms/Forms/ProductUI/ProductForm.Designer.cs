namespace CSMS.WinForms.Forms.ProductUI
{
    partial class ProductForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnAddProduct = new Button();
            flowProducts = new Panel();
            dgvProducts = new DataGridView();
            cbCategory = new ComboBox();
            txtSearch = new TextBox();
            lblProduct = new Label();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            flowProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(355, 46);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 82);
            label2.Name = "label2";
            label2.Size = new Size(386, 28);
            label2.TabIndex = 1;
            label2.Text = "Manage your store inventory and products";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.HotTrack;
            btnAddProduct.FlatStyle = FlatStyle.Popup;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddProduct.ForeColor = SystemColors.ButtonHighlight;
            btnAddProduct.Location = new Point(1119, 62);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(197, 48);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "+   Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // flowProducts
            // 
            flowProducts.AutoScroll = true;
            flowProducts.BackColor = SystemColors.ControlLightLight;
            flowProducts.BorderStyle = BorderStyle.FixedSingle;
            flowProducts.Controls.Add(dgvProducts);
            flowProducts.Controls.Add(cbCategory);
            flowProducts.Controls.Add(txtSearch);
            flowProducts.Controls.Add(lblProduct);
            flowProducts.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            flowProducts.Location = new Point(56, 142);
            flowProducts.Name = "flowProducts";
            flowProducts.Size = new Size(1292, 646);
            flowProducts.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.ControlLightLight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Category, Price, Stock, ExpiryDate, Status, Edit, Delete });
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 149);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1290, 495);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(1031, 81);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(195, 31);
            cbCategory.TabIndex = 2;
            cbCategory.Text = "All Categories";
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged_1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Light", 10F);
            txtSearch.Location = new Point(32, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(924, 30);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "🔍 Search by product name or code...";
            txtSearch.TextChanged += textBox1_TextChanged_1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(32, 29);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(77, 23);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Products";
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ProductId";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.HeaderText = "ExpiryDate";
            ExpiryDate.MinimumWidth = 6;
            ExpiryDate.Name = "ExpiryDate";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Edit ✏";
            Edit.HeaderText = "Edit ✏";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Delete 🗑";
            Delete.HeaderText = "Delete 🗑";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ProductForm";
            Size = new Size(1618, 830);
            flowProducts.ResumeLayout(false);
            flowProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAddProduct;
        private Panel flowProducts;
        private Label lblProduct;
        private TextBox txtSearch;
        private ComboBox cbCategory;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
    }
}
