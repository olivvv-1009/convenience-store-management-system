using CSMS.Models;
using CSMS.Repositories;
using System.Collections.Generic;

namespace CSMS.Services
{
    public class ProductService
    {
        private ProductRepository productRepo = new ProductRepository();

        public List<Product> GetProducts()
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

        public void DeleteProduct(int id)
        {
            productRepo.DeleteProduct(id);
        }
    }
}