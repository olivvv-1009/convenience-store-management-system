namespace CSMS.WinForms.Forms.Employees
{
    partial class EditEmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            cmbRole = new ComboBox();
            dtpHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "Edit Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 47);
            label2.Name = "label2";
            label2.Size = new Size(276, 28);
            label2.TabIndex = 1;
            label2.Text = "Update employee information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 89);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 157);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(433, 89);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 4;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 228);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 5;
            label6.Text = "Hire Date";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(337, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 42);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(521, 325);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 41);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
          
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(22, 127);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(346, 27);
            txtFullName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 27);
            txtEmail.TabIndex = 9;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(433, 126);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 10;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(22, 259);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(262, 27);
            dtpHireDate.TabIndex = 11;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(703, 401);
            Controls.Add(dtpHireDate);
            Controls.Add(cmbRole);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            Load += EditEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private DateTimePicker dtpHireDate;
    }
}