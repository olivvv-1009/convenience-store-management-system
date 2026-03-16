namespace CSMS.WinForms.Forms.Inventory
{
    partial class ImportGood
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
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numQuantity = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            txtBatchNumber = new TextBox();
            txtUnitCost = new TextBox();
            dtpExpiryDate = new DateTimePicker();
            cmbProduct = new ComboBox();
            cmbSupplier = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(714, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(708, 59);
            label1.TabIndex = 0;
            label1.Text = "Import New Stock";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(708, 41);
            label2.TabIndex = 1;
            label2.Text = "Add new inventory to your store";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 333);
            button1.Name = "button1";
            button1.Padding = new Padding(3);
            button1.Size = new Size(128, 44);
            button1.TabIndex = 2;
            button1.Text = "Import Good";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnImportGoods_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 1, 2);
            tableLayoutPanel2.Controls.Add(numQuantity, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(label8, 1, 4);
            tableLayoutPanel2.Controls.Add(txtBatchNumber, 1, 5);
            tableLayoutPanel2.Controls.Add(txtUnitCost, 0, 5);
            tableLayoutPanel2.Controls.Add(dtpExpiryDate, 0, 3);
            tableLayoutPanel2.Controls.Add(cmbProduct, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbSupplier, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3934422F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.4918041F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8852463F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1428566F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4285717F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2857151F));
            tableLayoutPanel2.Size = new Size(708, 224);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(348, 36);
            label3.TabIndex = 0;
            label3.Text = "Product";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(357, 0);
            label4.Name = "label4";
            label4.Size = new Size(348, 36);
            label4.TabIndex = 1;
            label4.Text = "Quantity";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(348, 26);
            label5.TabIndex = 2;
            label5.Text = "Expiry Date";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(357, 82);
            label6.Name = "label6";
            label6.Size = new Size(348, 26);
            label6.TabIndex = 3;
            label6.Text = "Supplier";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numQuantity
            // 
            numQuantity.Dock = DockStyle.Fill;
            numQuantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(357, 39);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(348, 30);
            numQuantity.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 155);
            label7.Name = "label7";
            label7.Size = new Size(348, 25);
            label7.TabIndex = 4;
            label7.Text = "Unit Cost";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(357, 155);
            label8.Name = "label8";
            label8.Size = new Size(348, 25);
            label8.TabIndex = 5;
            label8.Text = "Batch Number";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.Dock = DockStyle.Fill;
            txtBatchNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBatchNumber.Location = new Point(357, 183);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.Size = new Size(348, 30);
            txtBatchNumber.TabIndex = 9;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Dock = DockStyle.Fill;
            txtUnitCost.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitCost.Location = new Point(3, 183);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(348, 30);
            txtUnitCost.TabIndex = 10;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExpiryDate.Dock = DockStyle.Fill;
            dtpExpiryDate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExpiryDate.Location = new Point(3, 111);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(348, 30);
            dtpExpiryDate.TabIndex = 11;
            // 
            // cmbProduct
            // 
            cmbProduct.Dock = DockStyle.Fill;
            cmbProduct.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(3, 39);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(348, 30);
            cmbProduct.TabIndex = 12;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Dock = DockStyle.Fill;
            cmbSupplier.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(357, 111);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(348, 30);
            cmbSupplier.TabIndex = 13;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // ImportGood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "ImportGood";
            Size = new Size(714, 427);
            Load += ImportGood_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUnitCost;
        private DateTimePicker dtpExpiryDate;
        private ComboBox cmbProduct;
        private NumericUpDown numQuantity;
        private ComboBox cmbSupplier;
        private TextBox txtBatchNumber;
    }
}
