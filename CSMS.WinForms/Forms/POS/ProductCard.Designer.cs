namespace CSMS.WinForms.Forms.POS
{
    partial class ProductCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            price = new Label();
            stock = new Label();
            NameProduct = new Label();
            Id = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(NameProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(Id, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(461, 332);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.98901F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.01099F));
            tableLayoutPanel2.Controls.Add(price, 0, 0);
            tableLayoutPanel2.Controls.Add(stock, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 201);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(455, 128);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Dock = DockStyle.Fill;
            price.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.ForeColor = SystemColors.Highlight;
            price.Location = new Point(3, 0);
            price.Name = "price";
            price.Size = new Size(226, 128);
            price.TabIndex = 0;
            price.Text = "Price";
            price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Dock = DockStyle.Fill;
            stock.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock.Location = new Point(235, 0);
            stock.Name = "stock";
            stock.Size = new Size(217, 128);
            stock.TabIndex = 1;
            stock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameProduct
            // 
            NameProduct.AutoSize = true;
            NameProduct.Dock = DockStyle.Fill;
            NameProduct.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameProduct.Location = new Point(3, 0);
            NameProduct.Name = "NameProduct";
            NameProduct.Size = new Size(455, 99);
            NameProduct.TabIndex = 1;
            NameProduct.Text = "Tên SP";
            NameProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Dock = DockStyle.Fill;
            Id.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id.ForeColor = SystemColors.ControlDarkDark;
            Id.Location = new Point(3, 99);
            Id.Name = "Id";
            Id.Size = new Size(455, 99);
            Id.TabIndex = 2;
            Id.Text = "Mã SP";
            Id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(487, 358);
            panel1.TabIndex = 1;
            panel1.Click += Card_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductCard";
            Size = new Size(487, 358);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NameProduct;
        private Label price;
        private Label Id;
        private Panel panel1;
        private Label stock;
    }
}
