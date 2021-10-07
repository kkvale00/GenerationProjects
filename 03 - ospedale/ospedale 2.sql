select * from reparti;
select * from medici;-- con la foreign key uso la colonna reparto nella table medici

select *
from medici,reparti
where medici.idreparto = reparti.id; 

#chiedo di associare l'id reparto al reparto
#una join e l'associazione tramite chiave esterna di 2 tabelle
#join implicita

select *
from medici inner join reparti on medici.idreparto = reparti.id;
#questa is una join esplicita

-- stampare il cognome dei medici e 
-- il nome del reparto in cui lavara di coloro che hanno uno stipendio > 3000
select cognome, nome
from medici, reparti
where medici.idreparto = reparti.id and stipendio > 3000;

#1 stampare il cognome dei medici che lavorano in pronto soccorso o ortopedia
select cognome, nome
from medici inner join reparti on medici.idreparto = reparti.id 
where reparti.nome in ("pronto soccorso","ortopedia");

#2 stampare il cognome e lo stipendio di coloro che lavorano in neurologia e hanno più di 35 anni
select cognome, stipendio
from medici inner join reparti on medici.idreparto = reparti.id
where reparti.nome = "neurologia" and year(curdate()) - year(dob) > 35;

#3 stampare l'età di ciascun medico e il suo cognome
select cognome, year(curdate()) - year(dob)
from medici;

#4 stampare l'età media di coloro che non lavorano in ortopedia
select avg(year(curdate()) - year(dob)) as etamedia
from medici inner join reparti on medici.idreparto = reparti.id
where nome != "ortopedia";

#5 stampare quanti medici ci sono per reparto e il nome del reparto
select count(*), nome
from medici inner join reparti on medici.idreparto = reparti.id
group by nome;

#6 stampare lo stipendio medio per ogni residenza
select avg(stipendio) as stipendiomedio, residenza
from medici
group by residenza;

#7 stampare il cognome del medico che prende di più
select stipendio, cognome
from medici
where stipendio = (select max(stipendio) from medici);

select year(dob)
from medici
where idreparto in (select id from reparti where budget > 200000);

#8 stampare l'anno di nascita dei medici che lavorano in un reparto il cui budget supera i 200000
select cognome, year(dob), nome
from medici inner join reparti on medici.idreparto = reparti.id
where budget > 200000;

#9 stampare il cognome dei medici che hanno lo stipendio maggiore  dello stipendio medio generale
select cognome
from medici
where stipendio > (select avg(stipendio) from medici);

#10 stampare il reparto che ha lo stipendio medio maggiore
select *
from (select avg(stipendio) as media, reparti.nome from medici inner join reparti on medici.idreparto 
            = reparti.id group by reparti.nome) as tabella
where media = (select max(media) from(select avg(stipendio) as media, reparti.nome
				from medici inner join reparti on medici.idreparto = reparti.id
                group by reparti.nome) as t1);

-- stampa stipendio medio per reparto
create view stipendiomedioreparto as
select avg(stipendio) as media, reparti.nome
from medici inner join reparti on medici.idreparto = reparti.id
group by reparti.nome;
-- ho creato una vista, una specietabella richiamabile con l'alias

select *
from stipendiomedioreparto
where media = (select max(media) from stipendiomedioreparto);

-- per evitare di ripetere la join creiamo una view che lo fa da solo
create view medicireparti as
select medici.*, nome, piano, budget
from medici inner join reparti on medici.idreparto = reparti.id;

select *
from medicireparti;

-- stampare quanti medici ci sono per reparto e il nome di esso
select count(*) as numero, nome
from medicireparti
group by nome;