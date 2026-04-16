using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace convenience_store_management_system.Models
{
    public class Customers
    {
        public int MemberId { get; set; }

        public string FullName { get; set; } = "";
        public string Phone { get; set; } = "";

        public int Points { get; set; }

        public decimal TotalSpent { get; set; } = 0;
    }
}
