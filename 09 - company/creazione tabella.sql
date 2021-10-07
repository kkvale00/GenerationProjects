create database company;
use company;

create table dipendenti(
id int primary key auto_increment,
nome varchar(230),
cognome varchar(200),
dob date,
stipendio double,
reparto varchar(200)
);

create table clienti(
id int primary key auto_increment,
nome varchar(200),
cognome varchar(200),
cosacompra varchar(200)
);

insert into dipendenti (nome, cognome, dob, stipendio, reparto) values
("Davide", "Testa", "1963-08-19",1923,"Managment"),
('Raffaele', 'Poziello', '1974-08-19',1230,'Magazziniere'),
('Andy', 'Testa', '1999-08-19',900,'Segretario'),
('Fabio', 'Testa', '1956-08-19',3450,'CEO'),
('Barbara', 'Testa', '1969-08-19',2198,'CTO');

insert into clienti (nome,cognome,cosacompra) values 
('Dario', 'Giordano', '1963-08-19'),
('Toti', 'Coco', '1974-08-1923'),
('Roberto', 'Salassa', '1999-08-19'),
('Antonio', 'Maisto', '1956-08-19'),
('Manue', 'Mascitelli', '1969-08-19');


