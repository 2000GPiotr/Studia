CREATE OR ALTER PROCEDURE addReader
@pesel varchar(50),
@nazwisko varchar(30),
@miasto varchar(30),
@data date
AS 
BEGIN
	IF(LEN(@pesel) != 11)
		THROW 50001, 'Z³a d³ugoœæ PESELU', 1;

	declare @k int
	set @k = 0

	set @k = @k + (SUBSTRING(@pesel, 1, 1) * 1) % 10
	set @k = @k + (SUBSTRING(@pesel, 2, 1) * 3) % 10
	set @k = @k + (SUBSTRING(@pesel, 3, 1) * 7) % 10
	set @k = @k + (SUBSTRING(@pesel, 4, 1) * 9) % 10
	set @k = @k + (SUBSTRING(@pesel, 5, 1) * 1) % 10
	set @k = @k + (SUBSTRING(@pesel, 6, 1) * 3) % 10
	set @k = @k + (SUBSTRING(@pesel, 7, 1) * 7) % 10
	set @k = @k + (SUBSTRING(@pesel, 8, 1) * 9) % 10
	set @k = @k + (SUBSTRING(@pesel, 9, 1) * 1) % 10
	set @k = @k + (SUBSTRING(@pesel, 10, 1) * 3) % 10

		
	set @k = @k % 10

	IF(10 - @k != SUBSTRING(@pesel, 11, 1))
		THROW 50002, 'Z³a suma kontrolna', 1;

	IF(YEAR(@data) < 1900)
		THROW 66666, 'Taki czytelnik nie ¿yje', 1;

	IF(YEAR(@data) < 2000)
	BEGIN
		IF(YEAR(@data) != 1900 + SUBSTRING(@pesel, 1, 2))
			THROW 50091, 'B³¹d w peselu lub dacie urodzenia (rok)', 1;
		IF(MONTH(@data) != SUBSTRING(@pesel, 3, 2))
			THROW 50092, 'B³¹d w peselu lub dacie urodzenia (miesi¹c)', 1;
		if(DAY(@data) != SUBSTRING(@pesel, 5, 2))
			THROW 50093, 'B³¹d w peselu lub dacie urodzenia (dzieñ)', 1;
	END
	ELSE
	BEGIN
		IF(YEAR(@data) != 2000 + SUBSTRING(@pesel, 1, 2))
			THROW 50021, 'B³¹d w peselu lub dacie urodzenia (rok)', 1;
		IF(MONTH(@data) + 20 != SUBSTRING(@pesel, 3, 2))
			THROW 50022, 'B³¹d w peselu lub dacie urodzenia (miesi¹c)', 1;
		IF(DAY(@data) != SUBSTRING(@pesel, 5, 2))
			THROW 50023, 'B³¹d w peselu lub dacie urodzenia (dzieñ)', 1;
	END	

	IF(@nazwisko not like '[A-Z]%' COLLATE Latin1_General_BIN)
	OR((SUBSTRING(@nazwisko, 2, LEN(@nazwisko))) not like (LOWER(SUBSTRING(@nazwisko, 2, LEN(@nazwisko)))) COLLATE Latin1_General_BIN)
	OR(@nazwisko not like '__%')
		THROW 50001, 'B³¹d w nazwisku', 1;
		

--	THROW 50000, 'OK', 1;
	INSERT INTO Czytelnik VALUES(@pesel, @nazwisko, @miasto,  @data, NULL)
	
END
GO



DELETE FROM Czytelnik WHERE PESEL = '02070803628'
EXEC addReader
@pesel = '02070803628',
@nazwisko = 'Egju',
@miasto = 'Wroc³aw',
@data = '1902-07-08'
GO

DELETE FROM Czytelnik WHERE PESEL = '03221491455'
EXEC addReader
@pesel = '03221491455',
@nazwisko = 'Afsdfgju',
@miasto = 'Warszawa',
@data = '2003-02-14'
GO

EXEC addReader
@pesel = '020708036275',
@nazwisko = 'Etkuuuu',
@miasto = 'Wroc³aw',
@data = '1902-07-08'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'Etkuuuu',
@miasto = 'Wroc³aw',
@data = '1902-07-08'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'Fteshg',
@miasto = 'Wroc³aw',
@data = '1995-07-08'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'Fteshg',
@miasto = 'Wroc³aw',
@data = '1995-03-08'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'F',
@miasto = 'Wroc³aw',
@data = '1995-03-10'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'FasdEEd',
@miasto = 'Wroc³aw',
@data = '1995-03-10'
GO

EXEC addReader
@pesel = '95031071536',
@nazwisko = 'dsfdd',
@miasto = 'Wroc³aw',
@data = '1995-03-10'
GO
