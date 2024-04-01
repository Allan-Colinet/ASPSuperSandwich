﻿CREATE TABLE Commande (
Id INT PRIMARY KEY IDENTITY,
SandwichId INT NOT NULL,
PainGris BIT DEFAULT 1,
Commentaire VARCHAR(500),
PourQui VARCHAR(40) NOT NULL,
[Date] DateTime NOT NULL,
CONSTRAINT FK_Sandwich_Commande FOREIGN KEY (SandwichId) REFERENCES Sandwich(Id)
)