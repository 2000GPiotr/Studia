CREATE TYPE IdListType AS TABLE   
    (ID int);  
GO  

CREATE OR ALTER PROCEDURE Z6 
@Product_ID IdListType READONLY,
@Date date
AS
BEGIN

	/*UPDATE p
	SET p.DiscontinuedDate = @Date
	FROM @Product_ID, SalesLT.Product p
	WHERE ID = p.ProductID
	AND p.DiscontinuedDate IS NULL*/

	DECLARE @pom table ( myID int IDENTITY(1, 1), ID int, ddate date)

	INSERT INTO @pom(ID, ddate)
	SELECT p.ProductID, p.DiscontinuedDate
	FROM @Product_ID, SalesLT.Product p
	WHERE ID = p.ProductID

	declare @i int
	set @i = 1

	declare @n int
	
	SELECT @n = COUNT(ID)
	FROM @pom;

	WHILE(@i <= @n)
	BEGIN
	declare @p date
	declare @pomoc int
		
		SELECT @p = ddate, @pomoc = ID
		FROM @pom
		WHERE myID = @i
	

	if(@p IS NULL)
	BEGIN
		UPDATE p
		SET p.DiscontinuedDate = @Date
		FROM SalesLT.Product p
		WHERE p.ProductID = @pomoc
	END
	ELSE
		THROW 50000, 'FAIL', 1;

	set @i = @i + 1;

	END
END
GO

DECLARE @Product_ID AS IdListType;

INSERT INTO @Product_ID (ID) 
SELECT TOP 25 p.ProductID FROM SalesLT.Product p
ORDER BY p.ProductID
/*
		UPDATE p
		SET p.DiscontinuedDate = NULL
		FROM SalesLT.Product p
*/
EXEC Z6 @Product_ID, '1987-10-20'

SELECT p.ProductID, p.DiscontinuedDate 
FROM SalesLT.Product p
--WHERE p.DiscontinuedDate != NULL
ORDER BY p.ProductID