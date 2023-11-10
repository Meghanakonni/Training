create database MoviesDB

use MoviesDB

create table Movie(
Mid int,MovieName varchar(30),DateofRelease Date)

insert into Movie values
(1, 'Athadu', '2002-01-01'),
(2, 'Murari', '2005-05-23'),
(3, 'Arjun', '2005-10-31'),
(4, 'Yuvaraj', '2001-08-09')

select * from Movie