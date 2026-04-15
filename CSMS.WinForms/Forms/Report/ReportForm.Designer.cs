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
            tlpMain = new TableLayoutPanel();
            panelHeader = new Panel();
            btnExport = new Button();
            label2 = new Label();
            label1 = new Label();
            panelFilters = new Panel();
            cmbTimeRange = new ComboBox();
            cmbReportType = new ComboBox();
            tlpInfoPanels = new TableLayoutPanel();
            panelProfitMargin = new Panel();
            lblProfitPercent = new Label();
            lblProfitAmount = new Label();
            label6 = new Label();
            panelAverageOrder = new Panel();
            lblAvgOrderPercent = new Label();
            lblAvgOrderAmount = new Label();
            label5 = new Label();
            panel5 = new Panel();
            panelRevenue = new Panel();
            lblRevenuePercent = new Label();
            lblRevenueAmount = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panelOrders = new Panel();
            lblOrdersPercent = new Label();
            lblOrdersAmount = new Label();
            label3 = new Label();
            chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvReport = new DataGridView();
            tlpMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelFilters.SuspendLayout();
            tlpInfoPanels.SuspendLayout();
            panelProfitMargin.SuspendLayout();
            panelAverageOrder.SuspendLayout();
            panel5.SuspendLayout();
            panelRevenue.SuspendLayout();
            panel3.SuspendLayout();
            panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.AutoSize = true;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(panelHeader, 0, 0);
            tlpMain.Controls.Add(panelFilters, 0, 1);
            tlpMain.Controls.Add(tlpInfoPanels, 0, 2);
            tlpMain.Controls.Add(chartMain, 0, 3);
            tlpMain.Controls.Add(dgvReport, 0, 4);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpMain.Size = new Size(1082, 645);
            tlpMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnExport);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1076, 74);
            panelHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(854, 9);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(178, 50);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Report";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 52);
            label2.Name = "label2";
            label2.Size = new Size(336, 22);
            label2.TabIndex = 1;
            label2.Text = "Analyze business performance and trends";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 0;
            label1.Text = "Reports And Statitics";
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(cmbTimeRange);
            panelFilters.Controls.Add(cmbReportType);
            panelFilters.Location = new Point(3, 83);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(1076, 54);
            panelFilters.TabIndex = 1;
            // 
            // cmbTimeRange
            // 
            cmbTimeRange.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTimeRange.FormattingEnabled = true;
            cmbTimeRange.Location = new Point(286, 12);
            cmbTimeRange.Name = "cmbTimeRange";
            cmbTimeRange.Size = new Size(201, 30);
            cmbTimeRange.TabIndex = 1;
            cmbTimeRange.SelectedIndexChanged += cmbTimeRange_SelectedIndexChanged;
            // 
            // cmbReportType
            // 
            cmbReportType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(22, 12);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(209, 30);
            cmbReportType.TabIndex = 0;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // tlpInfoPanels
            // 
            tlpInfoPanels.ColumnCount = 4;
            tlpInfoPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpInfoPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpInfoPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpInfoPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpInfoPanels.Controls.Add(panelProfitMargin, 3, 0);
            tlpInfoPanels.Controls.Add(panelAverageOrder, 2, 0);
            tlpInfoPanels.Controls.Add(panel5, 0, 0);
            tlpInfoPanels.Controls.Add(panel3, 1, 0);
            tlpInfoPanels.Location = new Point(3, 143);
            tlpInfoPanels.Name = "tlpInfoPanels";
            tlpInfoPanels.RowCount = 1;
            tlpInfoPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInfoPanels.Size = new Size(1076, 94);
            tlpInfoPanels.TabIndex = 2;
            // 
            // panelProfitMargin
            // 
            panelProfitMargin.Controls.Add(lblProfitPercent);
            panelProfitMargin.Controls.Add(lblProfitAmount);
            panelProfitMargin.Controls.Add(label6);
            panelProfitMargin.Dock = DockStyle.Fill;
            panelProfitMargin.Location = new Point(810, 3);
            panelProfitMargin.Name = "panelProfitMargin";
            panelProfitMargin.Size = new Size(263, 88);
            panelProfitMargin.TabIndex = 3;
            // 
            // lblProfitPercent
            // 
            lblProfitPercent.BackColor = SystemColors.GradientActiveCaption;
            lblProfitPercent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfitPercent.ForeColor = SystemColors.ActiveCaptionText;
            lblProfitPercent.Location = new Point(81, 56);
            lblProfitPercent.Name = "lblProfitPercent";
            lblProfitPercent.Size = new Size(111, 22);
            lblProfitPercent.TabIndex = 4;
            // 
            // lblProfitAmount
            // 
            lblProfitAmount.BackColor = SystemColors.ActiveCaption;
            lblProfitAmount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfitAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblProfitAmount.Location = new Point(81, 22);
            lblProfitAmount.Name = "lblProfitAmount";
            lblProfitAmount.Size = new Size(111, 22);
            lblProfitAmount.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(81, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 1;
            label6.Text = "Profit Margin";
            // 
            // panelAverageOrder
            // 
            panelAverageOrder.Controls.Add(lblAvgOrderPercent);
            panelAverageOrder.Controls.Add(lblAvgOrderAmount);
            panelAverageOrder.Controls.Add(label5);
            panelAverageOrder.Dock = DockStyle.Fill;
            panelAverageOrder.Location = new Point(541, 3);
            panelAverageOrder.Name = "panelAverageOrder";
            panelAverageOrder.Size = new Size(263, 88);
            panelAverageOrder.TabIndex = 2;
            // 
            // lblAvgOrderPercent
            // 
            lblAvgOrderPercent.BackColor = SystemColors.GradientActiveCaption;
            lblAvgOrderPercent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgOrderPercent.ForeColor = SystemColors.ActiveCaptionText;
            lblAvgOrderPercent.Location = new Point(80, 56);
            lblAvgOrderPercent.Name = "lblAvgOrderPercent";
            lblAvgOrderPercent.Size = new Size(111, 22);
            lblAvgOrderPercent.TabIndex = 3;
            // 
            // lblAvgOrderAmount
            // 
            lblAvgOrderAmount.BackColor = SystemColors.ActiveCaption;
            lblAvgOrderAmount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgOrderAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblAvgOrderAmount.Location = new Point(80, 22);
            lblAvgOrderAmount.Name = "lblAvgOrderAmount";
            lblAvgOrderAmount.Size = new Size(111, 22);
            lblAvgOrderAmount.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(80, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 1;
            label5.Text = "Average Order";
            // 
            // panel5
            // 
            panel5.Controls.Add(panelRevenue);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 88);
            panel5.TabIndex = 1;
            // 
            // panelRevenue
            // 
            panelRevenue.Controls.Add(lblRevenuePercent);
            panelRevenue.Controls.Add(lblRevenueAmount);
            panelRevenue.Controls.Add(label4);
            panelRevenue.Dock = DockStyle.Fill;
            panelRevenue.Location = new Point(0, 0);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.Size = new Size(263, 88);
            panelRevenue.TabIndex = 1;
            // 
            // lblRevenuePercent
            // 
            lblRevenuePercent.BackColor = SystemColors.GradientActiveCaption;
            lblRevenuePercent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevenuePercent.ForeColor = SystemColors.ActiveCaptionText;
            lblRevenuePercent.Location = new Point(74, 56);
            lblRevenuePercent.Name = "lblRevenuePercent";
            lblRevenuePercent.Size = new Size(111, 22);
            lblRevenuePercent.TabIndex = 3;
            // 
            // lblRevenueAmount
            // 
            lblRevenueAmount.BackColor = SystemColors.ActiveCaption;
            lblRevenueAmount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevenueAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblRevenueAmount.Location = new Point(74, 22);
            lblRevenueAmount.Name = "lblRevenueAmount";
            lblRevenueAmount.Size = new Size(111, 22);
            lblRevenueAmount.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(74, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 22);
            label4.TabIndex = 1;
            label4.Text = "Total Revenue";
            // 
            // panel3
            // 
            panel3.Controls.Add(panelOrders);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(272, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 88);
            panel3.TabIndex = 0;
            // 
            // panelOrders
            // 
            panelOrders.Controls.Add(lblOrdersPercent);
            panelOrders.Controls.Add(lblOrdersAmount);
            panelOrders.Controls.Add(label3);
            panelOrders.Dock = DockStyle.Fill;
            panelOrders.Location = new Point(0, 0);
            panelOrders.Name = "panelOrders";
            panelOrders.Size = new Size(263, 88);
            panelOrders.TabIndex = 1;
            // 
            // lblOrdersPercent
            // 
            lblOrdersPercent.BackColor = SystemColors.GradientActiveCaption;
            lblOrdersPercent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdersPercent.ForeColor = SystemColors.ActiveCaptionText;
            lblOrdersPercent.Location = new Point(82, 56);
            lblOrdersPercent.Name = "lblOrdersPercent";
            lblOrdersPercent.Size = new Size(111, 22);
            lblOrdersPercent.TabIndex = 2;
            // 
            // lblOrdersAmount
            // 
            lblOrdersAmount.BackColor = SystemColors.ActiveCaption;
            lblOrdersAmount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdersAmount.ForeColor = SystemColors.ActiveCaptionText;
            lblOrdersAmount.Location = new Point(82, 22);
            lblOrdersAmount.Name = "lblOrdersAmount";
            lblOrdersAmount.Size = new Size(111, 22);
            lblOrdersAmount.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(82, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 0;
            label3.Text = "Total Orders";
            // 
            // chartMain
            // 
            chartArea1.Name = "chartMain";
            chartMain.ChartAreas.Add(chartArea1);
            chartMain.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMain.Legends.Add(legend1);
            chartMain.Location = new Point(3, 243);
            chartMain.Name = "chartMain";
            chartMain.Size = new Size(1076, 237);
            chartMain.TabIndex = 3;
            chartMain.Text = "chart1";
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = SystemColors.ButtonHighlight;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(3, 486);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1076, 156);
            dgvReport.TabIndex = 4;
            // 
            // ReportForm
            // 
            Controls.Add(tlpMain);
            Name = "ReportForm";
            Size = new Size(1082, 645);
            tlpMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFilters.ResumeLayout(false);
            tlpInfoPanels.ResumeLayout(false);
            panelProfitMargin.ResumeLayout(false);
            panelProfitMargin.PerformLayout();
            panelAverageOrder.ResumeLayout(false);
            panelAverageOrder.PerformLayout();
            panel5.ResumeLayout(false);
            panelRevenue.ResumeLayout(false);
            panelRevenue.PerformLayout();
            panel3.ResumeLayout(false);
            panelOrders.ResumeLayout(false);
            panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel panelHeader;
        private Button btnExport;
        private Label label2;
        private Label label1;
        private Panel panelFilters;
        private ComboBox cmbTimeRange;
        private ComboBox cmbReportType;
        private TableLayoutPanel tlpInfoPanels;
        private Panel panelProfitMargin;
        private Panel panelAverageOrder;
        private Panel panel5;
        private Panel panelRevenue;
        private Panel panel3;
        private Panel panelOrders;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblRevenueAmount;
        private Label lblOrdersPercent;
        private Label lblOrdersAmount;
        private Label lblAvgOrderPercent;
        private Label lblAvgOrderAmount;
        private Label lblRevenuePercent;
        private Label lblProfitPercent;
        private Label lblProfitAmount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private DataGridView dgvReport;
    }
}

