create database TattooStudio;
use TattooStudio;

create table tatuatori(
id int primary key auto_increment,
nome varchar(200),
cognome varchar(200),
dob date,
residenza varchar(200),
anniesperienza int
);
select * from tatuatori;
create table tatuaggi(
id int primary key auto_increment,
descrizione varchar(200),
data date,
colori bool,
prezzo int,
altezzacm int,
larghezzacm int,
idtatuatore int,
foreign key (idtatuatore) references tatuatori(id)
on delete set null
on update cascade
);

insert into tatuatori (nome, cognome, dob, residenza, anniesperienza) values
('Davide', 'Testa', '1993-08-19','milano',3),
('Raffaele', 'Poziello', '1986-08-19','torino',2),
('Fabio', 'Testa', '1983-08-19','venezia',8);


insert into tatuaggi (descrizione, data, colori, prezzo, altezzacm, larghezzacm) values
('gorilla','2019-08-19',1,350,19,7),
('lupo','2020-08-19',0,243,14,5),
('drago','2021-08-19',1,460,27,9),
('serpente','2021-08-19',0,230,12,5),
('maradona','2021-08-19',0,340,30,9),
('vesuvio','2021-08-19',1,299,15,9),
('rosa','2020-08-19',1,150,9,3),
('occhio','2021-08-19',0,120,6,3),
('aereo','2021-08-19',1,135,5,3),
('lavatrice','2021-08-19',1,550,35,12);