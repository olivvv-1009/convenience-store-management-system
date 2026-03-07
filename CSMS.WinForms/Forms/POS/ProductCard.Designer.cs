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
            NameProduct = new Label();
            Id = new Label();
            price = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            stock = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(NameProduct, 0, 0);
            tableLayoutPanel1.Controls.Add(Id, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(487, 358);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(price, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 217);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(481, 138);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // NameProduct
            // 
            NameProduct.AutoSize = true;
            NameProduct.Dock = DockStyle.Fill;
            NameProduct.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameProduct.Location = new Point(3, 0);
            NameProduct.Name = "NameProduct";
            NameProduct.Size = new Size(481, 107);
            NameProduct.TabIndex = 1;
            NameProduct.Text = "Tên SP";
            NameProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Dock = DockStyle.Fill;
            Id.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id.ForeColor = SystemColors.ControlDarkDark;
            Id.Location = new Point(3, 107);
            Id.Name = "Id";
            Id.Size = new Size(481, 107);
            Id.TabIndex = 2;
            Id.Text = "Mã SP";
            Id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Dock = DockStyle.Fill;
            price.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.ForeColor = SystemColors.Highlight;
            price.Location = new Point(3, 0);
            price.Name = "price";
            price.Size = new Size(234, 138);
            price.TabIndex = 0;
            price.Text = "Price";
            price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(stock, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(243, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(235, 132);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 132);
            label1.TabIndex = 0;
            label1.Text = "Stock:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Dock = DockStyle.Fill;
            stock.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock.ForeColor = SystemColors.ControlDarkDark;
            stock.Location = new Point(120, 0);
            stock.Name = "stock";
            stock.Size = new Size(112, 132);
            stock.TabIndex = 1;
            stock.Text = "Number";
            stock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProductCard";
            Size = new Size(487, 358);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NameProduct;
        private Label price;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label stock;
        private Label Id;
    }
}
