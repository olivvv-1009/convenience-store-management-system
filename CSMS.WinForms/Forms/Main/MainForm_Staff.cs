using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.WinForms.Forms.DashBoard;
using CSMS.WinForms.Forms.POS;
using CSMS.WinForms.Forms.Product;
using CSMS.WinForms.Forms.Inventory;

namespace CSMS.WinForms.Forms.Main
{
    public partial class MainForm_Staff : Form
    {
        public MainForm_Staff()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }
        private void MainForm_Admin_Load(object sender, EventArgs e)
        {
            LoadUserControl(new DashBoardForm());
        }

        private void PosBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new POSForm());
        }

        private void ProductBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductForm());

        }

        private void InventoryBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new InventoryForm());

        }

        private void DashboardBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashBoardForm());

        }
    }
}
