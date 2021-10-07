-- commento monoriga due trattini e spazio
/*
	commento
	su
    piu
    righe
*/

-- creare un database
create database Libreria;

-- utilizza Libreria;
use Libreria;

-- creare tabella;
-- i nomi delle tabelle sono sempre al plurale
-- la primary key(PK) colonna con 2 caratteristiche: MAI nulla, MAI doppia
-- ci serve per distingure le righe nella tabella, anche in caso di omonimia
create table libri
(
	id int primary key, 
	titolo varchar(50),
    autore varchar(100),
    genere varchar(20),
    nPagine int
);

-- Inserire dati dentro una tabella
insert into libri
values
(1,"It","King","Horror",1200),
(2,"Il Suggeritore","Carrisi","Giallo",350),
(3,"Il Pendolo","Poe","Horror",10),
(4,"Lo Hobbit","Tolkien","Fantasy",300);

-- QUERY: e una domanda che noi facciamo al DB che stiamo usando
select *
from libri;

-- SELECT -> mostra le colonne indicate, con '*' mostrera tutte le righe
-- FROM ->   indica da quale tabella andare a leggere
-- WHERE -> lavora con le righe , filtra solo quelle indicate

-- mostra solo il libro sulla 3 riga[id]
select *
from libri
where id = 3;

-- mostra i libri che come genere sono fantasy
select *
from libri
where genere = "fantasy";

-- voglio vedere i libri che hanno piu di 300 pagine e sono horror
select *
from libri
where npagine > 300 or genere != "horror";

-- AND -> tutto vero
-- OR -> basta una condizione sia vera
-- NOT o ! -> nega 








