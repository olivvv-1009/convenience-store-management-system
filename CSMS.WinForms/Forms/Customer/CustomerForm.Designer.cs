namespace CSMS.WinForms.Forms.Customer
{
    partial class CustomerForm
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
            tlpMain = new TableLayoutPanel();
            btnAddCustomer = new Button();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            lblTotalSpent = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblTotalPoints = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblTotalCustomers = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            txtSearch = new TextBox();
            dgvCustomer = new DataGridView();
            CustomerId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Points = new DataGridViewTextBoxColumn();
            TotalSpent = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel6 = new Panel();
            tlpMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.AutoSize = true;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpMain.Controls.Add(panel5, 0, 2);
            tlpMain.Controls.Add(dgvCustomer, 0, 3);
            tlpMain.Controls.Add(tableLayoutPanel2, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1067, 632);
            tlpMain.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.HotTrack;
            btnAddCustomer.FlatStyle = FlatStyle.Popup;
            btnAddCustomer.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.ButtonHighlight;
            btnAddCustomer.Location = new Point(342, 18);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(189, 38);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(389, 22);
            label2.TabIndex = 1;
            label2.Text = "Manage customer information and loyalty points";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1061, 94);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(lblTotalSpent);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(709, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 88);
            panel4.TabIndex = 2;
            // 
            // lblTotalSpent
            // 
            lblTotalSpent.BackColor = SystemColors.ActiveCaption;
            lblTotalSpent.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSpent.Location = new Point(83, 43);
            lblTotalSpent.Name = "lblTotalSpent";
            lblTotalSpent.Size = new Size(196, 33);
            lblTotalSpent.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 0);
            label5.Name = "label5";
            label5.Size = new Size(297, 33);
            label5.TabIndex = 5;
            label5.Text = "Total Customer Spending";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(lblTotalPoints);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(356, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(347, 88);
            panel3.TabIndex = 1;
            // 
            // lblTotalPoints
            // 
            lblTotalPoints.BackColor = SystemColors.ActiveCaption;
            lblTotalPoints.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPoints.Location = new Point(80, 43);
            lblTotalPoints.Name = "lblTotalPoints";
            lblTotalPoints.Size = new Size(196, 33);
            lblTotalPoints.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 33);
            label4.TabIndex = 4;
            label4.Text = "Total Points Issued";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lblTotalCustomers);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 88);
            panel2.TabIndex = 0;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.BackColor = SystemColors.ActiveCaption;
            lblTotalCustomers.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(68, 43);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(196, 33);
            lblTotalCustomers.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 33);
            label3.TabIndex = 3;
            label3.Text = "Total Customers";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtSearch);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 183);
            panel5.Name = "panel5";
            panel5.Size = new Size(1061, 74);
            panel5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 3;
            label6.Text = "Customer List";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(14, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(845, 30);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search by name, code, or phone ...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { CustomerId, FullName, Phone, Points, TotalSpent, Edit, Delete });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(3, 263);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(1061, 366);
            dgvCustomer.TabIndex = 4;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // CustomerId
            // 
            CustomerId.DataPropertyName = "MemberId";
            CustomerId.HeaderText = "Customer Id";
            CustomerId.MinimumWidth = 6;
            CustomerId.Name = "CustomerId";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // Points
            // 
            Points.DataPropertyName = "Points";
            Points.HeaderText = "Points";
            Points.MinimumWidth = 6;
            Points.Name = "Points";
            // 
            // TotalSpent
            // 
            TotalSpent.DataPropertyName = "TotalSpent";
            TotalSpent.HeaderText = "Total Spent";
            TotalSpent.MinimumWidth = 6;
            TotalSpent.Name = "TotalSpent";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel6, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1061, 74);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 68);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAddCustomer);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(533, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(525, 68);
            panel6.TabIndex = 1;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Size = new Size(1067, 632);
            Load += CustomerForm_Load;
            tlpMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Label label2;
        private Label label1;
        private Button btnAddCustomer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblTotalSpent;
        private Label label5;
        private Label lblTotalPoints;
        private Label label4;
        private Label lblTotalCustomers;
        private Label label3;
        private Panel panel5;
        private Label label6;
        private TextBox txtSearch;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Points;
        private DataGridViewTextBoxColumn TotalSpent;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel6;
    }
}
