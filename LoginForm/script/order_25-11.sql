	go
	create proc MercyTable
	@idTable1 int, @idTable2 int
	as 
	begin
		declare @idFirstBill int;
		declare @idSecondBill int;

		select @idFirstBill = Id_bill from Bills where Id_table = @idTable1 and status = 0;
		select @idSecondBill = Id_bill from Bills where Id_table = @idTable2 and status = 0;
		
		if(@idFirstBill is not null)
		begin
				update Bills_detail set Id_bill= @idSecondBill
				where Id_bill = @idFirstBill
				update tables set Status = N'Trống' where ID_Table = @idTable1
				delete Bills where Id_bill = @idFirstBill
		end
	end
	go


alter proc [dbo].[getListMenu]
@Id_table int
as
begin
	select bv.Name,bd.Quantity,CONCAT(CAST(bv.Price AS varchar(10)),N'đ') , CONCAT(CAST(bd.totalPrice AS varchar(10)),N'đ'), CONCAT(CAST(bd.sale AS varchar(10)),'%'), Id_bill_detaill from Bills_detail as bd, Bills as b, Beverages as bv
	where bd.Id_bill = b.Id_bill and bd.Id_beverage = bv.Id_beverage
	and b.Id_table = @Id_table and B.status = 0
end
GO


create proc changeQuantityBillDetail
@idBillDetail int, @quantity int
as
begin
	update Bills_detail set Quantity = @quantity
	where Id_bill_detaill = @idBillDetail
end
go


create proc deleteBillDetail
@idBillDetail int
as
begin
	declare @idBill int;
	select @idBill = Id_bill from Bills_detail where Id_bill_detaill = @idBillDetail

	delete Bills_detail
	where Id_bill_detaill = @idBillDetail

	declare @count int;
	select @count = count(*) from Bills_detail where Id_bill = @idBill

	if(@count = 0) 
	begin
		declare @idtable int
		select @idtable = Id_table from Bills where Id_bill = @idBill;
		update tables set Status = N'Trống' where ID_Table = @idtable;
		delete Bills where Id_bill = @idBill
	end
end
go
-- exec deleteBillDetail 1135

select * from Bills_detail
select * from bills
select * from tables
