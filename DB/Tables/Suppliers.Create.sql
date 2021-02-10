-- Suppliers Table ========================
CREATE TABLE Suppliers (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    CompanyName nvarchar(200)  NULL,
    AddressLine1 nvarchar(200)  NULL,
    AddressLine2 nvarchar(200)  NULL,
    Town nvarchar(200)  NULL,
    Postcode nvarchar(200)  NULL
);

