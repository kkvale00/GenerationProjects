-- Scrivere una query che mi permetta di vedere solo i gli animali di una certa specie a vostra scelta
select *
from animali
where specie = "koala";

-- Scrivere una query che mi permetta di vedere solo i gli animali carnivori
select specie
from animali
where tipoalimentazione ="carnivoro";

-- Scrivere una query che mi permetta di vedere tutte le specie presenti nel DB

select distinct specie
from animali
group by specie
order by specie;

-- Scrivere una query che mi permetta di vedere il numero di animali per ogni tipo di alimentazione

select count(*) as nAnimali, specie, tipoalimentazione
from animali 
group by tipoAlimentazione;

-- Scrivere una query che mi permetta di vedere il peso medio per ogni specie
select avg(pesoanimale),specie
from animali
group by specie;

-- //===========================SOLO GABBIE======================================\\
-- Scrivere una query che mi permetta di vedere la gabbia che ha la capienza maggiore
select max(capienzamax),tipogabbia
from gabbie;

-- Scrivere una query che mi permetta di vedere il numero di gabbie per tipologia
create view ngabbie as
select count(*) as ngabbie, tipogabbia
from gabbie
group by tipogabbia
order by ngabbie desc;

-- Scrivere una query che mi permetta di vedere il numero massimo di animali che posso avere nello zoo
select sum(ngabbie) as numeromassimo 
from ngabbie;


-- Scrivere una query che mi permetta di vedere il nome della gabbia con la capienza minima
select gabbie.tipogabbia
from gabbie
where tipogabbia = (select min(capienzamax) from gabbie);

-- //==============================SOLO TABELLA Personale======================================================\\

-- Scrivere una query che mi permetta di vedere il nominativo della persona più anziana
select *
from personale
where dob = (select min(dob) from personale);

-- Scrivere una query che mi permetta di vedere l'età media del personale
create view etamedia as 
select avg(2021 - year(dob)) as mediaeta
from personale;
-- Scrivere una query che mi permetta di vedere i nomi delle persone con un età superiore alla media
select *
from etamedia 
where etamedia = (select eta > etamedia from etamedia);


-- Scrivere una query che mi permetta di vedere quante persone sono presenti per ogni residenza
select * 
from personale
group by residenza;

-- //==============================SOLO TABELLA tutti======================================================\\

-- Scrivere una query che mi permetta di vedere per ogni gabbia quanti animali effettivamente contiene
select distinct count(*) as contanimali, gabbie.*
from animali inner join gabbie on gabbie.id = animali.idgabbia
group by gabbie.id;


-- Scrivere una query che mi permetta di vedere i nomi delle gabbie che contengono carnivori
select gabbie.tipogabbia
from gabbie inner join animali on gabbie.id = animali.idgabbia
where gabbie.tipogabbia = (select animali.id from animali where tipoAlimentazione = "carnivori");

-- Scrivere una query che mi permetta di vedere il nome dell'animale più anziano e il nome della gabbia dove sta

-- Scrivere una query che mi permetta di vedere l'elenco di tutte le gabbie vuote
-- Scrivere una query che mi permetta di vedere la capienza media effettiva in base al tipo di gabbia
-- Scrivere una query che mi permetta di vedere le gabbie e chi se ne occupa
-- Scrivere una query che mi permetta di vedere quale persona si occupa del minor numero di gabbie
-- Scrivere una query che mi permetta di vedere di quanti animali si occupa ogni persona

