CREATE OR ALTER FUNCTION borrowedBook(@n int) RETURNS TABLE AS
	RETURN 
		SELECT Czytelnik.PESEL, COUNT(Wypozyczenie.Wypozyczenie_ID) AS "Egzemplarze"
		FROM Czytelnik
		JOIN Wypozyczenie ON Wypozyczenie.Czytelnik_ID = Czytelnik.Czytelnik_ID
		GROUP BY Czytelnik.PESEL
		HAVING MAX(Wypozyczenie.Liczba_Dni) >= @n
GO

SELECT * FROM borrowedBook(1)
SELECT * FROM borrowedBook(14)