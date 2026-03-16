namespace CSMS.WinForms.Controls
{
    partial class ProductItemControl
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
            pnlCard = new Panel();
            btnUpdate = new Button();
            btnCancel = new Button();
            dtExpiry = new DateTimePicker();
            numStock = new NumericUpDown();
            cbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            lblExpiry = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            label3 = new Label();
            lblName = new Label();
            lblCode = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = SystemColors.ControlLightLight;
            pnlCard.Controls.Add(btnUpdate);
            pnlCard.Controls.Add(btnCancel);
            pnlCard.Controls.Add(dtExpiry);
            pnlCard.Controls.Add(numStock);
            pnlCard.Controls.Add(cbCategory);
            pnlCard.Controls.Add(txtPrice);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(txtCode);
            pnlCard.Controls.Add(lblExpiry);
            pnlCard.Controls.Add(lblStock);
            pnlCard.Controls.Add(lblPrice);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(lblName);
            pnlCard.Controls.Add(lblCode);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(label2);
            pnlCard.Location = new Point(49, 42);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(807, 453);
            pnlCard.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(543, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 41);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(355, 381);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 41);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtExpiry
            // 
            dtExpiry.Location = new Point(420, 326);
            dtExpiry.Name = "dtExpiry";
            dtExpiry.Size = new Size(290, 27);
            dtExpiry.TabIndex = 13;
            // 
            // numStock
            // 
            numStock.Location = new Point(19, 317);
            numStock.Name = "numStock";
            numStock.Size = new Size(258, 27);
            numStock.TabIndex = 12;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(19, 219);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(258, 28);
            cbCategory.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(420, 219);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(290, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(420, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 27);
            txtName.TabIndex = 9;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(17, 131);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(260, 27);
            txtCode.TabIndex = 8;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiry.Location = new Point(420, 286);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(123, 28);
            lblExpiry.TabIndex = 7;
            lblExpiry.Text = "Expiry Date";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(17, 286);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(153, 28);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(420, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 28);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price (vnd)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 188);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(420, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Product Name";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.Location = new Point(17, 100);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(139, 28);
            lblCode.TabIndex = 2;
            lblCode.Text = "Product Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 55);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 1;
            label1.Text = "Update product information";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(179, 38);
            label2.TabIndex = 0;
            label2.Text = "Edit Product";
            // 
            // ProductItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCard);
            Name = "ProductItemControl";
            Size = new Size(922, 556);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label label2;
        private Label label1;
        private Label lblCode;
        private Label lblStock;
        private Label lblPrice;
        private Label label3;
        private Label lblName;
        private DateTimePicker dtExpiry;
        private NumericUpDown numStock;
        private ComboBox cbCategory;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtCode;
        private Label lblExpiry;
        private Button btnUpdate;
        private Button btnCancel;
    }
}
