namespace CSMS.WinForms.Forms.DashBoard
{
    partial class DashBoardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            pnlchartRevenue = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            lblrevenuecomp = new Label();
            lblRevenue = new Label();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            lblTotalProduct = new Label();
            panel4 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            lblLowStock = new Label();
            label11 = new Label();
            panel5 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label12 = new Label();
            lblOrders = new Label();
            label14 = new Label();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            pnlchartRevenue.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pnlchartRevenue);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(667, 421);
            panel1.TabIndex = 0;
            // 
            // pnlchartRevenue
            // 
            pnlchartRevenue.ColumnCount = 1;
            pnlchartRevenue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlchartRevenue.Controls.Add(label1, 0, 0);
            pnlchartRevenue.Controls.Add(label2, 0, 1);
            pnlchartRevenue.Controls.Add(tableLayoutPanel2, 0, 2);
            pnlchartRevenue.Controls.Add(chartRevenue, 0, 3);
            pnlchartRevenue.Dock = DockStyle.Fill;
            pnlchartRevenue.Location = new Point(15, 15);
            pnlchartRevenue.Name = "pnlchartRevenue";
            pnlchartRevenue.RowCount = 4;
            pnlchartRevenue.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlchartRevenue.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnlchartRevenue.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            pnlchartRevenue.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            pnlchartRevenue.Size = new Size(637, 391);
            pnlchartRevenue.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(631, 60);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(631, 50);
            label2.TabIndex = 1;
            label2.Text = "Welcome back, Administrator! Here's what's happening today.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 2, 0);
            tableLayoutPanel2.Controls.Add(panel5, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 113);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(631, 144);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 138);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(lblrevenuecomp, 0, 2);
            tableLayoutPanel3.Controls.Add(lblRevenue, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(151, 138);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 48);
            label3.TabIndex = 0;
            label3.Text = "Total Revenue";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblrevenuecomp
            // 
            lblrevenuecomp.AutoSize = true;
            lblrevenuecomp.Dock = DockStyle.Fill;
            lblrevenuecomp.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblrevenuecomp.Location = new Point(3, 103);
            lblrevenuecomp.Name = "lblrevenuecomp";
            lblrevenuecomp.Size = new Size(145, 35);
            lblrevenuecomp.TabIndex = 1;
            lblrevenuecomp.Text = "label4";
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Dock = DockStyle.Fill;
            lblRevenue.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.Location = new Point(3, 48);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(145, 55);
            lblRevenue.TabIndex = 2;
            lblRevenue.Text = "label5";
            lblRevenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(160, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(151, 138);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(label7, 0, 2);
            tableLayoutPanel4.Controls.Add(lblTotalProduct, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Size = new Size(151, 138);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 48);
            label6.TabIndex = 0;
            label6.Text = "Total Products";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 103);
            label7.Name = "label7";
            label7.Size = new Size(145, 35);
            label7.TabIndex = 1;
            label7.Text = "Active in inventory";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.AutoSize = true;
            lblTotalProduct.Dock = DockStyle.Fill;
            lblTotalProduct.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProduct.Location = new Point(3, 48);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(145, 55);
            lblTotalProduct.TabIndex = 2;
            lblTotalProduct.Text = "label8";
            lblTotalProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(317, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(151, 138);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(lblLowStock, 0, 1);
            tableLayoutPanel5.Controls.Add(label11, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(151, 138);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 48);
            label9.TabIndex = 0;
            label9.Text = "Low Stock Products";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Dock = DockStyle.Fill;
            lblLowStock.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.DarkOrange;
            lblLowStock.Location = new Point(3, 48);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(145, 55);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "label10";
            lblLowStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 103);
            label11.Name = "label11";
            label11.Size = new Size(145, 35);
            label11.TabIndex = 2;
            label11.Text = "Require attention";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(474, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 138);
            panel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(label12, 0, 0);
            tableLayoutPanel6.Controls.Add(lblOrders, 0, 1);
            tableLayoutPanel6.Controls.Add(label14, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(154, 138);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(148, 48);
            label12.TabIndex = 0;
            label12.Text = "Today's Orders";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Dock = DockStyle.Fill;
            lblOrders.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrders.Location = new Point(3, 48);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(148, 55);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "label13";
            lblOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 103);
            label14.Name = "label14";
            label14.Size = new Size(148, 35);
            label14.TabIndex = 2;
            label14.Text = "label14";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            chartRevenue.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(3, 263);
            chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(631, 294);
            chartRevenue.TabIndex = 3;
            chartRevenue.Text = "chart1";
            // 
            // DashBoardForm
            // 
            Controls.Add(panel1);
            Name = "DashBoardForm";
            Size = new Size(667, 421);
            panel1.ResumeLayout(false);
            pnlchartRevenue.ResumeLayout(false);
            pnlchartRevenue.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel pnlchartRevenue;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label lblrevenuecomp;
        private Label lblRevenue;
        private Label label6;
        private Label label7;
        private Label lblTotalProduct;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label lblLowStock;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label12;
        private Label lblOrders;
        private Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}
