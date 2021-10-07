insert into autori (id,nome,nazione) values

(1,'Red hot chili peppers', 'Stati Uniti'),

(2,'The Who', 'Inghilterra');

 

insert into album (id,nome, genere, datapubblicazione, idautore) values

(1,'Californication' , 'rock' , '1999-06-08',1),

(2,'By the way' , 'rock' ,'2002-07-05',1),

(3,'Show' , 'rock' , '1999-04-01',2);

 

insert into tracce (id,titolo, durata, idalbum) values

(1,'Fascination Street', 5.01, 2),

(2,'High', 3.31, 1),

(3,'Dead Already', 3.01, 1),

(4,'Lullaby', 4.25,1),

(5,'The Seeker', 3.58,3),

(6,'Parallel Universe', 4.30,3),

(7,'Scar Tissue', 3.37,2),

(8,'Otherside' , 4.15,2),

(9,'Purple Stain', 4.13,1);

 

insert into film (id, titolo, regista, genere, durata, datapubblicazione) values

(1,'American beauty','Sam Mendeds', 'drammatico' , 121, '1999-01-18'),

(2,'Memento' , 'Christopher Nolan', 'dramatico' , 113, '2000-05-25');

 

insert into colonnaSonora(idfilm,idtraccia) values

(1,3),

(1,5);

 

insert into autori values

(10,'Will Smith', 'Stati Uniti'),

(11, 'Metallica', 'Stati Uniti');

 

insert into album values

(10, 'Men in Black: The Album', 'Hip-Hop', '1997-07-01', 10),

(11, 'Master of Puppets', 'Metal', '1986-03-03', 11),

(12, 'Metallica', 'Metal' , '1991-08-13', 11);

 

insert into Tracce values

(10, 'Man in balck', 3.48, 10),

(11, 'Just Cruisin', 4.10, 10),

(12, 'Orion', 8.27, 11),

(13, 'Enter Sandman' , 5.37, 12),

(14, 'Master of Puppets' , 8.35 , 11),

(15, 'The Thing That Should Not Be' , 6.36, 11),

(16, 'Nothing Else Matters' , 6.29, 12),

(17, 'The Unforgiven', 6.26, 12),

(18, 'My Friend of Misery' , 6.47,12),

(19, 'So What', 3.09,12);

 

insert into Film values

(10, 'Man in black', 'Barry Sonnenfeld', 'Fantascienza', 90, '1997-10-03'),

(11, 'Avenger', 'Joss Whedon' , 'Azione', 120, '2012-04-25');

 

insert into autori(id,nome, nazione) values

(30,'Gorillaz', 'Americano'),

(31,'Joey Bada$$', 'Americano');

 

insert into album(id,nome,genere,dataPubblicazione, idautore) values

(30,'Gorillaz', 'Trip Hop', '2001-3-26',30),

(31,'Plastic Beach', 'Hip-Hop Alternativo', '2010-3-3',30),

(32,'All-American Bada$$', 'Hip-Hop', '2017-4-7',31);

 

insert into tracce(id,titolo, durata, idalbum) values

(30,'For My People', 1.38, 3),(31,'Land of the Free', 4.43,3),

(32,'Devastated', 3.27,3),(33,'Plastic Beach',3.47,2),

(34,'Stylo', 4.30,2),(35,'On Melancholy Hill', 3.53, 2),

(36,'Clint Eastwood', 5.42,1),(37,'19-2000',3.27,1),

(38,'Tomorrow Comes Today', 3.12,1),(39,'Rock the House', 4.09,1);

 

insert into film(id,titolo, genere, regista, durata, dataPubblicazione) values

(30,'Bananaz', 'Documentario', 'Ceri Levy', 92, '2008-2-7'),

(31,'Il Gladiatore', 'Epico','Ridley Scott', 170, '2000-5-5');




insert into autori(id,nome,nazione) values

(40,'einar','italiana'),(41,'Brani','canada');

 

insert into album(id,nome,genere,datapubblicazione,idautore) values

(40,'Mendes Shawn','rock pop','2018-05-25',1),

(41,'Illuminate','rock pop','2017-05-19',1),

(42,'Einar','rock pop','2018-06-01',2);

 

insert into tracce(id,titolo,durata,idalbum) values

(40,'Ruin',3.25,2),(41,'Treat You Better',2.25,2),

