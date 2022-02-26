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

