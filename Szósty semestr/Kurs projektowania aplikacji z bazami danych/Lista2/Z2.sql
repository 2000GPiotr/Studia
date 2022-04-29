SELECT SalesLT.ProductModel.Name, COUNT(SalesLT.Product.ProductID) AS "Liczba produktów"
FROM SalesLT.ProductModel, SalesLT.Product
WHERE SalesLT.ProductModel.ProductModelID = SalesLT.Product.ProductModelID
GROUP BY SalesLT.ProductModel.Name, SalesLT.ProductModel.ProductModelID
HAVING COUNT(SalesLT.Product.ProductID) > 1
ORDER BY COUNT(SalesLT.Product.ProductID) --DESC