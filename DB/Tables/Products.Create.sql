-- Products Table ========================
CREATE TABLE Products (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Category uniqueidentifier  NULL
);
CREATE INDEX [IX_Products->Category] ON Products (Category);

GO

