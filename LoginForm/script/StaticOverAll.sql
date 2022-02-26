create proc StaticOverAllBillsMonth
@YearNow varchar(50), @Month varchar(50)
as
	begin
		select (@Month),count(DISTINCT a.Id_bill), sum(b.totalPrice) from Bills a
		inner join Bills_detail b on a.Id_bill = b.Id_bill and Year(a.DateCheckOut) = @YearNow and Month(a.DateCheckOut) = @Month
	end
go
-- tổng thể hóa đơn theo năm
create proc StaticOverAllBillsYears
as
begin
		select  Year(a.DateCheckOut) as 'Năm', count(DISTINCT a.Id_bill) as 'Tổng số bill', sum(b.totalPrice) as 'Tổng tiền' from Bills a
		inner join Bills_detail b on a.Id_bill = b.Id_bill
		group by  Year(a.DateCheckOut)
end
go


