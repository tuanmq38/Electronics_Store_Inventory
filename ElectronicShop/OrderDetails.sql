CREATE TABLE [dbo].[OrderDetails]
(
	[InventoryId] INT NOT NULL , 
    [OrderId] INT NOT NULL, 
    [OrderQuantity] INT NULL, 
    [TotalAmount] FLOAT NULL, 
    CONSTRAINT [FK_OrderDetails_Inventory] FOREIGN KEY ([InventoryId]) REFERENCES [Inventory]([InventoryId]),
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([OrderId]) REFERENCES [Orders]([OrderId]),
    PRIMARY KEY ([InventoryId], [OrderId]), 

)
