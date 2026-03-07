namespace CSMS.WinForms.Forms.POS
{
    partial class CartItemControl
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            giam = new Button();
            tang = new Button();
            delete = new Button();
            number = new Label();
            price = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 60);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(giam, 0, 0);
            tableLayoutPanel1.Controls.Add(tang, 2, 0);
            tableLayoutPanel1.Controls.Add(delete, 3, 0);
            tableLayoutPanel1.Controls.Add(number, 1, 0);
            tableLayoutPanel1.Controls.Add(price, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(300, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // giam
            // 
            giam.Dock = DockStyle.Fill;
            giam.Location = new Point(3, 3);
            giam.Name = "giam";
            giam.Size = new Size(54, 54);
            giam.TabIndex = 0;
            giam.Text = "-";
            giam.UseVisualStyleBackColor = true;
            // 
            // tang
            // 
            tang.Dock = DockStyle.Fill;
            tang.Location = new Point(123, 3);
            tang.Name = "tang";
            tang.Size = new Size(54, 54);
            tang.TabIndex = 1;
            tang.Text = "+";
            tang.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Dock = DockStyle.Fill;
            delete.Location = new Point(183, 3);
            delete.Name = "delete";
            delete.Size = new Size(54, 54);
            delete.TabIndex = 2;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Dock = DockStyle.Fill;
            number.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            number.Location = new Point(63, 0);
            number.Name = "number";
            number.Size = new Size(54, 60);
            number.TabIndex = 3;
            number.Text = "Slg";
            number.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Dock = DockStyle.Fill;
            price.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(243, 0);
            price.Name = "price";
            price.Size = new Size(54, 60);
            price.TabIndex = 4;
            price.Text = "price";
            price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CartItemControl";
            Size = new Size(300, 60);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button giam;
        private Button tang;
        private Button delete;
        private Label number;
        private Label price;
    }
}
