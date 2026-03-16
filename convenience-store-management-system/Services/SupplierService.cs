using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMS.Models;
using CSMS.Repositories;

namespace convenience_store_management_system.Services
{
    public class SupplierService
    {
        private SupplierRepository repository = new SupplierRepository();

        public List<Supplier> GetAllSuppliers()
        {
            return repository.GetAllSuppliers();
        }
    }
}
