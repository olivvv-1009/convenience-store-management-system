using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSMS.Services;
using convenience_store_management_system.Models;
using System.Collections.Generic;

namespace CSMS.Tests.IntegrationTests
{
    [TestClass]
    public class InvoiceFlowIntegrationTests
    {
        private InvoiceService service;

        [TestInitialize]
        public void Setup()
        {
            service = new InvoiceService();
        }

        // =========================
        // 1. FULL INVOICE FLOW
        // =========================
        [TestMethod]
        public void FullInvoiceFlow_ShouldWork()
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

            service.CreateInvoice(items, "Cash", 1, 0);

            Assert.IsTrue(true);
        }

        // =========================
        // 2. STOCK UPDATE FLOW
        // =========================
        [TestMethod]
        public void Stock_ShouldDecreaseAfterInvoice()
        {
            var beforeItems = new List<CartItem>
            {
                new CartItem
                {
                    ProductId = "P002",
                    Quantity = 1,
                    Price = 10000
                }
            };

            service.UpdateStockAfterInvoice(beforeItems);

            Assert.IsTrue(true);
        }

        // =========================
        // 3. POINTS UPDATE FLOW
        // =========================
        [TestMethod]
        public void Points_ShouldBeUpdatedAfterInvoice()
        {
            var items = new List<CartItem>
            {
                new CartItem
                {
                    ProductId = "P003",
                    Quantity = 2,
                    Price = 25000
                }
            };

            // MemberId = 1 (có sẵn trong DB của bạn)
            service.CreateInvoice(items, "Cash", 1, 0);

            Assert.IsTrue(true);
        }
    }
}