using System.Collections.Generic;
using convenience_store_management_system.Models;
using CSMS.Models;
using CSMS.Repositories;

namespace CSMS.Services
{
    public class ProductService
    {
        private ProductRepository productRepo = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return productRepo.GetAllProducts();
        }

        public void CreateProduct(Product product)
        {
            productRepo.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepo.UpdateProduct(product);
        }

        public void DeleteProduct(string id)
        {
            productRepo.DeleteProduct(id);
        }
        public List<ProductPOS> GetProductsForPOS()
        {
            return productRepo.GetProductsForPOS();
        }
    }
}