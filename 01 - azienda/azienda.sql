-- Creare un nuovo database di nome azienda
create database 01_azienda;
use 01_azienda;


-- 				//CAMBIARE IL NOME \\
-- 		alter table dipendenti rename nomenuovo;
-- 		rename table dipendenti to nomenuovo;

--            //O IL TIPO DI UNA COLONNA\\
-- 		alter table dipendenti
--      change column annodinascita yob int

--         			//RIMUOVERE COLONNA\\
-- 				alter table dipendenti
-- 				drop column colonna

-- 			//AGGIUNGERE COLONNA\\
-- 			alter table dipendenti
-- 			add column nome int

-- 		//Inserire i dati in una tabella gia popolata\\
-- 			update dipendenti
-- 			set yob = 1980
-- 			where matrice = 2;

--     //Cancellare tabella/database\\
--      drop table nometabella;
--      drop database nomedatabase;



-- Creare una nuova tabella di nome dipendenti che avrà come colonne: 
-- int matricola PK, nome, cognome, annoDiNascita, residenza, int stipendio, reparto 

create table dipendenti
(
	matricola int primary key,
    nome varchar(50),
    cognome varchar(40),
    yob int,
    residenza varchar(60),
    stipendio int,
    reparto varchar(60)
);

-- Inserire almeno 5 dipendenti nella tabella
insert into dipendenti
values
(1,"Giovanni","Giorgio","1926","Milano",1843,"acquisti"),
(2,"Lorenzo","Insigne","1990","Napoli",1450,"vendite"),
(3,"Matteo","Politano","1993","Torino",2110,"acquisti"),
(4,"Mario","Mandzukic","1995","Napoli",2110,"vendite"),
(5,"Mario","Moretti","1923","Venezia",2350,"amministrazione");

select * from dipendenti;


-- stampare il nome e il cognome di tutti i dipendenti
select nome, cognome
from dipendenti;

-- stampare nome, cognome e residenza dei dipendenti di milano
select nome, cognome, residenza
from dipendenti
where residenza = "milano";

-- stampare l'anno di nascita di coloro che si chiamano "mario"
select yob
from dipendenti
where nome = "mario";

-- stampare il nome dei reparti di chi ha uno stipendio maggiore di 2000
select reparto
from dipendenti
where stipendio > 2000;

-- stampare la matricola di coloro che sono nati tra il 1970 e il 1990 compresi
select matricola
from dipendenti
where yob between 1970 and 1990;

-- stampare matricola e cognome di coloro che lavorano nel reparto vendite con uno stipendio compreso tra 1500 e 1700, 
-- oppure lavorano negli acquisti maggiore di 1800
select matricola, cognome
from dipendenti
where (reparto = "vendite" and stipendio between 1500 and 1700) or (reparto = "acquisti" and stipendio > 1800);

-- stampare la residenza di coloro che lavorano in un reparto tra "vendite", "amministrazione", "acquisti"
select residenza
from dipendenti
where reparto in ("vendite","acquisti","amministrazione");

-- stampare il matricola, cognome ed età di ciascun dipendente
select matricola, cognome, 2021 - yob as eta -- si usa per rinominare la colonna col il risultato del calcolo
from dipendenti;

-- stampare matricola, nome, cognome e stipendio annuale di coloro che abitano a "milano", "napoli" o "torino" e sono nati negli anni '90
select matricola, nome, cognome, stipendio * 12 as annualrenvenue
from dipendenti
where residenza in ("milano","napoli","torino") and yob between 1990 and 1999;