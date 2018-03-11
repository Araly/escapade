-- insertions in table stay

insert into `escapade`.`stay` (`id`, `theme`) values (0, 's95');

-- insertions in table car

insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values (0, 'Maze', 'berline', 'Quat', 1, 0, 'A0', 0);

-- insertions in table client

insert into `escapade`.`client` (`id`, `firstname`, `lastname`, `phone`, `adress`, `email`) values (0, 'Goku', 'Son', '+811234567', 'Ferme Chichi', 'gokuson@akira.jp');

-- insertions in table housing

insert into `escapade`.`housing` (`id`, `name`, `theme`) values (0, 'Salle du temps', 's95');

-- insertions in table parking

insert into `escapade`.`parking` (`id`, `theme`) values (0, 's95');

-- insertions in table supervisor

insert into `escapade`.`supervisor` (`id`, `firstname`, `lastname`) values (0, 'Patrick', 'Star');

-- insertions in table deal

insert into `escapade`.`deal` (`id`, `id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`, `rating`, `ratingDescription`) values (0, 0, 0, 0, 0, 1500, 12, 2018, 4, 'On s\'est bien entrainé avec Gohan, voiture jolie, il manque juste la wifi');

-- insertions in table maintenance

insert into `escapade`.`maintenance` (`id`, `id_car`, `cause`, `intervention`, `week`, `year`, `done`) values (0, 0, 'goku doesn\'t have a driving licence', 'replaced everything', 12, 2018, 1);
