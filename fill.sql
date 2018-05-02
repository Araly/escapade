-- insertions in table stay

insert into `escapade`.`stay` (`theme`) values ('Visite des champs elysées');
insert into `escapade`.`stay` (`theme`) values ('Visite Musée Orsay');
insert into `escapade`.`stay` (`theme`) values ('Visite Louvre');
insert into `escapade`.`stay` (`theme`) values ('Tournee de bars de Bastille');
insert into `escapade`.`stay` (`theme`) values ('Ballade a Montmartre');
insert into `escapade`.`stay` (`theme`) values ('Pic Nique au Jardin des Plantes');
insert into `escapade`.`stay` (`theme`) values ('Forfait Premium Aquaboulevard');
insert into `escapade`.`stay` (`theme`) values ('Tour en hélicoptère');
insert into `escapade`.`stay` (`theme`) values ('Visite Tour Eiffel');

-- insertions in table car

insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('OU642EF', 'Mazerati', 'berline', 'Quattroporte', 1, 0, 'A0', 0);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GP654G', 'Mazerati', 'cabriolet', 'Ottoporte', 1, 0, 'A3', 1);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GF654GD', 'Renaud', 'berline', 'Twingo', 1, 0, 'A0', 2);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG654GD', 'Citreon', 'berline', 'C418', 1, 1, 'A0', 3);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG68GEG', 'Capsule', 'berline', 's645', 1, 1, 'A0', 4);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG56784F', 'Capsule', 'berline', 'h684', 1, 1, 'A0', 5);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GDG684EDG', 'Tesla', 'cabriolet', 'S', 1, 2, 'A0', 6);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GF66ETY', 'Marine', 'berline', 'Red', 1, 2, 'A0', 7);
insert into `escapade`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('OID99PFL', 'Marine', 'berline', 'Blue', 1, 2, 'A0', 8);

-- insertions in table client

insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goku', 'Son', '+811234567', 'Ferme Chichi', 'gokuson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Gohan', 'Son', '+811567', 'Ferme Chichi', 'gohanson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goten', 'Son', '+811267', 'Ferme Chichi', 'gotenson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Chichi', 'Son', '+814654', 'Ferme Chichi', 'chichison@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Videl', 'Son', '+87021567', 'Ferme Chichi', 'videlson@akira.jp');
insert into `escapade`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Pan', 'Son', '+81126545', 'Ferme Chichi', 'panson@akira.jp');

-- insertions in table housing

insert into `escapade`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`) values (2, '01', 5, 1,1,1);
insert into `escapade`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`) values (4, '02', 4.5, 0,1,2);
insert into `escapade`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`) values (1, '03', 3, 1,2,1);
insert into `escapade`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`) values (3, '03', 3.5, 1,3,2);
insert into `escapade`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`) values (1, '03', 4, 0,3,5);

-- insertions in table parking

insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Rivoli', '2 Rue Boucher', '01');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Rivoli', '2 Rue Boucher', '02');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Beaubourg', '31 Rue Beaubourg', '03');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Lobau', '4 Rue Lobau', '04');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Soufflot', '22 Rue Soufflot', '05');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Jardin des plantes', '25 Rue Geoffroy-Saint-Hilaire', '06');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Maubourg', '45 Quai d Orsay', '07');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Champs-Elysees', '77 Avenue Marceau', '08');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Pigalle', '10 Rue Jean-Baptiste Pigalle', '09');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Lariboisiere', '1 bis Rue Ambroise Pare', '10');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Oberkampf', '11 Rue Ternaux', '11');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Gare de Lyon', '6 Rue de Rambouillet', '12');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Italie', '25 Rue Stephen Pichon', '13');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Raspail', '120 Boulevard Montparnasse', '14');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Beaugrenelle', '5 Quai Andre Citroen', '15');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Victor Hugo', '75 Avenue Victor Hugo', '16');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Ternes', '38 Avenue des Ternes', '17');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Stalingrad', '13 Rue d Aubervillier', '18');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Philharmonie', '185 Boulevard Serurier', '19');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Rosa Parks', '157 Boulevard Macdonald', '20');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Orly', 'Orly Airport', '21');
insert into `escapade`.`parking` (`name`, `adress`, `theme`) values ('Roissy', 'Roissy Airport', '22');

-- insertions in table supervisor

insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Patrick', 'Star');
insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Jon', 'Snow');
insert into `escapade`.`supervisor` (`firstname`, `lastname`) values ('Cave', 'Johnson');

-- insertions in table deal

insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`,`state`) values (0, 'OU642EF', 0, 0, 1500, 12, 2018, 'confirmed');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`,`state`) values (1, 'GP654G5', 2, 1, 2000, 12, 2018, 'confirmed');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`,`state`) values (2, 'DG654GD', 4, 3, 500, 12, 2018, 'confirmed');
insert into `escapade`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `price`, `week`, `year`,`state`) values (2, 'DG68GEG', 5, 4, 300, 12, 2018, 'confirmed');

-- insertions in table maintenance

insert into `escapade`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('OU642EF', 'goku doesn t have a driving licence', 'replaced everything', 13, 2018, 1);
insert into `escapade`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('OU642EF', 'radio explosed', 'replaced radio', 12, 2018, 1);
insert into `escapade`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('GF6454GD', 'goku let gohan drive', 'replaced everything', 12, 2018, 0);
