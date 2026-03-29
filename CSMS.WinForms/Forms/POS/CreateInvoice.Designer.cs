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
            pnlContent = new FlowLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            discount = new Label();
            member = new Label();
            pnlCartArea = new Panel();
            lblEmptyCart = new Label();
            flowCartItems = new Panel();
            txtMemberPhone = new TextBox();
            lblCustomerName = new Label();
            checkout = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            cash = new Button();
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            total1 = new Label();
            lbltotal = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            lblsubtotal = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtPromo = new TextBox();
            btnCheck = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            pnlCartArea.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(851, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(pnlContent, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8534288F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2968454F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 78.8497238F));
            tableLayoutPanel2.Size = new Size(547, 623);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(541, 67);
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
            tableLayoutPanel3.Location = new Point(3, 70);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(541, 58);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Search
            // 
            Search.Dock = DockStyle.Fill;
            Search.Location = new Point(489, 3);
            Search.Name = "Search";
            Search.Size = new Size(49, 52);
            Search.TabIndex = 0;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search products...";
            textBox1.Size = new Size(480, 30);
            textBox1.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Location = new Point(3, 134);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(541, 486);
            pnlContent.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(556, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 623);
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
            tableLayoutPanel4.Controls.Add(pnlCartArea, 0, 1);
            tableLayoutPanel4.Controls.Add(txtMemberPhone, 0, 5);
            tableLayoutPanel4.Controls.Add(lblCustomerName, 0, 6);
            tableLayoutPanel4.Controls.Add(checkout, 0, 12);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 11);
            tableLayoutPanel4.Controls.Add(label6, 0, 10);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 9);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 8);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 7);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 13;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.9145093F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30.6788235F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93588352F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93588352F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93588352F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 5.59988928F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.08921337F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.43502855F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 6.916306F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.472475F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.086104F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(292, 623);
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
            label2.Size = new Size(286, 42);
            label2.TabIndex = 0;
            label2.Text = "Current Invoice";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 208);
            label3.Name = "label3";
            label3.Size = new Size(286, 32);
            label3.TabIndex = 2;
            label3.Text = "Discount ";
            // 
            // discount
            // 
            discount.AutoSize = true;
            discount.Dock = DockStyle.Fill;
            discount.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount.Location = new Point(3, 240);
            discount.Name = "discount";
            discount.Size = new Size(286, 32);
            discount.TabIndex = 3;
            discount.Text = "0";
            // 
            // member
            // 
            member.AutoSize = true;
            member.Dock = DockStyle.Fill;
            member.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            member.Location = new Point(3, 272);
            member.Name = "member";
            member.Size = new Size(286, 32);
            member.TabIndex = 4;
            member.Text = "Member Number";
            // 
            // pnlCartArea
            // 
            pnlCartArea.Controls.Add(lblEmptyCart);
            pnlCartArea.Controls.Add(flowCartItems);
            pnlCartArea.Dock = DockStyle.Fill;
            pnlCartArea.Location = new Point(3, 45);
            pnlCartArea.Name = "pnlCartArea";
            pnlCartArea.Size = new Size(286, 160);
            pnlCartArea.TabIndex = 12;
            // 
            // lblEmptyCart
            // 
            lblEmptyCart.Dock = DockStyle.Top;
            lblEmptyCart.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmptyCart.ForeColor = SystemColors.ControlDarkDark;
            lblEmptyCart.Location = new Point(0, 0);
            lblEmptyCart.Name = "lblEmptyCart";
            lblEmptyCart.Size = new Size(286, 69);
            lblEmptyCart.TabIndex = 0;
            lblEmptyCart.Text = "Cart is empty";
            lblEmptyCart.TextAlign = ContentAlignment.BottomCenter;
            // 
            // flowCartItems
            // 
            flowCartItems.AutoScroll = true;
            flowCartItems.Dock = DockStyle.Fill;
            flowCartItems.Location = new Point(0, 0);
            flowCartItems.Name = "flowCartItems";
            flowCartItems.Size = new Size(286, 160);
            flowCartItems.TabIndex = 1;
            // 
            // txtMemberPhone
            // 
            txtMemberPhone.Dock = DockStyle.Fill;
            txtMemberPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemberPhone.Location = new Point(3, 307);
            txtMemberPhone.Name = "txtMemberPhone";
            txtMemberPhone.Size = new Size(286, 30);
            txtMemberPhone.TabIndex = 13;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Dock = DockStyle.Fill;
            lblCustomerName.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(3, 334);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(286, 38);
            lblCustomerName.TabIndex = 14;
            lblCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkout
            // 
            checkout.Dock = DockStyle.Right;
            checkout.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkout.Location = new Point(152, 581);
            checkout.Name = "checkout";
            checkout.Size = new Size(137, 39);
            checkout.TabIndex = 1;
            checkout.Text = "Checkout";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += checkout_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(cash, 0, 0);
            tableLayoutPanel8.Controls.Add(button3, 2, 0);
            tableLayoutPanel8.Controls.Add(button2, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 540);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(286, 35);
            tableLayoutPanel8.TabIndex = 11;
            // 
            // cash
            // 
            cash.Dock = DockStyle.Fill;
            cash.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cash.Location = new Point(3, 3);
            cash.Name = "cash";
            cash.Size = new Size(89, 29);
            cash.TabIndex = 0;
            cash.Text = "Cash";
            cash.UseVisualStyleBackColor = true;
            cash.Click += cash_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(193, 3);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 2;
            button3.Text = "E-Wallet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(98, 3);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 1;
            button2.Text = "Bank";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 494);
            label6.Name = "label6";
            label6.Size = new Size(286, 43);
            label6.TabIndex = 9;
            label6.Text = "Payment Method";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(total1, 0, 0);
            tableLayoutPanel6.Controls.Add(lbltotal, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 452);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(286, 39);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // total1
            // 
            total1.AutoSize = true;
            total1.Dock = DockStyle.Fill;
            total1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total1.Location = new Point(3, 0);
            total1.Name = "total1";
            total1.Size = new Size(137, 39);
            total1.TabIndex = 0;
            total1.Text = "Total";
            total1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Dock = DockStyle.Fill;
            lbltotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(146, 0);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(137, 39);
            lbltotal.TabIndex = 1;
            lbltotal.Text = "0";
            lbltotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(lblsubtotal, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 415);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(286, 31);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 31);
            label5.TabIndex = 0;
            label5.Text = "Subtotal";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Dock = DockStyle.Fill;
            lblsubtotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsubtotal.Location = new Point(146, 0);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(137, 31);
            lblsubtotal.TabIndex = 1;
            lblsubtotal.Text = "0";
            lblsubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.87412F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1258736F));
            tableLayoutPanel7.Controls.Add(txtPromo, 0, 0);
            tableLayoutPanel7.Controls.Add(btnCheck, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 375);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(286, 34);
            tableLayoutPanel7.TabIndex = 15;
            // 
            // txtPromo
            // 
            txtPromo.Dock = DockStyle.Fill;
            txtPromo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPromo.Location = new Point(3, 3);
            txtPromo.Name = "txtPromo";
            txtPromo.PlaceholderText = "Promotion ID";
            txtPromo.Size = new Size(211, 30);
            txtPromo.TabIndex = 15;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ActiveCaption;
            btnCheck.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = SystemColors.ActiveCaptionText;
            btnCheck.Location = new Point(220, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(63, 28);
            btnCheck.TabIndex = 16;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tableLayoutPanel1);
            Name = "CreateInvoice";
            Size = new Size(851, 629);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            pnlCartArea.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button Search;
        private TextBox textBox1;
        private FlowLayoutPanel pnlContent;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label3;
        private Label discount;
        private Label member;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private Label lblsubtotal;
        private TableLayoutPanel tableLayoutPanel6;
        private Label total1;
        private Label lbltotal;
        private Label label6;
        private Button cash;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel8;
        private Button checkout;
        private Panel pnlCartArea;
        private Label lblEmptyCart;
        private Panel flowCartItems;
        private TextBox txtMemberPhone;
        private Label lblCustomerName;
        private TextBox txtPromo;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnCheck;
    }
}