(42,'Three Empty Words',1.25,2),(43,'Like This',3.15,2),

(44,'No Promises',3.00,2),(45,'In My Blood',2.25,1),

(46,'Lost In Japan',3.05,1),(47,'Like To Be You',1.25,1),

(48,'Youth',2.25,1),(49,'Mutual',3.50,1);

 

insert into film(id,titolo,regista,genere,durata,datapubblicazione) values

(40,'50 sfumature di rosso','James','drammatico',95,'2018-05-23'),

(41,'Made in Italy','Stefano Accorsi e Kasia Smutniak','drammatico',105,'2018-05-16');

insert into colonnasonora(idfilm,idtraccia) values

(40,40),(40,41),

(40,42),(40,43),

(40,44),(41,45),

(41,46),(41,47),

(41,48),(41,49);

 

insert into autori (id,nome,nazione) values

(50,'Genesis','Inghilterra'),

(51,'Messhuggah','Svezia'),

(52,'Cypres Hill','USA'),

(53,'King Crimson','Inghilterra'),

(54,'Porcupine Tree','Inghilterra'),

(55,'Pink Floyd','Inghilterra'),

(56,'Yes','Inghilterra'),

(57,'Jethro Tull','Inghilterra'),

(58,'Miles Davis','USA'),

(59,'Herbie Hancock','USA');



insert into album (id,nome,genere,datapubblicazione,idautore) values

(50,'The Lamb Lies Down On Broadway','Progressive Rock','1974-11-18',50),

(51,'Nursery Cryme','Progressive Rock','1971-11-12',50),

(52,'ObZen','Djent','2008-3-3',51),

(53,'The Violent Sleep Of Reason','Djent','2016-10-7',51),

(54,'Black Sunday','HipHop','1993-7-20',52),

(55,'Cypress Hill','HipHop','1991-8-13',52),

(56,'In The Court Of The Crimson King','Progressive Rock','1969-10-10',53),

(57,'THRAK','Progressive Rock','1995-4-3',53),

(58,'In Absentia','Progressive Rock','2002-9-24',54),

(59,'Fear Of A Blank Planet','Progressive Rock','2007-4-16',54),

(1000,'Soundtrack From The Film More','Rock Psichedelico','1969-7-27',55),

(1001,'Zabriskie Point','Rock Psichedelico','1970-2-9',55),

(1002,'Close To The Edge','Progressive Rock','1972-9-13',56),

(1003,'Fragile','Progressive Rock','1971-11-26',56),

(1004,'Thick As A Brick','Progressive Rock','1972-3-3',57),

(1005,'Kind Of Blue','Jazz','1959-8-17',58),

(1006,'Head Hunters','Fusion','1973-10-13',59);

 

insert into tracce (id,titolo,durata,idAlbum) values

(1000,'Fear Of A Blank Planet',7.28,59),

(1001,'My Ashes',5.07,59),

(1002,'Anesthetize',17.42,59),

(1003,'Sentimental',5.26,59),

(1004,'Way Out Of Here',7.37,59),

(1005,'Sleep Together',7.28,59),

 

(1006,'Blackest Eyes',4.23,58),

(1007,'Trains',5.56,58),

(1008,'Lips Of Ashes',4.39,58),

(1009,'The Sound Of Muzak',4.59,58),

(1010,'Gravity Eyelid',7.56,58),

(1011,'Wedding Nails',6.33,58),

(1012,'Prodigal',5.35,58),

(1013,'.3',5.25,58),

(1014,'The Creator Has A Mastertape',5.21,58),

(1015,'Heartattack In A Layby',4.15,58),

(1016,'Strip The Soul',7.21,58),

(1017,'Collapse The Light Into Earth',5.54,58),

 

(1018,'VROOM',4.37,57),

(1019,'Marine 475',2.41,57),

(1020,'Dinosaur',6.35,57),

(1021,'Walking On Air',4.34,57),

(1022,"B'Boom",4.22,57),

(1023,'THRAK',3.58,57),

(1024,'Inner Garden I',1.47,57),

(1025,'People',5.53,57),

(1026,'Radio I',0.43,57),

(1027,'One Time',5.21,57),

(1028,'Radio II',1.02,57),

(1029,'Inner Garden II',1.15,57),

