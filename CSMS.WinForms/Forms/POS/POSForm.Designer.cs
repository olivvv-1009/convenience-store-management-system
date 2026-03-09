namespace CSMS.WinForms.Forms.POS
{
    partial class POSForm
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
            CreateInvoice = new Button();
            InvoiceHistory = new Button();
            pnlContent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pnlContent, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.881423F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.079051F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.869565F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.16996F));
            tableLayoutPanel1.Size = new Size(958, 506);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(952, 50);
            label1.TabIndex = 0;
            label1.Text = "Point of Sale";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(952, 51);
            label2.TabIndex = 1;
            label2.Text = "Process customer transactions and view history";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CreateInvoice, 0, 0);
            tableLayoutPanel2.Controls.Add(InvoiceHistory, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 104);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(952, 49);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // CreateInvoice
            // 
            CreateInvoice.Dock = DockStyle.Fill;
            CreateInvoice.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateInvoice.Location = new Point(3, 3);
            CreateInvoice.Name = "CreateInvoice";
            CreateInvoice.Size = new Size(470, 43);
            CreateInvoice.TabIndex = 0;
            CreateInvoice.Text = "Create Invoice";
            CreateInvoice.UseVisualStyleBackColor = true;
            CreateInvoice.Click += CreateInvoice_Click;
            // 
            // InvoiceHistory
            // 
            InvoiceHistory.Dock = DockStyle.Fill;
            InvoiceHistory.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceHistory.Location = new Point(479, 3);
            InvoiceHistory.Name = "InvoiceHistory";
            InvoiceHistory.Size = new Size(470, 43);
            InvoiceHistory.TabIndex = 1;
            InvoiceHistory.Text = "Invoice History";
            InvoiceHistory.UseVisualStyleBackColor = true;
            InvoiceHistory.Click += InvoiceHistory_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(3, 159);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(952, 344);
            pnlContent.TabIndex = 3;
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tableLayoutPanel1);
            Name = "POSForm";
            Size = new Size(958, 506);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CreateInvoice;
        private Button InvoiceHistory;
        private Panel pnlContent;
    }
}
