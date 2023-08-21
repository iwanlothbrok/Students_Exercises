CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10) AS
BEGIN
		DECLARE @SALARY_INFO VARCHAR(10)
		IF(@salary < 30000)
		BEGIN 
			SET @SALARY_INFO = 'LOW'
		END
		ELSE IF(@salary > 30000 AND @salary < 50000)
		BEGIN
			SET @SALARY_INFO = 'AVG'
		END
		ELSE 
		BEGIN
			SET @SALARY_INFO = 'HIGH'
		END

RETURN @SALARY_INFO
END

 go
SELECT FirstName as Name, Salary, dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
	FROM Employees




-- 