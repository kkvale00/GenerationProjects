#stampare il titolo di tutte le tracce e il nome dell'album dove sono
select tracce.titolo, album.nome
from tracce inner join album on tracce.idalbum = album.id;

#stampare il titolo di tutte le tracce e il nome dell'autore
select *
from tracce inner join album on tracce.idalbum = album.id
			inner join autori on album.idautore = autori.id
where autori.nome = "pink floyd"
order by datapubblicazione;

#stampare la durata medie delle tracce contenute in album rock
select avg(tracce.durata) as duratamedia
from tracce inner join album on tracce.idalbum = album.id
where album.genere = "rock";


#contare quante tracce ci sono per ogni genere
select count(*) as nTracce, genere
from tracce inner join album on tracce.idalbum = album.id
group by genere
order by nTracce desc;

-- //===================================================================\\
#1 Stampare il titolo dei film che durano più di 2 ore
select film.titolo
from film
where durata > 120
order by durata desc;

-- //===================================================================\\
#2 Stampare il titolo degli album prodotti da autori provenienti da "stati uniti"
select album.nome, autori.nome, nazione
from album inner join autori on album.idautore = autori.id
where nazione = "stati uniti";

-- //===================================================================\\
#3 Stampare il numero di album prodotti da ciascun autore
select count(*) as nAlbum, autori.nome
from album inner join autori on album.id = autori.id
group by autori.nome;

-- //===================================================================\\
#4 Stampare il numero di tracce che sono state prodotte da ciascun autore
select count(*) as nTracce, autori.nome
from tracce inner join album on tracce.idalbum = album.id
			inner join autori on album.idautore = autori.id
group by autori.nome
order by nTracce desc;

-- //===================================================================\\
#5 Stampare il numero di tracce prodotte da ciascuna nazione
select count(*) as nTracce, autori.nazione
from tracce inner join album on tracce.idalbum = album.id
			inner join autori on album.idautore = autori.id
group by nazione
order by nTracce desc;

-- //===================================================================\\
#6 Stampare il titolo dei film che nella propria colonna sonora contengono
#tracce che durano più di 2 minuti
select distinct film.titolo
from colonnasonora inner join tracce on colonnasonora.idtraccia = tracce.id
					inner join film on colonnasonora.idtraccia = film.id
where tracce.durata > 2;

#DISTINCT = EVITA RIPETIZIONI DI RIGHE COMPLETAMENTE UGUALI
-- //===================================================================\\
#7 Stampare il titolo dei film che nella propria colonna sonora contengono brani
#  scritti da autori provenienti da "italia"
select distinct film.titolo, film.regista, film.genere, film.durata
from colonnasonora inner join film on colonnasonora.idfilm = film.id
				   inner join tracciacompleta on colonnasonora.idtraccia = tracciacompleta.idtraccia
where tracciacompleta.nazione = "italia";

#creiamo una view per semplificare le join
create view tracciacompleta as
select tracce.id as idtraccia, titolo, durata, idalbum, 
	   album.nome as nomealbum, genere, datapubblicazione,idautore,
	   autori.nome as nomeautore, nazione
from tracce inner join album on tracce.idalbum = album.id
			inner join autori on album.idautore = autori.id;

SELECT *
FROM tracciacompleta;

-- //===================================================================\\
#8 Stampare per ogni regista il numero di film che ha prodotto
create view numerofilm as
select Count(*) as nFilm, film.regista
from  film 
group by film.regista;

-- //===================================================================\\
#9 Stampare il nome del regista che ha prodotto più film
select *
from numerofilm 
where nfilm = (select max(nfilm) from numerofilm);

-- //===================================================================\\
#10 Stampare quante tracce sono uscite negli anni 80
select Count(*) as nTracce
from tracce inner join album on album.id = tracce.idalbum
where year(datapubblicazione) between 1980 and 1989;

-- //===================================================================\\
#11 Contare quante tracce prodotte da autori degli "Stati uniti" ci sono per ogni film
select Count(*) as nTracce, film.*
from film inner join colonnasonora on film.id = colonnasonora.idfilm
				inner join tracciacompleta 
                on colonnasonora.idtraccia = tracciacompleta.idtraccia
where tracciacompleta.nazione = "stati uniti"
group by film.id
order by ntracce;



-- //===================================================================\\
#12 Stampare il titolo del film con la colonna sonora più lunga
create view duratacolonne as
select sum(tracce.durata) as durataCS, film.titolo
from film inner join colonnasonora on film.id = colonnasonora.idfilm
		  inner join tracce on colonnasonora.idtraccia = tracce.id
group by film.titolo;

select *
from duratacolonne
where durataCS = (select max(durataCS) from duratacolonne);

-- //===================================================================\\
#13 Stampare quante volte ciascuna traccia è comparsa in una colonna sonora
select count(*) as contatracce, tracce.*
from colonnasonora inner join tracce on colonnasonora.idtraccia = tracce.id
#group by titolo; #si mette tracce.id, mettiam tracce* nel selecttt
group by tracce.id; 



-- //===================================================================\\
#14 Contare per ogni autore quante sue tracce sono state utilizzate in colonne sonor
select count(*) as nvolte, tracciacompleta.nomeautore
from tracciacompleta inner join colonnasonora
 on tracciacompleta.idtraccia = colonnasonora.idtraccia
group by tracciacompleta.nomeautore
order by nvolte desc;

#15 Stampare il numero di album che contengono almeno 10 tracce che durano tra 2 e 3 minuti
create view ntracce23 as
select count(*) as ntracce, album.*
from tracce inner join album on tracce.idalbum = album.id
where durata between 2 and 3
group by album.id; 

select count(*) as album 
from ntracce23
where ntracce >= 3;

#16 Stampare quante tracce vengono usate mediamente all'interno di un film

#Prima calcolo quante tracce ci sono in ciascuna colonna sonora
create view tracceperfilm as
select count(*) as ntracce, film.*
from film inner join colonnasonora on film.id = colonnasonora.idfilm
group by film.id;


#Poi faccio una media 
select avg(ntracce) as media
from tracceperfilm;




