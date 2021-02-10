-- SupplierServices Table ========================
CREATE TABLE SupplierServices (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Supplier uniqueidentifier  NULL,
    ServiceType uniqueidentifier  NULL,
    Price numeric(27, 2)  NULL
);
CREATE INDEX [IX_SupplierServices->Supplier] ON SupplierServices (Supplier);

GO

