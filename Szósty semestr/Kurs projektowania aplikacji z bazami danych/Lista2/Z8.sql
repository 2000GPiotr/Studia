UPDATE SalesLT.SalesOrderHeader SET ShipDate = '2008-06-20 00:00:00.000'
WHERE SalesOrderID = 71774

SELECT * FROM SalesLT.SalesOrderHeader

ALTER TABLE  SalesLT.SalesOrderHeader NOCHECK CONSTRAINT CK_SalesOrderHeader_ShipDate

ALTER TABLE  SalesLT.SalesOrderHeader CHECK CONSTRAINT CK_SalesOrderHeader_ShipDate

DBCC CHECKCONSTRAINTS('SalesLT.SalesOrderHeader')
