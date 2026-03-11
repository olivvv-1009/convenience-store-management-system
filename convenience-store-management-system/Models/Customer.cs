using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string phoneNumber { get; set; }
        public string memberLevel { get; set; }
        public double loyaltyPoints { get; set; }

    }
}
