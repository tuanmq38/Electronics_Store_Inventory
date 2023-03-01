CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NULL, 
    [OrderDate] DATE NULL,
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([CustomerId])
)
