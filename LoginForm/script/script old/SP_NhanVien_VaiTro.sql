-- drop proc dbo.LOGIN
CREATE PROCEDURE [dbo].[LOGIN] @EMAIL VARCHAR(50), @PASSWORD NVARCHAR(100)
AS 
BEGIN
	DECLARE @STATUS INT
	IF EXISTS(SELECT * FROM Employees 
	WHERE Email = @EMAIL AND Password = @PASSWORD)
		SET @STATUS = 1
	ELSE 
		SET @STATUS = 0
	SELECT @STATUS
END
GO


/****** Object:  StoredProcedure [dbo].[FORGOT_PASSWORD]    Script Date: 11/5/2021 1:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FORGOT_PASSWORD] @EMAIL varchar(50)
AS
BEGIN
	Declare @STATUS int

if exists(select Id_employee from Employees where Email = @EMAIL)
	set @STATUS = 1
else
	set @STATUS = 0
select @STATUS
END
GO

/****** Object:  StoredProcedure [dbo].[CREATE_NEW_PASS]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CREATE_NEW_PASS] 
@Email nvarchar(50),
@Password nvarchar(50)
AS
BEGIN
Update Employees SET Password = @Password
where Email = @Email
END

/****** Object:  StoredProcedure [dbo].[CHANGE_PASSWORD]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[CHANGE_PASSWORD] 
@EMAIL varchar(50),
@OLDPASS nvarchar(100),
@NEWPASS nvarchar(100)
AS
BEGIN
		DECLARE @OP varchar(100)
		SELECT @OP = Password from Employees where Email = @EMAIL
		IF @OP = @OLDPASS
		BEGIN 
		UPDATE Employees SET Password = @NEWPASS where Email = @EMAIL
		return 1
		END
		ELSE
		return -1
END
GO

/****** Object:  StoredProcedure [dbo].[INSERT_DATA_TO_EMPLOYEE]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_DATA_TO_EMPLOYEE] 
@Id_role int,
@Gender nvarchar(10),
@Email varchar(50),
@Address nvarchar(50),
@DayOfBirth date,
@Name nvarchar(50),
@Salary float
AS
BEGIN
		INSERT INTO Employees(Id_role,Name,Gender,Email,Address,DayOfBirth,Salary)
		VALUES(@Id_role,@Name,@Gender,@Email,@Address,@DayOfBirth,@Salary)
END
GO

-- exec INSERT_DATA_TO_EMPLOYEE  1,N'nam','daotanthien1405@gmail.com','44 HQV','1998-05-14','Thien',5000000

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
		UPDATE Employees SET Id_role = @Id_role, Address =  @Address, Gender = @Gender,
												  Email = @Email,DayOfBirth = @DayOfBirth,Salary = @Salary,Name = @Name
												where Id_employee = @Id_employee
END
GO

/****** Object:  StoredProcedure [dbo].[DELETE_DATA_TO_EMPLOYEE]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[DELETE_DATA_FROM_EMPLOYEE] @Email varchar(50)
AS
BEGIN
		--DELETE from Employees 
		--where Email = @Email
		UPDATE Employees SET isDelete = 1 where Email = @Email
END
GO

--CREATE PROC [dbo].[IS_DELETE]
--AS
--BEGIN
--		SELECT isDelete from Employees
--END
--GO
/****** Object:  StoredProcedure [dbo].[CHECK_EXIST_EMAIL]    Script Date: 11/5/2021 1:37:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CHECK_EXIST_EMAIL]
AS
BEGIN
		SELECT Email from Employees
END
GO

/****** Object:  StoredProcedure [dbo].[CHECK_EXIST_EMAIL_BY_ID]    Script Date: 11/5/2021 1:37:21 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CHECK_EXIST_EMAIL_BY_ID]
@email varchar(50),
@id_employee int
AS
BEGIN
		SELECT * from Employees where Email = @email and Id_employee = @id_employee
END
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_EMPLOYEE]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SEARCH_EMPLOYEE]
@Name nvarchar(50)
AS
BEGIN
		SET NOCOUNT ON;
		SELECT  Id_role,Name,Gender,Email,Address,DayOfBirth,Salary from Employees
		where LOWER(Name) like N'%' + lower(@Name) + '%'
END
GO

/****** Object:  StoredProcedure [dbo].[GETNHANVIEN]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETNHANVIEN]
AS
BEGIN
		Select Id_role,Name,Gender,Email,Address,DayOfBirth,Salary,Id_employee,isDelete from Employees
		Where isDelete = 0
END
GO

/****** Object:  StoredProcedure [dbo].[INSERT_DATA_TO_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_DATA_TO_ROLES]
@Name nvarchar(20)
AS
BEGIN
		INSERT INTO ROLES(Name)
		VALUES(@Name)
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_DATA_TO_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_DATA_TO_ROLES]
@id_role int,
@name nvarchar(50)
AS
BEGIN
		UPDATE Roles
		SET Name = @name 
		where Id_role = @id_role 
END
GO

exec UPDATE_DATA_TO_ROLES 34,'con à'
/****** Object:  StoredProcedure [dbo].[DELETE_DATA_FROM_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/
Insert into Roles
values
(N'Quản lý'),
(N'Nhân viên')

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETE_DATA_FROM_ROLES]
@id_role int
AS
BEGIN
		DELETE FROM Roles
		where Id_role = @id_role
		DBCC CHECKIDENT ('Roles', RESEED, 2) -- Reset identity to 2
END
GO


exec INSERT_DATA_TO_ROLES 'Quản thúc'
exec DELETE_DATA_FROM_ROLES 'Quản thúc'

/****** Object:  StoredProcedure [dbo].[GET_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GET_ROLES]
AS
BEGIN
		Select Id_role,Name from Roles
END
GO

/****** Object:  StoredProcedure [dbo].[SEARCH_ROLES]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SEARCH_ROLES]
@Name nvarchar(50)
AS
BEGIN
		SET NOCOUNT ON;
		SELECT  Id_role,Name from Roles
		where LOWER(Name) like N'%' + lower(@Name) + '%'
END
GO

/****** Object:  StoredProcedure [dbo].[INSERT_VAITRO]    Script Date: 11/5/2021 1:39:53 PM ******/
--DBCC CHECKIDENT ('Roles', RESEED, 0) -- Reset identity to 0
--GO
--delete from Roles
--delete from Employees

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_VAITRO]
AS
BEGIN
		SELECT * from Roles
END
GO