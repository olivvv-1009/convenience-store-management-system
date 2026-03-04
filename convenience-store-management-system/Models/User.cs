using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Status { get; set; }

        public int RoleId { get; set; }
    }
}
