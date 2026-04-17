using CSMS.Models;
using CSMS.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSMS.Tests.UnitTests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        private ProductRepository repo;

        [TestInitialize]
        public void Setup()
        {
            repo = new ProductRepository();
        }

        [TestMethod]
        public void GetAllProducts_ShouldReturnData()
        {
            var result = repo.GetAllProducts();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count >= 4);
        }

        [TestMethod]
        public void Exists_ShouldReturnTrue_ForP001()
        {
            var result = repo.Exists("P001");

            Assert.IsTrue(result);
        }
    }
}