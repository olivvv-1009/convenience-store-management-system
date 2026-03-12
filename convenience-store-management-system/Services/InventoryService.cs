using CSMS.Models;
using CSMS.Repositories;
using System.Collections.Generic;

namespace CSMS.Services
{
    public class InventoryService
    {
        private InventoryRepository inventoryRepo = new InventoryRepository();

        public List<Inventory> GetInventory()
        {
            return inventoryRepo.GetInventory();
        }

        public Inventory GetByProductId(int productId)
        {
            return inventoryRepo.GetByProductId(productId);
        }

        public void UpdateStock(int productId, int quantity)
        {
            inventoryRepo.UpdateStock(productId, quantity);
        }
    }
}