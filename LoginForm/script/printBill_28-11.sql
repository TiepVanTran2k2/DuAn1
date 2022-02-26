exec getListMenu 4
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


create proc [dbo].[getListMenuNotVnd]
@Id_table int
as
begin
	select bv.Name,bd.Quantity,bv.Price  ,bd.totalPrice , bd.sale, Id_bill_detaill from Bills_detail as bd, Bills as b, Beverages as bv
	where bd.Id_bill = b.Id_bill and bd.Id_beverage = bv.Id_beverage
	and b.Id_table = @Id_table and B.status = 0
end
GO