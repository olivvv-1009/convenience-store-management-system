
    using convenience_store_management_system.Models;
using CSMS.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace CSMS.WinForms.Controls
{
    public partial class ProductItemControl : UserControl
    {
        Product product;
        public ProductItemControl(Product p)
        {
            InitializeComponent();
        }

        private void ProductItemControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}