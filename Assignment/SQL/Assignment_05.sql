use Database_Submissions

select * from EMP


---creating a procedure

create or alter procedure GeneratePaySlip (@empno int)
as
begin
declare @salary float
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @DEDUCTIONS float
declare @GROSS_SALARY float
declare @NET_SALARY float 

select @salary = salary from EMP where empno = @empno
select @HRA = @salary * 0.10
select @DA = @salary * 0.20
select @PF = @salary * 0.08
select @IT = @salary * 0.05 

--Deductions as sum of PF and IT
select @Deductions = @PF + @IT 

--Gross Salary as sum of SAL,HRA,DA 
select @Gross_Salary = @salary + @HRA + @DA

--Net salary as  Gross salary- Deduction
select @Net_Salary = @Gross_Salary - @Deductions

   select @empno, 'ename', @salary as 'salary', @HRA as 'HRA', @DA as 'DA', @PF as 'PF', @IT as 'IT', @DEDUCTIONS as 'Deductions', @GROSS_SALARY as 'Gross Salary', @NET_SALARY AS 'Net Salary'
   from EMP
   where empno = @EMPNO

end

execute GeneratePaySlip @Empno = 7782


