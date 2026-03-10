using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS.WinForms.Forms.Promotion
{
	public partial class PromotionForm : UserControl
	{
		public PromotionForm()
		{
			InitializeComponent();
		}

		private void createPromo_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
