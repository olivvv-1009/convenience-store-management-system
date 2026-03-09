using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.WinForms.Forms.POS;

namespace CSMS.WinForms.Forms.Main
{
    public partial class MainForm_Staff : Form
    {
        public MainForm_Staff()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm posForm = new POSForm();
            LoadUserControl(posForm);
        }

        private void PosBut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new POSForm());
        }
    }
}
