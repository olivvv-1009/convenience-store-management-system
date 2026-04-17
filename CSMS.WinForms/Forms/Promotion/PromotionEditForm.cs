using System;
using System.Drawing;
using System.Windows.Forms;
using PromotionModel = convenience_store_management_system.Models.Promotion;
using CSMS.Repositories;

namespace CSMS.WinForms.Forms.Promotion
{
    public class PromotionEditForm : Form
    {
        private PromotionRepository repo = new PromotionRepository();
        private PromotionModel editingPromotion = null;

        private Label label1;
        private TextBox txtCode;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private NumericUpDown numDiscount;
        private ComboBox cbType;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Button btnCancel;
        private Button btnSave;
        private PromotionModel? _promotion;

        public PromotionEditForm(PromotionModel p = null)
        {

            InitializeComponent();

            // ComboBox setup
            cbType.Items.Add("Percentage");
            cbType.Items.Add("Fixed");
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.SelectedIndex = 0;

            if (p != null)
            {
                editingPromotion = p;
                LoadData();
                txtCode.Enabled = false;

            }
        }

        // LOAD DATA
        private void LoadData()
        {
            txtCode.Text = editingPromotion.Code;
            txtName.Text = editingPromotion.PromotionName;
            numDiscount.Value = editingPromotion.DiscountPercent;
            cbType.SelectedItem = editingPromotion.Type ?? "Percentage";
            dtStart.Value = editingPromotion.StartDate ?? DateTime.Now;
            dtEnd.Value = editingPromotion.EndDate ?? DateTime.Now;
        }

        // VALIDATE
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Code is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
                return false;
            }

            if (cbType.SelectedItem == null)
            {
                MessageBox.Show("Select discount type");
                return false;
            }

            if (dtEnd.Value < dtStart.Value)
            {
                MessageBox.Show("End date must be after start date");
                return false;
            }

            if (cbType.SelectedItem.ToString() == "Percentage" && numDiscount.Value > 100)
            {
                MessageBox.Show("Percentage cannot exceed 100%");
                return false;
            }

            return true;
        }

        // SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var p = new PromotionModel
            {
                Code = txtCode.Text.Trim(),
                PromotionName = txtName.Text.Trim(),
                DiscountPercent = (int)numDiscount.Value,
                Type = cbType.SelectedItem.ToString(),
                StartDate = dtStart.Value,
                EndDate = dtEnd.Value,
                IsActive = true
            };

            try
            {
                if (editingPromotion == null)
                {
                    repo.Insert(p);
                }
                else
                {
                    p.PromotionId = editingPromotion.PromotionId;
                    repo.Update(p);
                }

                MessageBox.Show("Saved successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            numDiscount = new NumericUpDown();
            cbType = new ComboBox();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(166, 26);
            label1.TabIndex = 0;
            label1.Text = "Promotion Code";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(24, 60);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(453, 30);
            txtCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 297);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 2;
            label2.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 297);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 3;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(330, 205);
            label4.Name = "label4";
            label4.Size = new Size(147, 26);
            label4.TabIndex = 4;
            label4.Text = "Discount Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 205);
            label5.Name = "label5";
            label5.Size = new Size(152, 26);
            label5.TabIndex = 5;
            label5.Text = "Discount Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 179);
            label6.Name = "label6";
            label6.Size = new Size(0, 26);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 112);
            label7.Name = "label7";
            label7.Size = new Size(171, 26);
            label7.TabIndex = 7;
            label7.Text = "Promotion Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(24, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(453, 30);
            txtName.TabIndex = 8;
            // 
            // numDiscount
            // 
            numDiscount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDiscount.Location = new Point(24, 246);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(250, 30);
            numDiscount.TabIndex = 9;
            // 
            // cbType
            // 
            cbType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(330, 246);
            cbType.Name = "cbType";
            cbType.Size = new Size(250, 30);
            cbType.TabIndex = 10;
            // 
            // dtStart
            // 
            dtStart.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStart.Location = new Point(24, 339);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(250, 27);
            dtStart.TabIndex = 11;
            // 
            // dtEnd
            // 
            dtEnd.CalendarFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEnd.Location = new Point(330, 339);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(250, 27);
            dtEnd.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(321, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 47);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(474, 401);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 47);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // PromotionEditForm
            // 
            ClientSize = new Size(619, 477);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Controls.Add(cbType);
            Controls.Add(numDiscount);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "PromotionEditForm";
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}