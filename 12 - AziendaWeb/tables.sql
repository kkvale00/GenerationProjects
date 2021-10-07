create database AziendaWeb;
use AziendaWeb;

create table Dipendenti(
id int primary key auto_increment,
nome varchar(200),
cognome varchar(200),
dob date,
reparto varchar(200),
residenza varchar(200)
);

insert into Dipendenti (nome,cognome,dob,reparto,residenza) values
('davide','testa','1989-08-23','vendite','milano'),
('raffaele','poziello','1999-08-23','acquisti','monza'),
('fabio','testa','1979-08-23','vendite','bergamo'),
('barbara','testa','1969-08-23','acquisti','triveneto');