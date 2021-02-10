ALTER TABLE TimeLogs ADD Constraint
                [FK_TimeLog.Project]
                FOREIGN KEY (Project)
                REFERENCES Projects (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE TimeLogs ADD Constraint
                [FK_TimeLog.Developer]
                FOREIGN KEY (Developer)
                REFERENCES Developers (ID)
                ON DELETE NO ACTION;
GO