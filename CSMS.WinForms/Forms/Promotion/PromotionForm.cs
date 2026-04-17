using System;
using System.Windows.Forms;
using PromotionModel = convenience_store_management_system.Models.Promotion;
using CSMS.Repositories;

namespace CSMS.WinForms.Forms.Promotion
{
    public partial class PromotionForm : UserControl
    {

        private PromotionRepository repo = new PromotionRepository();

        public PromotionForm()
        {
            InitializeComponent();
        }

        private void PromotionManagementForm_Load(object sender, EventArgs e)
        {
            LoadPromotions();
        }

        // LOAD DATA
        private void LoadPromotions()
        {
            dgvPromotions.Rows.Clear();

            var list = repo.GetAll();

            foreach (var p in list)
            {
                dgvPromotions.Rows.Add(
                    p.Code,
                    p.PromotionName,
                    p.DiscountPercent,
                    p.Type,
                    p.StartDate?.ToString("dd/MM/yyyy"),
                    p.EndDate?.ToString("dd/MM/yyyy"),
                    p.IsActive ? "Active" : "Inactive"
                );
            }

            lblActive.Text = $"Active Promotions: {list.Count(x => x.IsActive)}";
            lblTotal.Text = $"Total Promotions: {list.Count}";
            lblDiscount.Text = $"Total Discount Given: 0"; // chưa tracking
        }

        // ADD
        private void btnAddPromotion_Click(object sender, EventArgs e)
        {
            var f = new PromotionEditForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadPromotions();
            }
        }

        // EDIT
        private void dgvPromotions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvPromotions.Columns["colEdit"].Index)
            {
                string code = dgvPromotions.Rows[e.RowIndex].Cells["colCode"].Value.ToString();

                var promo = repo.GetByCode(code);

                if (promo == null)
                {
                    MessageBox.Show("Promotion not found");
                    return;
                }

                var f = new PromotionEditForm(promo);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadPromotions();
                }
            }

        }
    }
}