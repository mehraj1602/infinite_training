create database infinitedb

create table students(studentid int, studentname varchar(20), age tinyint, address varchar(50))


insert into students values
(200,'mehraj',22,'hyd'),
(300,'fatima',22,'hyd'),
(400,'syeda',21,'bang'),
(500,'humera',23,'pune'),
(600,'pooja',23,'Bang')

select * from students
-- display student where age is greater than 22
select * from students where age > 22

--display all the students age in descending order
select * from students order by studentname asc, age desc

--show all the records where age is btw 20 and 22
select * from students where age between 20 and 22

--show all the record where name starts with 'M'
select * from students where studentname like 'M%'


