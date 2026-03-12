using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;

namespace convenience_store_management_system.Repositories
{
    internal class UserRepository
    {
        private List<User> users = new List<User>();

        public User GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }

        public bool UpdatePassword(int userId, string newPassword)
        {
            var user = users.FirstOrDefault(u => u.UserId == userId);

            if (user != null)
            {
                user.PasswordHash = newPassword;
                return true;
            }

            return false;
        }
    }
}
