namespace CSMS.WinForms.Forms.Report
{
    partial class ReportForm
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
            tableLayoutPanelMain = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            tableLayoutPanelCards = new TableLayoutPanel();
            panelCard1 = new Panel();
            tableLayoutPanelCard1 = new TableLayoutPanel();
            labelTotalRevenue = new Label();
            lblTotalRevenue = new Label();
            labelCard1Sub = new Label();
            panelCard2 = new Panel();
            tableLayoutPanelCard2 = new TableLayoutPanel();
            labelTotalOrders = new Label();
            lblTotalOrders = new Label();
            labelCard2Sub = new Label();
            panelCard3 = new Panel();
            tableLayoutPanelCard3 = new TableLayoutPanel();
            labelAverageOrder = new Label();
            lblAverageOrder = new Label();
            labelCard3Sub = new Label();
            panelCard4 = new Panel();
            tableLayoutPanelCard4 = new TableLayoutPanel();
            labelProfitMargin = new Label();
            lblProfitMargin = new Label();
            labelCard4Sub = new Label();
            chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTopRight = new FlowLayoutPanel();
            btnExport = new Button();
            cboPeriod = new ComboBox();
            cboReportType = new ComboBox();
            panel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            panelCard1.SuspendLayout();
            tableLayoutPanelCard1.SuspendLayout();
            panelCard2.SuspendLayout();
            tableLayoutPanelCard2.SuspendLayout();
            panelCard3.SuspendLayout();
            tableLayoutPanelCard3.SuspendLayout();
            panelCard4.SuspendLayout();
            tableLayoutPanelCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartReport).BeginInit();
            panelTopRight.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanelMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(951, 512);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(lblSubtitle, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelCards, 0, 2);
            tableLayoutPanelMain.Controls.Add(chartReport, 0, 3);
            tableLayoutPanelMain.Controls.Add(panelTopRight, 0, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(15, 15);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 5;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelMain.Size = new Size(921, 482);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(915, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports & Statistics";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Times New Roman", 11F);
            lblSubtitle.ForeColor = SystemColors.ControlDarkDark;
            lblSubtitle.Location = new Point(3, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(915, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Analyze business performance and trends";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.ColumnCount = 4;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCards.Controls.Add(panelCard1, 0, 0);
            tableLayoutPanelCards.Controls.Add(panelCard2, 1, 0);
            tableLayoutPanelCards.Controls.Add(panelCard3, 2, 0);
            tableLayoutPanelCards.Controls.Add(panelCard4, 3, 0);
            tableLayoutPanelCards.Dock = DockStyle.Fill;
            tableLayoutPanelCards.Location = new Point(3, 93);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCards.Size = new Size(915, 114);
            tableLayoutPanelCards.TabIndex = 2;
            // 
            // panelCard1
            // 
            panelCard1.BackColor = SystemColors.ControlLightLight;
            panelCard1.Controls.Add(tableLayoutPanelCard1);
            panelCard1.Dock = DockStyle.Fill;
            panelCard1.Location = new Point(3, 3);
            panelCard1.Name = "panelCard1";
            panelCard1.Padding = new Padding(8);
            panelCard1.Size = new Size(222, 108);
            panelCard1.TabIndex = 0;
            // 
            // tableLayoutPanelCard1
            // 
            tableLayoutPanelCard1.ColumnCount = 1;
            tableLayoutPanelCard1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCard1.Controls.Add(labelTotalRevenue, 0, 0);
            tableLayoutPanelCard1.Controls.Add(lblTotalRevenue, 0, 1);
            tableLayoutPanelCard1.Controls.Add(labelCard1Sub, 0, 2);
            tableLayoutPanelCard1.Dock = DockStyle.Fill;
            tableLayoutPanelCard1.Location = new Point(8, 8);
            tableLayoutPanelCard1.Name = "tableLayoutPanelCard1";
            tableLayoutPanelCard1.RowCount = 3;
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelCard1.Size = new Size(206, 92);
            tableLayoutPanelCard1.TabIndex = 0;
            // 
            // labelTotalRevenue
            // 
            labelTotalRevenue.Dock = DockStyle.Fill;
            labelTotalRevenue.Font = new Font("Times New Roman", 12F);
            labelTotalRevenue.Location = new Point(3, 0);
            labelTotalRevenue.Name = "labelTotalRevenue";
            labelTotalRevenue.Size = new Size(200, 36);
            labelTotalRevenue.TabIndex = 0;
            labelTotalRevenue.Text = "Total Revenue";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Dock = DockStyle.Fill;
            lblTotalRevenue.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblTotalRevenue.Location = new Point(3, 36);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(200, 36);
            lblTotalRevenue.TabIndex = 1;
            // 
            // labelCard1Sub
            // 
            labelCard1Sub.Dock = DockStyle.Fill;
            labelCard1Sub.Font = new Font("Times New Roman", 10F);
            labelCard1Sub.ForeColor = Color.Green;
            labelCard1Sub.Location = new Point(3, 72);
            labelCard1Sub.Name = "labelCard1Sub";
            labelCard1Sub.Size = new Size(200, 20);
            labelCard1Sub.TabIndex = 2;
            // 
            // panelCard2
            // 
            panelCard2.BackColor = SystemColors.ControlLightLight;
            panelCard2.Controls.Add(tableLayoutPanelCard2);
            panelCard2.Dock = DockStyle.Fill;
            panelCard2.Location = new Point(231, 3);
            panelCard2.Name = "panelCard2";
            panelCard2.Padding = new Padding(8);
            panelCard2.Size = new Size(222, 108);
            panelCard2.TabIndex = 1;
            // 
            // tableLayoutPanelCard2
            // 
            tableLayoutPanelCard2.ColumnCount = 1;
            tableLayoutPanelCard2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCard2.Controls.Add(labelTotalOrders, 0, 0);
            tableLayoutPanelCard2.Controls.Add(lblTotalOrders, 0, 1);
            tableLayoutPanelCard2.Controls.Add(labelCard2Sub, 0, 2);
            tableLayoutPanelCard2.Dock = DockStyle.Fill;
            tableLayoutPanelCard2.Location = new Point(8, 8);
            tableLayoutPanelCard2.Name = "tableLayoutPanelCard2";
            tableLayoutPanelCard2.RowCount = 3;
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelCard2.Size = new Size(206, 92);
            tableLayoutPanelCard2.TabIndex = 0;
            // 
            // labelTotalOrders
            // 
            labelTotalOrders.Dock = DockStyle.Fill;
            labelTotalOrders.Font = new Font("Times New Roman", 12F);
            labelTotalOrders.Location = new Point(3, 0);
            labelTotalOrders.Name = "labelTotalOrders";
            labelTotalOrders.Size = new Size(200, 36);
            labelTotalOrders.TabIndex = 0;
            labelTotalOrders.Text = "Total Orders";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.Dock = DockStyle.Fill;
            lblTotalOrders.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblTotalOrders.Location = new Point(3, 36);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(200, 36);
            lblTotalOrders.TabIndex = 1;
            // 
            // labelCard2Sub
            // 
            labelCard2Sub.Dock = DockStyle.Fill;
            labelCard2Sub.Font = new Font("Times New Roman", 10F);
            labelCard2Sub.ForeColor = Color.Green;
            labelCard2Sub.Location = new Point(3, 72);
            labelCard2Sub.Name = "labelCard2Sub";
            labelCard2Sub.Size = new Size(200, 20);
            labelCard2Sub.TabIndex = 2;
            // 
            // panelCard3
            // 
            panelCard3.BackColor = SystemColors.ControlLightLight;
            panelCard3.Controls.Add(tableLayoutPanelCard3);
            panelCard3.Dock = DockStyle.Fill;
            panelCard3.Location = new Point(459, 3);
            panelCard3.Name = "panelCard3";
            panelCard3.Padding = new Padding(8);
            panelCard3.Size = new Size(222, 108);
            panelCard3.TabIndex = 2;
            // 
            // tableLayoutPanelCard3
            // 
            tableLayoutPanelCard3.ColumnCount = 1;
            tableLayoutPanelCard3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCard3.Controls.Add(labelAverageOrder, 0, 0);
            tableLayoutPanelCard3.Controls.Add(lblAverageOrder, 0, 1);
            tableLayoutPanelCard3.Controls.Add(labelCard3Sub, 0, 2);
            tableLayoutPanelCard3.Dock = DockStyle.Fill;
            tableLayoutPanelCard3.Location = new Point(8, 8);
            tableLayoutPanelCard3.Name = "tableLayoutPanelCard3";
            tableLayoutPanelCard3.RowCount = 3;
            tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelCard3.Size = new Size(206, 92);
            tableLayoutPanelCard3.TabIndex = 0;
            // 
            // labelAverageOrder
            // 
            labelAverageOrder.Dock = DockStyle.Fill;
            labelAverageOrder.Font = new Font("Times New Roman", 12F);
            labelAverageOrder.Location = new Point(3, 0);
            labelAverageOrder.Name = "labelAverageOrder";
            labelAverageOrder.Size = new Size(200, 36);
            labelAverageOrder.TabIndex = 0;
            labelAverageOrder.Text = "Average Order";
            // 
            // lblAverageOrder
            // 
            lblAverageOrder.Dock = DockStyle.Fill;
            lblAverageOrder.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblAverageOrder.Location = new Point(3, 36);
            lblAverageOrder.Name = "lblAverageOrder";
            lblAverageOrder.Size = new Size(200, 36);
            lblAverageOrder.TabIndex = 1;
            // 
            // labelCard3Sub
            // 
            labelCard3Sub.Dock = DockStyle.Fill;
            labelCard3Sub.Font = new Font("Times New Roman", 10F);
            labelCard3Sub.ForeColor = Color.Green;
            labelCard3Sub.Location = new Point(3, 72);
            labelCard3Sub.Name = "labelCard3Sub";
            labelCard3Sub.Size = new Size(200, 20);
            labelCard3Sub.TabIndex = 2;
            // 
            // panelCard4
            // 
            panelCard4.BackColor = SystemColors.ControlLightLight;
            panelCard4.Controls.Add(tableLayoutPanelCard4);
            panelCard4.Dock = DockStyle.Fill;
            panelCard4.Location = new Point(687, 3);
            panelCard4.Name = "panelCard4";
            panelCard4.Padding = new Padding(8);
            panelCard4.Size = new Size(225, 108);
            panelCard4.TabIndex = 3;
            // 
            // tableLayoutPanelCard4
            // 
            tableLayoutPanelCard4.ColumnCount = 1;
            tableLayoutPanelCard4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCard4.Controls.Add(labelProfitMargin, 0, 0);
            tableLayoutPanelCard4.Controls.Add(lblProfitMargin, 0, 1);
            tableLayoutPanelCard4.Controls.Add(labelCard4Sub, 0, 2);
            tableLayoutPanelCard4.Dock = DockStyle.Fill;
            tableLayoutPanelCard4.Location = new Point(8, 8);
            tableLayoutPanelCard4.Name = "tableLayoutPanelCard4";
            tableLayoutPanelCard4.RowCount = 3;
            tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelCard4.Size = new Size(209, 92);
            tableLayoutPanelCard4.TabIndex = 0;
            // 
            // labelProfitMargin
            // 
            labelProfitMargin.Dock = DockStyle.Fill;
            labelProfitMargin.Font = new Font("Times New Roman", 12F);
            labelProfitMargin.Location = new Point(3, 0);
            labelProfitMargin.Name = "labelProfitMargin";
            labelProfitMargin.Size = new Size(203, 36);
            labelProfitMargin.TabIndex = 0;
            labelProfitMargin.Text = "Profit Margin";
            // 
            // lblProfitMargin
            // 
            lblProfitMargin.Dock = DockStyle.Fill;
            lblProfitMargin.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblProfitMargin.Location = new Point(3, 36);
            lblProfitMargin.Name = "lblProfitMargin";
            lblProfitMargin.Size = new Size(203, 36);
            lblProfitMargin.TabIndex = 1;
            // 
            // labelCard4Sub
            // 
            labelCard4Sub.Dock = DockStyle.Fill;
            labelCard4Sub.Font = new Font("Times New Roman", 10F);
            labelCard4Sub.ForeColor = Color.Red;
            labelCard4Sub.Location = new Point(3, 72);
            labelCard4Sub.Name = "labelCard4Sub";
            labelCard4Sub.Size = new Size(203, 20);
            labelCard4Sub.TabIndex = 2;
            // 
            // chartReport
            // 
            chartArea1.Name = "ChartArea1";
            chartReport.ChartAreas.Add(chartArea1);
            chartReport.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartReport.Legends.Add(legend1);
            chartReport.Location = new Point(3, 213);
            chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartReport.Series.Add(series1);
            chartReport.Size = new Size(915, 226);
            chartReport.TabIndex = 3;
            chartReport.Text = "chartReport";
            // 
            // panelTopRight
            // 
            panelTopRight.Controls.Add(btnExport);
            panelTopRight.Controls.Add(cboPeriod);
            panelTopRight.Controls.Add(cboReportType);
            panelTopRight.Dock = DockStyle.Fill;
            panelTopRight.FlowDirection = FlowDirection.RightToLeft;
            panelTopRight.Location = new Point(3, 445);
            panelTopRight.Name = "panelTopRight";
            panelTopRight.Size = new Size(915, 34);
            panelTopRight.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.Location = new Point(801, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(111, 30);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export Report";
            // 
            // cboPeriod
            // 
            cboPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriod.Location = new Point(655, 3);
            cboPeriod.Name = "cboPeriod";
            cboPeriod.Size = new Size(140, 28);
            cboPeriod.TabIndex = 1;
            // 
            // cboReportType
            // 
            cboReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportType.Location = new Point(469, 3);
            cboReportType.Name = "cboReportType";
            cboReportType.Size = new Size(180, 28);
            cboReportType.TabIndex = 2;
            // 
            // ReportForm
            // 
            Controls.Add(panel1);
            Name = "ReportForm";
            Size = new Size(951, 512);
            panel1.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelCards.ResumeLayout(false);
            panelCard1.ResumeLayout(false);
            tableLayoutPanelCard1.ResumeLayout(false);
            panelCard2.ResumeLayout(false);
            tableLayoutPanelCard2.ResumeLayout(false);
            panelCard3.ResumeLayout(false);
            tableLayoutPanelCard3.ResumeLayout(false);
            panelCard4.ResumeLayout(false);
            tableLayoutPanelCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartReport).EndInit();
            panelTopRight.ResumeLayout(false);
            panelTopRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private TableLayoutPanel tableLayoutPanelMain;
		private Label lblTitle;
		private Label lblSubtitle;
		private FlowLayoutPanel panelTopRight;
		private ComboBox cboReportType;
		private ComboBox cboPeriod;
		private Button btnExport;
		private TableLayoutPanel tableLayoutPanelCards;
		private Panel panelCard1;
		private TableLayoutPanel tableLayoutPanelCard1;
		private Label labelTotalRevenue;
		private Label lblTotalRevenue;
		private Label labelCard1Sub;
		private Panel panelCard2;
		private TableLayoutPanel tableLayoutPanelCard2;
		private Label labelTotalOrders;
		private Label lblTotalOrders;
		private Label labelCard2Sub;
		private Panel panelCard3;
		private TableLayoutPanel tableLayoutPanelCard3;
		private Label labelAverageOrder;
		private Label lblAverageOrder;
		private Label labelCard3Sub;
		private Panel panelCard4;
		private TableLayoutPanel tableLayoutPanelCard4;
		private Label labelProfitMargin;
		private Label lblProfitMargin;
		private Label labelCard4Sub;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
	}
}

