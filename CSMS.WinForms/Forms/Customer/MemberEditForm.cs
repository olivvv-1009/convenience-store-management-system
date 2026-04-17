using CSMS.Models;
using CSMS.Services;
using System;
using System.Windows.Forms;
using CustomerModel = convenience_store_management_system.Models.Customers;

namespace CSMS.WinForms.Forms.Customer
{
    public class MemberEditForm : Form
    {
        CustomerService service = new CustomerService();

        private int? memberId = null;
        private TextBox txtName;
        private TextBox txtPhone;
        private NumericUpDown numPoints;
        private Button btnOk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button btnSave;
        private Button btnCancel;

       

        // ================= ADD MODE =================
        public MemberEditForm()
        {
            InitializeComponent();
           
        }

        // ================= EDIT MODE =================
        public MemberEditForm(int id)
        {
            InitializeComponent();
            memberId = id;
            
        }

        // ================= LOAD =================
        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            if (memberId != null)
            {
                var c = service.GetAllCustomers()
                    .FirstOrDefault(x => x.MemberId == memberId);

                if (c != null)
                {
                    txtFullName.Text = c.FullName;
                    txtPhone.Text = c.Phone;
                    numPoints.Value = c.Points;
                }
            }
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerModel c = new CustomerModel()
            {
                MemberId = memberId ?? 0,
                FullName = txtFullName.Text,
                Phone = txtPhone.Text,
                Points = (int)numPoints.Value,
                TotalSpent = 0
            };

            try
            {
                // ================= ADD =================
                if (memberId == null)
                {
                    if (service.IsPhoneExists(c.Phone, c.FullName))
                    {
                        MessageBox.Show("Phone or Name already exists!");
                        return;
                    }

                    service.AddCustomer(c);
                    MessageBox.Show("Added successfully");
                }
                // ================= EDIT =================
                else
                {
                    if (service.IsPhoneExists(c.Phone, c.FullName, memberId))
                    {
                        MessageBox.Show("Phone or Name already exists!");
                        return;
                    }

                    service.UpdateCustomer(c);
                    MessageBox.Show("Updated successfully");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            numPoints = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numPoints).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 190);
            label2.Name = "label2";
            label2.Size = new Size(147, 26);
            label2.TabIndex = 1;
            label2.Text = "Loyalty Points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 103);
            label4.Name = "label4";
            label4.Size = new Size(153, 26);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(30, 59);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(384, 30);
            txtFullName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(30, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(384, 30);
            txtPhone.TabIndex = 5;
            // 
            // numPoints
            // 
            numPoints.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPoints.Location = new Point(30, 230);
            numPoints.Name = "numPoints";
            numPoints.Size = new Size(384, 30);
            numPoints.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(227, 289);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(355, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // MemberEditForm
            // 
            ClientSize = new Size(483, 359);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(numPoints);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MemberEditForm";
            Load += FrmCustomerDetail_Load;
            ((System.ComponentModel.ISupportInitialize)numPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
