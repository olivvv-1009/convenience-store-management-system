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
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			tableLayoutPanelMain = new TableLayoutPanel();
			lblTitle = new Label();
			lblSubtitle = new Label();
			panelTopRight = new FlowLayoutPanel();
			cboReportType = new ComboBox();
			cboPeriod = new ComboBox();
			btnExport = new Button();
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
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Dock = DockStyle.Fill;
			panel1.Padding = new Padding(15);
			panel1.Controls.Add(tableLayoutPanelMain);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
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
			lblTitle.Text = "Reports & Statistics";
			lblTitle.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblSubtitle
			// 
			lblSubtitle.AutoSize = true;
			lblSubtitle.Dock = DockStyle.Fill;
			lblSubtitle.Font = new Font("Times New Roman", 11F);
			lblSubtitle.ForeColor = SystemColors.ControlDarkDark;
			lblSubtitle.Text = "Analyze business performance and trends";
			lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelTopRight
			// 
			panelTopRight.FlowDirection = FlowDirection.RightToLeft;
			panelTopRight.Dock = DockStyle.Fill;
			panelTopRight.Controls.Add(btnExport);
			panelTopRight.Controls.Add(cboPeriod);
			panelTopRight.Controls.Add(cboReportType);
			panelTopRight.Margin = new Padding(3);
			panelTopRight.Height = 36;
			// 
			// cboReportType
			// 
			cboReportType.DropDownStyle = ComboBoxStyle.DropDownList;
			cboReportType.Width = 180;
			cboReportType.Name = "cboReportType";
			// 
			// cboPeriod
			// 
			cboPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPeriod.Width = 140;
			cboPeriod.Name = "cboPeriod";
			// 
			// btnExport
			// 
			btnExport.Text = "Export Report";
			btnExport.AutoSize = true;
			btnExport.Name = "btnExport";
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
			tableLayoutPanelCards.Size = new Size(921, 114);
			// 
			// panelCard1
			// 
			panelCard1.Padding = new Padding(8);
			panelCard1.Dock = DockStyle.Fill;
			panelCard1.Controls.Add(tableLayoutPanelCard1);
			// 
			// tableLayoutPanelCard1
			// 
			tableLayoutPanelCard1.ColumnCount = 1;
			tableLayoutPanelCard1.RowCount = 3;
			tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelCard1.Dock = DockStyle.Fill;
			tableLayoutPanelCard1.Controls.Add(labelTotalRevenue, 0, 0);
			tableLayoutPanelCard1.Controls.Add(lblTotalRevenue, 0, 1);
			tableLayoutPanelCard1.Controls.Add(labelCard1Sub, 0, 2);
			labelTotalRevenue.Text = "Total Revenue";
			labelTotalRevenue.Font = new Font("Times New Roman", 12F);
			labelTotalRevenue.Dock = DockStyle.Fill;
			lblTotalRevenue.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
			lblTotalRevenue.Dock = DockStyle.Fill;
			labelCard1Sub.Font = new Font("Times New Roman", 10F);
			labelCard1Sub.ForeColor = Color.Green;
			labelCard1Sub.Dock = DockStyle.Fill;
			// 
			// panelCard2
			// 
			panelCard2.Padding = new Padding(8);
			panelCard2.Dock = DockStyle.Fill;
			panelCard2.Controls.Add(tableLayoutPanelCard2);
			tableLayoutPanelCard2.ColumnCount = 1;
			tableLayoutPanelCard2.RowCount = 3;
			tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelCard2.Dock = DockStyle.Fill;
			tableLayoutPanelCard2.Controls.Add(labelTotalOrders, 0, 0);
			tableLayoutPanelCard2.Controls.Add(lblTotalOrders, 0, 1);
			tableLayoutPanelCard2.Controls.Add(labelCard2Sub, 0, 2);
			labelTotalOrders.Text = "Total Orders";
			labelTotalOrders.Font = new Font("Times New Roman", 12F);
			labelTotalOrders.Dock = DockStyle.Fill;
			lblTotalOrders.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
			lblTotalOrders.Dock = DockStyle.Fill;
			labelCard2Sub.Font = new Font("Times New Roman", 10F);
			labelCard2Sub.ForeColor = Color.Green;
			labelCard2Sub.Dock = DockStyle.Fill;
			// 
			// panelCard3
			// 
			panelCard3.Padding = new Padding(8);
			panelCard3.Dock = DockStyle.Fill;
			panelCard3.Controls.Add(tableLayoutPanelCard3);
			tableLayoutPanelCard3.ColumnCount = 1;
			tableLayoutPanelCard3.RowCount = 3;
			tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelCard3.Dock = DockStyle.Fill;
			tableLayoutPanelCard3.Controls.Add(labelAverageOrder, 0, 0);
			tableLayoutPanelCard3.Controls.Add(lblAverageOrder, 0, 1);
			tableLayoutPanelCard3.Controls.Add(labelCard3Sub, 0, 2);
			labelAverageOrder.Text = "Average Order";
			labelAverageOrder.Font = new Font("Times New Roman", 12F);
			labelAverageOrder.Dock = DockStyle.Fill;
			lblAverageOrder.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
			lblAverageOrder.Dock = DockStyle.Fill;
			labelCard3Sub.Font = new Font("Times New Roman", 10F);
			labelCard3Sub.ForeColor = Color.Green;
			labelCard3Sub.Dock = DockStyle.Fill;
			// 
			// panelCard4
			// 
			panelCard4.Padding = new Padding(8);
			panelCard4.Dock = DockStyle.Fill;
			panelCard4.Controls.Add(tableLayoutPanelCard4);
			tableLayoutPanelCard4.ColumnCount = 1;
			tableLayoutPanelCard4.RowCount = 3;
			tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanelCard4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanelCard4.Dock = DockStyle.Fill;
			tableLayoutPanelCard4.Controls.Add(labelProfitMargin, 0, 0);
			tableLayoutPanelCard4.Controls.Add(lblProfitMargin, 0, 1);
			tableLayoutPanelCard4.Controls.Add(labelCard4Sub, 0, 2);
			labelProfitMargin.Text = "Profit Margin";
			labelProfitMargin.Font = new Font("Times New Roman", 12F);
			labelProfitMargin.Dock = DockStyle.Fill;
			lblProfitMargin.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
			lblProfitMargin.Dock = DockStyle.Fill;
			labelCard4Sub.Font = new Font("Times New Roman", 10F);
			labelCard4Sub.ForeColor = Color.Red;
			labelCard4Sub.Dock = DockStyle.Fill;
			// 
			// chartReport
			// 
			chartArea1.Name = "ChartArea1";
			chartReport.ChartAreas.Add(chartArea1);
			chartReport.Dock = DockStyle.Fill;
			legend1.Name = "Legend1";
			chartReport.Legends.Add(legend1);
			chartReport.Location = new Point(3, 193);
			chartReport.Name = "chartReport";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartReport.Series.Add(series1);
			chartReport.Size = new Size(915, 246);
			chartReport.TabIndex = 3;
			chartReport.Text = "chartReport";
			// 
			// ReportForm
			// 
			Controls.Add(panel1);
			Name = "ReportForm";
			Size = new Size(951, 512);
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

