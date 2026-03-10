using System;
using System.Windows.Forms;
using CSMS.Core.Services;
using CSMS.Core.Helpers;
using CSMS.WinForms.Forms.Main;

namespace CSMS.WinForms.Forms.Auth
{
<<<<<<< Updated upstream
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
	}
=======
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
    }
>>>>>>> Stashed changes
}
