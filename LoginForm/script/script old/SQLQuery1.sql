create trigger UpdateBill
on bills for update
as
begin
	declare @idbill int;
	select @idbill = id_bill from inserted;
	
	declare  @idtable int;
	select @idtable = Id_table from bills
	where  Id_bill = @idbill;	

	declare @count int = 0;
	select @count = count(*) from Bills
	where Id_table = @idtable and status = 0;

	if(@count = 0)
		update tables set
		Status = N'Trống' where ID_Table = @idtable;
end
go



go
create trigger updateBillDetail
on bills_detail for insert, update
as 
begin
	declare @idbill int;
	select @idbill = Id_bill from inserted;

	declare  @idtable int;
	select @idtable = Id_table from bills
	where  Id_bill = @idbill and status = 0;

	update tables set Status = N'Có người' where ID_Table = @idtable;
end
go


create proc checkOut
@idBill int
as
begin
	update bills set status = 1, DateCheckOut = GETDATE()
	where Id_bill = @idBill
end


go
create trigger updateBillDetail
on bills_detail for insert, update
as 
begin
	declare @idbill int;
	select @idbill = Id_bill from inserted;

	declare  @idtable int;
	select @idtable = Id_table from bills
	where  Id_bill = @idbill and status = 0;

	update tables set Status = N'Có người' where ID_Table = @idtable;
end
go


create proc sp_insertBillDetail
@idBill int, @idBeverage int, @quantity int, @sale int
as
begin
	declare @price float;
	select @price = Price from Beverages
	where Id_beverage = @idBeverage
	if(@sale = 0)
	begin
		declare @isExistBillInfo int = 0;
		declare @quantityBeverage int;
		select @isExistBillInfo = Id_bill_detaill, @quantityBeverage = Quantity from Bills_detail
		where Id_bill = @idBill and Id_beverage = @idBeverage
		
		if(@isExistBillInfo > 0)
		begin
			declare @newQuantity int = @quantityBeverage + @quantity
			if(@newQuantity > 0)
				update Bills_detail set Quantity = @newQuantity, totalPrice = @newQuantity * @price
				where Id_beverage = @idBeverage and Id_bill = @idBill
			else
				delete Bills_detail where Id_bill = @idBill and Id_beverage = @idBeverage
		end
		else
		begin
			insert into Bills_detail(Id_beverage,Id_bill,Quantity, sale,totalPrice)
			values (@idBeverage, @idBill, @quantity, @sale, @price * @quantity)	
		end
	end
	else
	begin
		insert into Bills_detail(Id_beverage,Id_bill,Quantity, sale,totalPrice)
		values (@idBeverage, @idBill, @quantity, @sale, (@price * @quantity) * (100 - @sale)/100)	
	end
end

go
-- drop proc GETNHANVIEN
CREATE PROCEDURE [dbo].[GETNHANVIEN]
AS
BEGIN
		Select Id_role,Name,Gender,Email,Address,DayOfBirth,Salary,Id_employee from Employees
END
GO


CREATE PROCEDURE [dbo].[CHECK_EXIST_EMAIL_BY_ID]
@email varchar(50),
@id_employee int
AS
BEGIN
		SELECT * from Employees where Email = @email and Id_employee = @id_employee
END
GO


CREATE PROCEDURE [dbo].[CHECK_EXIST_EMAIL]
AS
BEGIN
		SELECT Email from Employees
END
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

