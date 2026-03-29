using System;
using System.Windows.Forms;
using CSMS.Models;

namespace CSMS.WinForms.Forms.Customer
{
    public class MemberEditForm : Form
    {
        private TextBox txtName;
        private TextBox txtPhone;
        private NumericUpDown numPoints;
        private Button btnOk;
        private Button btnCancel;

        public Member Member { get; private set; }

        public MemberEditForm()
        {
            Initialize();
        }

        public MemberEditForm(Member m) : this()
        {
            txtName.Text = m.FullName;
            txtPhone.Text = m.Phone;
            numPoints.Value = m.Points;
            Member = m;
        }

        private void Initialize()
        {
            this.Text = "Member";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 400;
            this.Height = 220;

            var lbl1 = new Label { Text = "Full name:", Left = 10, Top = 20, Width = 80 };
            txtName = new TextBox { Left = 100, Top = 18, Width = 260 };

            var lbl2 = new Label { Text = "Phone:", Left = 10, Top = 60, Width = 80 };
            txtPhone = new TextBox { Left = 100, Top = 58, Width = 260 };

            var lbl3 = new Label { Text = "Points:", Left = 10, Top = 100, Width = 80 };
            numPoints = new NumericUpDown { Left = 100, Top = 98, Width = 120, Minimum = 0, Maximum = 100000 };

            btnOk = new Button { Text = "OK", Left = 200, Width = 80, Top = 140, DialogResult = DialogResult.OK };
            btnCancel = new Button { Text = "Cancel", Left = 290, Width = 80, Top = 140, DialogResult = DialogResult.Cancel };

            btnOk.Click += BtnOk_Click;

            this.Controls.Add(lbl1);
            this.Controls.Add(txtName);
            this.Controls.Add(lbl2);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lbl3);
            this.Controls.Add(numPoints);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name required");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (Member == null) Member = new Member();

            Member.FullName = txtName.Text.Trim();
            Member.Phone = txtPhone.Text.Trim();
            Member.Points = (int)numPoints.Value;
        }
    }
}
