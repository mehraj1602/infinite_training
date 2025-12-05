--5th question

begin transaction;
update customers
set age = 99
where custid = 102;


--6TH question
begin transaction
update customers
set age = 40
where custid = 102;
commit;


---7TH question--------
begin transaction
-- insert a new row that falls into the same range (a phantom)
insert into sales (SaleId,EmpId, region, SaleAmount, saledate)
values (6,6, 'north', 95000, getdate());

commit;