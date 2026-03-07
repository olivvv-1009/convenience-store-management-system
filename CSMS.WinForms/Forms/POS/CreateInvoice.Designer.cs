namespace CSMS.WinForms.Forms.POS
{
    partial class CreateInvoice
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            Search = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            discount = new Label();
            member = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            subtotal = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            total = new Label();
            label7 = new Label();
            label6 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            cash = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            print = new Button();
            checkout = new Button();
            pnlCartArea = new Panel();
            lblEmptyCart = new Label();
            flowCartItems = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            pnlCartArea.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(851, 483);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8534288F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2968454F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 78.8497238F));
            tableLayoutPanel2.Size = new Size(547, 477);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(541, 51);
            label1.TabIndex = 0;
            label1.Text = "Products";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(Search, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 54);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(541, 43);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Search
            // 
            Search.Dock = DockStyle.Fill;
            Search.Location = new Point(489, 3);
            Search.Name = "Search";
            Search.Size = new Size(49, 37);
            Search.TabIndex = 0;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search products...";
            textBox1.Size = new Size(480, 27);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(541, 371);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(556, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 477);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(discount, 0, 3);
            tableLayoutPanel4.Controls.Add(member, 0, 4);
            tableLayoutPanel4.Controls.Add(textBox2, 0, 5);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 6);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 7);
            tableLayoutPanel4.Controls.Add(label6, 0, 8);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 9);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 10);
            tableLayoutPanel4.Controls.Add(pnlCartArea, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 11;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.919213F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30.69705F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93941F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93941F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93941F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.60321665F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.093536F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.91921425F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93941F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.91921425F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.090909F));
            tableLayoutPanel4.Size = new Size(292, 477);
            tableLayoutPanel4.TabIndex = 0;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 37);
            label2.TabIndex = 0;
            label2.Text = "Current Invoice";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 183);
            label3.Name = "label3";
            label3.Size = new Size(286, 28);
            label3.TabIndex = 2;
            label3.Text = "Discount (%)";
            // 
            // discount
            // 
            discount.AutoSize = true;
            discount.Dock = DockStyle.Fill;
            discount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount.Location = new Point(3, 211);
            discount.Name = "discount";
            discount.Size = new Size(286, 28);
            discount.TabIndex = 3;
            discount.Text = "0";
            // 
            // member
            // 
            member.AutoSize = true;
            member.Dock = DockStyle.Fill;
            member.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            member.Location = new Point(3, 239);
            member.Name = "member";
            member.Size = new Size(286, 28);
            member.TabIndex = 4;
            member.Text = "Member Number";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(3, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 27);
            textBox2.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(subtotal, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 296);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(286, 32);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 32);
            label5.TabIndex = 0;
            label5.Text = "Subtotal";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Dock = DockStyle.Fill;
            subtotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtotal.Location = new Point(146, 0);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(137, 32);
            subtotal.TabIndex = 1;
            subtotal.Text = "0";
            subtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(total, 0, 0);
            tableLayoutPanel6.Controls.Add(label7, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 334);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(286, 31);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Dock = DockStyle.Fill;
            total.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(3, 0);
            total.Name = "total";
            total.Size = new Size(137, 31);
            total.TabIndex = 0;
            total.Text = "Total";
            total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(146, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 31);
            label7.TabIndex = 1;
            label7.Text = "0";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 368);
            label6.Name = "label6";
            label6.Size = new Size(286, 28);
            label6.TabIndex = 9;
            label6.Text = "Payment Method";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel7.Controls.Add(cash, 0, 0);
            tableLayoutPanel7.Controls.Add(button2, 1, 0);
            tableLayoutPanel7.Controls.Add(button3, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 399);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(286, 31);
            tableLayoutPanel7.TabIndex = 10;
            // 
            // cash
            // 
            cash.Dock = DockStyle.Fill;
            cash.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cash.Location = new Point(3, 3);
            cash.Name = "cash";
            cash.Size = new Size(88, 25);
            cash.TabIndex = 0;
            cash.Text = "Cash";
            cash.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(97, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 25);
            button2.TabIndex = 1;
            button2.Text = "Bank";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(191, 3);
            button3.Name = "button3";
            button3.Size = new Size(92, 25);
            button3.TabIndex = 2;
            button3.Text = "E-Wallet";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(print, 0, 0);
            tableLayoutPanel8.Controls.Add(checkout, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 436);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(286, 38);
            tableLayoutPanel8.TabIndex = 11;
            // 
            // print
            // 
            print.Dock = DockStyle.Fill;
            print.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            print.Location = new Point(3, 3);
            print.Name = "print";
            print.Size = new Size(137, 32);
            print.TabIndex = 0;
            print.Text = "Print";
            print.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            checkout.Dock = DockStyle.Fill;
            checkout.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkout.Location = new Point(146, 3);
            checkout.Name = "checkout";
            checkout.Size = new Size(137, 32);
            checkout.TabIndex = 1;
            checkout.Text = "Checkout";
            checkout.UseVisualStyleBackColor = true;
            // 
            // pnlCartArea
            // 
            pnlCartArea.Controls.Add(lblEmptyCart);
            pnlCartArea.Controls.Add(flowCartItems);
            pnlCartArea.Dock = DockStyle.Fill;
            pnlCartArea.Location = new Point(3, 40);
            pnlCartArea.Name = "pnlCartArea";
            pnlCartArea.Size = new Size(286, 140);
            pnlCartArea.TabIndex = 12;
            // 
            // lblEmptyCart
            // 
            lblEmptyCart.Dock = DockStyle.Fill;
            lblEmptyCart.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmptyCart.ForeColor = SystemColors.ControlDarkDark;
            lblEmptyCart.Location = new Point(0, 0);
            lblEmptyCart.Name = "lblEmptyCart";
            lblEmptyCart.Size = new Size(286, 140);
            lblEmptyCart.TabIndex = 0;
            lblEmptyCart.Text = "Cart is empty";
            lblEmptyCart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowCartItems
            // 
            flowCartItems.AutoScroll = true;
            flowCartItems.Dock = DockStyle.Fill;
            flowCartItems.FlowDirection = FlowDirection.TopDown;
            flowCartItems.Location = new Point(0, 0);
            flowCartItems.Name = "flowCartItems";
            flowCartItems.Size = new Size(286, 140);
            flowCartItems.TabIndex = 1;
            flowCartItems.Visible = false;
            flowCartItems.WrapContents = false;
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CreateInvoice";
            Size = new Size(851, 483);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            pnlCartArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button Search;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label3;
        private Label discount;
        private Label member;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private Label subtotal;
        private TableLayoutPanel tableLayoutPanel6;
        private Label total;
        private Label label7;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button cash;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel8;
        private Button print;
        private Button checkout;
        private Panel pnlCartArea;
        private Label lblEmptyCart;
        private FlowLayoutPanel flowCartItems;
    }
}
