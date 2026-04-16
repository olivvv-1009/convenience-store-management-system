namespace CSMS.WinForms.Forms.Promotion
{
	partial class PromotionForm
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
            tblMain = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnAddPromotion = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            dgvPromotions = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDiscount = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colStart = new DataGridViewTextBoxColumn();
            colEnd = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblActive = new Label();
            lblStatsTitle = new Label();
            tblMain.SuspendLayout();
            tblHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblHeader, 0, 0);
            tblMain.Controls.Add(panel3, 0, 1);
            tblMain.Controls.Add(dgvPromotions, 0, 2);
            tblMain.Controls.Add(tableLayoutPanel1, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblMain.Size = new Size(951, 545);
            tblMain.TabIndex = 0;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblHeader.Controls.Add(panel1, 0, 0);
            tblHeader.Controls.Add(panel2, 1, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(3, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.Size = new Size(945, 94);
            tblHeader.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 88);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(348, 22);
            label2.TabIndex = 1;
            label2.Text = "Create and manage promotional campaigns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 29);
            label1.TabIndex = 0;
            label1.Text = "Promotion And Discount Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddPromotion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(475, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 88);
            panel2.TabIndex = 1;
            // 
            // btnAddPromotion
            // 
            btnAddPromotion.BackColor = SystemColors.HotTrack;
            btnAddPromotion.FlatStyle = FlatStyle.Popup;
            btnAddPromotion.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPromotion.ForeColor = SystemColors.ButtonHighlight;
            btnAddPromotion.Location = new Point(299, 18);
            btnAddPromotion.Name = "btnAddPromotion";
            btnAddPromotion.Size = new Size(165, 53);
            btnAddPromotion.TabIndex = 0;
            btnAddPromotion.Text = "Create Promotion";
            btnAddPromotion.UseVisualStyleBackColor = false;
            btnAddPromotion.Click += btnAddPromotion_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 79);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 43);
            label4.Name = "label4";
            label4.Size = new Size(442, 22);
            label4.TabIndex = 2;
            label4.Text = "Manage all promotional campaigns and discount codes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 14);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 2;
            label3.Text = "Active Promotions";
            // 
            // dgvPromotions
            // 
            dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotions.BackgroundColor = Color.White;
            dgvPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotions.Columns.AddRange(new DataGridViewColumn[] { colCode, colName, colDiscount, colType, colStart, colEnd, colStatus, colEdit });
            dgvPromotions.Dock = DockStyle.Fill;
            dgvPromotions.Location = new Point(3, 188);
            dgvPromotions.Name = "dgvPromotions";
            dgvPromotions.RowHeadersWidth = 51;
            dgvPromotions.Size = new Size(945, 210);
            dgvPromotions.TabIndex = 2;
            dgvPromotions.CellContentClick += dgvPromotions_CellClick;
            // 
            // colCode
            // 
            colCode.HeaderText = "Code";
            colCode.MinimumWidth = 6;
            colCode.Name = "colCode";
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colDiscount
            // 
            colDiscount.HeaderText = "Discount";
            colDiscount.MinimumWidth = 6;
            colDiscount.Name = "colDiscount";
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            // 
            // colStart
            // 
            colStart.HeaderText = "Start Date";
            colStart.MinimumWidth = 6;
            colStart.Name = "colStart";
            // 
            // colEnd
            // 
            colEnd.HeaderText = "End Date";
            colEnd.MinimumWidth = 6;
            colEnd.Name = "colEnd";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Action";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 404);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(945, 138);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDiscount);
            panel4.Controls.Add(lblTotal);
            panel4.Controls.Add(lblActive);
            panel4.Controls.Add(lblStatsTitle);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 132);
            panel4.TabIndex = 0;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(30, 110);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(210, 22);
            lblDiscount.TabIndex = 6;
            lblDiscount.Text = "Total Discount Given: $0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(30, 76);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(167, 22);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Promotions: 0";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActive.Location = new Point(30, 44);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(179, 22);
            lblActive.TabIndex = 4;
            lblActive.Text = "Active Promotions: 0";
            // 
            // lblStatsTitle
            // 
            lblStatsTitle.AutoSize = true;
            lblStatsTitle.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatsTitle.Location = new Point(30, 9);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(212, 25);
            lblStatsTitle.TabIndex = 3;
            lblStatsTitle.Text = "Promotion Statistics";
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PromotionForm";
            Size = new Size(951, 545);
            Load += PromotionManagementForm_Load;
            tblMain.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblHeader;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnAddPromotion;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private DataGridView dgvPromotions;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colStart;
        private DataGridViewTextBoxColumn colEnd;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colEdit;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Label lblActive;
        private Label lblStatsTitle;
        private Label lblDiscount;
        private Label lblTotal;
    }
}
