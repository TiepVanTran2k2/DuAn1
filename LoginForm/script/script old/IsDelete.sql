
alter table Employees
add isDelete bit DEFAULT(0)

update Employees set isDelete = 0
go

/****** Object:  StoredProcedure [dbo].[GETNHANVIEN]    Script Date: 11/5/2021 1:39:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [dbo].[GETNHANVIEN]
AS
BEGIN
		Select Id_role,Name,Gender,Email,Address,DayOfBirth,Salary,Id_employee,isDelete from Employees
		Where isDelete = 0
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