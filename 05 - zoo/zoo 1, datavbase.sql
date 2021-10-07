/*
DATABASE ZOO
Creare un database Zoo

Creare una tabella Animali, strutturata così:
    int id PK AI, varchar specie, date dob, varchar sesso, double pesoAnimale, varchar tipoAlimentazione
    
Creare una tabella Gabbie, strutturata così:
    int id PK AI, varchar tipoGabbia(es Recinto, piscina, voliera, ecc), int capienzaMax

Creare una tabella Personale, strutturata così:
    int id PK AI, varchar nominativo, date dob, varchar residenza
     
Animali N - 1 Gabbie     /c'e una gabbia per ogni animale/ 
Personale N - N Gabbie /personale ha assegnate delle gabbie/
						/gabbie e gestito dal personale/
*/
create database zoo;
use zoo;

create table personale(
id int primary key auto_increment,
nominativo varchar(200),
dob date,
residenza varchar(200)
);

create table gabbie(
id int primary key auto_increment,
tipogabbia varchar(200),
capienzamax int
);

create table animali(
id int primary key auto_increment, 
specie varchar(200),
dob date,
sesso varchar(200),
pesoAnimale double,
tipoAlimentazione varchar(200),
idgabbia int,
foreign key (idgabbia) references gabbie(id) on delete set null
);

-- on delete set null significa che qualora venisse eliminata una gabbia
-- a cui un nostro animale è assegnato allora la chiave esterna idgabbia prenderà
-- come nuovo valore "null"

create table gestisce(
idpersonale int,
idgabbia int,
foreign key (idpersonale) references personale(id) on delete cascade,
foreign key (idgabbia) references gabbie(id) on delete cascade,
primary key(idpersonale, idgabbia)
);

-- il cascade serve ad indicare che qualora venisse canceellato l'oggetto
-- a cui siamo collegati a cascata verrrebe cancellata anche la riga 
-- della tabella gestisce











