create database concessionaria;
use concessionaria;

/*Creare la tabella Prodotti, con:
	 int id, varchar marca, varchar modello, boolean affittabile,
	 int annoImmatricolazione, int consumoMedioAKM, int capienzaSerbatoio

Creare la tabella Automobili, con:
	int id, int cilindrata, int velocitaMax, int posti

Creare la tabella Moto, con:
	int id, boolean passeggeri*/
    
create table Prodotti(
id int primary key auto_increment,
marca varchar(200),
modello varchar(200),
affittabile bool,
annoimmatricolazione int,
consumomedio int,
capienzaserbatoio int
);

create table Automobili(
id int primary key auto_increment,
cilindrata int,
velocitamax int,
posti int,
foreign key (id) references prodotti(id)
on delete cascade
on update cascade
);

create table Moto(
id int primary key auto_increment,
passeggeri bool,
foreign key (id) references prodotti(id)
on delete cascade
on update cascade
);

insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaSerbatoio) values ('BMW', 1999, true, 1993, 15, 23);
insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaSerbatoio) values ('Jaguar', 2008, false, 2021, 14, 20);
insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaserbatoio) values ('hyundai', 1999, true, 1993, 15, 23);
insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaserbatoio) values ('harley davidson', 2000, false, 2000, 11, 29);
insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaserbatoio) values ('ducati', 2012, false, 2021, 11, 23);
insert into Prodotti (marca, modello, affittabile, annoImmatricolazione, consumoMedio, capienzaserbatoio) values ('ferrari', 1993, true, 1997, 12, 28);

insert into Automobili (id, cilindrata, velocitaMax, posti) values (2, 2273, 314, 3);
insert into Automobili (id, cilindrata, velocitaMax, posti) values (4, 2429, 221, 2);
insert into Automobili (id, cilindrata, velocitaMax, posti) values (5, 2429, 221, 2);

insert into Moto (id, passeggeri) values (1, true);
insert into Moto (id, passeggeri) values (3, true);
insert into Moto (id, passeggeri) values (6, false);