using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Repositories;

namespace convenience_store_management_system.Services
{
    internal class InventoryService
    {
        private InventoryRepository repo = new InventoryRepository();

        public int CheckStock(int productId)
        {
            return repo.GetQuantity(productId);
        }

        public void UpdateStock(int productId, int quantity)
        {
            repo.UpdateStock(productId, quantity);
        }
    }
}
