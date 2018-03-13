-- insertions in table stay

insert into `escapade`.`stay` (`theme`) values ('s01');
insert into `escapade`.`stay` (`theme`) values ('p02');
insert into `escapade`.`stay` (`theme`) values ('s02');
insert into `escapade`.`stay` (`theme`) values ('s03');
insert into `escapade`.`stay` (`theme`) values ('p03');
insert into `escapade`.`stay` (`theme`) values ('j03');
insert into `escapade`.`stay` (`theme`) values ('s04');
insert into `escapade`.`stay` (`theme`) values ('p04');
insert into `escapade`.`stay` (`theme`) values ('s06');

-- insertions in table car

insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('OU642EF', 'Mazerati', 'berline', 'Quattroporte', 1, 0, 'A0', 0);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GP654G', 'Mazerati', 'cabriolet'
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GF654GD', 'Renaud', 'berline', 'Twingo', 1, 0, 'A0', 2);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG654GD', 'Citreon', 'berline', 'C418', 1, 1, 'A0', 3);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG68GEG', 'Capsule', 'berline', 's645', 1, 1, 'A0', 4);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG56784F', 'Capsule', 'berline', 'h684', 1, 1, 'A0', 5);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GDG684EDG', 'Tesla', 'cabriolet', 'S', 1, 2, 'A0', 6);
insert into `escapade`.`car` (`brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('Marine', 'berline', 'Red', 1, 2, 'A0', 7);
insert into `escapade`.`car` (`brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('Marine', 'berline', 'Blue', 1, 2, 'A0', 8);

-- insertions in table client

insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goku', 'Son', '+811234567', 'Ferme Chichi', 'gokuson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Gohan', 'Son', '+811567', 'Ferme Chichi', 'gohanson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goten', 'Son', '+811267', 'Ferme Chichi', 'gotenson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Chichi', 'Son', '+814654', 'Ferme Chichi', 'chichison@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Videl', 'Son', '+87021567', 'Ferme Chichi', 'videlson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Pan', 'Son', '+81126545', 'Ferme Chichi', 'panson@akira.jp');

-- insertions in table housing

insert into `escapade`.`housing` (`name`, `theme`) values ('salle du temps', 's01');
insert into `escapade`.`housing` (`name`, `theme`) values ('kamehouse', 'p02');
insert into `escapade`.`housing` (`name`, `theme`) values ('namek', 's03');
insert into `escapade`.`housing` (`name`, `theme`) values ('korin tower', 'p03');
insert into `escapade`.`housing` (`name`, `theme`) values ('capsule house', 'j03');

-- insertions in table parking

insert into `escapade`.`parking` (`theme`) values ('01');
insert into `escapade`.`parking` (`theme`) values ('02');
insert into `escapade`.`parking` (`theme`) values ('03');
insert into `escapade`.`parking` (`theme`) values ('04');
insert into `escapade`.`parking` (`theme`) values ('05');
insert into `escapade`.`parking` (`theme`) values ('06');
insert into `escapade`.`parking` (`theme`) values ('07');

-- insertions in table supervisor

insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Patrick', 'Star');
insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Jhon', 'Snow');
insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Cave', 'Jhonson');

-- insertions in table deal

insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');

-- insertions in table maintenance

insert into `escapade`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values (0, 'goku doesn\'t have a driving licence', 'replaced everything', 12, 2018, 1);

