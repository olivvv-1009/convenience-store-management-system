using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromotionModel = convenience_store_management_system.Models.Promotion;
using CSMS.Repositories;

namespace CSMS.WinForms.Forms.Promotion
{
	public partial class PromotionForm : UserControl
	{
        private PromotionRepository _repo = new PromotionRepository();
		private BindingSource _binding = new BindingSource();
		public PromotionForm()
		{
			InitializeComponent();
            this.Dock = DockStyle.Fill;
            InitializeGridColumns();
			dgvPromotions.DataSource = _binding;
			LoadPromotions();
        }

        private void createPromo_Click(object sender, EventArgs e)
		{
			// Open editor for new promotion
			var edit = new PromotionEditForm();
			if (edit.ShowDialog() == DialogResult.OK)
			{
				LoadPromotions();
			}
		}

		private void InitializeGridColumns()
		{
			dgvPromotions.Columns.Clear();
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "PromotionId", DataPropertyName = "PromotionId", HeaderText = "ID", Width = 50 });
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "PromotionName", DataPropertyName = "PromotionName", HeaderText = "Name", Width = 200 });
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiscountPercent", DataPropertyName = "DiscountPercent", HeaderText = "Discount %", Width = 80 });
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "StartDate", DataPropertyName = "StartDate", HeaderText = "Start", Width = 120 });
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "EndDate", DataPropertyName = "EndDate", HeaderText = "End", Width = 120 });
			dgvPromotions.Columns.Add(new DataGridViewTextBoxColumn { Name = "IsActive", DataPropertyName = "IsActive", HeaderText = "Active", Width = 60 });
		}

		private void LoadPromotions()
		{
			try
			{
                var list = _repo.GetAll();
				// mark expired based on EndDate
				foreach (var p in list)
				{
					if (p.EndDate.HasValue && p.EndDate.Value < DateTime.Now)
						p.IsActive = false; // expire automatically
				}
				_binding.DataSource = list;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load promotions: " + ex.Message);
			}
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			LoadPromotions();
		}

        private PromotionModel? GetSelectedPromotion()
		{
			if (dgvPromotions.CurrentRow == null) return null;
            return dgvPromotions.CurrentRow.DataBoundItem as PromotionModel;
		}

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

		private void activateBtn_Click(object sender, EventArgs e)
		{
			var sel = GetSelectedPromotion();
			if (sel == null) { MessageBox.Show("Select promotion."); return; }
			try
			{
				_repo.SetActive(sel.PromotionId, true);
				LoadPromotions();
			}
			catch (Exception ex) { MessageBox.Show("Failed to activate: " + ex.Message); }
		}

		private void deactivateBtn_Click(object sender, EventArgs e)
		{
			var sel = GetSelectedPromotion();
			if (sel == null) { MessageBox.Show("Select promotion."); return; }
			try
			{
				_repo.SetActive(sel.PromotionId, false);
				LoadPromotions();
			}
			catch (Exception ex) { MessageBox.Show("Failed to deactivate: " + ex.Message); }
		}
	}
}
