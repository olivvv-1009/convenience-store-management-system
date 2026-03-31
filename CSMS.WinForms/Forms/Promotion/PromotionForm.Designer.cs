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
            label1 = new Label();
            createPromo = new Button();
            panel1 = new Panel();
            dgvPromotions = new DataGridView();
            refreshBtn = new Button();
            editBtn = new Button();
            activateBtn = new Button();
            deactivateBtn = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(745, 60);
            label1.TabIndex = 0;
            label1.Text = "Promotion";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createPromo
            // 
            createPromo.BackColor = Color.Blue;
            createPromo.Dock = DockStyle.Left;
            createPromo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPromo.ForeColor = SystemColors.ButtonHighlight;
            createPromo.Location = new Point(3, 9);
            createPromo.Margin = new Padding(3, 4, 3, 4);
            createPromo.Name = "createPromo";
            createPromo.Size = new Size(188, 41);
            createPromo.TabIndex = 1;
            createPromo.Text = "+ Create";
            createPromo.UseVisualStyleBackColor = false;
            createPromo.Click += createPromo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvPromotions);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(745, 444);
            panel1.TabIndex = 2;
            // 
            // dgvPromotions
            // 
            dgvPromotions.AllowUserToAddRows = false;
            dgvPromotions.AllowUserToDeleteRows = false;
            dgvPromotions.BackgroundColor = SystemColors.ControlLightLight;
            dgvPromotions.ColumnHeadersHeight = 29;
            dgvPromotions.Dock = DockStyle.Fill;
            dgvPromotions.Location = new Point(15, 15);
            dgvPromotions.MultiSelect = false;
            dgvPromotions.Name = "dgvPromotions";
            dgvPromotions.ReadOnly = true;
            dgvPromotions.RowHeadersVisible = false;
            dgvPromotions.RowHeadersWidth = 51;
            dgvPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotions.Size = new Size(715, 414);
            dgvPromotions.TabIndex = 0;
            // 
            // refreshBtn
            // 
            refreshBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(28, 13);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(132, 34);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Dock = DockStyle.Left;
            editBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(28, 63);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(132, 36);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // activateBtn
            // 
            activateBtn.Dock = DockStyle.Left;
            activateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activateBtn.Location = new Point(28, 113);
            activateBtn.Name = "activateBtn";
            activateBtn.Size = new Size(132, 34);
            activateBtn.TabIndex = 3;
            activateBtn.Text = "Activate";
            activateBtn.UseVisualStyleBackColor = true;
            activateBtn.Click += activateBtn_Click;
            // 
            // deactivateBtn
            // 
            deactivateBtn.Dock = DockStyle.Left;
            deactivateBtn.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deactivateBtn.Location = new Point(28, 163);
            deactivateBtn.Name = "deactivateBtn";
            deactivateBtn.Size = new Size(132, 34);
            deactivateBtn.TabIndex = 4;
            deactivateBtn.Text = "Deactivate";
            deactivateBtn.UseVisualStyleBackColor = true;
            deactivateBtn.Click += deactivateBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 512);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(951, 512);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel2.Controls.Add(refreshBtn, 1, 1);
            tableLayoutPanel2.Controls.Add(editBtn, 1, 3);
            tableLayoutPanel2.Controls.Add(activateBtn, 1, 5);
            tableLayoutPanel2.Controls.Add(deactivateBtn, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(754, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 446);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(createPromo, 0, 1);
            tableLayoutPanel3.Location = new Point(754, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(194, 54);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PromotionForm";
            Size = new Size(951, 512);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
		private Button createPromo;
		private Panel panel1;
        private Panel panel2;
        private DataGridView dgvPromotions;
        private Button refreshBtn;
        private Button editBtn;
        private Button activateBtn;
        private Button deactivateBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
