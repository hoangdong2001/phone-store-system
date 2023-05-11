create database saleManagement
go
use saleManagement

create table accountant(
	idAccountant varchar(50) PRIMARY KEY,
	nameAccountant varchar(50),
	phoneAccountant varchar(15),
)

create table customer(
	idCustomer varchar(50) PRIMARY KEY,
	nameCustomer varchar(50),
	phoneCustomer varchar(50)
)

create table item(
	idItem varchar(50) PRIMARY KEY,
	nameItem nvarchar(50),
	inventory int
)

create table receipt(
	idReceipt varchar(50) PRIMARY KEY,
	idAccountant varchar(50),
	creationDate date,
	totalPrice int,
	foreign key(idAccountant) references accountant(idAccountant)
)

create table detailReceipt(
	idReceipt varchar(50),
	idItem varchar(50),
	quantity int,
	price int
	foreign key(idReceipt) references receipt(idReceipt),
	foreign key(idItem) references item(idItem),
	primary key (idReceipt, idItem)
)

create table orders(
	idOrder varchar(50) PRIMARY KEY,
	idCustomer varchar(50),
	paymentMethod varchar(50),
	creationDate date,
	totalPrice int,
	foreign key(idCustomer) references customer(idCustomer)
)

create table detailOrder(
	idOrder varchar(50),
	idItem varchar(50),
	quantity int,
	price int,
	foreign key(idItem) references item(idItem),
	foreign key(idOrder) references orders(idOrder),
	primary key (idOrder, idItem)
)

create table deliveryBill(
	idDeliveryBill varchar(50) PRIMARY KEY,
	idOrder varchar(50),
	idAccountant varchar(50),
	creationDate date,
	orderStatus varchar(50),
	paymentStatus varchar(50),
	foreign key(idOrder) references orders(idOrder),
	foreign key(idAccountant) references accountant(idAccountant)
)

/*insert database test */

insert into accountant values ('ac1', 'Ke toan 1', '123')

insert into customer values ('cus1', 'Khach hang 1', '123456')

insert into item values ('it1', 'Mat hang 1', 0)
insert into item values ('it2', 'Mat hang 2', 0)
insert into item values ('it3', 'Mat hang 3', 0)
insert into item values ('it4', 'Mat hang 4', 0)
insert into item values ('it5', 'Mat hang 5', 0)
insert into item values ('it6', 'Mat hang 6', 0)
insert into item values ('it7', 'Mat hang 7', 0)
insert into item values ('it8', 'Mat hang 8', 0)
insert into item values ('it9', 'Mat hang 9', 0)
insert into item values ('it10', 'Mat hang 10', 0)

/*create receipt*/
insert into receipt values ('rc1', 'ac1', '1/4/2022', '')
insert into receipt values ('rc2', 'ac1', '12/6/2021', '')

insert into detailReceipt values ('rc1','it1', 2, 10000)
insert into detailReceipt values ('rc1','it2', 3, 20000)
insert into detailReceipt values ('rc1','it3', 4, 40000)
insert into detailReceipt values ('rc1','it4', 5, 50000)
insert into detailReceipt values ('rc1','it5', 21, 60000)
insert into detailReceipt values ('rc2','it1', 2, 10000)
insert into detailReceipt values ('rc2','it2', 3, 20000)
insert into detailReceipt values ('rc2','it3', 4, 40000)
insert into detailReceipt values ('rc2','it4', 5, 50000)
insert into detailReceipt values ('rc2','it5', 21, 60000)
insert into detailReceipt values ('rc2','it7', 32, 100000)

/* update total Price*/
UPDATE re
    SET totalPrice = COALESCE(de.amount, 0)  
    FROM receipt re LEFT JOIN
         (select r.idReceipt, sum(price*quantity) as amount 
		 from  detailReceipt dr, receipt r 
		 where r.idReceipt = dr.idReceipt 
		 group by r.idReceipt
         ) de
         ON de.idReceipt = re.idReceipt;

/*create order*/
insert into orders values ('or1', 'cus1', 'Momo', '1/4/2022', 0)
insert into orders values ('or2', 'cus1', 'Momo', '12/6/2022', 0)

insert into detailOrder values ('or1', 'it1', 3, 12000)
insert into detailOrder values ('or1', 'it2', 3, 15000)
insert into detailOrder values ('or1', 'it3', 4, 23000)
insert into detailOrder values ('or1', 'it4', 5, 53000)
insert into detailOrder values ('or1', 'it5', 8, 64000)
insert into detailOrder values ('or1', 'it10', 20, 123000)
insert into detailOrder values ('or2', 'it6', 2, 12000)
insert into detailOrder values ('or2', 'it7', 3, 15000)
insert into detailOrder values ('or2', 'it8', 4, 23000)
insert into detailOrder values ('or2', 'it9', 5, 53000)
insert into detailOrder values ('or2', 'it10', 6, 64000)
insert into detailOrder values ('or2', 'it3', 50, 164000)
/* update total Price*/
UPDATE o
    SET totalPrice = COALESCE(de.amount, 0)  
    FROM orders o LEFT JOIN
         (select ord.idOrder, sum(price*quantity) as amount 
		 from  detailOrder do, orders ord 
		 where ord.idOrder = do.idOrder 
		 group by ord.idOrder
         ) de
         ON de.idOrder = o.idOrder;

/*create delivery bill */
insert into deliveryBill values ('db1', 'or1', 'ac1', '1/4/2021', 'being transported' , 'unpaid')

insert into deliveryBill values ('db2', 'or2', 'ac1', '12/24/2021', 'being transported' , 'paid')

/*get incoming stock */
select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney 
from detailReceipt dr, item i
where dr.idItem = i.idItem
group by  i.nameItem 

/*get outgoing stock */
select i.nameItem, sum(quantity) as quantity, sum(quantity*price) as totalMoney 
from detailOrder orders, item i
where orders.idItem = i.idItem
group by  i.nameItem 

/*get revenue monthly*/
select year(rc.creationDate) as year, month(rc.creationDate) as month, (sum(ord.totalPrice)-sum(rc.totalPrice)) as revenue 
from orders ord, deliveryBill db, receipt rc
where ord.idOrder = db.idOrder and month(ord.creationDate) = month(rc.creationDate)
group by month(rc.creationDate), year(rc.creationDate)
order by month(rc.creationDate), year(rc.creationDate)

/*test select*/
select * from item
select * from receipt
select * from detailReceipt
select * from orders
select * from detailOrder
select * from deliveryBill



