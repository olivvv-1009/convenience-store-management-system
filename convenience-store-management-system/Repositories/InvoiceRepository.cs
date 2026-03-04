using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;

namespace convenience_store_management_system.Repositories
{
    internal class InvoiceRepository
    {
        private List<Invoice> invoices = new List<Invoice>();

        public void Save(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public List<Invoice> GetAll()
        {
            return invoices;
        }
    }
}
