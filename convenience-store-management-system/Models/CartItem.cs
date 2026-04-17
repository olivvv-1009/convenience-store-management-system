using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Models
{
    public class CartItem
    {
        public string ProductId { get; set; } = "";

        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public decimal SubTotal
        {
            get { return Price * Quantity; }
        }

    }
}
