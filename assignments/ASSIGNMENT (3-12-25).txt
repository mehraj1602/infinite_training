
----------FUNCTIONS---------------------------
--1. create a function to find the greatest of three numbers
create function getgreatest(@a int, @b int, @c int)
returns int
as
begin
declare @max int;
set @max = case 
when @a >= @b and @a >= @c then @a
when @b >= @a and @b >= @c then @b
else @c
end;
return @max;
end;
select dbo.getgreatest(10, 25, 7) as greatest;


--2. create a function to calculate to discount of 10% on price on all 
--the products 
create function getdiscount10(@price decimal(10,2))
returns decimal(10,2)
as
begin
return @price - (@price * 0.10);
end;

select 
    productid,
    pname,
    price,
    dbo.getdiscount10(price) as discounted_price
from products;



--3. create a function to calculate the discount on price as following 
--if productname = 'books' then 10% 
--if productname = toys then 15% 
--else 
--no discount
create function getcategorydiscount
(
    @productname varchar(50),
    @price decimal(10,2)
)
returns decimal(10,2)
as
begin
declare @finalprice decimal(10,2);
set @finalprice =
case 
when @productname = 'books' then @price - (@price * 0.10)
when @productname = 'toys' then @price - (@price * 0.15)
else @price
end;
return @finalprice;
end;

select
    productid,
    pname,
    price,
    dbo.getcategorydiscount(pname, price) as discounted_price
from products;



--4. create inline function which accepts number and prints last n 
--years of orders made from  now. 
--(pass n as a parameter)

create function getlastnyear(@n int)
returns int
as
begin
    return year(getdate()) - @n;
end

select *
from orders
where year(orderdate) >= dbo.getlastnyear(3);


----------TRIGGERS------------
--1. Create a trigger for table customer, which does not allow 
--the user to delete the record who stays in Bangalore, 
--Chennai, delhi 
create trigger trgblockdeletecity
on customers
for delete
as
begin
select * 
from deleted 
where caddress in ('Bangalore', 'Chennai', 'Delhi');
if @@rowcount > 0
begin
print('cannot delete customers from bangalore, chennai, delhi');
rollback transaction;
return;
end
delete from customers
where custid in (select custid from deleted);
end;

delete from customers 
where custid = 102;

--2. Create a triggers for orders which allows the user to insert 
--only books, cd, mobile 
create trigger trg_allow_only_specific_products
on orders
for insert
as
begin
if exists (
select * from inserted
where product not in ('books', 'cd', 'mobile')
)
 begin
print('only books, cd, mobile can be inserted into orders table');
rollback transaction;
return;
end
end;

insert into orders(custid, orderid, orderdate, product, price, quantity)
values (102, 70002, '2025-12-02', 'cd', 300, 1)

drop trigger trg_allow_only_specific_products

--3. Create a trigger for customer table whenever an item is 
--delete from this table. The corresponding item should be 
--added in customerhistory table. 
create trigger trg_customers_delete_history
on customers
for delete
as
begin
insert into custhistory (custid, custname, age, caddress, cphone)
select custid, custname, age, caddress, cphone
from deleted
select * from deleted
end;

delete from customers where custid = 108;

--4. Create update trigger for stock. Display old values and new 
--values
create trigger trg_stock_update_show
on stock
for update
as
begin
select
d.stockid      as old_stockid,
d.minstocklvl  as old_minstock,
d.maxstocklvl  as old_maxstock,
i.stockid      as new_stockid,
i.minstocklvl  as new_minstock,
i.maxstocklvl  as new_maxstock
from deleted d
join inserted i
on d.stockid = i.stockid;
end;
update stock
set minstocklvl = 12, maxstocklvl = 55
where stockid = 'abc-44-def';

--5. Create Instead Of Insert Trigger for Joined View (the user 
--should able to insert record for 2 table using single insert 
--command) Use following table

create table a 
( 
custid int, 
custname varchar(12) 
)

create table b 
( 
custid int, 
product varchar(12) 
)

create view testview 
as 
select a.* , b.product from a inner join b on a.custid = 
b.custid

select * from testview

 
create trigger trg_testview_instead_of_insert
on testview
instead of insert
as
begin
insert into a(custid, custname)
select i.custid, i.custname
from inserted i

insert into b(custid, product)
select i.custid, i.product
from inserted i
end


insert into testview (custid, custname, product)
values (111, 'chandini', 'books');
insert into testview (custid, custname, product)
values 
  (112, 'arjun', 'cd'),
  (113, 'meera', 'mobile');

select * from a;
select * from b;
select * from testview;



