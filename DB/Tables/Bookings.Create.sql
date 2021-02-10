-- Bookings Table ========================
CREATE TABLE Bookings (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Customer nvarchar(200)  NULL,
    Destination nvarchar(200)  NULL,
    [Date] datetime2  NULL,
    Agency uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Bookings->Agency] ON Bookings (Agency);

GO

