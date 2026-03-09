namespace CSMS.WinForms.Forms.POS
{
    partial class PaymentQRForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            total = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            lblQR = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 394);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(total, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(lblQR, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.64467049F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9137058F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 68.527916F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9137058F));
            tableLayoutPanel2.Size = new Size(794, 394);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(788, 38);
            label2.TabIndex = 0;
            label2.Text = "Số tiền cần thanh toán:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Dock = DockStyle.Fill;
            total.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = SystemColors.ActiveCaptionText;
            total.Location = new Point(3, 38);
            total.Name = "total";
            total.Size = new Size(788, 43);
            total.TabIndex = 1;
            total.Text = "label3";
            total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel3.Controls.Add(btnConfirm, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 354);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(788, 37);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Left;
            btnCancel.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 31);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Right;
            btnConfirm.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(691, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 31);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 50);
            label1.TabIndex = 1;
            label1.Text = "THANH TOÁN QR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQR
            // 
            lblQR.AutoSize = true;
            lblQR.Dock = DockStyle.Fill;
            lblQR.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQR.Location = new Point(3, 81);
            lblQR.Name = "lblQR";
            lblQR.Size = new Size(788, 270);
            lblQR.TabIndex = 4;
            lblQR.Text = "label3";
            lblQR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentQRForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PaymentQRForm";
            Text = "PaymentQRForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label total;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblQR;
    }
}