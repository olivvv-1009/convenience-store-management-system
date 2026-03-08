using CSMS.Core.Models;
using CSMS.Core.Repositories;

namespace CSMS.Core.Services
{
    public class AuthService
    {
        private readonly UserRepository userRepository;

        public AuthService()
        {
            userRepository = new UserRepository();
        }

        public User? Login(string username, string password)
        {
            var user = userRepository.GetUserByUsername(username);

            if (user == null)
                return null;

            // So sánh mật khẩu
            if (user.PasswordHash != password)
                return null;

            // Kiểm tra tài khoản có bị khóa không
            if (user.IsLocked)
                return null;

            return user;
        }
    }
}