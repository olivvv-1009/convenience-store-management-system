namespace CSMS.Models
{
    public class InventoryItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Supplier { get; set; }
        public decimal UnitCost { get; set; }
        public string BatchNumber { get; set; }
    }
}