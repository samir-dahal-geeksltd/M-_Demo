ALTER TABLE ShopProductsLinks ADD Constraint
                [FK_ShopProductsLink.Shop]
                FOREIGN KEY (Shop)
                REFERENCES Shops (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE ShopProductsLinks ADD Constraint
                [FK_ShopProductsLink.Product]
                FOREIGN KEY (Product)
                REFERENCES Products (ID)
                ON DELETE NO ACTION;
GO