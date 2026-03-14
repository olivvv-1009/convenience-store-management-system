CREATE DATABASE CSMS_DB
GO

USE CSMS_DB
GO

CREATE TABLE Roles (
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL
)

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(200),
    Phone NVARCHAR(20),
    RoleId INT,
    IsLocked BIT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
)

CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(200) NOT NULL
)

CREATE TABLE Products (
    ProductId NVARCHAR(20) PRIMARY KEY,
    ProductName NVARCHAR(200) NOT NULL,
    --Barcode NVARCHAR(100),
    Price FLOAT,
    CategoryId INT,
    ExpiryDate DATE,
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
    UserId INT,
    MemberId INT,
    TotalAmount DECIMAL(12,2),
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (UserId) REFERENCES Users(UserId),
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

INSERT INTO Users(Username,PasswordHash,FullName,RoleId)
VALUES
('admin','123456','Administrator',1),
('staff','123456','Staff User',2)

INSERT INTO Categories(CategoryName)
VALUES
('Dairy'),
('Bakery'),
('Frozen'),
('Beverages')

INSERT INTO Products(ProductId,ProductName,Price,CategoryId,ExpiryDate,Status)
VALUES
('P001','Milk',15000,1,'2026-10-10','Active'),
('P002','Bread',10000,2,'2026-10-05','Active'),
('P003','Ice Cream',25000,3,'2026-05-01','Active'),
('P004','Coca Cola',12000,4,'2027-05-01','Active')

INSERT INTO Inventory(ProductId,Quantity)
VALUES
('P001',50),
('P002',40),
('P003',30),
('P004',60)

INSERT INTO Members(FullName,Phone)
VALUES
('Nguyen Van A','0900000001'),
('Tran Thi B','0900000002')