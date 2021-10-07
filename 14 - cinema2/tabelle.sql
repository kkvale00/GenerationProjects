create database cinema;
use cinema;

create table utenti(
username varchar(200) primary key,
password varchar(200),
nome varchar(200),
cognome varchar(200),
dob date,
residenza varchar(200)
);
select * from utenti;
create table film(
id int primary key auto_increment,
titolo varchar(200),
genere varchar(200),
annouscita int,
trama varchar(200),
durata int,
vietato bool,
locandina varchar(2000)
);

create table programmazione(
id int primary key auto_increment,
idfilm int,
sala int,
orario datetime,
foreign key (idfilm) references film(id)
on update cascade
on delete cascade
);

create table prenotazioni(
id int primary key auto_increment,
idprogrammazione int,
username varchar(200),
nposti int,
foreign key (idprogrammazione) references programmazione(id) on update cascade on delete cascade,
foreign key (username) references utenti(username) on update cascade on delete cascade
);


insert into film values
(1, "The Chaser", "Thriller", 2013, "Tizio rapisce prostite e fa cose", 120, true, "https://pad.mymovies.it/filmclub/2010/01/038/locandina.jpg"),
(2, "Arrival", "Sci-fi", 2016, "Arrivano gli alieni, scappa bro scappa!", 98, false, "https://i.ytimg.com/vi/WwW1nqV3pI0/movieposter_en.jpg");

insert into programmazione values
(1, 1, 1, "2021-9-28 21:30"),
(2, 1, 1, "2021-9-28 23:45"),
(3, 1, 1, "2021-9-29 21:30"),
(4, 1, 1, "2021-9-30 21:00"),
(5, 2, 2, "2021-9-28 21:15"),
(6, 2, 3, "2021-9-28 21:45"),
(7, 2, 3, "2021-10-1 21:15");

insert into utenti values
("pippo", md5("pluto"), "Pino", "Pane", "1977-4-1", "Milano"),
("dinosauro", md5("trex"), "Mario", "Polli", "1987-5-12", "Milano"),
("ajeje", md5("carabbaggio"), "Al", "Caruso", "1983-12-12", "New York");

insert into prenotazioni values
(1, 1, "pippo", 3),
(2, 1, "ajeje", 5),
(3, 2, "pippo", 8),
(4, 7, "dinosauro", 1);







