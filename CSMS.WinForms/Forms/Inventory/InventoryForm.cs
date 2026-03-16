using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.WinForms.Forms.POS;

namespace CSMS.WinForms.Forms.Inventory
{
    public partial class InventoryForm : UserControl
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            ImportGood uc = new ImportGood();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void ImportGood_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ImportGood uc = new ImportGood();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void StockList_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            StockList uc = new StockList();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void ExpiredProducts_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ExpiredProducts uc = new ExpiredProducts();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }
    }
}
