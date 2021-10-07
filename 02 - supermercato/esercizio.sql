create database 02_Supermercato;
use 02_Supermercato;
-- Creare la tabella Personale, composto da id int PK, nome varchar, cognome varchar, yob int, residenza varchar, stipendio double, reparto varchar
create table personale
(
	id int primary key,
    nome varchar(200),
    cognome varchar(200),
    yob int,
    residenza varchar(200),
    stipendio double,
    reparto varchar(200)
);

-- Creare la tabella Merci, composto da id int PK, nome varchar, marca varchar, prezzo double, categoria varchar
create table merci
(
	id int primary key,
    nome varchar(200),
    marca varchar(200),
    prezzo double,
    categoria varchar(200)
);
-- Inserire almeno 3 persone e 10 merci
insert into personale
values
(1,"Antonio","Tammaro",1989,"Milano",1800,"ortofrutta"),
(2,"Cristo","Redentore",0,"Gerusalemme",1923,"tecnologia"),
(3,"Amato","Ciciretti",1999,"Napoli",600,"ortofrutta");

insert into merci
values
(1,"mela","annurca",1.89,"frutta"),
(2,"pera","pere",1.99,"frutta"),
(3,"patate","novi",2.99,"verdura"),
(4,"arancia","annurca",0.99,"frutta"),
(5,"pane","novi",0.99,"cibo"),
(6,"acqua","santa",0.56,"bevande"),
(7,"succoace","santa",0.76,"bevande"),
(8,"pasta","novi",0.34,"cibo"),
(9,"kinder","annurca",1.29,"cioccolato"),
(10,"gocciole","novi",3.49,"cioccolato");


-- Scrivere le seguenti query:

    -- Voglio vedere i nominativi (nome e cognome) del personale che prende più di 1500
    select nome,cognome
    from personale
    where stipendio > 1500;

	-- Voglio vedere per ogni persona l'età che hanno
    select nome,cognome,year(curdate()) - yob as eta
    from personale;
    
    -- Voglio vedere tutto il personale che è residente a Milano o Napoli e ha più di 35 anni
    select nome, cognome, residenza
    from personale
    where year(curdate()) - yob > 35 and residenza in ("milano","napoli");
   
    
    
    -- Voglio vedere tutte le merci di una categoria a vostra scelta
    select nome, categoria
    from merci
    where categoria = "cioccolato";
    
    -- Voglio vedere la somma degli stipendi del personale
    select sum(stipendio) as sommastipendi
    from personale;
    
    -- Voglio vedere la somma delle merci del negozio
    select sum(prezzo) as sommaprezzi, count(*) as numeromerci
    from merci;
    
    -- Voglio vedere la somma delle merci di una categoria a vostra scelta
    select sum(prezzo) as sommaprezzi, categoria
    from merci
    where categoria = "cibo";
    
    -- Voglio vedere lo stipendio medio del personale che lavora nel reparto "ortofrutta"
    select avg(stipendio) as stipendiomedio
    from personale
    where reparto = "ortofrutta";
    
    -- Voglio vedere lo stipendio medio del personale per ogni reparto
    select avg(stipendio) as stipendiomedio, reparto
    from personale
    group by reparto;
    
    -- Voglio vedere il nome delle merci che costano di più nella categoria "bevande"
    select *
    from merci
    where categoria = "bevande" and 
		  prezzo = (select  max(prezzo) from merci where categoria = "bevande");
    
    -- Voglio vedere l'anno della persona più anziana per ogni reparto
    select min(yob) as anziano
    from personale
    group by reparto;
    
    
    -- Voglio vedere l'età media per ogni reparto
    select avg(2021 - yob) as etamedia, reparto
    from personale
    group by reparto;
    
    
    -- Voglio vedere i dettagli della merce che costa meno in assoluto
    select *
    from merci
    where prezzo = (select min(prezzo) as prezzominore from merci);
    
    
    -- Voglio vedere quante persone lavorano per ogni reparto
    select count(*) as personale
    from personale
    group by reparto;
    
    
    -- Voglio vedere il budget totale che il supermercato usa in un anno per pagare tutti gli stipendi al personale
    select sum(stipendio * 12) as budget
    from personale;
