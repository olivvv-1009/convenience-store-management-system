namespace CSMS.WinForms.Forms.Main
{
    partial class MainForm_Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            storePOS = new Label();
            label1 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            DashboardBut = new Button();
            PosBut = new Button();
            ProductBut = new Button();
            InventoryBut = new Button();
            CustomersBut = new Button();
            PromotionsBut = new Button();
            EmployeesBut = new Button();
            ReportsBut = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            searchbut = new Button();
            textBox1 = new TextBox();
            admin = new Label();
            LogoutBut = new Button();
            pnlContent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(154, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(storePOS, 0, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(147, 82);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // storePOS
            // 
            storePOS.AutoSize = true;
            storePOS.Dock = DockStyle.Fill;
            storePOS.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storePOS.ForeColor = SystemColors.HotTrack;
            storePOS.ImageAlign = ContentAlignment.BottomLeft;
            storePOS.Location = new Point(3, 0);
            storePOS.Name = "storePOS";
            storePOS.Size = new Size(141, 41);
            storePOS.TabIndex = 0;
            storePOS.Text = "StorePOS";
            storePOS.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 1;
            label1.Text = "Management System";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(DashboardBut, 0, 0);
            tableLayoutPanel6.Controls.Add(PosBut, 0, 1);
            tableLayoutPanel6.Controls.Add(ProductBut, 0, 2);
            tableLayoutPanel6.Controls.Add(InventoryBut, 0, 3);
            tableLayoutPanel6.Controls.Add(CustomersBut, 0, 4);
            tableLayoutPanel6.Controls.Add(PromotionsBut, 0, 5);
            tableLayoutPanel6.Controls.Add(EmployeesBut, 0, 6);
            tableLayoutPanel6.Controls.Add(ReportsBut, 0, 7);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 91);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 9;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Size = new Size(148, 350);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // DashboardBut
            // 
            DashboardBut.Dock = DockStyle.Fill;
            DashboardBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashboardBut.Location = new Point(3, 3);
            DashboardBut.Name = "DashboardBut";
            DashboardBut.Size = new Size(142, 29);
            DashboardBut.TabIndex = 0;
            DashboardBut.Text = "DashBoard";
            DashboardBut.UseVisualStyleBackColor = true;
            DashboardBut.Click += DashboardBut_Click;
            // 
            // PosBut
            // 
            PosBut.Dock = DockStyle.Fill;
            PosBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PosBut.Location = new Point(3, 38);
            PosBut.Name = "PosBut";
            PosBut.Size = new Size(142, 29);
            PosBut.TabIndex = 1;
            PosBut.Text = "POS";
            PosBut.UseVisualStyleBackColor = true;
            PosBut.Click += PosBut_Click;
            // 
            // ProductBut
            // 
            ProductBut.Dock = DockStyle.Fill;
            ProductBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductBut.Location = new Point(3, 73);
            ProductBut.Name = "ProductBut";
            ProductBut.Size = new Size(142, 29);
            ProductBut.TabIndex = 2;
            ProductBut.Text = "Product";
            ProductBut.UseVisualStyleBackColor = true;
            ProductBut.Click += ProductBut_Click;
            // 
            // InventoryBut
            // 
            InventoryBut.Dock = DockStyle.Fill;
            InventoryBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryBut.Location = new Point(3, 108);
            InventoryBut.Name = "InventoryBut";
            InventoryBut.Size = new Size(142, 29);
            InventoryBut.TabIndex = 3;
            InventoryBut.Text = "Inventory";
            InventoryBut.UseVisualStyleBackColor = true;
            InventoryBut.Click += InventoryBut_Click;
            // 
            // CustomersBut
            // 
            CustomersBut.Dock = DockStyle.Fill;
            CustomersBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomersBut.Location = new Point(3, 143);
            CustomersBut.Name = "CustomersBut";
            CustomersBut.Size = new Size(142, 29);
            CustomersBut.TabIndex = 4;
            CustomersBut.Text = "Customers";
            CustomersBut.UseVisualStyleBackColor = true;
            CustomersBut.Click += CustomersBut_Click;
            // 
            // PromotionsBut
            // 
            PromotionsBut.Dock = DockStyle.Fill;
            PromotionsBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PromotionsBut.Location = new Point(3, 178);
            PromotionsBut.Name = "PromotionsBut";
            PromotionsBut.Size = new Size(142, 29);
            PromotionsBut.TabIndex = 5;
            PromotionsBut.Text = "Promotions";
            PromotionsBut.UseVisualStyleBackColor = true;
            PromotionsBut.Click += PromotionsBut_Click;
            // 
            // EmployeesBut
            // 
            EmployeesBut.Dock = DockStyle.Fill;
            EmployeesBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeesBut.Location = new Point(3, 213);
            EmployeesBut.Name = "EmployeesBut";
            EmployeesBut.Size = new Size(142, 29);
            EmployeesBut.TabIndex = 6;
            EmployeesBut.Text = "Employees";
            EmployeesBut.UseVisualStyleBackColor = true;
            EmployeesBut.Click += EmployeesBut_Click;
            // 
            // ReportsBut
            // 
            ReportsBut.Dock = DockStyle.Fill;
            ReportsBut.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportsBut.Location = new Point(3, 248);
            ReportsBut.Name = "ReportsBut";
            ReportsBut.Size = new Size(142, 29);
            ReportsBut.TabIndex = 7;
            ReportsBut.Text = "Reports";
            ReportsBut.UseVisualStyleBackColor = true;
            ReportsBut.Click += ReportsBut_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(pnlContent, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(163, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1351347F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 89.86487F));
            tableLayoutPanel3.Size = new Size(634, 444);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel4.Controls.Add(admin, 1, 0);
            tableLayoutPanel4.Controls.Add(LogoutBut, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(628, 39);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.Controls.Add(searchbut, 1, 0);
            tableLayoutPanel7.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(433, 33);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // searchbut
            // 
            searchbut.Location = new Point(392, 3);
            searchbut.Name = "searchbut";
            searchbut.Size = new Size(37, 26);
            searchbut.TabIndex = 0;
            searchbut.Text = "button1";
            searchbut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 25);
            textBox1.TabIndex = 1;
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.BackColor = SystemColors.ControlDark;
            admin.Dock = DockStyle.Fill;
            admin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin.Location = new Point(442, 0);
            admin.Name = "admin";
            admin.Size = new Size(132, 39);
            admin.TabIndex = 1;
            admin.Text = "Admin";
            admin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogoutBut
            // 
            LogoutBut.Dock = DockStyle.Fill;
            LogoutBut.Location = new Point(580, 3);
            LogoutBut.Name = "LogoutBut";
            LogoutBut.Size = new Size(45, 33);
            LogoutBut.TabIndex = 2;
            LogoutBut.Text = "Logout";
            LogoutBut.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(3, 48);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(628, 393);
            pnlContent.TabIndex = 1;
            // 
            // MainForm_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm_Admin";
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label storePOS;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button DashboardBut;
        private Button PosBut;
        private Button ProductBut;
        private Button InventoryBut;
        private Button CustomersBut;
        private Button PromotionsBut;
        private Button EmployeesBut;
        private Button ReportsBut;
        private TableLayoutPanel tableLayoutPanel7;
        private Button searchbut;
        private TextBox textBox1;
        private Label admin;
        private Button LogoutBut;
        private Panel pnlContent;
    }
}