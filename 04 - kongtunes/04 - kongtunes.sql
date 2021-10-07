create database 04_kongtunes;
use 04_kongtunes;

/*
In questa libreria multimediale dovremo gestire: autori, album, tracce e film

autori 1 - N album --> 1 autore produce N album
                       1 album è prodotto da 1 autore
                   
album 1 - N tracce --> 1 album contiene N tracce
					   1 traccia è contenuta in 1 album
                       
tracce N - N film --> 1 traccia è contenuta in N film
	                  1 film contiene N tracce
*/

-- ci servono 5 tabelle: inizio a creare quelle che sono indipendenti
-- ovvero quelle che NON contengono chiavi esterne

-- Parto da Autori perché non contiene chiavi esterne

create table autori(
id int primary key auto_increment,
nome varchar(200),
nazione varchar(200)
);

create table album(
id int primary key auto_increment,
nome varchar(200),
genere varchar(200),
datapubblicazione date,
idautore int,
foreign key (idautore) references autori(id)
);

create table tracce(
id int primary key auto_increment,
titolo varchar(200),
durata double,
idalbum int,
foreign key (idalbum) references album(id)
);

create table film(
id int primary key auto_increment,
titolo varchar(200),
regista varchar(200),
genere varchar(200),
durata int,
datapubblicazione date
);

create table colonnasonora(
idfilm int,
idtraccia int,
foreign key(idfilm) references film(id),
foreign key(idtraccia) references tracce(id),
primary key(idfilm, idtraccia) #la coppia di valori e' univoca, per non far uscire la stessa tracia nello stesso film
);

