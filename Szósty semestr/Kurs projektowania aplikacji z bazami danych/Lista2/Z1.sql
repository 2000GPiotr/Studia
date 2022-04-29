SELECT DISTINCT SalesLT.Address.City
FROM SalesLT.SalesOrderHeader, SalesLT.Address
WHERE SalesLT.SalesOrderHeader.ShipToAddressID = SalesLT.Address.AddressID
AND SalesLT.SalesOrderHeader.Status = 5
ORDER BY SalesLT.Address.City --DESC
