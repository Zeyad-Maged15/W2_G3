create table student 
(
id int identity primary key,
sname varchar(60),
sage int,
sadd varchar(60),
spoh varchar(60),
);
Create Table loigin
(
Aname varchar(60) Primary Key,
Apass varchar(60),
);

Insert Into student Values
('Alaa',17,'6th of october', '0112345678');

Insert Into loigin Values
('Alaa','lolla'),
('Retaj','reta'),
('Zeyad','zoz'),
('Habiba','haboba'),
('Adam','doma');