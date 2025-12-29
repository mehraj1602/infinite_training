create database ElectricityBillDB;

create table ElectricityBill (
    Id int identity(1,1) primary key,
    consumer_number varchar(20),
    consumer_name varchar(50),
    units_consumed int,
    bill_amount float);

	delete from ElectricityBill where Id = 3