select * from customers
select * from orders

--1. display all the records from customers who made a purchase of books 
select * from customers where custid in (select custid from orders where product = 'books')

--2. display all the records from customer who made a purchase of books , toys, cd
select * from customers where custid in ( select custid from orders where product in ('books','toys','cd'))

--3. display the list of customers who never made any purchase
select * from customers where custid not in (select custid from orders)

--4. display the second highest age from customers (do not use top keyword)
select max(age) as second_highest_age from customers where age<(select max(age) from customers)

 --5.display the list from orders  where customers stays in bangalore
select * from orders where custid in (select custid from customers where caddress = 'banglore')

--6. display list of customer who made lowest purchase (in terms of quantity) 
select * from customers where custid in (select custid from orders where quantity = (select min (quantity) from orders))

--7. display the list of customer who's age is greater then  ajay's age ( but we dont know ajay's age)
select * from customers where age > (select age from customers where custname = 'Ajay')

--8. update customer table where custid =100's age  = custid=200's age
update customers set age=(select age from customers where custid=200) where custid=100

--9. Display those details who made orders in December of any year
select*from orders where month(orderdate)=12

--10. Show all orders made before first half of the month (before the 16th of the month who does not reside in bangalore)
select*from orders where day(orderdate) < 16 and custid in (select custid from customers where caddress<> 'Banglore')

--11. Display list of customers from delhi and Bangalore who made purchase of less than 3 product
select*from customers where caddress in ('Delhi','Banglore') and custid in (select custid from orders where quantity < 3)

--12. Display list of orders where price is greater than average price
select*from orders where price>(select avg(price) from orders)

--13. update orders table increasing price by 10% for customers residing in Bangalore and who have purchased books.
update orders set price = price*1.10 where product='books' and custid in (select custid from customers where caddress='banglore')

--14.Display orderdetails in following format
--OrderID-Date      Total(price*qty)
--100-1/1/2000      500
select concat(orderid, '_',convert(varchar,orderdate, 101)) as orderdate, (price*quantity) as totalAmount from orders
