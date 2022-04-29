ALTER TABLE SalesLT.Customer 
DROP COLUMN CreditCardNumber 

ALTER TABLE SalesLT.Customer 
ADD CreditCardNumber varchar(4)

SELECT * FROM SalesLT.SalesOrderHeader

UPDATE SalesLT.SalesOrderHeader SET CreditCardApprovalCode='1' WHERE SalesOrderID = 71774; 
UPDATE SalesLT.SalesOrderHeader SET CreditCardApprovalCode='2' WHERE SalesOrderID = 71776; 
UPDATE SalesLT.SalesOrderHeader SET CreditCardApprovalCode='3' WHERE SalesOrderID = 71780; 

UPDATE SalesLT.Customer SET CreditCardNumber = 'X' WHERE SalesLT.Customer.CustomerID 
IN (SELECT SalesLT.Customer.CustomerID FROM SalesLT.Customer, SalesLT.SalesOrderHeader 
WHERE Customer.CustomerID = SalesOrderHeader.CustomerID AND SalesOrderHeader.CreditCardApprovalCode IS NOT Null)

UPDATE SalesLT.Customer SET CreditCardNumber = 'Y' WHERE SalesLT.Customer.CustomerID 
IN (SELECT SalesLT.Customer.CustomerID 
	FROM SalesLT.Customer
	JOIN SalesLT.SalesOrderHeader ON Customer.CustomerID = SalesOrderHeader.CustomerID
WHERE SalesOrderHeader.CreditCardApprovalCode IS NOT Null)


Select * 
From SalesLT.Customer AS customer
WHERE customer.CreditCardNumber IS NOT NULL