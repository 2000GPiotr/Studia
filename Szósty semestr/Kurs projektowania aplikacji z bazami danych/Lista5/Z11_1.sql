SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; 

BEGIN TRAN
SELECT * FROM Test
WAITFOR DELAY '00:00:10'
SELECT * FROM Test
COMMIT TRAN