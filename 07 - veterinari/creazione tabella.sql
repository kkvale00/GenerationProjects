create database veterinario;
use veterinario;

create table veterinari(
id int primary key auto_increment,
nome varchar(200),
cognome varchar(200),
anniLavorati int,
stipendioMensile double
);

# Stampare la scheda del o dei veterinari con lo stipendio mensile più alto
select *, max(stipendioMensile) from veterinari;

# Stampare il o i veterinari con lo stipendio annuo più basso
select nome, min(stipendioMensile * 12) as stipendioannuo
from veterinari;

# Stampare l'esperienza media dei veterinari
select avg(anniLavorati) from veterinari;

#Stampare il nome del veterinario con meno esperienza
select *, min(anniLavorati)
from veterinari;


#Creare la tabella Animali con id, specie, problema, costoCure
create table animali(
id int primary key auto_increment,
specie varchar(200),
problema varchar(200),
costoCure double,
idveterinario int,
foreign key (idveterinario) references veterinari(id)
);
#Stampare la lista di tutti gli animali
select * from animali;
#Stampare la lista dei problemi, senza ripetizioni, degli animali
select distinct problema
from animali;

#Stampare il problema con il costo cure maggiore
select max(costoCure) as costomax, problema
from animali;


#Stampare il costo medio delle cure per ogni specie
select avg(costoCure), specie
from animali
group by specie;

#Stampare la specie con il costo totale delle cure più alto

#Stampare per ogni specie quanti animali sono presenti
select count(*) as howmany,specie
from animali
group by specie;



#Stampare la specie con il minor numero di animali presenti



