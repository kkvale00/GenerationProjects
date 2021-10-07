use ospedale;

create table certificati(
id int primary key auto_increment,
nome varchar(200),
annivalidita int
);

-- 1 medico prende N certificati
-- 1 certificato possono prenderlo N medici

-- si creare una tabella di intermezzo con le chiavi
-- esterne, collegate ad una tabella che fa parte della relazione
-- e' come se da una relazione N a N passassimo a due relazioni 1 a N

create table ottengono(
idmedico int,
idcertificato int,
anno int, -- aggiunge informazioni sul medico X che ha preso certificato Y
foreign key (idmedico) references medici(id),
foreign key (idcertificato) references certificati(id),
primary key (idmedico,idcertificato)
);

insert into certificati (nome,annivalidita) values
("cert 01", 5),
("cert 02", 9),
("cert 03", 100);

insert into ottengono values
(1,2,2008),
(1,3,2012),
(4,2,2007),
(5,3,2020),
(6,1,2019),
(6,2,2018);

delete from certificati where id > 3;




-- stampare il cognome di ciascun medico e il nome dei certificati
select *
from medici inner join ottengono on medici.id = ottengono.idmedico
inner join certificati on ottengono.idcertificato = certificati.id;

-- stampare per ogni medico quante certificazioni possiede e il suo cognome
select count(*) as ncertificati, medici.cognome
from medici inner join ottengono on medici.id = ottengono.idmedico
group by medici.id;

-- se raggruppiamo per chiave primaria nella select possiamo inserire
-- una qualasiasi colonna di quella tabella per la stampa
-- se raggruppiamo per una colonna non PK potremo mettere solo quella
-- nella select

