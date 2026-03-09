using System;
using System.Drawing;
using System.Windows.Forms;
using CSMS.Services;

namespace CSMS.WinForms.Forms.POS
{
    public partial class PaymentQRForm : Form
    {
        public bool PaymentConfirmed = false;

        public PaymentQRForm(string type, decimal amount)
        {
            InitializeComponent();

            // 💰 Hiển thị tiền
            total.Text = "$" + amount.ToString("0.00");

            // 🟪 Hiển thị loại QR
            if (type == "bank")
                lblQR.Text = "🏦 QR NGÂN HÀNG";
            else
                lblQR.Text = "📱 QR MOMO";
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = true;
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = false;
            this.Close();
        }
    }
}