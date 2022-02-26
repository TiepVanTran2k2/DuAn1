create proc [dbo].[searchScheduleByName]
@namenv nvarchar(50)
as
	begin
		set nocount on;
		select b.Id_schedule, a.Name, b.Days, c.Id_shift from Employees a
		inner join Schedules b on a.Id_employee = b.Id_employee
		inner join Shifts c on b.Id_shift = c.Id_shift where a.Name like '%' + @namenv + '%'
	end
GO


