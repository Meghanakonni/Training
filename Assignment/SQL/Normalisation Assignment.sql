create table ClientRental(
clientno varchar(10),
cname varchar(20),
propertyno varchar(10),
paddress varchar(30),
rentstart date,
rentfinish date,
rent bigint,
ownerno varchar(10),
oname varchar(20)
)

insert into clientrental values
('CR76','John Kay','PG4','6 Lawerence st.glasgow','1-jul-00','31-aug-01',350,'CO40','Tina Murphy'),
('CR76','John Kay','PG16','5 Novar Dr. Glasgow','1-sep-02','1-sep-03',450,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 Lawerence st.glasgow','1-sep-99','10-jun-00',350,'CO40','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 Manor rd.glasgow','10-oct-00','1-dec-01',370,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 Novar Dr. glasgow','1-nov-02','1-aug-03',450,'CO93','Tony Shaw')
select  * from clientrental 


create table client1(
clientno varchar(10) primary key,
cname varchar(20))

insert into client1 values
('CR76','John Kay'),
('CR56','Aline Stewart')
select * from client1 

create table owner1(
ownerno varchar(10)primary key,
oname varchar(20)
)

insert into owner1 values 
('CO40','Tina Murphy'),
('CO93','Tony Shaw')

select * from owner1

create table propertyowner1(
propertyno varchar(10)primary key,
paddress varchar(30),
rent bigint,
ownerno varchar(10)
)

insert into propertyowner1 values
('pg4','6 lawerence st.glasgow',350,'co40'),
('pg16','5 novar dr glasgow ',450,'co93'),
('pg36','2 manor rd.glasgow ',370,'co93')

select * from propertyowner1

create table rental1(
clientno varchar(10) foreign key references client1(clientno),
propertyno varchar(10) foreign key references propertyowner1(propertyno),
rentstart date,
rentfinish date)

insert into rental1 values
('cr76','pg4','2000-07-01','2001-08-31'),
('cr76','pg16','2002-09-01','2003-09-01'),
('cr56','pg4','1999-09-01','2000-06-10'),
('cr56','pg36','2000-10-10','2001-12-01'),
('cr56','pg16','2002-11-01','2003-08-01')

select * from rental1

select c.clientno,c.cname,po.propertyno,po.paddress,po.rent,r.rentstart,r.rentfinish,o.oname
from Client1 c inner join rental1 r on c.clientno= r.clientno inner join propertyowner1 po on r.propertyno=po.propertyno
inner join owner1 o on po.ownerno = o.ownerno