(1030,'Sex Sleep Eat Drink Dream',4.48,57),

(1031,'VROOOM VROOOM',5.37,57),

(1032,'VROOOM VROOOM: Coda',3.00,57),

 

(1033,'21st Century Schizoid Man',6.52,56),

(1034,'I Talk To The Wind',5.40,56),

(1035,'Epitaph',8.30,56),

(1036,'Moonchild',12.09,56),

(1037,'The Court Of The Crimson King',8.48,56),

 

(1038,'Pigs',2.51,55),

(1039,'How I Could Just Kill A Man',4.08,55),

(1040,'Hand On The Pump',4.03,55),

(1041,'Hole In The Head',3.33,55),

(1042,'Ultraviolet Dreams',0.41,55),

(1043,'Light Another',3.17,55),

(1044,'The Phunky Feel One',3.28,55),

(1045,'Break It Up',1.07,55),

(1046,'Real Estate',3.45,55),

(1047,'Stoned Is The Way Of The Walk',2.46,55),

(1048,'Psycobetabuckdown',2.59,55),

(1049,'Something For The Blunted',1.15,55),

(1050,'Latin Lingo',3.58,55),

(1051,'The Funky Cypress Hill Shit',4.01,55),

(1052,'Tres Equis',1.54,55),

(1053,'Born To Get Buisy',3.00,55),

 

(1054,'I Wanna Get High',2.54,54),

(1055,"I Ain't Goin' Out Like That",4.27,54),

(1056,'Insane In The Brain',3.29,54),

(1057,'When The Shit Goes Down',3.08,54),

(1058,'Lick A Shot',3.23,54),

(1059,'Cock The Hammer',4.25,54),

(1060,'Lock Down',1.17,54),

(1061,"3 Lil' Putos",3.39,54),

(1062,'Legalize It',0.46,54),

(1063,'Hits From The Bong',2.40,54),

(1064,'What Go Around Come Around, Kid',3.42,54),

(1065,'A To The K',3.27,54),

(1066,'Hand On The Glock',3.32,54),

(1067,"Break 'Em Off Some",2.46,54),

 

(1068,'Clockworks',7.15,53),

(1069,'Born In Dissonance',4.34,53),

(1070,'MonstroCity',6.13,53),

(1071,'By The Ton',6.04,53),

(1072,'Violent Sleep Of Reason',6.51,53),

(1073,'Ivory Tower',4.59,53),

(1074,'Stifled',6.31,53),

(1075,'Nostrum',5.15,53),

(1076,"Our Rage Won't Die",4.41,53),

(1077,'Into Decay',6.31,53),

 

(1078,'Combustion',4.11,52),

(1079,'Electric Red',5.53,52),

(1080,'Bleed',7.24,52),

(1081,'Lethargica',5.49,52),

(1082,'obZen',4.26,52),

(1083,'This Spiteful Snake',4.54,52),

(1084,'Pineal Gland Optics',5.14,52),

(1085,'Pravus',5.12,52),

(1086,'Dancers To A Discordant System',9.36,52),

 

(1087,'The Musical Box',10.27,51),

(1088,'For Absent Friends',1.48,51),

(1089,'The Return Of The Giant HogWeed',8.12,51),

(1090,'Seven Stones',5.09,51),

(1091,'Harold The Barrel',3.01,51),

(1092,'Harlequin',2.55,51),

(1093,'The Fountain Of Salmacis',7.56,51),

 

(1094,'The Lamb Lies Down On Broadway',4.50,50),

(1095,'Fly On A Windshield',2.44,50),

(1096,'Broadway Melody Of 1974',2.13,50),

(1097,'Cuckoo Cocoon',2.12,50),

(1098,'In The Cage',8.13,50),

(1099,'The Grand Parade Of Lifeless Packaging',2.45,50),

(1100,'Back In N.Y.C.',5.43,50),

(1101,'Hairless Heart',2.13,50),

(1102,'Counting Out Time',3.40,50),

(1103,'The Carpet Crawlers',5.15,50),

(1104,'The Chamber Of 32 Doors',5.41,50),

(1105,'Lilywhite Lilith',2.42,50),

(1106,'The Waiting Room',5.25,50),

(1107,'Anyway',3.08,50),

(1108,'Here Comes The Supernatural Anaesthetist',3.00,50),

