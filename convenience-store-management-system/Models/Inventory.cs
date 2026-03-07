using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int MinimumStock { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}