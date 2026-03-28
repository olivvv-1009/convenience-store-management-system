using convenience_store_management_system.Models;
using CSMS.Services;
using System;
using System.Windows.Forms;

namespace CSMS.WinForms.Forms.Employees
{
    public partial class EmployeeForm : UserControl
    {
        private EmployeeService employeeService = new EmployeeService();

        public EmployeeForm()
        {
            InitializeComponent();
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            LoadStatsAndUsers();
        }

        private void LoadStatsAndUsers()
        {
            var stats = employeeService.GetEmployeeStats();

            lblTotal.Text = stats.total.ToString();
            lblActive.Text = stats.active.ToString();
            lblAdmins.Text = stats.admins.ToString();
            lblStaff.Text = stats.staff.ToString();

            dgvEmployees.Rows.Clear();

            List<Employee> list = employeeService.GetAllEmployees();

            foreach (var e in list)
            {
                dgvEmployees.Rows.Add(
                    e.EmployeeId,
                    e.FullName,
                    e.Email,
                    e.Position,
                    e.HireDate.ToString("yyyy-MM-dd"), // ✅ đúng cột
                    e.IsActive ? "Active" : "Locked",  // ✅ đúng cột
                    "Edit",
                    e.IsActive ? "Lock" : "Unlock"
                );
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);

            string columnName = dgvEmployees.Columns[e.ColumnIndex].Name;

            // 👉 EDIT
            if (columnName == "Edit")
            {
                EditEmployeeForm f = new EditEmployeeForm(id);
                f.ShowDialog();
                LoadStatsAndUsers();
            }

            // 👉 LOCK / UNLOCK
            if (columnName == "Action")
            {
                employeeService.ToggleActive(id);
                LoadStatsAndUsers();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            EditEmployeeForm f = new EditEmployeeForm(0); // 0 = ADD
            f.ShowDialog();
            LoadStatsAndUsers();
        }

        private void Search(string keyword)
        {
            var list = employeeService.GetAllEmployees();

            var filtered = list.Where(x =>
                x.FullName.ToLower().Contains(keyword.ToLower()) ||
                x.Email.ToLower().Contains(keyword.ToLower())
            ).ToList();

            dgvEmployees.Rows.Clear();

            foreach (var e in filtered)
            {
                dgvEmployees.Rows.Add(
                    e.EmployeeId,
                    e.FullName,
                    e.Email,
                    e.Position,
                    e.HireDate.ToString("yyyy-MM-dd"), // ✅ thêm lại dòng này
                    e.IsActive ? "Active" : "Locked",  // ✅ thêm lại dòng này
                    "Edit",
                    e.IsActive ? "Lock" : "Unlock"
                );
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search employees...") return;

            Search(txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search employees...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}