(1109,'The Lamia',6.56,50),

(1110,'Silent Sorrow In Empty Boats',3.07,50),

(1111,'The Colony Of Slippermen (The Arrival-A Visit To The Doktor-The Raven)',8.14,50),

(1112,'Ravine',2.04,50),

(1113,'The Light Dies Down On Broadway',3.33,50),

(1114,'Riding The Scree',3.56,50),

(1115,'In The Rapids',2.24,50),

(1116,'it',4.17,50),

 

(1117,'Heart Beat, Pig Meat',3.21,1001),

(1118,'Come In Number 51, Your Time Is Up',5.01,1001),

(1119,'Crumbling Land',4.16,1001),

(1120,'Love Scene Version 4',6.46,1001),

(1121,'Love Scene Version 6',7.29,1001),

(1122,'Unknown Song',6.03,1001),

(1123,'Country Song',4.40,1001),

 

(1124,'Cirrus Minor',5.16,1000),

(1125,'The Nile Song',3.24,1000),

(1126,'Crying Song',3.25,1000),

(1127,'Up The Khyber',2.07,1000),

(1128,'Green Is The Colour',2.53,1000),

(1129,'Cymbaline',4.45,1000),

(1130,'Party Sequence',1.10,1000),

(1131,'Main Theme',5.27,1000),

(1132,'Ibiza Bar',3.17,1000),

(1133,'More Blues',2.13,1000),

(1134,'Quicksilver',7.03,1000),

(1135,'A Spanish Piece',1.00,1000),

(1136,'Dramatic Theme',2.11,1000),

 

(1137,'Close To The Edge',18.43,1002),

(1138,'And You And I',10.09,1002),

(1139,'Siberian Khatru',8.55,1002),

 

(1140,'Roundabout',8.33,1003),

(1141,'Cans And Brahms',1.38,1003),

(1142,'We Have Heaven',1.40,1003),

(1143,'South Side Of The Sky',7.58,1003),

(1144,'Five Per Cent For Nothing',0.35,1003),

(1145,'Long Distance Runaround',3.30,1003),

(1146,'The Fish (Schindleria Praematurus)',2.39,1003),

(1147,'Mood For A Day',3.00,1003),

(1148,'Heart Of The Sunrise',11.27,1003),

 

(1149,'Thick As A Brick Part 1',22.45,1004),

(1150,'Thick As A Brick Part 2',21.05,1004),

 

(1151,'So What',9.22,1005),

(1152,'Freddie Freeloader',9.46,1005),

(1153,'Blue In Green',5.37,1005),

(1154,'All Blues',11.33,1005),

(1155,'Flamenco Sketches',9.26,1005),

 

(1156,'Chameleon',15.41,1006),

(1157,'Watermelon Man',6.29,1006),

(1158,'Sly',10.15,1006),

(1159,'Vein Melter',9.09,1006);

 

insert into film (id,titolo,regista,genere,durata,datapubblicazione) values

(50,'More','Barbet Schroeder','Drammatico',116,'1969-7-27'),

(51,'Zabriskie Point','Michelangelo Antonioni','Drammatico',110,'1970-2-9');

 

insert into colonnasonora (idfilm,idtraccia) values

(50,1124),

(50,1125),

(50,1126),

(50,1127),

(50,1128),

(50,1129),

(50,1130),

(50,1131),

(50,1132),

(50,1133),

(50,1134),

(50,1135),

(50,1136),

 

(51,1117),

(51,1118),

(51,1119),

(51,1120),

(51,1121),

(51,1122),

(51,1123);







insert into autori values

(60,'Childish Gambino','Stati Uniti'),

(61,'Paul Leonard-Morgan','Inghilterra');

 

insert into album values

(60,'Because the Internet','Hip Hop','2013-12-10',60),

(61,'Awaken, My Love!','R&B','2016-12-2',60),

(62,'Limitless','Colonna Sonora','2011-06-15',61);

 

insert into tracce values

(60,'Opening',1.51,62),

(61,'i Still love you',1.05,62),

(62,'Walk home',1.28,62),

(63,'Limitless',1.29,62),

(64,'II. Worldstar',4.04,60),

(65,'III. Telegraph Ave. ("Oakland" by Lloyd)',3.30,60),

(66,'IV. Sweatpants',3.00,60),

