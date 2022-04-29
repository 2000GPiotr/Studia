ALTER TABLE Towary NOCHECK CONSTRAINT ALL
ALTER TABLE Kursy NOCHECK CONSTRAINT ALL
ALTER TABLE Ceny NOCHECK CONSTRAINT ALL

DROP TABLE IF EXISTS Towary

CREATE TABLE Towary(
	ID INT PRIMARY KEY,
	NazwaTowaru VARCHAR(30)
)
GO

DROP TABLE IF EXISTS Kursy

CREATE TABLE Kursy(
	Waluta VARCHAR(3) PRIMARY KEY,
	CenaPLN MONEY
)
GO

DROP TABLE IF EXISTS Ceny

CREATE TABLE Ceny(
	TowarID INT REFERENCES Towary(ID),
	Waluta VARCHAR(3) REFERENCES Kursy(Waluta),
	Cena MONEY
)
GO

ALTER TABLE Towary WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE Kursy WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE Ceny WITH CHECK CHECK CONSTRAINT ALL


INSERT INTO Towary VALUES(1, 'banan')
INSERT INTO Towary VALUES(2, 'jab³ko')
INSERT INTO Towary VALUES(3, 'wiœnia')

INSERT INTO Kursy VALUES('PLN', 1.00)
INSERT INTO Kursy VALUES('EUR', 4.00)
INSERT INTO Kursy VALUES('USD', 4.50)
INSERT INTO Kursy VALUES('RUB', 0.04)
INSERT INTO Kursy VALUES('CZK', 0.20)

INSERT INTO Ceny VALUES(1, 'PLN', 8.00)
INSERT INTO Ceny VALUES(2, 'PLN', 7.00)
INSERT INTO Ceny VALUES(3, 'PLN', 3.49)
INSERT INTO Ceny VALUES(1, 'EUR', 1.72)
INSERT INTO Ceny VALUES(1, 'USD', 2.03)
INSERT INTO Ceny VALUES(2, 'RUB', 140.00)
INSERT INTO Ceny VALUES(2, 'CZK', 38.88)
INSERT INTO Ceny VALUES(3, 'EUR', 0.75)
INSERT INTO Ceny VALUES(3, 'CZK', 19.38)

--------------------------------------------------------------------

DECLARE Kursy_kursor CURSOR FOR SELECT Waluta, CenaPLN FROM Kursy
DECLARE Towary_kursor CURSOR FOR SELECT TowarID, Waluta, Cena FROM Ceny

DECLARE @kurs_waluta VARCHAR(3), @kurs_cenaPLN MONEY
DECLARE @towar_ID INT, @towar_waluta VARCHAR(3), @towar_cena MONEY
DECLARE @akt_Cena MONEY
DECLARE @delete BIT

OPEN Towary_kursor
FETCH NEXT FROM Towary_kursor INTO @towar_ID, @towar_waluta, @towar_cena
SET @akt_Cena = (SELECT Cena FROM Ceny WHERE TowarID = @towar_ID AND Waluta = 'PLN')
WHILE (@@FETCH_STATUS = 0)
BEGIN
	OPEN Kursy_kursor
	FETCH NEXT FROM Kursy_kursor INTO @kurs_waluta, @kurs_cenaPLN
	SET @delete = 1
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		IF(@towar_waluta = @kurs_waluta)
		BEGIN
			SET @towar_cena = @akt_Cena / @kurs_cenaPLN
			UPDATE Ceny
			SET Cena = @towar_cena
			WHERE TowarID = @towar_ID AND Waluta = @towar_waluta
			SET @delete = 0
		END
		FETCH NEXT FROM Kursy_kursor INTO @kurs_waluta, @kurs_cenaPLN
	END
	IF(@delete=1)
		DELETE FROM Ceny WHERE TowarID = @towar_ID AND Waluta = @towar_waluta
	CLOSE Kursy_kursor
	FETCH NEXT FROM Towary_kursor INTO @towar_ID, @towar_waluta, @towar_cena
	SET @akt_Cena = (SELECT Cena FROM Ceny WHERE TowarID = @towar_ID AND Waluta = 'PLN')
END
CLOSE Towary_kursor
DEALLOCATE Kursy_kursor
DEALLOCATE Towary_kursor
GO