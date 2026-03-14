using System;
using System.Windows.Forms;
using convenience_store_management_system.Models;
using CSMS.Models;

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
            this.Width = 320;
            this.Height = 170;

            // ⭐ HIỂN THỊ DỮ LIỆU
            NameProduct.Text = p.ProductName;
            Id.Text = p.ProductId.ToString();
            price.Text = "$" + p.Price.ToString("N2");
            stock.AutoSize = true;
            stock.Text = p.Stock.ToString();
            if (p.Stock == 0)
            {
                stock.Text = "Out";
                stock.ForeColor = Color.Red;
            }
            else if (p.Stock < 10)
            {
                stock.ForeColor = Color.OrangeRed;
            }

            // ⭐ BẮT CLICK TOÀN BỘ CARD
            this.Click += Card_Click;
            AddClickEventToChildren(this);
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

        private void stk_Click(object sender, EventArgs e)
        {

        }
    }
}