namespace CSMS.WinForms.Forms.Main
{
    partial class MainForm_Staff
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
            tableLayoutPanel3 = new TableLayoutPanel();
            storePOS = new Label();
            ManagementSystem = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            DashboardBut = new Button();
            PosBut = new Button();
            ProductBut = new Button();
            InventoryBut = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            staff = new Label();
            logout = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            textBox1 = new TextBox();
            Search = new Button();
            pnlContent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 451);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(154, 445);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(storePOS, 0, 0);
            tableLayoutPanel3.Controls.Add(ManagementSystem, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(146, 83);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // storePOS
            // 
            storePOS.AutoSize = true;
            storePOS.Dock = DockStyle.Fill;
            storePOS.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storePOS.ForeColor = SystemColors.Highlight;
            storePOS.Location = new Point(3, 0);
            storePOS.Name = "storePOS";
            storePOS.Size = new Size(140, 41);
            storePOS.TabIndex = 0;
            storePOS.Text = "StorePOS";
            storePOS.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ManagementSystem
            // 
            ManagementSystem.AutoSize = true;
            ManagementSystem.Dock = DockStyle.Fill;
            ManagementSystem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagementSystem.ForeColor = SystemColors.ControlDarkDark;
            ManagementSystem.Location = new Point(3, 41);
            ManagementSystem.Name = "ManagementSystem";
            ManagementSystem.Size = new Size(140, 42);
            ManagementSystem.TabIndex = 1;
            ManagementSystem.Text = "Management System";
            ManagementSystem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(DashboardBut, 0, 0);
            tableLayoutPanel4.Controls.Add(PosBut, 0, 1);
            tableLayoutPanel4.Controls.Add(ProductBut, 0, 2);
            tableLayoutPanel4.Controls.Add(InventoryBut, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 92);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(148, 350);
            tableLayoutPanel4.TabIndex = 1;
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
            ProductBut.Text = "Products";
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
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(pnlContent, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(163, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.Size = new Size(634, 445);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tableLayoutPanel6.Controls.Add(staff, 1, 0);
            tableLayoutPanel6.Controls.Add(logout, 2, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(628, 38);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // staff
            // 
            staff.AutoSize = true;
            staff.BackColor = SystemColors.ControlDark;
            staff.Dock = DockStyle.Fill;
            staff.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staff.Location = new Point(442, 0);
            staff.Name = "staff";
            staff.Size = new Size(132, 38);
            staff.TabIndex = 0;
            staff.Text = "Staff";
            staff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logout
            // 
            logout.Dock = DockStyle.Fill;
            logout.Location = new Point(580, 3);
            logout.Name = "logout";
            logout.Size = new Size(45, 32);
            logout.TabIndex = 1;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(Search, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(433, 32);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 0;
            // 
            // Search
            // 
            Search.Dock = DockStyle.Fill;
            Search.Location = new Point(392, 3);
            Search.Name = "Search";
            Search.Size = new Size(38, 26);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(3, 47);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(628, 395);
            pnlContent.TabIndex = 2;
            // 
            // MainForm_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm_Staff";
            Text = "MainForm_Staff";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel6;
        private Label storePOS;
        private Label ManagementSystem;
        private Button DashboardBut;
        private Button PosBut;
        private Button ProductBut;
        private Button InventoryBut;
        private Label staff;
        private Button logout;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox1;
        private Button Search;
        private Panel pnlContent;
    }
}