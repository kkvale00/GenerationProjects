-- GROUP BUY
-- questo strumento raggruppa i dati secondo x criteri
-- prima di applicare queste funzioni

-- calcolo stiopendio medio
select avg(stipendio) as media
from dipendente;

-- calcola stipendio medio di un dato reparto
select avg(stipendio)
from dipendenti
where reparto = "acquisti";

-- calcola stipendio medio per ogni reparto
select avg(stipendio) as media, reparto
from dipendenti
group by reparto;

-- calcola anno di nascita maggiore per ogni residenza
select max(yob) as Giovane, residenza
from dipendenti
group by residenza;

-- stampare stipendio medio per ogni reparto, solo chi e nato negli anni 80
select avg(stipendio) as stipendiomedio, reparto
from dipendenti
where yob between 1990 and 1999
group by reparto;

-- stampare il numero di persone con uno stipendio >= 2000 per reparto
select count(*) as numero, reparto
from dipendenti
where stipendio >= 2000
group by reparto;