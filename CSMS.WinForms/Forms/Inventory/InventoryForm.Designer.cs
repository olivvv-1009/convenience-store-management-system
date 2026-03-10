namespace CSMS.WinForms.Forms.Inventory
{
    partial class InventoryForm
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
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ImportGood = new Button();
            StockList = new Button();
            ExpiredProducts = new Button();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.4682865F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4270906F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.6082954F));
            tableLayoutPanel1.Size = new Size(939, 434);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(933, 75);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(933, 66);
            label2.TabIndex = 1;
            label2.Text = "Track and manage your inventory levels";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.1286163F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.8713837F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 144);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(933, 49);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 43);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.159668F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.92017F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.92017F));
            tableLayoutPanel3.Controls.Add(ImportGood, 0, 0);
            tableLayoutPanel3.Controls.Add(StockList, 1, 0);
            tableLayoutPanel3.Controls.Add(ExpiredProducts, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(555, 43);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // ImportGood
            // 
            ImportGood.Dock = DockStyle.Fill;
            ImportGood.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImportGood.Location = new Point(3, 3);
            ImportGood.Name = "ImportGood";
            ImportGood.Size = new Size(194, 37);
            ImportGood.TabIndex = 0;
            ImportGood.Text = "Import Goods";
            ImportGood.TextAlign = ContentAlignment.MiddleLeft;
            ImportGood.UseVisualStyleBackColor = true;
            // 
            // StockList
            // 
            StockList.Dock = DockStyle.Fill;
            StockList.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockList.Location = new Point(203, 3);
            StockList.Name = "StockList";
            StockList.Size = new Size(171, 37);
            StockList.TabIndex = 1;
            StockList.Text = "Stock List";
            StockList.TextAlign = ContentAlignment.MiddleLeft;
            StockList.UseVisualStyleBackColor = true;
            // 
            // ExpiredProducts
            // 
            ExpiredProducts.Dock = DockStyle.Fill;
            ExpiredProducts.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpiredProducts.Location = new Point(380, 3);
            ExpiredProducts.Name = "ExpiredProducts";
            ExpiredProducts.Size = new Size(172, 37);
            ExpiredProducts.TabIndex = 2;
            ExpiredProducts.Text = "Expired Products";
            ExpiredProducts.TextAlign = ContentAlignment.MiddleLeft;
            ExpiredProducts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 232);
            panel2.TabIndex = 3;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "Inventory";
            Size = new Size(939, 434);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ImportGood;
        private Button StockList;
        private Button ExpiredProducts;
        private Panel panel2;
    }
}
