using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;
using convenience_store_management_system.Repositories;

namespace convenience_store_management_system.Services
{
    internal class ProductService
    {
        private ProductRepository repo = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return repo.GetAll();
        }

        public void CreateProduct(Product product)
        {
            repo.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            repo.Update(product);
        }

        public void DeleteProduct(int id)
        {
            repo.Delete(id);
        }
    }
}
