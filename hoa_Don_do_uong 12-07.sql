alter proc [dbo].[sp_GetBillsDetailDoUong]( @id_bill int)
as
begin
	select b.Name, bd.Quantity,bd.Id_bill_detaill,bd.totalPrice,format(bd.totalPrice,'#,###') from Bills_detail bd inner join Beverages b on bd.Id_beverage = b.Id_beverage where bd.Id_bill =@id_bill
end