using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convenience_store_management_system.Repositories
{
    internal class InventoryRepository
    {
        private Dictionary<int, int> stock = new Dictionary<int, int>();

        public int GetQuantity(int productId)
        {
            if (stock.ContainsKey(productId))
                return stock[productId];

            return 0;
        }

        public void UpdateStock(int productId, int quantity)
        {
            stock[productId] = quantity;
        }
    }
}
