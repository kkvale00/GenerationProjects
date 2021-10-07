#Stampare il nome di tutte le persone di milano e di brescia
select *
from Persone
where residenza = "milano" or residenza = "brescia";
#==========================================================
#Stampare il nome di coloro che hanno tra i 0 e i 1 anni
select * #,datediff(curdate() , dob) / 365 between 20 and 30 as eta
from Persone 
where (year(curdate()) - year(dob)) between 20 and 30;
		#datediff(curdate() , dob) / 365 between 20 and 30;
#=======================================================
#Stampare il costo medio di un'assicurazione che non sia sulla vita
select avg(costoannuo) as costomedio
from assicurazioni
where tipo != "Vita";
#================================================================
#Stampare quante assicurazioni sono ancora attive
select count(*) as attive
from stipula
where datafine != null;
#================================================================
#Stampare l'età media degli assicuratori
select avg(year(current_date()) - year(dob))
from assicuratori;
#================================================================
#Stampare il nome di ciascuna persona affiancato dal tipo di assicurazione che ha stipulato
select *
from persone inner join stipula on persone.id = stipula.idpersona
			 inner join assicurazioni on stipula.idassicurazione = assicurazioni.id
group by tipo;
#================================================================
#Stampare quante assicurazioni sono state stipulate per ogni tipo
select Count(*)
from assicurazioni
group by assicurazioni.tipo;
#================================================================
#Stampare quante persone sono gestite da ciascun assicuratore
select assicuratori.*, Count(*) as personegestite
from persone inner join assicuratori on assicuratori.id = persone.idassicuratore
group by assicuratori.nome;
#================================================================
#Stampare quante assicurazioni sulla vita sono state stipulate per ogni città
select Count(*)
from persone inner join stipula on persone.id = stipula.idpersona
			 inner join assicurazioni on stipula.idassicurazione = assicurazioni.id
 where tipo = "vita"
 group by persone.residenza;
#================================================================
#Stampare il costo totale annuo di ogni persona
create view spesaannua as
select persone.*, sum(costoannuo) as spesaAnnua
from persone inner join stipula on persone.id = stipula.idpersona
			 inner join assicurazioni on stipula.idassicurazione = assicurazioni.id
 where datafine is null
 group by persone.id;
#================================================================
#Stampare il nome di ogni persona, affiancato dal tipo di assicurazione e dal numero di giorni mancanti al prossimo rinnovo
select persone.*,datainizio, assicurazioni.*,
			datediff(curdate() , datainizio) as duratafinemo
from assicurazioni inner join stipula on assicurazioni.id = stipula.idassicurazione
				   inner join persone on stipula.idpersona = persone.id
				   inner join assicuratori on assicuratori.id = persone.idassicuratore
where datafine is null
group by persone.id;
#================================================================
#Stampare il nome di ogni assicuratore e il suo guadagno annuo che è dato dal 15% di quello che pagano in totale i suoi clienti
select assicuratori.*, sum(costoannuo) * 0,15 as guadagno
from assicurazioni inner join stipula on assicurazioni.id = stipula.idassicurazione
				   inner join persone on stipula.idpersona = persone.id
				   inner join assicuratori on assicuratori.id = persone.idassicuratore
group by assicuratori.id;

#Stampare la città di residenza dove sono stipulate più assicurazioni
create view stipulazionipercitta as
select residenza, count(*) nstipulazioni
from persone inner join stipula on persone.id - stipula.idpersona
group by residenza;

select * 
from stipulazionipercitta
where nstipulazioni = (select max(nstipulazioni) from stipulazionipercitta);

#Stampare la città di residenza dove ci sono più persone che hanno stipulato almeno un'assicurazione
create view personeconassicurazioneattiva as
select distinct persone.*
from persone inner join stipula on stipula.idpersona = persone.id
where datafine is null;

create view personeassicurateperresidenza as
select residenza, count(*) as n
from personeconassicurazioneattiva
group by residenza;

select*
from personeassicurateperresidenza
where n = (select max(n) from personeconassicurazioneattiva);

#Stampare quanti assicuratori non sono collegati a nessuna persona (think out of the box)
select * 
from assicuratori
where id not in (select idassicuratore from persone);














