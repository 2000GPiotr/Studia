DROP TABLE IF EXISTS Imiona
GO

CREATE TABLE Imiona(
	ID INT IDENTITY(0, 1),
	Imie VARCHAR(30)
)
GO

INSERT INTO Imiona VALUES('Piotr')
INSERT INTO Imiona VALUES('Jan')
INSERT INTO Imiona VALUES('Pawe³')
INSERT INTO Imiona VALUES('Jakub')
INSERT INTO Imiona VALUES('Krzysztof')
INSERT INTO Imiona VALUES('Grzegorz')
INSERT INTO Imiona VALUES('Micha³')
INSERT INTO Imiona VALUES('Marek')
INSERT INTO Imiona VALUES('Antoni')


DROP TABLE IF EXISTS Nazwiska
GO

DROP TABLE IF EXISTS Nazwiska
GO

CREATE TABLE Nazwiska(
	ID INT IDENTITY(0, 1),
	Nazwisko VARCHAR(30)
)
GO

INSERT INTO Nazwiska VALUES('Malinowski')
INSERT INTO Nazwiska VALUES('Kowalski')
INSERT INTO Nazwiska VALUES('Iksiñski')
INSERT INTO Nazwiska VALUES('Igrekowski')
INSERT INTO Nazwiska VALUES('Nowak')
GO

DROP TABLE IF EXISTS Dane
GO

CREATE TABLE Dane(
	Imie VARCHAR(30),
	Nazwisko VARCHAR(30),
	CONSTRAINT PK_Dane PRIMARY KEY (Imie, Nazwisko)
)
GO

CREATE OR ALTER PROCEDURE combine
@n int
AS 
BEGIN
	TRUNCATE TABLE Dane

	declare @imiona_l int
	declare @nazwiska_l int

	set @imiona_l = (SELECT COUNT(DISTINCT imie) FROM Imiona)
	set @nazwiska_l = (SELECT COUNT (DISTINCT nazwisko) FROM Nazwiska)

	declare @i int
	set @i = 0

	declare @max int
	set @max = (@imiona_l * @nazwiska_l)

	IF(@n > @max/2) 
		THROW 50000, '@n jest wiêksze od po³owy mo¿liwych komginacji', 1;

	WHILE(@i < @n)
	BEGIN
		declare @imie varchar(30)
		declare @nazwisko varchar(30)
		set @imie = (SELECT TOP 1 Imie FROM Imiona ORDER BY NEWID())
		set @nazwisko = (SELECT TOP 1 Nazwisko FROM Nazwiska ORDER BY NEWID())

		IF NOT EXISTS (SELECT * FROM Dane WHERE Imie = @imie AND Nazwisko = @nazwisko)
		BEGIN
			INSERT INTO Dane VALUES (@imie, @nazwisko)
			set @i = @i + 1
		END
	END
--	INSERT INTO Dane VALUES (@imie, @nazwisko)
END
GO

EXECUTE combine @n=23
GO

EXECUTE combine @n=22
GO

--EXECUTE combine @n=45
GO

SELECT * FROM Dane ORDER BY Imie
