--Utworzyæ zapytanie, które w wyniku zwróci trzy kolumny: nazwê miasta (z tabeli Address), liczb¹ klientów z
--tego miasta, liczb¹ SalesPerson obs³uguj¹cych klientów z tego miasta.

SELECT SalesLT.Address.City, COUNT(DISTINCT SalesLT.Customer.CustomerID) AS	"Liczba klientów", COUNT(DISTINCT SalesLT.Customer.SalesPerson) AS "Liczba obs³uguj¹cych"
FROM SalesLT.CustomerAddress, SalesLT.Address, SalesLT.Customer
WHERE SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID
AND SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID
GROUP BY SalesLT.Address.City
