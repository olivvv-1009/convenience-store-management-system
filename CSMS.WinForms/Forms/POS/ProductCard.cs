using System;
using System.Drawing;
using System.Windows.Forms;
using convenience_store_management_system.Models;

namespace CSMS.WinForms.Forms.POS
{
    public partial class ProductCard : UserControl
    {
        private ProductPOS productData;
        public event Action<ProductPOS> OnProductSelected;

        public ProductCard(ProductPOS p)
        {
            InitializeComponent();
            productData = p;

            // ===== SIZE & STYLE =====
            this.Height = 150;
            this.Margin = new Padding(10);
            this.Padding = new Padding(10);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            // ===== DATA =====
            NameProduct.Text = p.ProductName;
            Id.Text = p.ProductId.ToString();

            // 💰 PRICE 
            price.AutoSize = false;
            price.Text = $"${p.Price:N0}";
            price.ForeColor = Color.RoyalBlue;

            // 📦 STOCK 
            stock.AutoSize = false;

            if (p.Stock == 0)
            {
                stock.Text = "Stock : Out";
                stock.ForeColor = Color.Red;
            }
            else
            {
                stock.Text = $"Stock : {p.Stock}";
                stock.ForeColor = p.Stock < 10 ? Color.OrangeRed : Color.Black;
            }

            // ===== CLICK TOÀN CARD =====
            this.Click += Card_Click;
            AddClickEventToChildren(this);

            // ===== HOVER EFFECT (UI xịn hơn) =====
            this.MouseEnter += (s, e) => this.BackColor = Color.AliceBlue;
            this.MouseLeave += (s, e) => this.BackColor = Color.White;
        }

        private void AddClickEventToChildren(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += Card_Click;
                if (c.Controls.Count > 0)
                    AddClickEventToChildren(c);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            OnProductSelected?.Invoke(productData);
        }
    }
}