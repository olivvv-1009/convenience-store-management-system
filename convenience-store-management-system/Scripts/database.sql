USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'CSMS_DB')
BEGIN
    ALTER DATABASE CSMS_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CSMS_DB;
END
GO

CREATE DATABASE CSMS_DB
GO

USE CSMS_DB
GO

CREATE TABLE Roles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,

    Username NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,

    RoleId INT NOT NULL,
    IsLocked BIT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
)

CREATE TABLE Employees (
    EmployeeId INT IDENTITY(1,1) PRIMARY KEY,

    FullName NVARCHAR(200) NOT NULL,
    Email NVARCHAR(200),
    Phone NVARCHAR(20),

    Position NVARCHAR(100), -- Cashier, Manager...
    HireDate DATETIME DEFAULT GETDATE(),

    IsActive BIT DEFAULT 1
)

CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(200) NOT NULL
)

CREATE TABLE Products (
    ProductId NVARCHAR(20) PRIMARY KEY,
    ProductName NVARCHAR(200) NOT NULL,
    Price DECIMAL(10,2),
    CategoryId INT,
    Status NVARCHAR(50),

    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
)

CREATE TABLE Inventory (
    InventoryId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId NVARCHAR(20),
    Quantity INT,
    MinimumStock INT DEFAULT 10,
    LastUpdated DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)

CREATE TABLE Batches (
    BatchId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId NVARCHAR(20) NOT NULL,
    UnitCost DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL,
    ExpiryDate DATE,
    ImportedDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)

CREATE TABLE Members (
    MemberId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(200),
    Phone NVARCHAR(20) UNIQUE,
    Points INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE()
)

CREATE TABLE Promotions (
    PromotionId INT IDENTITY(1,1) PRIMARY KEY,
    PromotionName NVARCHAR(200),
    DiscountPercent INT,
    StartDate DATETIME,
    EndDate DATETIME
)

CREATE TABLE Invoices (
    InvoiceId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT,
    MemberId INT,
    TotalAmount DECIMAL(12,2),
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
    FOREIGN KEY (MemberId) REFERENCES Members(MemberId)
)

CREATE TABLE InvoiceDetails (
    InvoiceDetailId INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT,
    ProductId NVARCHAR(20),
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    SubTotal DECIMAL(12,2),

    FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)

CREATE TABLE Payments (
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceId INT,
    PaymentMethod NVARCHAR(50),
    AmountPaid DECIMAL(12,2),
    PaymentDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId)
)

INSERT INTO Roles(RoleName)
VALUES
('Admin'),
('Staff')

INSERT INTO Users(Username, PasswordHash, RoleId)
VALUES
('admin','123456',1),
('staff','123456',2)
-- Employees 
INSERT INTO Employees (FullName, Email, Position)
VALUES
('Nguyen Van A', 'a@gmail.com', 'Manager'),
('Tran Thi B', 'b@gmail.com', 'Staff'),
('Le Van C', 'c@gmail.com', 'Staff')

INSERT INTO Categories(CategoryName)
VALUES
('Dairy'),
('Bakery'),
('Frozen'),
('Beverages')

INSERT INTO Products(ProductId,ProductName,Price,CategoryId,Status)
VALUES
('P001','Milk',15000,1,'Active'),
('P002','Bread',10000,2,'Active'),
('P003','Ice Cream',25000,3,'Active'),
('P004','Coca Cola',12000,4,'Active')

INSERT INTO Inventory(ProductId,Quantity)
VALUES
('P001',50),
('P002',40),
('P003',30),
('P004',60)

INSERT INTO Batches(ProductId,UnitCost,Quantity,ExpiryDate)
VALUES
('P001',12000,30,'2026-10-10'),
('P001',12500,20,'2026-11-01'),
('P002',7000,40,'2026-10-05'),
('P003',18000,30,'2026-05-01'),
('P004',9000,60,'2027-05-01')

INSERT INTO Members(FullName,Phone)
VALUES
('Nguyen Van A','0900000001'),
('Tran Thi B','0900000002')

ALTER TABLE Batches
ADD Supplier NVARCHAR(200)

ALTER TABLE Batches
ADD BatchNumber NVARCHAR(50)
GO

UPDATE Batches
SET BatchNumber = 'BATCH-' + ProductId + '-' + FORMAT(ExpiryDate,'yyyyMMdd')
WHERE BatchNumber IS NULL

ALTER TABLE Products
ADD ExpiryDate DATE

ALTER TABLE Members
ADD TotalSpent DECIMAL(12,2) DEFAULT 0

-- Unique Inventory
ALTER TABLE Inventory
ADD CONSTRAINT UQ_Inventory_Product UNIQUE(ProductId)

-- Payment status
ALTER TABLE Payments
ADD Status NVARCHAR(50) DEFAULT 'Paid'

-- Promotion mapping
CREATE TABLE PromotionProducts (
    PromotionId INT,
    ProductId NVARCHAR(20),

    PRIMARY KEY (PromotionId, ProductId),
    FOREIGN KEY (PromotionId) REFERENCES Promotions(PromotionId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)

-- Index
CREATE INDEX idx_product_CategoryName ON Products(CategoryId)
CREATE INDEX idx_inventory_product ON Inventory(ProductId)

ALTER TABLE Batches
ADD CONSTRAINT FK_Batches_Product
FOREIGN KEY (ProductId)
REFERENCES Products(ProductId)
ON DELETE CASCADE

ALTER TABLE dbo.Inventory
ADD CONSTRAINT FK_Inventory_Product
FOREIGN KEY (ProductId)
REFERENCES Products(ProductId)
ON DELETE CASCADE

CREATE TABLE Suppliers (
    SupplierId NVARCHAR(20) PRIMARY KEY,
    SupplierName NVARCHAR(200) NOT NULL
)

INSERT INTO Suppliers (SupplierId, SupplierName)
VALUES
('S001', 'Store A'),
('S002', 'Store B')
