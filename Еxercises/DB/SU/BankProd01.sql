use Bank
	-- 09

	go

	CREATE PROCEDURE usp_GetHoldersFullName 
		AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM AccountHolders


	EXEC usp_GetHoldersFullName



	-- 10
	GO
	CREATE PROC usp_GetHoldersWithBalanceHigherThan(@Cash Decimal(18,4))
		AS
	SELECT ah.FirstName,ah.LastName
		FROM AccountHolders as ah
		JOIN Accounts as a on a.AccountHolderId = ah.Id
		 GROUP BY FirstName,LastName
		HAVING SUM (a.Balance) > @Cash
		ORDER BY ah.FirstName, ah.LastName
		
		 EXEC dbo.usp_GetHoldersWithBalanceHigherThan 200


	--


