-- proc lấy danh sách tất cả các bill
create proc getBillsDetail
as
	begin
		select b.Id_employee, b.Id_customer, b.Id_bill, b.Id_table, Sum(a.totalPrice) as SumPrice, b.DateCheckIn, b.DateCheckOut from Bills_detail a
		inner join Bills b on a.Id_bill = b.Id_bill
		group by b.Id_bill, b.Id_customer, b.Id_employee, b.Id_table, b.DateCheckIn, b.DateCheckOut
	end
go
-- proc lấy tổng tiền của tất cả các bill
create proc LoadPriceBillsDetail
as
	begin
		select sum(totalPrice)  from Bills_detail 
	end
go
-- proc lấy danh sách bill trong khảng ngày tháng
create proc LoadBillInBetweenDate
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select b.Id_employee, b.Id_customer, b.Id_bill, b.Id_table, Sum(a.totalPrice) as SumPrice, b.DateCheckIn, b.DateCheckOut from Bills_detail a
		inner join Bills b on a.Id_bill = b.Id_bill and b.DateCheckOut between @dayStar and @dayEnd
		group by b.Id_bill, b.Id_customer, b.Id_employee, b.Id_table, b.DateCheckIn, b.DateCheckOut
	end
go
-- proc lấy tổng số tiền trong khoảng ngày tháng
create proc SumPriceDateTime
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select sum(a.totalPrice)  from Bills_detail a 
		inner join Bills b on a.Id_bill = b.Id_bill and b.DateCheckOut between @dayStar and @dayEnd
	end
go
-- proc lấy danh sách theo tuần
create proc LoadBillInDayOfWeek
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select b.Id_employee, b.Id_customer, b.Id_bill, b.Id_table, Sum(a.totalPrice) as SumPrice, b.DateCheckIn, b.DateCheckOut from Bills_detail a
		inner join Bills b on a.Id_bill = b.Id_bill and b.DateCheckOut between @dayStar and @dayEnd
		group by b.Id_bill, b.Id_customer, b.Id_employee, b.Id_table, b.DateCheckIn, b.DateCheckOut
	end
go
-- proc lấy dữ liệu của nguyên liệu
create proc getBillInput
as
	begin
		select * from InputBills
	end
go
-- lấy tổng tiền của bill nhập nguyên liệu
create proc getPriceBillInput
as
	begin
		select sum(SumPrice) from InputBills
	end
go
-- lấy danh sách bill nhập nguyên liệu trong khoảng thời gian
create proc getBillInputInBetween
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select * from InputBills where DateCheckIn between @dayStar and @dayEnd
	end
go
-- lấy tổng số tiền bill nhập nguyên liệu trong khoảng thời gian
create proc getSumPriceInBetween
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select sum(SumPrice) from InputBills where DateCheckIn between @dayStar and @dayEnd
	end
go
create proc [dbo].[getTypeVoucherById]
@id_voucher varchar(6)
as
begin
	if(exists(select * from Vouchers
	where Id_voucher = @id_voucher and DateEnd > GETDATE()))
	begin
		select t.Sale from Vouchers v, TypesVoucher t where v.Id_voucher = @id_voucher
		and v.ID_Type = t.ID_Type
	end
	else
		begin
		if(exists(select * from Vouchers
		where Id_voucher = @id_voucher and DateEnd < GETDATE()))
			select -1;
		else
			select 0;
		end
end
GO
-- danh sách bill nhân viên
create proc StaticDataEmployee
as
	begin
		select a.Id_employee, count(DISTINCT a.Id_bill), sum(b.totalPrice) from Bills a
		inner join Bills_detail b on a.Id_bill = b.Id_bill
		group by a.Id_employee
	end
go
-- thống kê danh sách khách hàng mua hàng
create proc StaticCustomer
as
	begin
		select a.Id_customer, sum(b.Quantity), sum(b.totalPrice) from Bills a 
		inner join Bills_detail b on a.Id_bill = b.Id_bill
		group by a.Id_customer
	end
go
-- danh sách bill nhân viên theo khoảng thời gian
create proc StaticEmployeeWeek
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select a.Id_employee, count(DISTINCT a.Id_bill), sum(b.totalPrice) from Bills a
		inner join Bills_detail b on a.Id_bill = b.Id_bill and a.DateCheckOut between @dayStar and @dayEnd
		group by a.Id_employee
	end
go
-- thống kê bill khách hàng theo khoảng thời gian
create proc StaticCustomerWeek
@dayStar varchar(50), @dayEnd varchar(50)
as
	begin
		select a.Id_customer, sum(b.Quantity), sum(b.totalPrice) from Bills a 
		inner join Bills_detail b on a.Id_bill = b.Id_bill and a.DateCheckOut between @dayStar and @dayEnd
		group by a.Id_customer
	end
go