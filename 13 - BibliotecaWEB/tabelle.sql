create database Biblioteca;
use Biblioteca;

create table Libri(
id int primary key auto_increment,
titolo varchar(200),
genere varchar(200),
annopubblicazione int,
linguaoriginale varchar(200),
copiemagazzino int,
idautore int,
foreign key (idautore) references autori(id)
on delete set null
on update cascade
);

create table Autori(
id int primary key auto_increment,
nome varchar(200),
cognome varchar(200),
dob date,
nazione varchar(200)
);

insert into Autori(nome,cognome,dob,nazione) values
('Franz','Kafka','1883-07-3','Polonia'),
('Herman','Hesse','1887-07-2','Germania'),
('James','Joyce','1882-02-2','Irlanda'),
('Geroge','Orwell','1882-02-2','Inghilterra'),
('Jose','Saramago','1922-11-16','Portogallo');

insert into Libri (titolo,genere,annopubblicazione,linguaoriginale,copiemagazzino,idautore) values
('Siddharta','Filosofia',1922,'Tedesco',23,2),
('Il Processo','Romanzo',1923,'Tedesco',12,1),
('Metamorfosi','Romanzo',1919,'Tedesco',11,1),
('Dubliners','Racconti',1914,'Inglese',34,3),
('Ulisse','Racconti',1912,'Inglese',7,3),
('1984','Distopico',1949,'Inglese',39,4),
('Fattoria degli animali','Distopico',1934,'Inglese',15,4),
('Cecita','Romanzo',1995,'Portoghese',45,5),
('L Uomo duplicato','Romanzo',1989,'Portoghese',11,5);



select * from libri;