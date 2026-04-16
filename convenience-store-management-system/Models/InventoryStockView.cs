using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class StockView
    {
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string CategoryName { get; set; } = "";
        public int CurrentStock { get; set; }
        public int MinStock { get; set; }
        public string Status { get; set; } = "";
    }
}
