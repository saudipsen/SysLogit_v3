using NUnit.Framework;
using Moq;
using SysLogit.Repository.Services;
using SysLogit.Repository.Contracts;
using SysLogit.Models;
using System.Collections.Generic;
using System.Linq;

namespace SysLogit.Tests.Repositories
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        private Mock<AppDbContext> _mockDbContext;
        private ProductRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _mockDbContext = new Mock<AppDbContext>();
            _repository = new ProductRepository(_mockDbContext.Object);
        }

        [Test]
        public void GetAll_ShouldReturnAllProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Product 1" },
                new Product { ProductId = 2, ProductName = "Product 2" }
            }.AsQueryable();

            var mockDbSet = MockDbSetHelper.GetMockDbSet(products);
            _mockDbContext.Setup(db => db.Products).Returns(mockDbSet.Object);

            // Act
            var result = _repository.GetAll();

            // Assert
            Assert.That(result.IsSuccess, Is.True);
           
        }

        [Test]
        public void Add_ShouldInsertProductSuccessfully()
        {
            // Arrange
            var product = new Product { ProductId = 3, ProductName = "Product 3" };
            var mockDbSet = MockDbSetHelper.GetMockDbSet(new List<Product>().AsQueryable());
            _mockDbContext.Setup(db => db.Products).Returns(mockDbSet.Object);

            // Act
            var result = _repository.Add(product);

            // Assert
            Assert.That(result.IsSuccess, Is.True);
            Assert.That(result.Message, Is.EqualTo("Product added successfully.")); 
            mockDbSet.Verify(db => db.Add(product), Times.Once);
        }
    }
}
