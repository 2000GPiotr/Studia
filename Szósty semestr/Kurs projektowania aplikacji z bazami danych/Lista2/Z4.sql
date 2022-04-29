--Kategorie produktów s¹ w strukturze drzewa. Mo¿emy oczekiwaæ, ¿e wszystkie produkty bêd¹ przypisane tylko
--do kategorii bêd¹cych w liœciach tego drzewa. Utworzyæ zapytanie, które zwróci dwie kolumny: nazwê kategorii
--i nazwê produktu dla produktów bêd¹cych przypisanych do kategorii nie bêd¹cych w liœciach.

SELECT SalesLT.Product.ProductCategoryID, SalesLT.ProductCategory.Name AS 'Nazwa kategorii', SalesLT.Product.Name AS 'Nazwa produktu'
FROM SalesLT.ProductCategory, SalesLT.Product
WHERE SalesLT.ProductCategory.ProductCategoryID = SalesLT.Product.ProductCategoryID
AND SalesLT.Product.ProductCategoryID IN
	(SELECT DISTINCT SalesLT.ProductCategory.ParentProductCategoryID
	FROM SalesLT.ProductCategory)

	--popsu³em Product
/*
SELECT SalesLT.ProductCategory.Name
FROM SalesLT.ProductCategory
WHERE SalesLT.ProductCategory.ProductCategoryID IN
	(SELECT DISTINCT SalesLT.ProductCategory.ParentProductCategoryID
	FROM SalesLT.ProductCategory)
	*/