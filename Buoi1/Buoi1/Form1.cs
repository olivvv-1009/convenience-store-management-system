using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = "Vui lòng nhập họ tên";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbListHoTen.Items.Clear();
            string text = txtHoTen.Text;
            if (lbListHoTen.Items.Contains(text))
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            else { lbListHoTen.Items.Add(text); }
                
        }
    }
}
