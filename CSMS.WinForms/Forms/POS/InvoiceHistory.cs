using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS.WinForms.Forms.POS
{
    public partial class InvoiceHistory : UserControl
    {
        public InvoiceHistory()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            string status = cboStatus.SelectedItem.ToString();

        }
    }
}
