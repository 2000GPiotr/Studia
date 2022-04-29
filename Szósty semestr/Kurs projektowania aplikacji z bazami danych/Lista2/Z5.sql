--Utworzy� zapytanie, kt�ry w wyniku zwr�ci trzy kolumny: nazwisko i imi� klienta (Customer) oraz kwot�, kt�r�
--ten klient zaoszcz�dzi� dzi�ki udzielonym rabatom (SalesOrderDetail.UnitPriceDiscount).


SELECT	c.LastName, 
		c.FirstName,
		SUM(d.UnitPriceDiscount * d.OrderQty) AS 'Suma oszcz�dno�ci'
FROM SalesLT.SalesOrderHeader  h
JOIN SalesLT.Customer c ON h.CustomerID = c.CustomerID
JOIN SalesLT.SalesOrderDetail d ON h.SalesOrderID = d.SalesOrderID
GROUP BY c.LastName, FirstName
HAVING SUM(d.UnitPriceDiscount * d.OrderQty) > 0

			

SELECT	MIN(SalesLT.Customer.LastName) AS 'Nazwisko', 
		MIN(SalesLT.Customer.FirstName) AS 'Imi�',
		SUM(SalesLT.SalesOrderDetail.UnitPriceDiscount * SalesLT.SalesOrderDetail.OrderQty) AS 'Suma oszcz�dno�ci'
FROM SalesLT.SalesOrderHeader, SalesLT.Customer, SalesLT.SalesOrderDetail
WHERE SalesLT.SalesOrderHeader.CustomerID = SalesLT.Customer.CustomerID
AND SalesLT.SalesOrderHeader.SalesOrderID =  SalesLT.SalesOrderDetail.SalesOrderID
GROUP BY SalesLT.Customer.CustomerID 
HAVING SUM(SalesLT.SalesOrderDetail.UnitPriceDiscount * SalesLT.SalesOrderDetail.OrderQty) > 0



SELECT	SalesLT.Customer.LastName, 
		SalesLT.Customer.FirstName,
		SUM(SalesLT.SalesOrderDetail.UnitPriceDiscount * SalesLT.SalesOrderDetail.OrderQty) AS 'Suma oszcz�dno�ci'
FROM SalesLT.SalesOrderHeader, SalesLT.Customer, SalesLT.SalesOrderDetail
WHERE SalesLT.SalesOrderHeader.CustomerID = SalesLT.Customer.CustomerID
AND SalesLT.SalesOrderHeader.SalesOrderID =  SalesLT.SalesOrderDetail.SalesOrderID
GROUP BY SalesLT.Customer.LastName, FirstName
HAVING SUM(SalesLT.SalesOrderDetail.UnitPriceDiscount * SalesLT.SalesOrderDetail.OrderQty) > 0
