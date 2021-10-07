create database 03_ospedale;
use 03_ospedale;

-- MEDICI: id, cognome, dob, residenza, stipendio, idreparto
-- REPARTI: id, nome, piano, budget

-- 1 Medico -> 1 Reparto
-- 1 Reparto -> N Medici

/*
Questa è una relazione 1 a N, per risolverla dobbiamo creare una colonna aggiuntiva
nella tabella lato N che conterrà una chiave esterna collegata alla chiave primaria
della tabella lato 1
*/

create table reparti
(
id int primary key auto_increment,
nome varchar(200),
piano int,
budget int
);

create table medici
(
id int primary key auto_increment,
cognome varchar(200),
dob date,
residenza varchar(200),
stipendio int,
idreparto int,
foreign key (idreparto) references reparti(id)
);

-- La foreign key serve a costringere idreparto ad avere come valore
-- un valore contenuto in reparti.id
-- Quindi un medico non potrà avere un idreparto qualsiasi ma solo
-- l'id di un reparto che effettivamente esiste nella tabella reparti

insert into reparti values
(1,"neurologia",3,390000),
(2,"pronto soccorso",0,140000),
(3,"urologia",2,310000),
(4,"ostetricia",3,310000),
(5,"ortopedia",1,140000);

insert into medici(cognome,dob,residenza,stipendio,idreparto) values
("rossi","1988-4-12","milano",2300, 3),
("bianchi","1974-12-19","milano",2480,4),
("gialli","1987-3-1","monza",3299,1),
("pollo","1958-4-19","milano",3900,5),
("fontecchio","1991-4-12","monza",2100,2),
("ricci","1955-10-19","milano",2033,2),
("franchi","1976-9-11","bergamo",3090,1),
("sacchetti","1988-9-9","bergamo",4018,5);