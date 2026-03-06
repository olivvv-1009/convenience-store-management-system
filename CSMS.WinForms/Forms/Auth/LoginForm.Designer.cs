namespace CSMS.WinForms.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

		private void InitializeComponent()
		{
			panel1 = new Panel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			usernameTB = new TextBox();
			passwordTB = new TextBox();
			label4 = new Label();
			label6 = new Label();
			rememberCB = new CheckBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(rememberCB);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(passwordTB);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(usernameTB);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.ForeColor = Color.White;
			panel1.Location = new Point(318, 128);
			panel1.Name = "panel1";
			panel1.Size = new Size(336, 379);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(124, 56);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.Window;
			label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(137, 71);
			label2.Name = "label2";
			label2.Size = new Size(61, 24);
			label2.TabIndex = 1;
			label2.Text = "Login";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(18, 145);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 2;
			label3.Text = "Username";
			// 
			// usernameTB
			// 
			usernameTB.Location = new Point(18, 163);
			usernameTB.Name = "usernameTB";
			usernameTB.Size = new Size(294, 23);
			usernameTB.TabIndex = 3;
			// 
			// passwordTB
			// 
			passwordTB.Location = new Point(18, 215);
			passwordTB.Name = "passwordTB";
			passwordTB.Size = new Size(294, 23);
			passwordTB.TabIndex = 5;
			passwordTB.TextChanged += textBox1_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(18, 197);
			label4.Name = "label4";
			label4.Size = new Size(65, 15);
			label4.TabIndex = 4;
			label4.Text = "Password";
			
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.DodgerBlue;
			label6.Location = new Point(197, 250);
			label6.Name = "label6";
			label6.Size = new Size(104, 15);
			label6.TabIndex = 7;
			label6.Text = "Forgot password?";
			// 
			// rememberCB
			// 
			rememberCB.AutoSize = true;
			rememberCB.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rememberCB.ForeColor = Color.Black;
			rememberCB.Location = new Point(18, 249);
			rememberCB.Name = "rememberCB";
			rememberCB.Size = new Size(109, 19);
			rememberCB.TabIndex = 8;
			rememberCB.Text = "Remember Me";
			rememberCB.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			BackColor = Color.SkyBlue;
			ClientSize = new Size(984, 961);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		private Panel panel1;
		private Label label1;
		private Label label2;
		private TextBox usernameTB;
		private Label label3;
		private TextBox passwordTB;
		private Label label4;
		private CheckBox rememberCB;
		private Label label6;
	}
}