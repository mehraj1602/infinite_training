
--creating the customers table
create table customers
(custid int,custname varchar(20),age tinyint,caddress varchar(50),cphone varchar(20))

--creating the orders table
create table orders
(custid int, orderid int,orderdate date,product varchar(40), price float,quantity int)

--Adding the values to customers table
insert into customers values
(101,'syeda',22,'mumbai',8675647839),
(102,'mehraj',20,'banglore',8653425678),
(103,'fatima',23,'delhi',5673452672),
(104,'roohi',27,'chennai',7845634567),
(105,'Niharika',32,'surat',8974653425),
(106,'raj',34,'kolkata',9873625435)

--Adding the values in the orders table
insert into orders values
(101,1,'2025-05-16','shampoo',280,2),
(102,2,'2025-08-03','oil',1200,3),
(103,3,'2025-10-15','lays',100,5),
(104,4,'2025-09-23','soaps',650,8),
(105,5,'2025-05-16','shampoo',280,2),
(106,6,'2025-11-14','detergents',1000,2),
(107,7,'2025-07-16','chocolates',300,5),
(108,8,'2025-03-27','toothpaste',480,6),
(109,9,'2025-01-07','flowers',900,20)

select * from customers
select * from orders

--1. Display the list of customers who resides in Bangalore
select * from customers where caddress = 'banglore'

--2. Display the list of customers who does not resides in Bangalore or chennai
select *from customers where caddress not in ('banglore','chennai')

--3. Display the list of customers who’s age is greater then 50 and does not resides in Bangalore
select * from customers where age > 50 and caddress != 'banglore'

--4.Display the list of customers who’s name starts with A 
select * from customers where custname like 'A%'

--5. Display the list of customers who’s name contains a word Br 
select * from customers where custname like '%br%'

--6. Display the list of customer who’s name start between a to k  
select * from customers where custname like '[a-k]%'

--7. Display the list of customers who’s name is 5 character long
select * from customers where custname like '_____'

--8. Display the list of customer who’s name  
--a. Start with s 
select * from customers where custname like 's%'
--b. Third character is c 
select * from customers where custname like '__c%'
--c. Ends with e 
select * from customers where custname like '%e'

--9. Display unique customer names from customers table
select distinct custname from customers

--10. List orders details where qty falling in the range 100-200  and 700-1200
select * from orders where quantity between 100 and 200 or quantity between 700 and 1200

--11.  List customer details where custname beginning with AL and ending 
--with N 
select * from customers where custname like 'al%n'

--12. Display what each  price would be if a 20% price increase were to take 
--place. Show the custid , old price and new price ,using meaningful 
--headings(use orders table)  
select custid, price AS OldPrice, price + (price * 0.20) AS NewPrice from orders

--13. Display top 3 highest qty from orders table 
select Top 3* from orders order by quantity DESC

--14. Display how many times customers have purchased a product (display 
--count and customerid from orders table)
select custid, count(*) AS TotalPurchases from orders group by custid

--15. Display the list of orders who’s orders made earlier then 5 years from 
--now
select * from orders where orderdate <DATEADD(YEAR, -5, GETDATE())

--16.  Select * from customers where custname is null 
select * from customers where custname IS NULL

--17.  Display orderdetails in following format 
--OrderID-Date Total(price*qty) 
--100-1/1/2000 500 
select CONCAT(orderid, '-', orderdate) AS [orderID-Date],(price * quantity) AS Total from orders

--18.  Update orders table by decreasing price by 20% for qty > 50
update orders set price = price - (price * 0.20) where quantity > 50

--19. You want to retrieve data for all the orders who made order  '1-12-90' 
--having price 4000 – 6000 and sort the column in descending order on 
--price
select * from orders where orderdate = '1990-12-01' order by price DESC


--20. Display order details in following format 
--Custid Price (sum of price) Count (count of qty) 
--1 5000 3 
--2 4000 9 
--3 6700 6
 select custid, SUM(price) AS TotalPrice, Count(quantity) AS quantityCount from orders group by custid

 --21. Display above details only for price > 4000
 select custid, sum(price) AS TotalPrice,count(quantity) AS quantitycount from orders group by custid having sum(price)> 4000


 --22. Write a query to create duplicate table of customer , and name it as 
--custhistory 
--a. Delete all the records of custhistory 
--b. Copy records of customers to custhistory where age > 30
select * into custhistory from customers where age > 30


