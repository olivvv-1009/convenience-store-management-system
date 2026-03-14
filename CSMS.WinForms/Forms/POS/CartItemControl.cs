using System;
using System.Windows.Forms;
using CSMS.Models;
using convenience_store_management_system.Models;

namespace CSMS.WinForms.Forms.POS
{
    public partial class CartItemControl : UserControl
    {
        public string ProductId;
        public int quantity = 1;
        private decimal unitPrice;

        public event Action<CartItemControl>? OnRemove;
        public event Action<CartItemControl>? OnQuantityChanged;

        public int Quantity => quantity;

        public CartItemControl(ProductPOS p)
        {
            InitializeComponent();

            ProductId = p.ProductId;
            unitPrice = p.Price;

            name.Text = p.ProductName;
            number.Text = "x1";

            UpdateSubTotalPrice();
            this.Dock = DockStyle.Top;
            this.Height = 60;
            this.Margin = new Padding(0);
        }

        public void IncreaseQuantity()
        {
            quantity++;
            number.Text = "x" + quantity;
            UpdateSubTotalPrice();
            OnQuantityChanged?.Invoke(this);
        }

        private void UpdateSubTotalPrice()
        {
            decimal total = quantity * unitPrice;
            price.Text = "$" + total.ToString("0.00");
        }

        public decimal GetTotalPrice()
        {
            return quantity * unitPrice;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = this.Parent?.ClientSize.Width ?? this.Width;
        }

        private void tang_Click(object sender, EventArgs e)
        {
            quantity++;
            number.Text = "x" + quantity;
            UpdateSubTotalPrice();
            OnQuantityChanged?.Invoke(this);
        }

        private void giam_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                number.Text = "x" + quantity;
                UpdateSubTotalPrice();
                OnQuantityChanged?.Invoke(this);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            OnRemove?.Invoke(this);
        }
    }
}