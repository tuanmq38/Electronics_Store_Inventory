CREATE TABLE [dbo].[Inventory]
(
	[InventoryId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [UnitInStock] INT NULL, 
    [UnitPrice] FLOAT NULL, 
    [CategoryId] INT NULL,
    [Type] VARCHAR(50) NULL, 
    [Current] VARCHAR(10) NULL, 
    [Voltage] VARCHAR(10) NULL, 
    [Version] NCHAR(2) NULL, 
    CONSTRAINT [FK_Inventory_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([CategoryId]), 

)
