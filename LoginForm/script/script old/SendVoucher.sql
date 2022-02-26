---- proc get email for send voucher
--create proc getEmailSendVoucher
--@reward int
--as
--	begin
--		select Email from Customers where Reward <= @reward
--	end
--go
---- proc get voucher for send mail to customer
--create proc getVoucherSendMail
--@id_type int
--as
--	begin
--		declare @status int = 0
--		if(exists(select Id_voucher from Vouchers where Status = @status))
--		begin
--			select a.Id_voucher from Vouchers a,TypesVoucher b where a.Status = 0 and b.ID_Type = @id_type
--		end
--	end
--go
---- proc update voucher after send mail to customer
--create proc UpdateVoucherForSend
--@Id_voucher nvarchar(6)
--as
--	begin
--		Update Vouchers set Status = 1 where Id_voucher = @Id_voucher
--	end
--go
---- update reward after send voucher mail to customer
--create proc UpdateCustomerAfterSendVoucher
--@email nvarchar(50)
--as
--	begin
--		Update Customers set Reward = 0 where Email = @email
--	end
--go
---- proc get sale for configuration
--create proc getConfigurationSale
--@id int
--as
--	begin
--		if(@id = 0)
--			begin
--				select ID_Type, Sale from TypesVoucher 
--			end
--		else
--			begin
--				select ID_Type, Sale from TypesVoucher where ID_Type = @id
--			end
--	end
--go
-- proc for unit, input bill detail and input bill
-- insert units
ALTER TABLE Ingredients
add mass Float(10)
ALTER TABLE Ingredients
add Id_unit int
ALTER TABLE Ingredients
add constraint fk foreign key (Id_unit) references units (Id_unit)
go
create proc InsertDataUnit
@name nvarchar(10)
as
	begin
		if(not exists(select * from units where Name = @name))
			begin
				insert into units(Name) values(@name)
			end
	end
go
-- get data units
create proc getDataUnits
as
	begin
		select * from units
	end
go
-- update data units
create proc UpdateDataUnits
@name nvarchar(10), @id int
as
	begin
		if(not exists(select * from units where Name = @name))
			begin
				update units set Name = @name where ID_unit = @id
			end
	end
go
-- get name units for inputBillDetail
create proc getNameForInputBillDetail
as
	begin
		select ID_unit, Name from units
	end
-- get Type ingredient for inputBillDetail
create proc getTypeIngredientForInputBillDetail
as
	begin
		select Name, Id_type from TypesOfIngredient
	end
go
-- get name ingredient for inputBillDetail
CREATE proc getNameIngredientForInputBillDetail
@id_type int
as
	begin
		select Name, Id_ingredient from Ingredients where Id_type = @id_type
	end
go
-- proc insert inputBillDetail
create proc insertBillDetailIngredient
@quantity nvarchar(45),
@nameType nvarchar(45), @datetime nvarchar(45)
as
	begin
		declare @id_ingredient int, @id_bill int
		select @id_ingredient = Id_ingredient from Ingredients where Name = @nameType
		select @id_bill = Id_bill from Bills where DateCheckIn = @datetime
		insert into InputBillsDetaill(quantity,Id_Ingredient,ID_Bill)
		values(@quantity,@id_ingredient,@id_bill)
	end
go
-- proc insert inputBill
create proc insertBillIngredient
@dayCheck datetime, @sumprice float, @mail nvarchar(50)
as
	begin
		declare @id_employee int
		select @id_employee = Id_employee from Employees where Email = @mail
		insert into InputBills(DateCheckIn,ID_employee, SumPrice) values(@dayCheck,@id_employee,@sumprice)
	end
go
-- proc sum price input bill
create proc PriceInputBill
@id_type int, @number int
as 
	begin
		select Price*@number from Ingredients where Id_ingredient = @id_type
	end
go
