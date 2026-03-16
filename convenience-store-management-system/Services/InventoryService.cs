using convenience_store_management_system.Models;
using CSMS.Models;
using CSMS.Repositories;

namespace CSMS.Services
{
    public class InventoryService
    {
        private InventoryRepository repository = new InventoryRepository();

        public void ImportStock(InventoryItem inventory)
        {
            if (inventory == null)
                throw new Exception("Inventory cannot be null");

            if (inventory.Quantity <= 0)
                throw new Exception("Quantity must be greater than 0");

            if (string.IsNullOrEmpty(inventory.ProductId))
                throw new Exception("Product is required");

            repository.ImportStock(inventory);
        }

        public decimal? GetLastUnitCost(string productId, string supplier)
        {
            return repository.GetLastUnitCost(productId, supplier);
        }
        public List<StockView> GetStockList()
        {
            return repository.GetStockList();
        }

        public List<StockView> GetLowStockProducts()
        {
            return repository.GetStockList()
                       .Where(p => p.CurrentStock < p.MinStock)
                       .ToList();
        }
        public List<ExpiredProduct> GetExpiredProducts()
        {
            return repository.GetExpiredProducts();
        }
    }
}