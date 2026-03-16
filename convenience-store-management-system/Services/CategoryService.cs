using convenience_store_management_system.Models;
using convenience_store_management_system.Repositories;
using CSMS.Models;
using CSMS.Repositories;
using System.Collections.Generic;

namespace CSMS.Services
{
    public class CategoryService
    {
        CategoryRepository repo = new CategoryRepository();

        public List<Category> GetAllCategories()
        {
            return repo.GetAllCategories();
        }
    }
}