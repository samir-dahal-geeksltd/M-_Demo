-- ShopProductsLinks Table ========================
CREATE TABLE ShopProductsLinks (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Shop uniqueidentifier  NOT NULL,
    Product uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_ShopProductsLinks->Shop] ON ShopProductsLinks (Shop);

GO

CREATE INDEX [IX_ShopProductsLinks->Product] ON ShopProductsLinks (Product);

GO

