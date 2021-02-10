ALTER TABLE SupplierServices ADD Constraint
                [FK_SupplierService.Supplier]
                FOREIGN KEY (Supplier)
                REFERENCES Suppliers (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE SupplierServices ADD Constraint
                [FK_SupplierService.ServiceType]
                FOREIGN KEY (ServiceType)
                REFERENCES ServiceTypes (ID)
                ON DELETE NO ACTION;
GO