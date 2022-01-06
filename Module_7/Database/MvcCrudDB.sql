CREATE TABLE [dbo].[Table]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] VARCHAR(50) NULL, 
    [Price] DECIMAL(18, 2) NULL, 
    [Count] INT NULL
)
