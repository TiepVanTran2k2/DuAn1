
go
create proc switchTalbe
@idTable1 int, @idTable2 int, @idEmployee int
as
begin
	declare @idFirstBill int;
	declare @idSecondBill int;
	declare @isFirstTable int = 1;
	declare @isSecondTable int = 1;

	select @idFirstBill = Id_bill from Bills where Id_table = @idTable1 and status = 0;
	select @idSecondBill = Id_bill from Bills where Id_table = @idTable2 and status = 0;

	if(@idFirstBill is null)
	begin
		insert into Bills (DateCheckIn, DateCheckOut, Id_table, status, Id_employee)
		values (getdate(),null, @idTable1, 0, @idEmployee)

		select @idFirstBill = max(Id_bill)  from Bills
		where Id_table = @idTable1 and status = 0;

	end

	select @isFirstTable = count(*) from Bills_detail where Id_bill = @idFirstBill

	if(@idSecondBill is null)
	begin
		insert into Bills (DateCheckIn, DateCheckOut, Id_table, status, Id_employee)
		values (getdate(),null, @idTable2, 0, @idEmployee)

		select @idSecondBill = max(Id_bill)  from Bills
		where Id_table = @idTable2 and status = 0;
	end

	select @isSecondTable = count(*) from Bills_detail where Id_bill = @idSecondBill


	select Id_bill_detaill into IdbillInfoTable from Bills_detail
	where Id_bill = @idSecondBill

	update Bills_detail set Id_bill= @idSecondBill
	where Id_bill = @idFirstBill

	update Bills_detail set Id_bill = @idFirstBill
	where Id_bill_detaill in (select * from IdbillInfoTable)

	drop table IdbillInfoTable

	if(@isFirstTable = 0 )
		update tables set Status = N'Trống' where ID_Table = @idTable2
	
	if(@isSecondTable =0 )
		update tables set Status = N'Trống' where ID_Table = @idTable1
end
go
-- exec switchTalbe 3,1,1


alter trigger [dbo].[updateBillDetail]
on [dbo].[Bills_detail] for insert, update
as 
begin
	declare @idbill int;
	select @idbill = Id_bill from inserted;

	declare  @idtable int;
	select @idtable = Id_table from bills
	where  Id_bill = @idbill and status = 0;

	declare @count int
	select @count = count(*) from Bills_detail
	where Id_bill = @idbill

	if(@count > 0)
		update tables set Status = N'Có người' where ID_Table = @idtable;
	else 
		update tables set Status = N'Trống' where ID_Table = @idtable;
end
GO

