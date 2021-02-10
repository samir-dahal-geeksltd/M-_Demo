-- Agencies Table ========================
CREATE TABLE Agencies (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NULL,
    Notes nvarchar(200)  NULL
);

