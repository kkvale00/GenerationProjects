create database movie;
use movie;

create table films(
id int primary key auto_increment,
titolo varchar(200),
durata int,
genere varchar(200),
annouscita int
);

create table serietv(
id int primary key auto_increment,
titolo varchar(200),
genere varchar(200),
stagioni int,
puntatemedie int,
puntatamediapuntata double
);