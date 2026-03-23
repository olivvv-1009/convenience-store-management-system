using convenience_store_management_system.Models;
using CSMS.Models;
using CSMS.Repositories;

public class ProductService
{
    private ProductRepository productRepo = new ProductRepository();

    public List<Product> GetAllProducts()
    {
        return productRepo.GetAllProducts();
    }

    public void AddProduct(Product p)
    {
        productRepo.AddProduct(p);
    }

    public void UpdateProduct(Product p)
    {
        productRepo.UpdateProduct(p);
    }

    public void DeleteProduct(string id)
    {
        productRepo.DeleteProduct(id);
    }

    public bool Exists(string id)
    {
        return productRepo.Exists(id);
    }

    public List<ProductPOS> GetProductsForPOS()
    {
        return productRepo.GetProductsForPOS();
    }
    public Product GetProductById(string id)
    {
        return productRepo.GetAllProducts()
                          .Find(p => p.ProductId == id);
    }
}