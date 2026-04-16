using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.Models;
using CSMS.Services;

namespace CSMS.WinForms.Forms.Customer
{
    public partial class CustomerForm : UserControl
    {
        CustomerService service = new CustomerService();
        public CustomerForm()
        {
            InitializeComponent();


        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Search by name or phone...";
            txtSearch.ForeColor = Color.Gray;
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.Columns["TotalSpent"].DefaultCellStyle.Format = "N2";
            LoadData();
        }
        private void LoadData()
        {
            var list = service.GetAllCustomers();

            dgvCustomer.DataSource = list;

            lblTotalCustomers.Text = list.Count.ToString();
            lblTotalPoints.Text = list.Sum(x => x.Points).ToString();
            lblTotalSpent.Text = list.Sum(x => x.TotalSpent).ToString("N0");
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var list = service.GetAllCustomers();

            string key = txtSearch.Text.Trim();

            if (key == "" || key == "Search by name or phone...")
            {
                dgvCustomer.DataSource = list;
                return;
            }

            dgvCustomer.DataSource = list.Where(x =>
                x.FullName.ToLower().Contains(key.ToLower()) ||
                x.Phone.Contains(key) ||
                x.MemberId.ToString().Contains(key)
            ).ToList();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MemberEditForm frm = new MemberEditForm();
            frm.ShowDialog();
            LoadData();
        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;

            int id = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value);

            if (colName == "Edit")
            {
                MemberEditForm frm = new MemberEditForm(id);
                frm.ShowDialog();
                LoadData();
            }

            if (colName == "Delete")
            {
                var confirm = MessageBox.Show("Delete?", "Confirm",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    service.DeleteCustomer(id);
                    LoadData();
                }
            }
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by name or phone...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by name or phone...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
