--Kategorie produkt�w s� w strukturze drzewa. Mo�emy oczekiwa�, �e wszystkie produkty b�d� przypisane tylko
--do kategorii b�d�cych w li�ciach tego drzewa. Utworzy� zapytanie, kt�re zwr�ci dwie kolumny: nazw� kategorii
--i nazw� produktu dla produkt�w b�d�cych przypisanych do kategorii nie b�d�cych w li�ciach.

SELECT SalesLT.Product.ProductCategoryID, SalesLT.ProductCategory.Name AS 'Nazwa kategorii', SalesLT.Product.Name AS 'Nazwa produktu'
FROM SalesLT.ProductCategory, SalesLT.Product
WHERE SalesLT.ProductCategory.ProductCategoryID = SalesLT.Product.ProductCategoryID
AND SalesLT.Product.ProductCategoryID IN
	(SELECT DISTINCT SalesLT.ProductCategory.ParentProductCategoryID
	FROM SalesLT.ProductCategory)

	--popsu�em Product
/*
SELECT SalesLT.ProductCategory.Name
FROM SalesLT.ProductCategory
WHERE SalesLT.ProductCategory.ProductCategoryID IN
	(SELECT DISTINCT SalesLT.ProductCategory.ParentProductCategoryID
	FROM SalesLT.ProductCategory)
	*/