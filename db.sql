CREATE TABLE [Product] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Lot] nvarchar(max) NOT NULL,
    [Unit] nvarchar(max) NOT NULL,
    [Price] int NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY ([Id])
);
GO


