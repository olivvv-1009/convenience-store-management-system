using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";

        public string Position { get; set; } = "";
        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }
    }
}
