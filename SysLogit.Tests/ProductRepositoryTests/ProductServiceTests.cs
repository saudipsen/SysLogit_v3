using NUnit.Framework;
using Moq;
using SysLogit.Business.Services;
using SysLogit.Repository.Contracts;
using SysLogit.Models;
using System.Collections.Generic;
using SysLogit.Utility;
using System.Linq;

namespace SysLogit.Tests.Business
{
    [TestFixture]
    public class ProductServiceTests
    {
        private Mock<IProductRepository> _mockRepository;
        private ProductService _service;

        [SetUp]
        public void SetUp()
        {
            _mockRepository = new Mock<IProductRepository>();
            _service = new ProductService(_mockRepository.Object);
        }

        [Test]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Product 1" },
                new Product { ProductId = 2, ProductName = "Product 2" }
            };
            _mockRepository.Setup(repo => repo.GetAll()).Returns(new Response<IEnumerable<Product>>(true, "Success", products));

            // Act
            var result = _service.GetAllProducts();

            // Assert
            Assert.That(result.IsSuccess);
           
        }
    }
}
