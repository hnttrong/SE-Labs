IF DB_ID(N'Lab4DB') IS NULL
BEGIN
    CREATE DATABASE Lab4DB;
END
GO

USE Lab4DB;
GO

IF OBJECT_ID(N'dbo.tblUsers', N'U') IS NULL
CREATE TABLE dbo.tblUsers
(
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.tblCustomers', N'U') IS NULL
CREATE TABLE dbo.tblCustomers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.tblProducts', N'U') IS NULL
CREATE TABLE dbo.tblProducts
(
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(18,2) NOT NULL CHECK (Price >= 0),
    Stock INT NOT NULL CHECK (Stock >= 0)
);
GO

IF OBJECT_ID(N'dbo.tblSuppliers', N'U') IS NULL
CREATE TABLE dbo.tblSuppliers
(
    SupplierId INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL
);
GO

IF OBJECT_ID(N'dbo.tblStudents', N'U') IS NULL
CREATE TABLE dbo.tblStudents
(
    StudentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Age INT NOT NULL CHECK (Age BETWEEN 0 AND 120),
    YearOfEnroll INT NOT NULL,
    Major NVARCHAR(50) NULL,
    GPA DECIMAL(3,2) NULL CHECK (GPA BETWEEN 0 AND 4)
);
GO

IF NOT EXISTS (SELECT 1 FROM dbo.tblUsers)
INSERT INTO dbo.tblUsers (Username, Password) VALUES
(N'admin', N'123456'), (N'user1', N'password1');

IF NOT EXISTS (SELECT 1 FROM dbo.tblCustomers)
INSERT INTO dbo.tblCustomers (Name, Email) VALUES
(N'John Doe', N'john.doe@tdtu.com'),
(N'Jane Smith', N'jane.smith@tdtu.com'),
(N'Trung Pham', N'trung.pham@tdtu.com');

IF NOT EXISTS (SELECT 1 FROM dbo.tblProducts)
INSERT INTO dbo.tblProducts (ProductName, Price, Stock) VALUES
(N'Laptop', 18500000, 8), (N'Wireless Mouse', 350000, 25), (N'Mechanical Keyboard', 1200000, 12);

IF NOT EXISTS (SELECT 1 FROM dbo.tblSuppliers)
INSERT INTO dbo.tblSuppliers (SupplierName, Phone, Email) VALUES
(N'TDT Technology', N'0901234567', N'sales@tdttech.vn'),
(N'Saigon Devices', N'0912345678', N'contact@saigondevices.vn');

IF NOT EXISTS (SELECT 1 FROM dbo.tblStudents)
INSERT INTO dbo.tblStudents (StudentName, DateOfBirth, City, Age, YearOfEnroll, Major, GPA) VALUES
(N'Trung Pham', '2000-01-15', N'HCMC', 24, 2018, N'Computer Science', 3.50),
(N'Jane Smith', '1999-05-22', N'Los Angeles', 25, 2017, N'Mathematics', 3.80),
(N'Alice Johnson', '2001-03-10', N'Chicago', 23, 2019, N'Physics', 3.60),
(N'Bob Brown', '2002-07-30', N'Houston', 22, 2020, N'Chemistry', 3.70);
GO
