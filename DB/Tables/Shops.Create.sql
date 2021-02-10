-- Shops Table ========================
CREATE TABLE Shops (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Address nvarchar(2000)  NULL
);

