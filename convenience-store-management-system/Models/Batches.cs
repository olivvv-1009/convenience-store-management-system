using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public string ProductId { get; set; } = "";
        public decimal UnitCost { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime ImportedDate { get; set; }
    }
}
