create table Shifts
(
	TimeBegin VARCHAR(10) not null,
	TimeEnd VARCHAR(10) not null,
	name nvarchar(45),
	Id_shift int primary key Identity ,
);
create table Schedules
(
	Id_schedule int identity primary key,
	Id_employee int not null,
	Id_shift int not null,
	Days int, -- các ngày nhân viên làm trong tuần (vd: 234 thì làm t2,t3,t4)
	constraint FK_Id_employee_schedule foreign key (Id_employee) references Employees(Id_employee),
	constraint FK_Id_Shift foreign key (Id_shift) references Shifts(Id_shift)
);
-- proc get data table shifts
create proc [dbo].[GetDataShifts]
as
	begin
		select Id_shift, name, TimeBegin, TimeEnd from Shifts
	end
go
-- sửa lại proc insert data shift
create proc [dbo].[InsertDataShifts]
@name nvarchar(50), @TimeBegin varchar(50), @TimeEnd varchar(50)
as
	begin
		if(not exists(select * from Shifts where name = @name))
		begin
			insert into Shifts(TimeBegin,TimeEnd, name) 
			values(@TimeBegin, @TimeEnd, @name)
		end
	end
go
-- sửa lại proc update
create proc [dbo].[UpdateDataShifts]
@Id_shift int, @TimeBegin varchar(50), @TimeEnd varchar(50)
as
	begin
		Update Shifts set TimeBegin = @TimeBegin, TimeEnd = @TimeEnd where Id_shift = @Id_shift
	end
go
-- sửa lại proc search data shift
create proc [dbo].[SearchDataShifts]
@name nvarchar(50)
as
	begin
		set nocount on;
		select Id_shift, name, TimeBegin, TimeEnd from Shifts where name like '%' + @name +'%'
	end
go
