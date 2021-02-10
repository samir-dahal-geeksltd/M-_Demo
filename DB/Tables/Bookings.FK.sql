ALTER TABLE Bookings ADD Constraint
                [FK_Booking.Agency]
                FOREIGN KEY (Agency)
                REFERENCES Agencies (ID)
                ON DELETE NO ACTION;
GO