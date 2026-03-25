using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if (!int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            if (!int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            int sum = num1 + num2;
            lblSum.Text = "Tổng = "+ sum.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to exit?", "Demo Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
