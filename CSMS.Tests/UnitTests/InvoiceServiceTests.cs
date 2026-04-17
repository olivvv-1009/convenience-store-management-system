using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSMS.Services;
using convenience_store_management_system.Models;
using System.Collections.Generic;

namespace CSMS.Tests.UnitTests
{
    [TestClass]
    public class InvoiceServiceTests
    {
        private InvoiceService service;

        [TestInitialize]
        public void Setup()
        {
            service = new InvoiceService();
        }

        [TestMethod]
        public void UpdateStock_ShouldNotThrow()
        {
            var items = new List<CartItem>
        {
            new CartItem
            {
                ProductId = "P001",
                Quantity = 1,
                Price = 15000
            }
        };

            service.UpdateStockAfterInvoice(items);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CreateInvoice_ShouldWork()
        {
            var service = new InvoiceService();

            var items = new List<CartItem>
    {
        new CartItem
        {
            ProductId = "P001",
            Quantity = 1,
            Price = 15000
        }
    };

            // MemberId = 1 có sẵn trong DB
            service.CreateInvoice(items, "Cash", 1, 0);

            Assert.IsTrue(true); // pass nếu không throw exception
        }
    }
}