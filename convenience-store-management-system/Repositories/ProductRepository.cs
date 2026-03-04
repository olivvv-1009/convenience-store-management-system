using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;

namespace convenience_store_management_system.Repositories
{
    internal class ProductRepository
    {
        private List<Product> products = new List<Product>();

        public List<Product> GetAll()
        {
            return products;
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Update(Product product)
        {
        }

        public void Delete(int id)
        {
            products.RemoveAll(p => p.ProductId == id);
        }
    }
}
