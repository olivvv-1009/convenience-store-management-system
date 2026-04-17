namespace CSMS.WinForms.Forms.Employees
{
    partial class EmployeeForm
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
            btnAddEmployee = new Button();
            panellbl = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblTotal = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblActive = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblAdmins = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lblStaff = new Label();
            label9 = new Label();
            panel5 = new Panel();
            dgvEmployees = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            HireDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Action = new DataGridViewButtonColumn();
            txtSearch = new TextBox();
            label4 = new Label();
            tblMain.SuspendLayout();
            panellbl.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(btnAddEmployee, 3, 0);
            tblMain.Controls.Add(panellbl, 0, 0);
            tblMain.Controls.Add(panel1, 0, 1);
            tblMain.Controls.Add(panel2, 1, 1);
            tblMain.Controls.Add(panel3, 2, 1);
            tblMain.Controls.Add(panel4, 3, 1);
            tblMain.Controls.Add(panel5, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(10);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 99F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1077, 612);
            tblMain.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Anchor = AnchorStyles.None;
            btnAddEmployee.AutoSize = true;
            btnAddEmployee.BackColor = SystemColors.HotTrack;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = SystemColors.HighlightText;
            btnAddEmployee.Location = new Point(854, 33);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(160, 52);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "+ Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // panellbl
            // 
            tblMain.SetColumnSpan(panellbl, 2);
            panellbl.Controls.Add(label2);
            panellbl.Controls.Add(label1);
            panellbl.Location = new Point(13, 13);
            panellbl.Name = "panellbl";
            panellbl.Size = new Size(522, 93);
            panellbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(342, 28);
            label2.TabIndex = 1;
            label2.Text = "Manage staff accounts and permissions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(13, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 90);
            panel1.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(104, 41);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 38);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 13);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 0;
            label3.Text = "Total Employees";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(lblActive);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(277, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 90);
            panel2.TabIndex = 3;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActive.Location = new Point(111, 41);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(33, 38);
            lblActive.TabIndex = 1;
            lblActive.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 13);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 0;
            label5.Text = "Active";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(lblAdmins);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(541, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 90);
            panel3.TabIndex = 4;
            // 
            // lblAdmins
            // 
            lblAdmins.AutoSize = true;
            lblAdmins.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmins.Location = new Point(112, 41);
            lblAdmins.Name = "lblAdmins";
            lblAdmins.Size = new Size(33, 38);
            lblAdmins.TabIndex = 1;
            lblAdmins.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(90, 13);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 0;
            label7.Text = "Admins";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(lblStaff);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(805, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 90);
            panel4.TabIndex = 5;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaff.Location = new Point(113, 41);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(33, 38);
            lblStaff.TabIndex = 1;
            lblStaff.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(104, 13);
            label9.Name = "label9";
            label9.Size = new Size(51, 28);
            label9.TabIndex = 0;
            label9.Text = "Staff";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            tblMain.SetColumnSpan(panel5, 4);
            panel5.Controls.Add(dgvEmployees);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(13, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(1051, 391);
            panel5.TabIndex = 6;
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.BackgroundColor = Color.FloralWhite;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { Code, Name, Email, Role, HireDate, Status, Edit, Action });
            dgvEmployees.Location = new Point(0, 95);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(1051, 293);
            dgvEmployees.TabIndex = 2;
            dgvEmployees.CellContentClick += dgvEmployees_CellClick;
            // 
            // Code
            // 
            Code.HeaderText = "Employee Code";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Full Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 125;
            // 
            // HireDate
            // 
            HireDate.HeaderText = "Hire Date";
            HireDate.MinimumWidth = 6;
            HireDate.Name = "HireDate";
            HireDate.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Text = "Lock / Unlock";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 125;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(913, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search employees...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 0;
            label4.Text = "Employee List";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            //Name = "EmployeeForm";
            Size = new Size(1077, 612);
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            panellbl.ResumeLayout(false);
            panellbl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnAddEmployee;
        private Panel panellbl;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label lblTotal;
        private Panel panel2;
        private Label lblActive;
        private Label label5;
        private Panel panel3;
        private Label lblAdmins;
        private Label label7;
        private Panel panel4;
        private Label lblStaff;
        private Label label9;
        private Panel panel5;
        private Label label4;
        private DataGridView dgvEmployees;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn HireDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Action;
    }
}
