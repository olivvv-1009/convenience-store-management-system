using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class ExpiredProduct
    {

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int DaysOverdue { get; set; }

        public string Status { get; set; }
        public string BatchNumber { get; set; }
    }
}
