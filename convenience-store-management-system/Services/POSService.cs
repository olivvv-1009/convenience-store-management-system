using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using convenience_store_management_system.Models;

namespace convenience_store_management_system.Services
{
    internal class POSService
    {
        private List<InvoiceDetail> items = new List<InvoiceDetail>();

        public void AddProduct(int productId, int quantity, decimal price)
        {
            InvoiceDetail item = new InvoiceDetail
            {
                ProductId = productId,
                Quantity = quantity,
                UnitPrice = price,
                LineTotal = quantity * price
            };

            items.Add(item);
        }

        public decimal CalculateTotal()
        {
            return items.Sum(i => i.LineTotal);
        }

        public Invoice CreateInvoice()
        {
            return new Invoice
            {
                CreatedAt = DateTime.Now,
                TotalAmount = CalculateTotal(),
                Status = "Paid"
            };
        }
    }
}
