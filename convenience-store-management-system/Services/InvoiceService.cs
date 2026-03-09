using convenience_store_management_system.Models;
using CSMS.Repositories;

public class InvoiceService
{
    private ProductRepository productRepository = new ProductRepository();

    public void UpdateStockAfterInvoice(List<CartItem> cartItems)
    {
        foreach (var item in cartItems)
        {
            productRepository.UpdateStock(item.ProductId, item.Quantity);
        }
    }

    public void CreateInvoice(List<CartItem> cartItems)
    {
        // TODO: Lưu hóa đơn nếu cần

        // ⭐ Trừ tồn kho
        UpdateStockAfterInvoice(cartItems);
    }
}