using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.WinForms.Forms.Auth;
using CSMS.WinForms.Forms.Customer;
using CSMS.WinForms.Forms.DashBoard;
using CSMS.WinForms.Forms.Employees;
using CSMS.WinForms.Forms.Inventory;
using CSMS.WinForms.Forms.POS;
using CSMS.WinForms.Forms.ProductUI;
using CSMS.WinForms.Forms.Promotion;
using CSMS.WinForms.Forms.Report;



namespace CSMS.WinForms.Forms.Main
{
    public partial class MainForm_Admin : Form
    {
        public MainForm_Admin()
        {
            InitializeComponent();
            LoadUserControl(new DashBoardForm());

        }
        private void LoadForm(Form form)
        {
            pnlContent.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(form);
            form.Show();
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

        private void DashboardBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DashBoardForm());

        }

        private void ProductBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductForm());

        }

        private void InventoryBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new InventoryForm());


        }

        private void CustomersBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CustomerForm());

        }

        private void PromotionsBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new PromotionForm());

        }

        private void EmployeesBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EmployeeForm());

        }

        private void ReportsBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReportForm());

        }

        private void LogoutBut_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
        "Bạn có chắc muốn đăng xuất?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (confirm == DialogResult.Yes)
            {
                this.Hide();

                var login = new LoginForm();
                login.Show();

                this.Close();
            }
        }
    }
}
