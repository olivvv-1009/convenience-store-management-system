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
            label1 = new Label();
            dgvMembers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 77);
            label1.TabIndex = 0;
            label1.Text = "Customer ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(3, 80);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(772, 493);
            dgvMembers.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLightLight;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(184, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Member";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlLightLight;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(3, 53);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(184, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Member";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Member";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLightLight;
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(3, 103);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(184, 34);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 576);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.0493851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.95061731F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMembers, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3680553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.63194F));
            tableLayoutPanel1.Size = new Size(1006, 576);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 6);
            tableLayoutPanel2.Controls.Add(btnRefresh, 0, 4);
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(813, 80);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(190, 493);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Size = new Size(1006, 576);
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvMembers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
