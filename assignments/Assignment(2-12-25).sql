--1. Create a procedure which accepts input parameter and inserts the 
--data in the customer table.
create procedure spInsertCustomer(@custid int,@custname varchar(50),@age int,@caddress varchar(50), @cphone varchar(10))
as
insert INTO customers(custid, custname, age, caddress, cphone)
    VALUES(@custid, @custname, @age, @caddress, @cphone)

	spInsertCustomer 100, 'arcasia', 34, 'delhi', '5673452672'

--2.  Create a procedure for orders table , which displays all the purchase 
--made between  1-12-2005  and 2-12-2007 
--(Accept date as parameter_)

create procedure spOrdersBetweenDates
@StartDate date,
 @EndDate date
as
begin
 select *from Orders where OrderDate BETWEEN @StartDate AND @EndDate
end
spOrdersBetweenDates '1990-12-01','2025-01-07'

--03. create a procedure which reads custid as parameter  
--and return qty and produtid as output parameter
create table [Order] (
    OrderID int identity(1,1) primary key,
    CustID int,
    ProductID int,
    Qty int,
    OrderDate date,
    
	
insert into [Order] (CustID, ProductID, Qty, OrderDate)
values
(101, 201, 1, '2024-01-12'),
(102, 202, 2, '2024-02-15'),
(103, 201, 11, '2024-03-20'),
(101, 202, 20, '2024-04-05'),
(104, 201, 3, '2024-04-25');


create procedure spGetOrderDetails @CustID int,@Qty int output,@ProductID int output
as
begin
select 
@Qty = Qty,
@ProductID = ProductID from [Order] where CustID = @CustID;
END

declare @m int
declare @n int
exec spGetOrderDetails 102,@m output,@n output
print @m
print @n


--4. Write a batch that will check for the existence of the productname 
--“books” if it exists, display the total stock of the book else print  
--“productname books not found”.

alter table products
add stock int


create procedure checkproduct(@book varchar(20))
as
if exists (select * from products where pname = @book)
begin
select sum(stock) as TotalStock
from products
where pname = 'books'
end
else
begin
print 'productname books not found'
end

checkproduct 'books'


--5.insert  data to customer table via return value of sp_getdata() 
--procedure

create procedure sp_getdata
as
begin
declare @id int;
set @id = 105;
return @id;
end
declare @custid int;
exec @custid = sp_getdata;

insert into Customers (custid, custname,age,caddress,cphone)
values (@custid, 'alviran', 67,'surat','8974653425')


--6. Create a procedure to display all customer details where rownumber 
--between 2 to 5 (accept row number as a parameter)

create procedure spcustomerrows
@startrow int,
@endrow int
as
begin
with c as (
select *, row_number() over(order by custid) as rn
from customers
)
select * from c where rn between @startrow and @endrow
end
 exec spcustomerrows 2,5


--7.Create a stored procedure to insert a new employee 
--Create a table Employees and write a stored procedure: 
--• Procedure name: spAddEmployee 
--• Inputs: Name, Department, Salary 
--• Insert the record into Employees table. 
--• Return newly generated CustomerID using SCOPE_IDENTITY().

create table employeesnew (
    empid int identity(1,1) primary key,
    ename varchar(50),
    department varchar(50),
    salary decimal(10,2)
);

drop table employeesnew
insert into employeesnew (ename, department, salary) values
('amit', 'it', 65000),
('neha', 'hr', 50000),
('ravi', 'sales', 45000),
('sana', 'marketing', 42000),
('karan', 'finance', 48000),
('syeda', 'operations', 53000);
drop procedure spaddemployee
create procedure spaddemployee
@name varchar(50),
@department varchar(50),
@salary decimal(10,2)
as
begin
insert into employeesnew (ename, department, salary)
values (@name, @department, @salary);
return scope_identity();
end

declare @res int
exec @res = spAddEmployee 'fatima','IT', 560000 
print @res


--8.Create a stored procedure with default parameter 
--Create spGetProductsByCategory 
--• Parameter: CategoryName (default should be ‘Electronics’) 
--• Return all products of that category. 
--• Create Procedure WITH ENCRYPTION
alter table products
add categoryname varchar(50) default 'electronics'

create procedure spgetproductsbycategory
@categoryname varchar(50) = 'electronics'
with encryption
as
begin
select * from products where categoryname = @categoryname;
end
exec spgetproductsbycategory 'electronics'


--9. Stored procedure using TRY…CATCH 
--Create spSafeOrderInsert 
--• Insert a new order 
--• If any error occurs, insert error details into an ErrorLog table

create table ErrorLogs
(
ErrorId int identity primary key,
ErrorMessage varchar(max),
ErrorTime Datetime default GetDate()
)
 
create procedure spSafeOrderInsert
@custID int,
@orderId int,
@Price money,
@Qty int
as
begin Try
insert into Orders(custId,orderId,orderDate,price,quantity)
values (@custID,@orderId,GetDate(),@Price,@Qty)
end try
begin catch
insert into ErrorLogs(ErrorMessage)
values(Error_message())
end catch
 
 
exec spSafeOrderInsert
@custID=101,
@orderId=60000,
@Price=500,
@Qty=3
 
exec spSafeOrderInsert 102,60001,750,4
 
select * from Orders where orderId=60001
 
exec spSafeOrderInsert 999,54729,800,5
 
displayData 'ErrorLogs'
 
exec spSafeOrderInsert 101, Null, 500, 2
 

-- 10.Stored procedure with multiple operations 
--Create spUpdateSalary 
--• Inputs: EmpID, Percentage 
--• Increase employee salary by given percentage 
--• Return updated salary

create procedure spUpdateSalary
@empId int,
@percentage float
as
begin
 
update Employee 
set salary = salary +(salary * (@percentage/100))
where EmpID = @empId
 
select salary as UpdateSalary 
from Employee
where EmpId =@empId
end
 
exec spUpdateSalary
@empId=1,
@percentage=10
 
spUpdateSalary 2,20
 
displayData 'Employee'
go
displayData 'ErrorLogs'
 