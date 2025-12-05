
--------------CURSORS--------------------

--1.Basic Cursor – Print All Employee Names 
--Create a cursor on an Employees table to print each employee’s name one by one.

declare @empname varchar(100);
declare empcursor cursor for
select empname from employees;
open empcursor;
fetch next from empcursor into @empname;
while @@fetch_status = 0
begin
print 'EMPLOYEE NAME:' + @empname;
fetch next from empcursor into @empname;
end
close empcursor;
deallocate empcursor;

--2. Cursor to Update Salary 
--Create a cursor that increases each employee’s salary by 10%. 
--Update the table inside the cursor loop.

declare @empid int, @salary decimal(10,2)
declare salarycursor cursor for
select empid, salary from employees
open salarycursor
fetch next from salarycursor into @empid, @salary
while @@fetch_status = 0
begin
update employees
set salary = salary + (Salary* 0.10)
where empid = @empid
fetch next from salarycursor into @empid, @salary
end
close salarycursor
deallocate salarycursor

select * from Employees


--3.Cursor with Conditional Logic 
--Fetch all orders. 
--While looping: 
--• If quantity > 10 → give 5% discount 
--• If quantity <= 10 → give 2% discount 
--Update each order accordingly.

declare @orderid int, @qty int, @discount decimal(5,2)
declare ordercursor cursor for
select orderid, quantity from orders
open ordercursor
fetch next from ordercursor into @orderid, @qty
while @@fetch_status = 0
begin
if @qty > 10
set @discount = 0.05
else
set @discount = 0.02
print 'orderid: ' + cast(@orderid as varchar(10)) +
'  discount: ' + cast(@discount as varchar(10));
fetch next from ordercursor into @orderid, @qty;
end
close ordercursor
deallocate ordercursor

--4.Cursor to Copy Data From One Table to Another 
--Read records from OldProducts table using a cursor and insert them into NewProducts.

create table newproducts (
productid int,
pname varchar(100),
stock int,
categoryname varchar(100),
price decimal(10,2)
);

declare @pid int, @pname varchar(100), @stock int, @cat varchar(100), @price decimal(10,2);
declare prodcursor cursor for
select productid, pname, stock, categoryname, price
from products
open prodcursor
fetch next from prodcursor into @pid, @pname, @stock, @cat, @price
while @@fetch_status = 0
begin
insert into newproducts(productid, pname, stock, categoryname, price)
values(@pid, @pname, @stock, @cat, @price)
fetch next from prodcursor into @pid, @pname, @stock, @cat, @price
end
close prodcursor
deallocate prodcursor

select * from products

--5. Cursor to Delete Specific Rows 
--Create a cursor that loops through customers. 
--Delete customers whose LastOrderDate is more than 2 years old.

declare @cid int, @lastdate date;
declare custcursor cursor for
select custid, lastorderdate from customers;
open custcursor;
fetch next from custcursor into @cid, @lastdate;
while @@fetch_status = 0
begin
if datediff(year, @lastdate, getdate()) > 2
delete from customers where custid = @cid;
fetch next from custcursor into @cid, @lastdate;
end
close custcursor;
deallocate custcursor;


--5. Cursor to Delete Specific Rows 
--Create a cursor that loops through customers. 
--Delete customers whose LastOrderDate is more than 2 years old.

declare @cid int, @lastdate date;

declare customercursor cursor for
select c.custid, max(o.orderdate)
from customers c
inner join orders o on c.custid = o.custid
group by c.custid

open customercursor

fetch next from customercursor into @cid, @lastdate
while @@fetch_status = 0
begin
if datediff(year, @lastdate, getdate()) > 2
begin
delete from customers where custid = @cid;
end
fetch next from customercursor into @cid, @lastdate
end

close customercursor
deallocate customercursor

select * from customers