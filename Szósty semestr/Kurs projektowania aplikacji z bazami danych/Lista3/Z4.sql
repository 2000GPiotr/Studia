CREATE TYPE CzytelnikType AS TABLE   
    ( ID int);  
GO  

CREATE OR ALTER PROCEDURE Z4 
@Person_ID CzytelnikType READONLY
AS
BEGIN
	SELECT dbo.Czytelnik.Czytelnik_ID, SUM(Liczba_dni)
	FROM dbo.Czytelnik, dbo.Wypozyczenie, @Person_ID
	WHERE ID = dbo.Wypozyczenie.Czytelnik_ID
	AND dbo.Czytelnik.Czytelnik_ID = dbo.Wypozyczenie.Czytelnik_ID
	GROUP BY dbo.Czytelnik.Czytelnik_ID	
END
GO

DECLARE @Czytelnicy_ID AS CzytelnikType;

INSERT INTO @Czytelnicy_ID (ID) 
SELECT TOP 2 Czytelnik_ID FROM Czytelnik
ORDER BY Czytelnik.Czytelnik_ID;

EXEC Z4 @Czytelnicy_ID

SELECT dbo.Czytelnik.Czytelnik_ID, SUM(Liczba_dni)
FROM dbo.Czytelnik
LEFT JOIN dbo.Wypozyczenie ON dbo.Czytelnik.Czytelnik_ID = dbo.Wypozyczenie.Czytelnik_ID
GROUP BY dbo.Czytelnik.Czytelnik_ID