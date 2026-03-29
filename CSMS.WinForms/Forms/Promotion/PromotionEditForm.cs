using System;
using System.Drawing;
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

        public PromotionEditForm(int? promotionId = null)
        {
            this.Text = promotionId.HasValue ? "Edit Promotion" : "Create Promotion";
            this.Size = new Size(500, 350); // ?? TO H?N
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            InitializeControls();

            if (promotionId.HasValue)
            {
                _promotion = _repo.GetById(promotionId.Value);
                if (_promotion != null) LoadToForm();
            }
        }

        private void InitializeControls()
        {

            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };
            this.Controls.Add(panel);

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 2,
                RowCount = 5,
                AutoSize = true
            };

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));

            panel.Controls.Add(table);

            Font labelFont = new Font("Segoe UI", 10, FontStyle.Regular);

            // NAME
            table.Controls.Add(new Label { Text = "Name:", Font = labelFont, Anchor = AnchorStyles.Left }, 0, 0);
            txtName.Dock = DockStyle.Fill;
            table.Controls.Add(txtName, 1, 0);

            // DISCOUNT
            table.Controls.Add(new Label { Text = "Discount (%):", Font = labelFont, Anchor = AnchorStyles.Left }, 0, 1);
            nudDiscount.Maximum = 100;
            nudDiscount.Dock = DockStyle.Left;
            table.Controls.Add(nudDiscount, 1, 1);

            // START
            table.Controls.Add(new Label { Text = "Start Date:", Font = labelFont, Anchor = AnchorStyles.Left }, 0, 2);
            dtStart.Dock = DockStyle.Fill;
            table.Controls.Add(dtStart, 1, 2);

            // END
            table.Controls.Add(new Label { Text = "End Date:", Font = labelFont, Anchor = AnchorStyles.Left }, 0, 3);
            dtEnd.Dock = DockStyle.Fill;
            table.Controls.Add(dtEnd, 1, 3);

            // BUTTON PANEL
            var btnPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(0, 20, 0, 0)
            };

            panel.Controls.Add(btnPanel);

            // SAVE BUTTON
            btnSave.Text = "Save";
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Width = 100;
            btnSave.Height = 35;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += BtnSave_Click;

            // CANCEL BUTTON
            btnCancel.Text = "Cancel";
            btnCancel.Width = 100;
            btnCancel.Height = 35;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            btnPanel.Controls.Add(btnSave);
            btnPanel.Controls.Add(btnCancel);
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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name required");
                return;
            }

            if (_promotion == null) _promotion = new PromotionModel();

            _promotion.PromotionName = txtName.Text.Trim();
            _promotion.DiscountPercent = (int)nudDiscount.Value;
            _promotion.StartDate = dtStart.Value;
            _promotion.EndDate = dtEnd.Value;

            try
            {
                if (_promotion.PromotionId == 0)
                    _repo.Insert(_promotion);
                else
                    _repo.Update(_promotion);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }
    }
}