namespace CSMS.WinForms.Forms.Inventory
{
    partial class StockList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlTable = new Panel();
            pnlAlert = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pnlTable.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlTable, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlAlert, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Size = new Size(717, 411);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTable
            // 
            pnlTable.BackColor = SystemColors.ControlLightLight;
            pnlTable.Controls.Add(tableLayoutPanel2);
            pnlTable.Dock = DockStyle.Fill;
            pnlTable.Location = new Point(3, 3);
            pnlTable.Name = "pnlTable";
            pnlTable.Size = new Size(711, 285);
            pnlTable.TabIndex = 0;
            // 
            // pnlAlert
            // 
            pnlAlert.BackColor = Color.FromArgb(255, 224, 192);
            pnlAlert.Dock = DockStyle.Fill;
            pnlAlert.Location = new Point(3, 294);
            pnlAlert.Name = "pnlAlert";
            pnlAlert.Size = new Size(711, 114);
            pnlAlert.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(711, 285);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // StockList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "StockList";
            Size = new Size(717, 411);
            tableLayoutPanel1.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlTable;
        private Panel pnlAlert;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
    }
}
