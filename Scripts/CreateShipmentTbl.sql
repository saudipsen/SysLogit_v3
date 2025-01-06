CREATE TABLE Shipments (
    ShipmentId INT IDENTITY(1,1) PRIMARY KEY,
    ShipmentDescription NVARCHAR(200) NOT NULL,
    CreatedOn DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedOn DATETIME NULL,
    CreatedBy NVARCHAR(50) NOT NULL,
    ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
	ProductQnty INT NOT NULL,
    ConsignmentId NVARCHAR(50) NOT NULL
);