(67,'V. 3005',3.54,60),

(68,'Me and Your Mama',6.19,61),

(69,'Redbone',5.27,61);

 

insert into film values

(60,'Limitless','Neil Burger','Thriller',105,'2011-06-15'),

(61,'Tre uomini e una gamba','Giacomo Poretti, Aldo Baglio, Giovanni Storti, Massimo Venier','commedia',98,'1997-12-27');

 

insert into colonnaSonora values

(60,60),(60,61),

(60,62),(60,63);

 

insert into autori(id,nome, nazione) values

 

(90,'Salmo', 'Italia'),

(91,'John Williams' , 'Stati Uniti');

 

 insert into album(id,nome, genere , datapubblicazione, idautore) values

 (90,'HellvisBack', 'Hip hop', '2016-02-05',1),

 (91,'Star Wars', 'Classica', '1977-06-1', 2),

 (92,'Midnite', 'Rap', '2013-04-2',1);

 

 insert into tracce (id,titolo,durata,idalbum) values

 (90,'io sono qui', 3.01, 1),

 (91,'1984',4.10,1),

 (92,'Man title', 5.23,2),

 (93,'Imperia attack', 6.10,2),

 (94,'Princess leila theme',2.52,2),

 (95,'Inner city',4.12,2),

 (96,'The last battle' , 12.05,2),

 (97,'Borderline', 2.58,3),

 (98,'Rob Zombie',2.55,3),

 (99,'Faraway', 3.20,3);

 

 insert into film (id,titolo, regista,genere, durata,datapubblicazione) values

 (90,'Shooter','Antoine Fuqua','Thriller/Dramma',2.06, '2007-04-20'),

 (91,'Star Wars II',' John Williams','Azione',2.22, '2002-05-16');

 

insert into colonnasonora(idfilm, idtraccia) values

 

(91,90),

(91,96);



insert into autori (id, nome, nazione) values

(100,'Hans Zimmer','Germania'),

(101,'Ennio Morricone','Italia');

 

insert into album (id, nome, genere, datapubblicazione, idautore) values

(100,'Interstellar: Original Motion Picture Soundtrack','ambiente','2014-09-17',100),

(101,'Il gladiatore: Music from the Motion Picture','classica','2000-05-16',101),

(102,'The Hateful Eight','Musica classica','2015-12-18',101);

 

insert into tracce (id, titolo, durata, idalbum) values

(100,'Dreaming of the crash',3.55,100),

(101,'Cornfield Chase',2.06,100),

(102,'The Wormhole',1.30,100),

(103,'IMountains',3.39,100),

(104,'Afraid of Time',2.32,100),

(105,'Now We Are Free',4.14,101),

(106,'Strength and Honor',2.09,101),

(107,'L ultima diligenza di Red Rock',7.30,102),

(108,'Neve',12.16,102),

(109,'Sangue e Neve',2.05,102);

 

insert into film (id, titolo, regista, genere, durata, datapubblicazione) values

(100,'Interstellar','Christopher Nolan','fantascienza',169,'2014-10-26'),

(101,'The Hateful Eight','Quentin Tarantino','western',187,'2016-04-02');

 

insert into colonnaSonora (idfilm, idtraccia) values

(100,100),(100,101),

(100,102),(100,103),

(100,104),(101,107),

(101,108),(101,109);

 

insert into autori (id,nome,nazione) values

(110,'Skunk Anansie','Inghilterra'),

(111,'Porno Graffiti','Giappone');

insert into album (id,nome,genere,datapubblicazione,idautore) values

(110,'Paranoid & Sunburnt','Rock','1995-07-20',110),

(111,'Post Orgasmic Chill','Rock','1999-05-03',110),

(112,'Tsukigai','JRock','2003-02-04',111);

insert into tracce (id,titolo,durata,idalbum) values

(110,'Melissa',2.09,112),

(111,'Feed',1.10,110),

(112,'Selling Jesus',1.12,110),

(113,'Charlie Big Potato',1.12,110),

(114,'You ll Follow Me Down',1.13,110),

(115,' All I Want',1.14,110),

(116,'Lack',1.14,111),

(117,'Tasogare Romance',1.14,112),

(118,'Oto no Nai Mori',2.20,112),

(119,'Mugen',2.00,112);

insert into film (id,titolo,regista,genere,durata,dataPubblicazione) values

