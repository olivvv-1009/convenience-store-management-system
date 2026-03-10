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
            // lấy user từ database
            var user = userRepository.GetUserByUsername(username);

            if (user == null)
                return null;

            // kiểm tra password
            if (user.Password != password)
                return null;

            // kiểm tra user có hoạt động không
            if (!user.IsActive)
                return null;

            return user;
        }
    }
}