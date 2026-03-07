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
    CategoryName NVARCHAR(200)
)

CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(200) NOT NULL,
    Barcode NVARCHAR(100),
    Price DECIMAL(10,2) NOT NULL,
    CategoryId INT,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
)

CREATE TABLE Inventory (
    InventoryId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
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
    ProductId INT,
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
('Drink'),
('Snack'),
('Food')

INSERT INTO Products(ProductName,Barcode,Price,CategoryId)
VALUES
('Coca Cola','111111',10000,1),
('Pepsi','222222',10000,1),
('Potato Chips','333333',15000,2)

INSERT INTO Inventory(ProductId,Quantity)
VALUES
(1,50),
(2,40),
(3,30)

INSERT INTO Members(FullName,Phone)
VALUES
('Nguyen Van A','0900000001'),
('Tran Thi B','0900000002')