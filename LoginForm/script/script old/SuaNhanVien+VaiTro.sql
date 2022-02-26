-- Search Employee --

alter PROCEDURE [dbo].[SEARCH_EMPLOYEE]
@Name nvarchar(50),
@Id_role int
AS
BEGIN
		SET NOCOUNT ON;
		SELECT  Id_role,Name,Gender,Email,Address,DayOfBirth,Salary from Employees
		where LOWER(Name) like N'%' + lower(@Name) + '%' and Id_role = @Id_role and isDelete = 0
END
GO

--Login --

alter PROCEDURE [dbo].[LOGIN] @EMAIL VARCHAR(50), @PASSWORD NVARCHAR(100)
AS 
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT * FROM Employees 
	WHERE Email = @EMAIL AND Password = @PASSWORD AND isDelete = 0)
		SET @STATUS = 1
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END
GO