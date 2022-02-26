alter proc sp_GetBillsDoUongToday
as
begin
		select e.Name,tb.name,b.DateCheckOut,b.Id_bill from bills b  
inner join Employees e on b.Id_employee = e.Id_employee 
inner join dbo.tables tb on b.Id_table = tb.ID_Table 
where convert(varchar(10), b.DateCheckIn, 102) 
    = convert(varchar(10), getdate(), 102) and b.status = 1
end
go
--drop proc sp_GetBillsNguyenLieuToday
alter proc sp_GetBillsNguyenLieuToday
as
begin
		select e.Name,ib.DateCheckIn,ib.SumPrice,ib.ID_Bill from inputbills ib inner join Employees e on ib.ID_employee = e.Id_employee where convert(varchar(10), ib.DateCheckIn, 102) 
    = convert(varchar(10), getdate(), 102) 
end
go
--exec sp_GetBillsNguyenLieuToday
--drop proc sp_GetBillsDetailDoUong
alter proc sp_GetBillsDetailDoUong( @id_bill int)
as
begin
	select b.Name, bd.Quantity,bd.Id_bill_detaill,bd.totalPrice from Bills_detail bd inner join Beverages b on bd.Id_beverage = b.Id_beverage where bd.Id_bill =@id_bill
end
go
-- drop proc sp_GetBillsDetailNL
alter proc sp_GetBillsDetailNL( @id_bill int)
as
begin
	
	select i.Name,ib.quantity,ib.Id_BillDetaill from InputBillsDetaill ib inner join Ingredients i on ib.Id_Ingredient = i.Id_ingredient
	where ib.Id_bill = @id_bill 
end
go
-- exec sp_GetBillsDetailNL 11
if OBJECT_ID ('sp_BillDeleteDoUong') is not null 
drop proc sp_BillDeleteDoUong
go 
create PROCEDURE sp_BillDeleteDoUong(@id_bill int)
AS
  BEGIN

        BEGIN
			delete bills
			where Id_bill = @id_bill
        END
END
go
if OBJECT_ID ('sp_BillDeleteNL') is not null 
drop proc sp_BillDeleteNL
go 
create PROCEDURE sp_BillDeleteNL(@id_bill int)
AS
  BEGIN

        BEGIN
			delete InputBills
			where Id_bill = @id_bill
        END
END
go
if OBJECT_ID ('sp_BillsDetailDeleteNL') is not null 
drop proc sp_BillsDetailDeleteNL
go 
create PROCEDURE sp_BillsDetailDeleteNL(@id_bill int)
AS
  BEGIN

        BEGIN
			delete InputBillsDetaill
			where Id_BillDetaill = @id_bill
        END
END
go
if OBJECT_ID ('sp_BillsDetailDeleteDoUong') is not null 
drop proc sp_BillsDetailDeleteDoUong
go 
create PROCEDURE sp_BillsDetailDeleteDoUong(@id_bill int)
AS
  BEGIN

        BEGIN
			delete Bills_detail
			where Id_bill_detaill = @id_bill
        END
END
go

if OBJECT_ID ('sp_UpdateBillsDetailNL') is not null 
drop proc sp_UpdateBillsDetailNL
go 
create PROCEDURE sp_UpdateBillsDetailNL(@quantity int,@id_bill int)
AS
  BEGIN

        BEGIN

			update InputBillsDetaill
			set Quantity = @quantity
			where Id_BillDetaill = @id_bill;
        END
END
go
-- drop proc sp_BillsDetailSearch
alter PROCEDURE sp_BillsDetailSearch(@Name   NVARCHAR(55),@Col   NVARCHAR(55))
AS
  BEGIN

        BEGIN
			set nocount on;
			if @col = 'Id_Employee'
			begin
				
		select e.Name,tb.name,b.DateCheckOut,b.Id_bill from bills b  
		inner join Employees e on b.Id_employee = e.Id_employee 
		inner join dbo.tables tb on b.Id_table = tb.ID_Table 
		where convert(varchar(10), b.DateCheckIn, 102) 
			= convert(varchar(10), getdate(), 102) and b.status = 1 and e.Name like '%'+@Name+'%'
			end

			if @col = 'Id_table'
			begin
				select e.Name,tb.name,b.DateCheckOut,b.Id_bill from bills b  
		inner join Employees e on b.Id_employee = e.Id_employee 
		inner join dbo.tables tb on b.Id_table = tb.ID_Table 
		where convert(varchar(10), b.DateCheckIn, 102) 
			= convert(varchar(10), getdate(), 102) and b.status = 1 and b.Id_table like '%'+@Name+'%'
			end
			if @col = 'DateCheckOut'
			begin
				select e.Name,tb.name,b.DateCheckOut,b.Id_bill from bills b  
		inner join Employees e on b.Id_employee = e.Id_employee 
		inner join dbo.tables tb on b.Id_table = tb.ID_Table 
		where convert(varchar(10), b.DateCheckIn, 102) 
			= convert(varchar(10), getdate(), 102) and b.status = 1 and b.DateCheckOut like '%'+@Name+'%'
			end
			
        END
	END
	go
-- drop proc sp_InputBillsDetailSearch
alter PROCEDURE sp_InputBillsDetailSearch(@Name   NVARCHAR(55),@Col   NVARCHAR(55))
AS
  BEGIN

        BEGIN
			set nocount on;
			
			if @col = 'DateCheckIn'
			begin
				select e.Name,ib.DateCheckIn,ib.SumPrice,ib.ID_Bill from inputbills ib inner join Employees e on ib.ID_employee = e.Id_employee where convert(varchar(10), ib.DateCheckIn, 102) 
    = convert(varchar(10), getdate(), 102) and ib.DateCheckIn = @Name
			end
			if @col = 'ID_employee'
			begin
				select e.Name,ib.DateCheckIn,ib.SumPrice,ib.ID_Bill from inputbills ib inner join Employees e on ib.ID_employee = e.Id_employee where convert(varchar(10), ib.DateCheckIn, 102) 
    = convert(varchar(10), getdate(), 102) and e.Id_employee = @Name
			end
			if @col = 'SumPrice'
			begin
				select e.Name,ib.DateCheckIn,ib.SumPrice,ib.ID_Bill from inputbills ib inner join Employees e on ib.ID_employee = e.Id_employee where convert(varchar(10), ib.DateCheckIn, 102) 
    = convert(varchar(10), getdate(), 102) and ib.SumPrice = @Name
			end
        END
	END

	--------------------- new
	if OBJECT_ID ('sp_UpdateBillsDetailDoUong') is not null 
drop proc sp_UpdateBillsDetailDoUong
go 
create PROCEDURE sp_UpdateBillsDetailDoUong(@quantity int,@id_bill int)
AS
  BEGIN

        BEGIN
			update Bills_detail
			set  totalPrice = (totalPrice/Quantity)*@quantity,Quantity = @quantity
			where Id_bill_detaill = @id_bill
        END
END
go