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
    public class ShipmentRepositoryTests
    {
        private Mock<AppDbContext> _mockDbContext;
        private ShipmentRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _mockDbContext = new Mock<AppDbContext>();
            _repository = new ShipmentRepository(_mockDbContext.Object);
        }

        [Test]
        public void GetAll_ShouldReturnAllShipments()
        {
            // Arrange
            var shipments = new List<Shipment>
            {
                new Shipment { ShipmentId = 1, ShipmentDescription = "Shipment 1", ProductId = 1, ProductQnty = 10, ConsignmentId = "C001" },
                new Shipment { ShipmentId = 2, ShipmentDescription = "Shipment 2", ProductId = 2, ProductQnty = 20, ConsignmentId = "C002" }
            }.AsQueryable();

            var mockDbSet = MockDbSetHelper.GetMockDbSet(shipments);
            _mockDbContext.Setup(db => db.Shipments).Returns(mockDbSet.Object);

            // Act
            var result = _repository.GetAll();

            // Assert
            Assert.That(result.IsSuccess, Is.True);
            
        }

        [Test]
        public void Add_ShouldInsertShipmentSuccessfully()
        {
            // Arrange
            var shipment = new Shipment { ShipmentId = 3, ShipmentDescription = "Shipment 3", ProductId = 3, ProductQnty = 15, ConsignmentId = "C003" };
            var mockDbSet = MockDbSetHelper.GetMockDbSet(new List<Shipment>().AsQueryable());
            _mockDbContext.Setup(db => db.Shipments).Returns(mockDbSet.Object);

            // Act
            var result = _repository.Add(shipment);

            // Assert
            Assert.That(result.IsSuccess, Is.True);
            mockDbSet.Verify(db => db.Add(shipment), Times.Once);
        }
    }
}
