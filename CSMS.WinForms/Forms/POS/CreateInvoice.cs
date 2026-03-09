using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CSMS.Models;
using CSMS.Services;
using convenience_store_management_system.Models;

namespace CSMS.WinForms.Forms.POS
{
    public partial class CreateInvoice : UserControl
    {
        private ProductService productService = new ProductService();
        private InvoiceService invoiceService = new InvoiceService();
        private List<CartItem> cartItems = new List<CartItem>();
        private string paymentMethod = "Cash";
        private decimal manualDiscount = 0;

        public CreateInvoice()
        {
            InitializeComponent();
            flowCartItems.BringToFront();
            pnlContent.Resize += (s, e) => ReloadProductLayout(); // ⭐ chỉ gắn 1 lần
            LoadProducts();
        }

        // ================= LOAD SẢN PHẨM =================
        private void LoadProducts()
        {
            var products = productService.GetProductsForPOS();

            pnlContent.Controls.Clear();
            pnlContent.AutoScroll = true;

            foreach (var p in products)
            {
                ProductCard card = new ProductCard(p);
                card.Width = 300;
                card.Height = 180;
                card.Margin = new Padding(15);
                card.OnProductSelected += AddToCart;
                pnlContent.Controls.Add(card);
            }

            ReloadProductLayout(); // ⭐ tránh card bị co nhỏ
        }

        // ================= THÊM VÀO GIỎ =================
        private void AddToCart(ProductPOS product)
        {
            // Nếu đã có → tăng số lượng
            foreach (Control ctrl in flowCartItems.Controls)
            {
                if (ctrl is CartItemControl item && item.ProductId == product.ProductId)
                {
                    item.IncreaseQuantity();

                    var cartItem = cartItems.First(x => x.ProductId == product.ProductId);
                    cartItem.Quantity = item.Quantity;

                    UpdateSubTotal();
                    return;
                }
            }

            // Nếu chưa có → thêm mới
            CartItemControl newItem = new CartItemControl(product);
            newItem.OnRemove += RemoveCartItem;
            newItem.OnQuantityChanged += CartItemQuantityChanged;

            flowCartItems.Controls.Add(newItem);
            flowCartItems.Controls.SetChildIndex(newItem, 0);

            cartItems.Add(new CartItem
            {
                ProductId = product.ProductId,
                Name = product.ProductName,
                Price = product.Price,
                Quantity = 1
            });

            UpdateSubTotal();
            UpdateCartStatus();
        }

        // ================= CẬP NHẬT KHI ĐỔI SỐ LƯỢNG =================
        private void CartItemQuantityChanged(CartItemControl item)
        {
            var cartItem = cartItems.First(x => x.ProductId == item.ProductId);
            cartItem.Quantity = item.Quantity;
            UpdateSubTotal();
        }

        // ================= XÓA KHỎI GIỎ =================
        private void RemoveCartItem(CartItemControl item)
        {
            flowCartItems.Controls.Remove(item);
            cartItems.RemoveAll(x => x.ProductId == item.ProductId);

            UpdateSubTotal();
            UpdateCartStatus();
        }

        // ================= TỔNG TIỀN =================
        private void UpdateSubTotal()
        {
            decimal subtotal = cartItems.Sum(x => x.Price * x.Quantity);
            lblsubtotal.Text = "$" + subtotal.ToString("0.00");
            UpdateTotal(subtotal);
        }

        private void UpdateTotal(decimal subtotal)
        {
            if (manualDiscount > subtotal)
                manualDiscount = subtotal;

            lbltotal.Text = "$" + (subtotal - manualDiscount).ToString("0.00");
        }

        private decimal GetCurrentTotal()
        {
            decimal subtotal = cartItems.Sum(x => x.Price * x.Quantity);
            if (manualDiscount > subtotal) manualDiscount = subtotal;
            return subtotal - manualDiscount;
        }

        // ================= TRẠNG THÁI GIỎ =================
        private void UpdateCartStatus()
        {
            lblEmptyCart.Visible = flowCartItems.Controls.Count == 0;
        }

        // ================= THANH TOÁN =================
        private void checkout_Click(object sender, EventArgs e)
        {
            if (!cartItems.Any())
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            decimal totalAmount = GetCurrentTotal();

            if (paymentMethod == "Cash") ProcessInvoice();
            else if (paymentMethod == "Bank") ShowQRCode("bank", totalAmount);
            else if (paymentMethod == "EWallet") ShowQRCode("ewallet", totalAmount);
        }

        private void ShowQRCode(string type, decimal amount)
        {
            PaymentQRForm qrForm = new PaymentQRForm(type, amount);
            qrForm.ShowDialog();
            if (qrForm.PaymentConfirmed) ProcessInvoice();
        }

        private void ProcessInvoice()
        {
            invoiceService.CreateInvoice(cartItems); // ⭐ trừ kho ở đây

            MessageBox.Show("Thanh toán thành công!");

            cartItems.Clear();
            RefreshCartUI();
            LoadProducts(); // ⭐ load lại stock mới
        }

        private void RefreshCartUI()
        {
            flowCartItems.Controls.Clear();
            lblsubtotal.Text = "$0.00";
            lblDiscount.Text = "$0.00";
            lbltotal.Text = "$0.00";
            UpdateCartStatus();
        }

        // ================= DISCOUNT =================
        private void lblDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblDiscount.Text.Replace(",", ""), out decimal money))
                manualDiscount = Math.Abs(money);
            else
                manualDiscount = 0;

            UpdateSubTotal();
        }

        // ================= PAYMENT METHOD =================
        private void cash_Click(object sender, EventArgs e) => paymentMethod = "Cash";
        private void button2_Click(object sender, EventArgs e) => paymentMethod = "Bank";
        private void button3_Click(object sender, EventArgs e) => paymentMethod = "EWallet";

        // ================= LAYOUT =================
        private void ReloadProductLayout()
        {
            int panelWidth = pnlContent.ClientSize.Width;
            int cardWidth = (panelWidth / 2) - 30;

            foreach (Control ctrl in pnlContent.Controls)
                if (ctrl is ProductCard card)
                    card.Width = cardWidth;
        }
    }
}