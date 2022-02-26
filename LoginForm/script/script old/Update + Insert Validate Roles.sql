/****** Object:  StoredProcedure [dbo].[INSERT_DATA_TO_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[INSERT_DATA_TO_ROLES]
@Name nvarchar(20)
AS
BEGIN
		IF EXISTS(select * from Roles where LOWER(Name) like N'%' + lower(@Name) + '%' )
		return 1;
		ELSE
		INSERT INTO ROLES(Name)
		VALUES(@Name)
END
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_DATA_TO_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[UPDATE_DATA_TO_ROLES]
@id_role int,
@name nvarchar(50)
AS
BEGIN
		IF EXISTS(select * from Roles where LOWER(Name) like N'%' + lower(@Name) + '%' )
		return 1;
		ELSE
		UPDATE Roles
		SET Name = @name 
		where Id_role = @id_role 
END
GO

/****** Object:  StoredProcedure [dbo].[UPDATE_DATA_TO_EMPLOYEE]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[UPDATE_DATA_TO_EMPLOYEE] 
@Id_role int,
@Id_employee int,
@Name nvarchar(50),
@Gender int,
@Email varchar(50),
@Address nvarchar(50),
@DayOfBirth date,
@Salary float
AS
BEGIN
		IF EXISTS(select * from  Employees where Email = @Email)
		UPDATE Employees SET Id_role = @Id_role, Address =  @Address, Gender = @Gender,
												  Email = @Email,DayOfBirth = @DayOfBirth,Salary = @Salary,Name = @Name
												  where Email = @Email and Id_employee = @Id_employee
		ELSE
		UPDATE Employees SET Id_role = @Id_role, Address =  @Address, Gender = @Gender,
												  Email = @Email,DayOfBirth = @DayOfBirth,Salary = @Salary,Name = @Name
												where Id_employee = @Id_employee
END
GO