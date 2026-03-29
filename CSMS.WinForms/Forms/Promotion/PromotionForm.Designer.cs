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
            panel2 = new Panel();
            dgvPromotions = new DataGridView();
            refreshBtn = new Button();
            editBtn = new Button();
            activateBtn = new Button();
            deactivateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(186, 39);
            label1.TabIndex = 0;
            label1.Text = "Promotion";
            // 
            // createPromo
            // 
            createPromo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPromo.Location = new Point(674, 85);
            createPromo.Margin = new Padding(3, 4, 3, 4);
            createPromo.Name = "createPromo";
            createPromo.Size = new Size(242, 43);
            createPromo.TabIndex = 1;
            createPromo.Text = "+    Create Promotion";
            createPromo.UseVisualStyleBackColor = true;
            createPromo.Click += createPromo_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(16, 85);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 412);
            panel1.TabIndex = 2;
            // 
            // dgvPromotions
            // 
            dgvPromotions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPromotions.Location = new Point(8, 8);
            dgvPromotions.Name = "dgvPromotions";
            dgvPromotions.Size = new Size(620, 360);
            dgvPromotions.ReadOnly = true;
            dgvPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotions.AutoGenerateColumns = false;
            dgvPromotions.MultiSelect = false;
            dgvPromotions.AllowUserToAddRows = false;
            dgvPromotions.AllowUserToDeleteRows = false;
            dgvPromotions.RowHeadersVisible = false;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(8, 376);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 28);
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(92, 376);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 28);
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // activateBtn
            // 
            activateBtn.Location = new Point(176, 376);
            activateBtn.Name = "activateBtn";
            activateBtn.Size = new Size(100, 28);
            activateBtn.Text = "Activate";
            activateBtn.UseVisualStyleBackColor = true;
            activateBtn.Click += activateBtn_Click;
            // 
            // deactivateBtn
            // 
            deactivateBtn.Location = new Point(282, 376);
            deactivateBtn.Name = "deactivateBtn";
            deactivateBtn.Size = new Size(100, 28);
            deactivateBtn.Text = "Deactivate";
            deactivateBtn.UseVisualStyleBackColor = true;
            deactivateBtn.Click += deactivateBtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 512);
            panel2.TabIndex = 3;
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            panel1.Controls.Add(dgvPromotions);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(editBtn);
            panel1.Controls.Add(activateBtn);
            panel1.Controls.Add(deactivateBtn);
            Controls.Add(panel1);
            Controls.Add(createPromo);
            Controls.Add(label1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PromotionForm";
            Size = new Size(951, 512);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
