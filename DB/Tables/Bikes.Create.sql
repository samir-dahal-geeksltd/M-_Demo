-- Bikes Table ========================
CREATE TABLE Bikes (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    RequiresLicense bit  NOT NULL
);

