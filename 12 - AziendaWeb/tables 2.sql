use AziendaWeb;

create table Clienti(
id int primary key auto_increment,
nominativo varchar(200),
piva varchar(200),
annofondazione int,
settore varchar(200),
servizioacquistato varchar(200),
capitale int
);

insert into Clienti (nominativo,piva,annofondazione,settore,servizioacquistato,capitale) values
('ikea','02992760963',1943,'arredamento','assicurazione',400000000),
('vodafone','02992760963',1956,'telefonia','assicurazione',35000000),
('zalando','02944543603',1989,'abbigliamento','sitoweb',9870000),
('enel','02992760963',1923,'luce','sitoweb',9000000),
('google','02992760963',1923,'','sitoweb',400000000);

select * from dipendenti;

update dipendenti set nome = 'davide',cognome = 'testa', residenza = 'torino', reparto = 'vendite',dob = '1989-08-23' where id = 1;