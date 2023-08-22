use SoftUni

	GO
	CREATE PROCEDURE usp_EmployeesBySalaryLevel(@Level nvarchar(10))
		AS
	SELECT FirstName, LastName
		FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @Level


	GO

	EXEC usp_EmployeesBySalaryLevel 'High'
