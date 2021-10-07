-- select year("2020-07-19");

-- 			//FUNZIONI DI GRUPPO\\						es:
-- Quantri dipendenti ho in azienda? 				COUNT
-- Quanto prende in media un dipendente? 			AVG
-- Quando e' nato il dipendente piu giovane? 		MIN
-- Quando e' nato il dipendente piu giovane? 		MAX
-- Quanto spendo in totale di stipendi ogni mese	SUM

-- 						//REGOLE\\       -- 
-- LE FUNZIONI DI GRUPPO SI USANO SOLO NELLA SELECT
-- SE NELLA SELECT C'E UNA FUNZIONA DI GRUPPO ALLORA CI SARANNO 
-- SOLO FUNZIONI DI GRUPPO

-- Stampare la somma totale, minimo, massimo e medio degli stipendi
select sum(stipendio) as SommaStipendi -- sum somma tutti gli stipendi
from dipendenti;

select min(stipendio) as StipendioMinimo
from dipendenti;

select max(stipendio) as StipendioMassimo
from dipendenti;

select avg(stipendio) as StipendioMedio
from dipendenti;

-- quanti sono nati prima del 1990
select count(*) as conteggio
from dipendenti
where yob < 1990;