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
        private MemberService memberService = new MemberService();

        public CustomerForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadMembers();
        }

        private void SetupGrid()
        {
            if (dgvMembers.Columns.Count == 0)
            {
                dgvMembers.Columns.Add("MemberId", "ID");
                dgvMembers.Columns.Add("FullName", "Full Name");
                dgvMembers.Columns.Add("Phone", "Phone");
                dgvMembers.Columns.Add("Points", "Points");
            }
        }

        private void LoadMembers()
        {
            try
            {
                dgvMembers.Rows.Clear();
                var members = memberService.GetAllMembers();

                foreach (var m in members)
                {
                    dgvMembers.Rows.Add(m.MemberId, m.FullName, m.Phone, m.Points);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new MemberEditForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    memberService.AddMember(f.Member);
                    LoadMembers();
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0) return;

            var row = dgvMembers.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);
            string name = row.Cells[1].Value?.ToString();
            string phone = row.Cells[2].Value?.ToString();
            int points = Convert.ToInt32(row.Cells[3].Value);

            var m = new Member { MemberId = id, FullName = name, Phone = phone, Points = points };

            using (var f = new MemberEditForm(m))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    memberService.UpdateMember(f.Member);
                    LoadMembers();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0) return;

            var row = dgvMembers.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);

            var r = MessageBox.Show("Delete selected member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                memberService.DeleteMember(id);
                LoadMembers();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

    }
}
