/*
Persone (id, nome, cognome, dob, residenza

Assicurazioni (id, tipo (es. casa, auto, vita), costoannuo, 

Assicuratori (id, nome, cognome, dob, residenza, annilavoro, 



In base alle informazioni seguenti relazionare le tabelle tra di loro:

- ogni persona può stipulare diversi tipi di assicurazione e un'assicurazione può essere stipulata da più persone

- ogni persona è gestita da un assicuratore e un assicuratore gestisce più persone



Nella tabella di intermezzo inserire, oltre all'id della persona e all'id dell'assicurazione anche la dataInizio e la dataFine.
Ovviamente la dataInizio corrisponde a quando viene attivata la polizza, 
mentre la dataFine potrebbe essere 'null' che vale a dire che la polizza è ancora attiva.
*/
create database polizza;
use polizza;

create table assicuratori (
id int primary key auto_increment, 
nome varchar(200), 
cognome varchar(200), 
dob date, 
residenza varchar(200), 
annilavoro int
); 

create table persone (
id int primary key auto_increment, 
nome varchar(200), 
cognome varchar(200), 
dob date, 
residenza varchar(200), 
idassicuratore int,
foreign key (idassicuratore) references assicuratori(id)
);

#primary key: indica che i valori di una colonna in una tabella sono univoci
# possiamo avere 2 o più primary key in una tabella? Si, quando lo facciamo
# il valore univoco sarà l'associazione di quei valori 
#foreign key: ci costringe ad utilizzare come valori solo quelli che sono già contenuti
# nella colonna di riferimento

create table Assicurazioni (
id int primary key auto_increment, 
tipo varchar(200), 
costoannuo double
); 

create table stipula(
idpersona int,
idassicurazione int,
foreign key (idpersona) references persone(id),
foreign key (idassicurazione) references assicurazioni(id),
datainizio date not null,
datafine date,
primary key (idpersona, idassicurazione)
);


insert into assicurazioni (tipo, costoannuo) values
("Vita", 1200),
("Auto", 800),
("Furto", 300),
("Casa", 330);

insert into assicuratori (nome, cognome, dob, residenza, annilavoro) values
("Pino", "Pane", "1980-4-1", "Milano", 10),
("Maurizia", "Polli", "1976-4-12", "Brescia", 18),
("Jennifer", "Costanzo", "1995-9-4", "Milano", 1);

insert into persone (nome, cognome, dob, residenza, idassicuratore) values
("Rachele", "Rossoni", "1934-5-12", "Bergamo", 1),
("Alexis", "Monesi", "1989-4-11", "Milano", 1),
("Emilio", "Robot", "1993-12-12", "Milano", 3),
("Simone", "Berretto", "1955-10-24", "Brescia", 2),
("Sofia", "Parigi", "1948-5-12", "Milano", 1),
("Daniele", "Barba", "1956-9-3", "Milano", 2);

insert into stipula values
(1, 2, "2020-3-3", null),
(1, 3, "2018-5-12", null),
(2, 4, "2021-1-1", null),
(3, 1, "2020-12-1", null),
(3, 4, "2010-1-1", "2012-1-1"),
(4, 1, "2012-4-19", "2020-3-12"),
(5, 2, "2019-10-9", null),
(6, 3, "2020-9-1", null),
(6, 4, "2015-5-1", "2019-5-1");
