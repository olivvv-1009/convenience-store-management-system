namespace CSMS.WinForms.Forms.POS
{
    partial class InvoiceHistory
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
            pnlResults = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblInvoiceResults = new Label();
            export = new Button();
            dgvInvoices = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            resetfilter = new Button();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            datefrom = new DateTimePicker();
            dateto = new DateTimePicker();
            search = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnlResults.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlResults, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.981502F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.98678732F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.95073F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.080986F));
            tableLayoutPanel1.Size = new Size(896, 468);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(890, 32);
            label1.TabIndex = 0;
            label1.Text = "Invoice History";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(890, 23);
            label2.TabIndex = 1;
            label2.Text = "Search and view all invoice records";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlResults
            // 
            pnlResults.BackColor = SystemColors.ControlLightLight;
            pnlResults.BorderStyle = BorderStyle.FixedSingle;
            pnlResults.Controls.Add(tableLayoutPanel5);
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Location = new Point(3, 235);
            pnlResults.Name = "pnlResults";
            pnlResults.Padding = new Padding(15);
            pnlResults.Size = new Size(890, 230);
            pnlResults.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(dgvInvoices, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(15, 15);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.Size = new Size(858, 198);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Controls.Add(lblInvoiceResults, 0, 0);
            tableLayoutPanel6.Controls.Add(export, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel6.Size = new Size(852, 33);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // lblInvoiceResults
            // 
            lblInvoiceResults.AutoSize = true;
            lblInvoiceResults.Dock = DockStyle.Fill;
            lblInvoiceResults.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceResults.Location = new Point(3, 0);
            lblInvoiceResults.Name = "lblInvoiceResults";
            lblInvoiceResults.Size = new Size(675, 33);
            lblInvoiceResults.TabIndex = 0;
            lblInvoiceResults.Text = "Invoice Results (0 found)";
            lblInvoiceResults.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // export
            // 
            export.BackColor = SystemColors.Highlight;
            export.Dock = DockStyle.Fill;
            export.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            export.ForeColor = SystemColors.ButtonFace;
            export.Location = new Point(684, 3);
            export.Name = "export";
            export.Size = new Size(165, 27);
            export.TabIndex = 1;
            export.Text = "Export Result";
            export.UseVisualStyleBackColor = false;
            // 
            // dgvInvoices
            // 
            dgvInvoices.BackgroundColor = SystemColors.ControlLightLight;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.Location = new Point(3, 42);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(852, 153);
            dgvInvoices.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 58);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(890, 171);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8226948F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.17731F));
            tableLayoutPanel2.Size = new Size(860, 141);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(resetfilter, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(854, 29);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // resetfilter
            // 
            resetfilter.Dock = DockStyle.Fill;
            resetfilter.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetfilter.Location = new Point(728, 3);
            resetfilter.Name = "resetfilter";
            resetfilter.Size = new Size(123, 23);
            resetfilter.TabIndex = 0;
            resetfilter.Text = "Reset Filter";
            resetfilter.UseVisualStyleBackColor = true;
            resetfilter.Click += resetfilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(719, 29);
            label3.TabIndex = 1;
            label3.Text = "Search and Filter";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 1, 0);
            tableLayoutPanel4.Controls.Add(label6, 2, 0);
            tableLayoutPanel4.Controls.Add(label8, 0, 2);
            tableLayoutPanel4.Controls.Add(label9, 1, 2);
            tableLayoutPanel4.Controls.Add(txtPhone, 0, 1);
            tableLayoutPanel4.Controls.Add(txtName, 1, 1);
            tableLayoutPanel4.Controls.Add(txtId, 2, 1);
            tableLayoutPanel4.Controls.Add(datefrom, 0, 3);
            tableLayoutPanel4.Controls.Add(dateto, 1, 3);
            tableLayoutPanel4.Controls.Add(search, 3, 3);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 38);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel4.Size = new Size(854, 100);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 0;
            label4.Text = "Phone Number";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(216, 0);
            label5.Name = "label5";
            label5.Size = new Size(207, 21);
            label5.TabIndex = 1;
            label5.Text = "Customer Name";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(429, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 21);
            label6.TabIndex = 2;
            label6.Text = "Invoice ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 48);
            label8.Name = "label8";
            label8.Size = new Size(207, 21);
            label8.TabIndex = 4;
            label8.Text = "Date From";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(216, 48);
            label9.Name = "label9";
            label9.Size = new Size(207, 21);
            label9.TabIndex = 5;
            label9.Text = "Date To";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(3, 24);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(216, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(429, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 27);
            txtId.TabIndex = 9;
            // 
            // datefrom
            // 
            datefrom.CalendarFont = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datefrom.CustomFormat = "MM/dd/yyyy";
            datefrom.Dock = DockStyle.Fill;
            datefrom.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datefrom.Format = DateTimePickerFormat.Custom;
            datefrom.Location = new Point(3, 72);
            datefrom.Name = "datefrom";
            datefrom.Size = new Size(207, 28);
            datefrom.TabIndex = 10;
            // 
            // dateto
            // 
            dateto.CalendarFont = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateto.CustomFormat = "MM/dd/yyyy";
            dateto.Dock = DockStyle.Fill;
            dateto.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateto.Format = DateTimePickerFormat.Custom;
            dateto.Location = new Point(216, 72);
            dateto.Name = "dateto";
            dateto.Size = new Size(207, 28);
            dateto.TabIndex = 11;
            // 
            // search
            // 
            search.Dock = DockStyle.Fill;
            search.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(642, 72);
            search.Name = "search";
            search.Size = new Size(209, 25);
            search.TabIndex = 13;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // InvoiceHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InvoiceHistory";
            Size = new Size(896, 468);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlResults.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel pnlResults;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button resetfilter;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtId;
        private DateTimePicker datefrom;
        private DateTimePicker dateto;
        private Button search;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblInvoiceResults;
        private Button export;
        private DataGridView dgvInvoices;
    }
}
