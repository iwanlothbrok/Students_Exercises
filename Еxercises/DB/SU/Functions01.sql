USE [SoftUni]
GO
/****** Object:  UserDefinedFunction [dbo].[ufn_GetSalaryLevel]    Script Date: 22/08/2023 09:09:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[ufn_GetSalaryLevel](@salary DECIMAL(18,4))
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
