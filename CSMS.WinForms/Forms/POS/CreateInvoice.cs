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
        private MemberService memberService = new MemberService();

        private List<CartItem> cartItems = new List<CartItem>();

        private string paymentMethod = "Cash";
        private decimal manualDiscount = 0;
        private int? memberId = null;

        public CreateInvoice()
        {
            InitializeComponent();

            pnlContent.Dock = DockStyle.Left;
            pnlContent.Width = 950;

            pnlContent.AutoScroll = true;
            pnlContent.WrapContents = true;
            pnlContent.FlowDirection = FlowDirection.LeftToRight;

            flowCartItems.BringToFront();

            txtMemberPhone.TextChanged += (s, e) => FindMember();

            LoadProducts();
        }

        // ================= LOAD PRODUCTS =================
        private void LoadProducts()
        {
            var products = productService.GetProductsForPOS();

            pnlContent.Controls.Clear();

            foreach (var p in products)
            {
                var posProduct = new ProductPOS
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Price = p.Price
                };

                ProductCard card = new ProductCard(posProduct);
                card.OnProductSelected += AddToCart;

                pnlContent.Controls.Add(card);
            }

            ApplyGridLayout();
        }

        // ================= GRID =================
        private void ApplyGridLayout()
        {
            int spacing = 30;
            int cardWidth = 270;

            foreach (Control ctrl in pnlContent.Controls)
            {
                if (ctrl is ProductCard card)
                {
                    card.Width = cardWidth;
                    card.Margin = new Padding(spacing / 2);
                }
            }
        }

        // ================= MEMBER =================
        private void FindMember()
        {
            string phone = txtMemberPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                memberId = null;
                lblCustomerName.Text = "N/A";
                return;
            }

            var member = memberService.GetMemberByPhone(phone);

            if (member != null)
            {
                memberId = member.MemberId;
                lblCustomerName.Text = member.FullName;
            }
            else
            {
                memberId = null;
                lblCustomerName.Text = "N/A";
            }
        }

        // ================= ADD TO CART =================
        private void AddToCart(ProductPOS product)
        {
            foreach (Control ctrl in flowCartItems.Controls)
            {
                if (ctrl is CartItemControl item && item.ProductId == product.ProductId)
                {
                    item.IncreaseQuantity();

                    var cartItem = cartItems.First(x => x.ProductId == item.ProductId);
                    cartItem.Quantity = item.Quantity;

                    UpdateSubTotal();
                    return;
                }
            }

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

        private void CartItemQuantityChanged(CartItemControl item)
        {
            var cartItem = cartItems.First(x => x.ProductId == item.ProductId);
            cartItem.Quantity = item.Quantity;

            UpdateSubTotal();
        }

        private void RemoveCartItem(CartItemControl item)
        {
            flowCartItems.Controls.Remove(item);
            cartItems.RemoveAll(x => x.ProductId == item.ProductId);

            UpdateSubTotal();
            UpdateCartStatus();
        }

        // ================= CALCULATION =================
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

            decimal total = subtotal - manualDiscount;
            lbltotal.Text = "$" + total.ToString("0.00");
        }

        private decimal GetCurrentTotal()
        {
            decimal subtotal = cartItems.Sum(x => x.Price * x.Quantity);

            if (manualDiscount > subtotal)
                manualDiscount = subtotal;

            return subtotal - manualDiscount;
        }

        // ================= CART STATUS =================
        private void UpdateCartStatus()
        {
            lblEmptyCart.Visible = flowCartItems.Controls.Count == 0;
        }

        // ================= CHECKOUT =================
        private void checkout_Click(object sender, EventArgs e)
        {
            if (!cartItems.Any())
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            decimal totalAmount = GetCurrentTotal();

            if (paymentMethod == "Cash")
                ProcessInvoice();
            else if (paymentMethod == "Bank")
                ShowQRCode("bank", totalAmount);
            else if (paymentMethod == "EWallet")
                ShowQRCode("ewallet", totalAmount);
        }

        private void ShowQRCode(string type, decimal amount)
        {
            PaymentQRForm qrForm = new PaymentQRForm(type, amount);
            qrForm.ShowDialog();

            if (qrForm.PaymentConfirmed)
                ProcessInvoice();
        }

        // ================= CREATE INVOICE =================
        private void ProcessInvoice()
        {
            invoiceService.CreateInvoice(cartItems, paymentMethod, memberId);

            MessageBox.Show("Thanh toán thành công!");

            cartItems.Clear();

            RefreshCartUI();
            LoadProducts();
        }

        // ================= RESET =================
        private void RefreshCartUI()
        {
            flowCartItems.Controls.Clear();

            lblsubtotal.Text = "$0.00";
            lbltotal.Text = "$0.00";

            txtMemberPhone.Text = "";
            lblCustomerName.Text = "N/A";

            UpdateCartStatus();
        }

        // ================= DISCOUNT =================
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(discount.Text.Replace(",", ""), out decimal money))
                manualDiscount = Math.Abs(money);
            else
                manualDiscount = 0;

            UpdateSubTotal();
        }

        // ================= PAYMENT =================
        private void cash_Click(object sender, EventArgs e) => paymentMethod = "Cash";
        private void button2_Click(object sender, EventArgs e) => paymentMethod = "Bank";
        private void button3_Click(object sender, EventArgs e) => paymentMethod = "EWallet";
    }
}