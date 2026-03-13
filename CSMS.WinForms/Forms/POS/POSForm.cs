using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.Services;

namespace CSMS.WinForms.Forms.POS
{
    public partial class POSForm : UserControl
    {
        // Khai báo service
        private ProductService productService = new ProductService();

        public POSForm()
        {
            InitializeComponent();
            CreateInvoice uc = new CreateInvoice();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            CreateInvoice uc = new CreateInvoice();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void InvoiceHistory_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            InvoiceHistory uc = new InvoiceHistory();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }
        
    }
}