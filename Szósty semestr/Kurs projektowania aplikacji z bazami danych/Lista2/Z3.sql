--Utworzy� zapytanie, kt�re w wyniku zwr�ci trzy kolumny: nazw� miasta (z tabeli Address), liczb� klient�w z
--tego miasta, liczb� SalesPerson obs�uguj�cych klient�w z tego miasta.

SELECT SalesLT.Address.City, COUNT(DISTINCT SalesLT.Customer.CustomerID) AS	"Liczba klient�w", COUNT(DISTINCT SalesLT.Customer.SalesPerson) AS "Liczba obs�uguj�cych"
FROM SalesLT.CustomerAddress, SalesLT.Address, SalesLT.Customer
WHERE SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID
AND SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID
GROUP BY SalesLT.Address.City
