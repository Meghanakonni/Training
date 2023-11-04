use Database_Submissions

--question1
declare @inputNumber int = 6 -- Replace with your desired number
declare @factorial int = 1
declare @counter int = 1
while @counter <= @inputNumber
begin
    set @factorial = @factorial * @counter
    set @counter = @counter + 1
end
print 'Factorial of ' + cast(@inputNumber as nvarchar(10)) + ' is ' + cast(@factorial as nvarchar(10))

--question2
create  procedure  GenerateMultiplicationTables(@maxNumber int)
as
begin
   declare @number int = 1;
   while @number <= @maxNumber
    begin
        declare @counter int = 1;
        while @counter <= 10
        begin
            print cast(@number as nvarchar(10)) + ' x ' + cast(@counter as nvarchar(10)) + ' = ' + cast(@number * @counter as nvarchar(10));
            set @counter = @counter + 1
			end
        set @number = @number + 1
    end
end 

EXEC GenerateMultiplicationTables @maxNumber = 2; -- Replace 5 with the desired maximum number

--question3
create table Holiday
(Holiday_Date date,
Holiday_Name varchar(20))

insert into Holiday values('2023-01-26','Republic Day'),
('2023-08-15','Independence Day'),
('2023-09-07','Janmashtami'),
('2023-10-24','Dussehra')

-- Create a trigger to restrict data manipulation on EMP table during holidays


create trigger trgManipulatingOfData on EMP
after insert, update, delete as
begin
declare @holidayname varchar(20)
select @holidayname = holiday_name from Holiday
where holiday_date = convert(date, getdate())
if @holidayname is not null
begin
declare @errormessage varchar(50)
set @errormessage = 'Due To ' + @holidayname + ' You Cannot Manipulate Data';
throw 51000, @errormessage, 1
end
end 

select * from Holiday

insert into Holiday values ('2024-01-01', 'New Year')
update EMP set salary = 10500 where empno = 7369

select * from EMP