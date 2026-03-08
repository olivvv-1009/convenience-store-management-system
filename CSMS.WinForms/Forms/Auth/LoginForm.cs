using System;
using System.Windows.Forms;
using CSMS.Core.Services;
using CSMS.Core.Helpers;
using CSMS.WinForms.Forms.Main;

namespace CSMS.WinForms.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            AuthService authService = new AuthService();

            var user = authService.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                // lưu user vào session
                SessionHelper.CurrentUser = user;

                MessageBox.Show("Login thành công!");

                // phân quyền
                if (user.Role == "Admin")
                {
                    MainForm_Admin main = new MainForm_Admin();
                    main.Show();
                }
                else
                {
                    MainForm_Staff main = new MainForm_Staff();
                    main.Show();
                }

                // ẩn login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}