(110,'Strange Days','James Cameron','Fantascienza',120,'1999-12-02'),

(111,'Full Metal alchemist','Hiromu Arakawa','Anime',25,'2003-10-20');

insert into colonnaSonora (idtraccia,idfilm) values

(110,111),

(111,111),

(112,110),

(113,110),

(114,110),

(115,111),

(116,111),

(117,111),

(118,111),

(119,111);



insert into autori (id, nome, nazione) values

(120,'Evanescence','Stati Uniti'),

(121,'Garbage','Stati Uniti');

 

insert into album (id, nome, genere, datapubblicazione, idautore) values

(120,'Fallen','metal','2003-3-4',120),

(121,'The world is not enough','rock','1999-10-4',121),

(122,'The open door','metal','2006-9-25',120);

 

insert into tracce (id, titolo, durata, idalbum) values

(120,'Bring me to life',3.56,120),

(121,'My immortal',4.23,120),

(122,'Going under',3.35,120),

(123,'Imaginary',4.16,120),

(124,'Hello',3.40,120),

(125,'The world is not enough',3.57,121),

(126,'Good enough',5.32,122),

(127,'Snow white queen',4.22,122),

(128,'The only one',4.40,122),

(129,'Cloud nine',4.22,122);

 

insert into film (id, titolo, regista, genere, durata, datapubblicazione) values

(120,'Daredevil','Mark Steven Johnson','azione',103,'2003-2-14'),

(121,'The World Is Not Enough','Michael Apted','azione',128,'1999-11-8');

 

insert into colonnaSonora (idfilm, idtraccia) values

(120,120),

(120,121),

(121,122);

 

insert into colonnaSonora(idtraccia, idfilm) values

(33,30),(34,30),

(35,30),(36,30),

(37,30),(38,30),

(105,31),(106,31); 





insert into autori values

(20, 'Bill Conti', 'USA'),

(21, 'Vince DiCola', 'USA'),

(22, 'Niska', 'Francese');

 

insert into album values

(20, 'Rocky', 'pop', '1976-11-12', 20),

(21, 'Rocky IV', 'rock', '1985-11-27', 21),

(22, 'Commando', 'hip hop trap', '2017-09-22', 22);

 

insert into tracce values

(20, 'Gonna Fly Now', 2.48, 20),

(21, 'Philadelphia Morning', 2.22, 20),

(22, 'Going the distance', 2.40, 20),

(23, 'War', 5.54, 21),

(24, 'Training Montage', 3.38, 21),

(25, 'Story X', 2.42, 22),

(26, 'Réseaux', 3.16, 22),

(27, 'Medellin', 3.19, 22),

(28, 'Salé', 2.50, 22),

(29, 'Tuba Life', 3.14, 22);

 

insert into film values

(20, 'Rocky', 'John G. Avildsen', 'drammatico sportivo', 119, '1977-03-25'),

(21, 'Rocky IV', 'Sylvester Stallone', 'drammatico sportivo', 91, '1986-02-14');

 

insert into colonnaSonora values

(20, 20),

(21, 21);

 

 insert into autori values

   (80, 'HansZimmer' ,'Germania'),

   (81,'AntoniWit','GranBritannia'),

   (82,'RobbieRobertson','Canada');

   

   insert into album values

   (80,'InceptionMusicfromtheMotionPicture','epica','2011-05-13',80),

   (81,'Disco1','epica','2010-09-06',81),

   (82,'Disco2','epica','2010-06-10',82);

   

   insert into tracce values

   (80,'HalfRememberedDream',2.50,80),

   (81,'WeBuiltOurOwnWorld',3.00,80),

   (82,'RadicalNotion',2.60,80),

   (83,'OldSouls',4.00,80),

   (84,'RothkoChapel2',3.63,81),

   (85,'Thelostday' ,2.56,81),

   (86,'Lontano',3.00,81),

   (87,'LizardPoint',2.54,82),

   (88,'Prelude',3.65,82),

   (89,'TomorrowNight',4.00,82);

   

   insert into film values

   (80,'Inception','ChristopherNolan','thriller',140,'2010-05-09'),

   (82,'ShutterIsland','MartinScorsese','thriller',130,'2010-11-18');

   

   insert into colonnaSonora values

   (80,80),

   (82,85);


