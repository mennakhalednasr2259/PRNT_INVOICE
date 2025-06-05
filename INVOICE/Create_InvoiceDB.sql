
CREATE DATABASE InvoiceDB;
GO


USE InvoiceDB;
GO


CREATE TABLE InvoiceDetails (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100),
    InvoiceDate DATE,
    Item NVARCHAR(100),
    Quantity INT,
    Price DECIMAL(18,2),
    Total AS (Quantity * Price) PERSISTED
);
GO


INSERT INTO InvoiceDetails (CustomerName, InvoiceDate, Item, Quantity, Price)
VALUES 
('Ahmed Ali', GETDATE(), 'Laptop', 2, 7500),
('Ahmed Ali', GETDATE(), 'Mouse', 3, 120),
('Sara Mohamed', GETDATE(), 'Keyboard', 1, 500);
GO
