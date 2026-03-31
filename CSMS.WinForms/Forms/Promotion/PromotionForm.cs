using System;
using System.Windows.Forms;
using PromotionModel = convenience_store_management_system.Models.Promotion;
using CSMS.Repositories;

namespace CSMS.WinForms.Forms.Promotion
{
    public partial class PromotionForm : UserControl
    {
        private PromotionRepository _repo = new PromotionRepository();

        public PromotionForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            InitializeGridColumns();
            dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotions.Font = new Font("Times New Roman", 12);
            dgvPromotions.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            LoadPromotions();
        }

        // ================= LOAD =================
        private void LoadPromotions()
        {
            try
            {
                var list = _repo.GetAll();

                foreach (var p in list)
                {
                    if (p.EndDate.HasValue && p.EndDate.Value < DateTime.Now)
                        p.IsActive = false;
                }

                dgvPromotions.DataSource = null;   // 🔥 fix refresh
                dgvPromotions.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load promotions: " + ex.Message);
            }
        }

        // ================= GRID =================
        private void InitializeGridColumns()
        {
            dgvPromotions.AutoGenerateColumns = false;
            dgvPromotions.Columns.Clear();

            dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PromotionId",
                HeaderText = "ID",
                Width = 50
            });

            dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PromotionName",
                HeaderText = "Name",
                Width = 200
            });

            dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DiscountPercent",
                HeaderText = "Discount (%)",
                Width = 80
            });

            dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Start",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "End",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvPromotions.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsActive",
                HeaderText = "Active",
                Width = 60
            });
        }

        // ================= CREATE =================
        private void createPromo_Click(object sender, EventArgs e)
        {
            var edit = new PromotionEditForm();

            if (edit.ShowDialog() == DialogResult.OK)
            {
                LoadPromotions();
            }
        }

        // ================= REFRESH =================
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadPromotions();
        }

        // ================= SELECT =================
        private PromotionModel? GetSelectedPromotion()
        {
            if (dgvPromotions.CurrentRow == null) return null;
            return dgvPromotions.CurrentRow.DataBoundItem as PromotionModel;
        }

        // ================= EDIT =================
        private void editBtn_Click(object sender, EventArgs e)
        {
            var sel = GetSelectedPromotion();

            if (sel == null)
            {
                MessageBox.Show("Select a promotion to edit.");
                return;
            }

            var edit = new PromotionEditForm(sel.PromotionId);

            if (edit.ShowDialog() == DialogResult.OK)
            {
                LoadPromotions();
            }
        }

        // ================= ACTIVATE =================
        private void activateBtn_Click(object sender, EventArgs e)
        {
            var sel = GetSelectedPromotion();

            if (sel == null)
            {
                MessageBox.Show("Select promotion.");
                return;
            }

            try
            {
                _repo.SetActive(sel.PromotionId, true);
                LoadPromotions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to activate: " + ex.Message);
            }
        }

        // ================= DEACTIVATE =================
        private void deactivateBtn_Click(object sender, EventArgs e)
        {
            var sel = GetSelectedPromotion();

            if (sel == null)
            {
                MessageBox.Show("Select promotion.");
                return;
            }

            try
            {
                _repo.SetActive(sel.PromotionId, false);
                LoadPromotions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to deactivate: " + ex.Message);
            }
        }
    }
}