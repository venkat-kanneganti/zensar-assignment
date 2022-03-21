create database EmployeeManagement

use EmployeeManagement

create table Code_Employee(
empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check (empsal>=25000),
emptype varchar(1) check(emptype in('C','P')))

drop table Code_Employee

create or alter procedure addnewemployee @ename varchar(50), @esal numeric(10,2), @etype varchar(1)
as
 begin 
  declare @eid int = (select max(empno) from Code_Employee)
  if(@eid is null)
  begin
    set @eid = 0;
    declare @empid int = @eid + 1;
    insert into Code_Employee values(@empid, @ename, @esal, @etype)
  end
  
end
drop procedure addnewemployee


select * from Code_Employee