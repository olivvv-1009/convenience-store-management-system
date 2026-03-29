using System;
using System.Windows.Forms;
using PromotionModel = convenience_store_management_system.Models.Promotion;
using CSMS.Repositories;

namespace CSMS.WinForms.Forms.Promotion
{
    public class PromotionEditForm : Form
    {
        private PromotionRepository _repo = new PromotionRepository();
        private PromotionModel? _promotion;
        private TextBox txtName = new TextBox();
        private NumericUpDown nudDiscount = new NumericUpDown();
        private DateTimePicker dtStart = new DateTimePicker();
        private DateTimePicker dtEnd = new DateTimePicker();
        private Button btnSave = new Button();
        private Button btnCancel = new Button();

        public PromotionEditForm() : this(null) { }

        public PromotionEditForm(int? promotionId)
        {
            this.Text = promotionId.HasValue ? "Edit Promotion" : "Create Promotion";
            this.Width = 400;
            this.Height = 260;
            InitializeControls();
            if (promotionId.HasValue)
            {
                _promotion = _repo.GetById(promotionId.Value);
                if (_promotion != null) LoadToForm();
            }
        }

        private void InitializeControls()
        {
            Label lbl1 = new Label { Text = "Name:", Left = 10, Top = 20, Width = 80 };
            txtName.Left = 100; txtName.Top = 20; txtName.Width = 250;

            Label lbl2 = new Label { Text = "Discount %:", Left = 10, Top = 60, Width = 80 };
            nudDiscount.Left = 100; nudDiscount.Top = 60; nudDiscount.Width = 100; nudDiscount.Maximum = 100;

            Label lbl3 = new Label { Text = "Start:", Left = 10, Top = 100, Width = 80 };
            dtStart.Left = 100; dtStart.Top = 100; dtStart.Width = 200;

            Label lbl4 = new Label { Text = "End:", Left = 10, Top = 140, Width = 80 };
            dtEnd.Left = 100; dtEnd.Top = 140; dtEnd.Width = 200;

            btnSave.Text = "Save"; btnSave.Left = 100; btnSave.Top = 180; btnSave.Click += BtnSave_Click;
            btnCancel.Text = "Cancel"; btnCancel.Left = 200; btnCancel.Top = 180; btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.Add(lbl1); this.Controls.Add(txtName);
            this.Controls.Add(lbl2); this.Controls.Add(nudDiscount);
            this.Controls.Add(lbl3); this.Controls.Add(dtStart);
            this.Controls.Add(lbl4); this.Controls.Add(dtEnd);
            this.Controls.Add(btnSave); this.Controls.Add(btnCancel);
        }

        private void LoadToForm()
        {
            if (_promotion == null) return;
            txtName.Text = _promotion.PromotionName;
            nudDiscount.Value = _promotion.DiscountPercent;
            dtStart.Value = _promotion.StartDate ?? DateTime.Now;
            dtEnd.Value = _promotion.EndDate ?? DateTime.Now.AddDays(7);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Name required"); return; }
            if (_promotion == null) _promotion = new PromotionModel();
            _promotion.PromotionName = txtName.Text.Trim();
            _promotion.DiscountPercent = (int)nudDiscount.Value;
            _promotion.StartDate = dtStart.Value;
            _promotion.EndDate = dtEnd.Value;

            try
            {
                if (_promotion.PromotionId == 0)
                {
                    _repo.Insert(_promotion);
                }
                else
                {
                    _repo.Update(_promotion);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }
    }
}
