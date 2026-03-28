using CSMS.Core.Models;
using CSMS.Services;
using System;
using System.Windows.Forms;
using convenience_store_management_system.Models;

namespace CSMS.WinForms.Forms.Employees
{
    public partial class EditEmployeeForm : Form
    {
        private int userId;
        private EmployeeService employeeService = new EmployeeService();

        public EditEmployeeForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            btnCancel.Click += btnCancel_Click;
            btnUpdate.Click += btnUpdate_Click;
            LoadUserData();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Staff");

            cmbRole.SelectedIndex = 0; // chọn mặc định

            LoadUserData(); // load data sau khi có item
        }

        private void LoadUserData()
        {
            if (userId == 0) return; // 👉 ADD MODE
            var emp = employeeService.GetAllEmployees().Find(x => x.EmployeeId == userId);

            if (emp == null) return;

            txtFullName.Text = emp.FullName;
            txtEmail.Text = emp.Email;
            //txtPhone.Text = emp.Phone;
            cmbRole.SelectedItem = emp.Position;
            dtpHireDate.Value = emp.HireDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Employee emp = new Employee
            {
                EmployeeId = userId,
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Position = cmbRole.SelectedItem.ToString(),
                HireDate = dtpHireDate.Value,
                //Phone = "" // nếu không dùng
            };

            try
            {
                if (userId == 0)
                    employeeService.AddEmployee(emp);
                else
                    employeeService.UpdateEmployee(emp);

                MessageBox.Show("Thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}