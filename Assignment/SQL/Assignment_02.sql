use Database_Submissions;

create table EMP(Empno int, 
Ename varchar(30), 
Job varchar(25), 
Mgr_id int, 
Hiredate date, 
Salary int, 
Comm int, 
Deptno int)

insert into EMP values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
					  (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
					  (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
					  (7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
					  (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
					  (7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
					  (7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
					  (7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
					  (7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
					  (7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
					  (7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
					  (7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
					  (7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
					  (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

select * from EMP

create table DEPT(DEPNO int, DNAME varchar(30), DLOC varchar(35))

insert into DEPT values(10,'ACCOUNTING','NEW YORK'), 
					   (20,'RESEARCH','DALLAS'), 
					   (30,'SALES','CHICAGO'),
					   (40,'OPERATIONS','BOSTON') 
select * from DEPT

---1. List all employees whose name begins with 'A'. 

select * from EMP where ename like 'A%' --ALLEN, ADAMS

---2.Select all those employees who don't have a manager.

select e.empno,e.ename,e.job,e.Mgr_id from emp e
where Mgr_id is NULL  --KING,PRESIDENT

---3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

select e.empno,e.ename,e.Salary from emp e
where Salary between 1200 and 1400 ---WARD,MARTIN,ADAMS,MILLER

---4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 

---before 10% rise
select * from emp where deptno = 20 --- 800,2975,3000,1100,3000

update Emp set Salary = Salary + (Salary * 10/100)
where Deptno =20

---after 10% rise
select * from emp where deptno = 20 ---880,3272,3300,1210,3300

---5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as 'Number of clerks Employed'
from emp
where job = 'clerk' ---4

---6. Find the average salary for each job type and the number of people employed in each job. 

select deptno,avg(salary) as Average_Salary 
from emp group by deptno --- 10-2916, 20-2392, 30-1566

---7. List the employees with the lowest and highest salary. 

select max(salary) as Maximum_salary from emp ---5000
select min(salary) as Minimum_salary from emp ---880

---8. List full details of departments that don't have any employees. 

select * from dept d left join emp e
on d.Depno=e.Deptno
where e.deptno is null ---DEPNO - 40

---9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 

select ename,salary,job from emp where job = 'analyst' and Deptno=20 and salary>1200
order by ename --- FORD,SCOTT

---10. For each department, list its name and number together with the total salary paid to employees in that department.

select d.dname, d.depno, sum(e.Salary) as "Total Salary" 
from dept d left join emp e on d.depno = e.deptno
group by d.dname,d.depno ---accounting(10) - 8750,
						 ---research(20) - 11962
						 ---sales(20) - 9400
						 ---operations(40) - null

---11. Find out salary of both MILLER and SMITH.
select e.ename, e.salary from emp e where e.ename in ('miller','smith') --- miller-1300, smith-880 

---12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename from emp where ename like 'A%' or ename like 'M%' ---Allen,Adams,Martin,Miller

---13. Compute yearly salary of SMITH.
select ename , salary*12 as Yearly_Salary from emp where ename='smith' ---10560

---14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 

select e.ename,e.Salary from emp e
where Salary not between 1500 and 2850 ---SMITH,WARD,JONES,MARTIN,SCOTT,KING,ADAMS,JAMES,FORD,MILLER

---15. Find all managers who have more than 2 employees reporting to them

select m.ename as 'Manager Name', count(*) as 'No. of Employees Reporting'
from EMP m
inner join EMP e ON m.empno = e.Mgr_id
group by m.ename
having count(*) > 2  ---BLAKE-5,KING - 3