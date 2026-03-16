namespace CSMS.WinForms.Forms.POS
{
    partial class InvoiceDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvItems = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lblNameInvoice = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            lblInvoiceIdValue = new Label();
            lblInvoiceId = new Label();
            panel3 = new Panel();
            lblDateTimeValue = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblCustomerName = new Label();
            label3 = new Label();
            panel5 = new Panel();
            lblPhoneNumber = new Label();
            label4 = new Label();
            panel6 = new Panel();
            lblPaymentMethod = new Label();
            label5 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label8 = new Label();
            lblTotal = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            lblSubTotal = new Label();
            btPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(3, 233);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(700, 94);
            dgvItems.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvItems, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNameInvoice, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 5);
            tableLayoutPanel1.Controls.Add(btPrint, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(706, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 35);
            label1.TabIndex = 1;
            label1.Text = "Invoice Details";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameInvoice
            // 
            lblNameInvoice.AutoSize = true;
            lblNameInvoice.Dock = DockStyle.Fill;
            lblNameInvoice.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameInvoice.Location = new Point(3, 35);
            lblNameInvoice.Name = "lblNameInvoice";
            lblNameInvoice.Size = new Size(700, 25);
            lblNameInvoice.TabIndex = 2;
            lblNameInvoice.Text = "t";
            lblNameInvoice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 63);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(700, 144);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 1, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 2);
            tableLayoutPanel2.Controls.Add(panel7, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(670, 125);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblInvoiceIdValue);
            panel2.Controls.Add(lblInvoiceId);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 35);
            panel2.TabIndex = 0;
            // 
            // lblInvoiceIdValue
            // 
            lblInvoiceIdValue.AutoSize = true;
            lblInvoiceIdValue.Dock = DockStyle.Bottom;
            lblInvoiceIdValue.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceIdValue.Location = new Point(0, 18);
            lblInvoiceIdValue.Name = "lblInvoiceIdValue";
            lblInvoiceIdValue.Size = new Size(42, 17);
            lblInvoiceIdValue.TabIndex = 1;
            lblInvoiceIdValue.Text = "label3";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Dock = DockStyle.Top;
            lblInvoiceId.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceId.Location = new Point(0, 0);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(71, 17);
            lblInvoiceId.TabIndex = 0;
            lblInvoiceId.Text = "Invoice ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDateTimeValue);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(338, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 35);
            panel3.TabIndex = 1;
            // 
            // lblDateTimeValue
            // 
            lblDateTimeValue.AutoSize = true;
            lblDateTimeValue.Dock = DockStyle.Bottom;
            lblDateTimeValue.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTimeValue.Location = new Point(0, 18);
            lblDateTimeValue.Name = "lblDateTimeValue";
            lblDateTimeValue.Size = new Size(42, 17);
            lblDateTimeValue.TabIndex = 1;
            lblDateTimeValue.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 0;
            label2.Text = "Date & Time";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCustomerName);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 35);
            panel4.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Dock = DockStyle.Bottom;
            lblCustomerName.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(0, 18);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(42, 17);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 0;
            label3.Text = "Customer Name";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblPhoneNumber);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(338, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 35);
            panel5.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Dock = DockStyle.Bottom;
            lblPhoneNumber.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(0, 18);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(42, 17);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 0;
            label4.Text = "Phone Number";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblPaymentMethod);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 37);
            panel6.TabIndex = 4;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Dock = DockStyle.Bottom;
            lblPaymentMethod.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(0, 20);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(42, 17);
            lblPaymentMethod.TabIndex = 1;
            lblPaymentMethod.Text = "label9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 0;
            label5.Text = "Payment Method";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(338, 85);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 37);
            panel7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 210);
            label6.Name = "label6";
            label6.Size = new Size(700, 20);
            label6.TabIndex = 4;
            label6.Text = "Items";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label8, 0, 0);
            tableLayoutPanel3.Controls.Add(lblTotal, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 373);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(700, 34);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(344, 34);
            label8.TabIndex = 0;
            label8.Text = "Total";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(353, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(344, 34);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "label10";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(lblSubTotal, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 333);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(700, 34);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(344, 34);
            label7.TabIndex = 0;
            label7.Text = "SubTotal";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Dock = DockStyle.Fill;
            lblSubTotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(353, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(344, 34);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "label9";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btPrint
            // 
            btPrint.Dock = DockStyle.Right;
            btPrint.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPrint.Location = new Point(609, 413);
            btPrint.Name = "btPrint";
            btPrint.Size = new Size(94, 44);
            btPrint.TabIndex = 8;
            btPrint.Text = "Print";
            btPrint.UseVisualStyleBackColor = true;
            btPrint.Click += btPrint_Click;
            // 
            // InvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "InvoiceDetailForm";
            Text = "Invoice Details";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblNameInvoice;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Label lblInvoiceIdValue;
        private Label lblInvoiceId;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblDateTimeValue;
        private Label lblCustomerName;
        private Label label3;
        private Label lblPhoneNumber;
        private Label label4;
        private Label label5;
        private Label lblPaymentMethod;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label8;
        private Label lblTotal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Label lblSubTotal;
        private Button btPrint;
    }
}
