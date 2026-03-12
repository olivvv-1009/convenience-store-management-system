using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;
using convenience_store_management_system.Repositories;

namespace convenience_store_management_system.Services
{
    internal class AuthService
    {
        private readonly UserRepository _userRepo;

        public AuthService()
        {
            _userRepo = new UserRepository();
        }

        public User Login(string username, string password)
        {
            var user = _userRepo.GetUserByUsername(username);

            if (user != null && user.PasswordHash == password)
            {
                return user;
            }

            return null;
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            return _userRepo.UpdatePassword(userId, newPassword);
        }
    }
}
