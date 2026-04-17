using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSMS.Services;
using convenience_store_management_system.Models;

namespace CSMS.Tests.UnitTests
{
    [TestClass]
    public class CustomerServiceTests
    {
        private CustomerService service;

        [TestInitialize]
        public void Setup()
        {
            service = new CustomerService();
        }

        [TestMethod]
        public void GetAllCustomers_ShouldReturnData()
        {
            var result = service.GetAllCustomers();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetMemberByPhone_ShouldReturnMember()
        {
            var result = service.GetMemberByPhone("0900000001");

            Assert.IsNotNull(result);
            Assert.AreEqual("Nguyen Van A", result.FullName);
        }

        [TestMethod]
        public void AddCustomer_ShouldWork()
        {
            var service = new CustomerService();

            var c = new Customers
            {
                FullName = "Test User",
                Phone = "0999999999",
                Points = 0,
                TotalSpent = 0
            };

            service.AddCustomer(c);

            var result = service.GetMemberByPhone("0999999999");

            Assert.IsNotNull(result);
            Assert.AreEqual("Test User", result.FullName);
        }

        [TestMethod]
        public void UpdateCustomer_ShouldWork()
        {
            var service = new CustomerService();

            // lấy 1 member có sẵn trong DB (ID = 1)
            var customer = service.GetAllCustomers().First();

            customer.FullName = "Updated Name";

            service.UpdateCustomer(customer);

            var updated = service.GetAllCustomers()
                                 .First(x => x.MemberId == customer.MemberId);

            Assert.AreEqual("Updated Name", updated.FullName);
        }
    }
}