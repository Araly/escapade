-- insertions in table stay

insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Visite des champs elysées','08');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Visite Musée Orsay','07');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Visite Louvre','01');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Tournee de bars de Bastille','11');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Ballade a Montmartre','18');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Pic Nique au Jardin des Plantes','05');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Forfait Premium Aquaboulevard','15');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Tour en hélicoptère à la tour montparnasse','15');
insert into `KERI_ADRI`.`stay` (`theme`,`borough`) values ('Visite Tour Eiffel','07');

-- insertions in table car

insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('OU642EF', 'Mazerati', 'berline', 'Quattroporte', 1, 0, 'A0', 0);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GP654G', 'Mazerati', 'cabriolet', 'Ottoporte', 1, 0, 'A3', 1);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GF654GD', 'Renaud', 'berline', 'Twingo', 1, 0, 'A0', 2);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG654GD', 'Citreon', 'berline', 'C418', 1, 1, 'A0', 3);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG68GEG', 'Capsule', 'berline', 's645', 1, 1, 'A0', 4);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('DG56784F', 'Capsule', 'berline', 'h684', 1, 1, 'A0', 5);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GDG684EDG', 'Tesla', 'cabriolet', 'S', 1, 2, 'A0', 6);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('GF66ETY', 'Marine', 'berline', 'Red', 1, 2, 'A0', 7);
insert into `KERI_ADRI`.`car` (`id`, `brand`, `type`, `model`, `available`, `id_supervisor`, `parkingSpace`, `id_parking`) values ('OID99PFL', 'Marine', 'berline', 'Blue', 1, 2, 'A0', 8);

-- insertions in table client

insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goku', 'Son', '+811234567', 'Ferme Chichi', 'gokuson@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Gohan', 'Son', '+811567', 'Ferme Chichi', 'gohanson@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Goten', 'Son', '+811267', 'Ferme Chichi', 'gotenson@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Chichi', 'Son', '+814654', 'Ferme Chichi', 'chichison@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Videl', 'Son', '+87021567', 'Ferme Chichi', 'videlson@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Pan', 'Son', '+81126545', 'Ferme Chichi', 'panson@akira.jp');
insert into `KERI_ADRI`.`client` (`firstname`, `lastname`, `phone`, `adress`, `email`) values ('Adrien', 'Kerisit', '0782453482', 'ESILV, La défense', 'adrien.kerisit@devinci.fr');


-- insertions in table housing

insert into `KERI_ADRI`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`, `price`) values (2, '01', 5, 1,1,1,1100);
insert into `KERI_ADRI`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`, `price`) values (4, '02', 4.5, 0,1,2,2000);
insert into `KERI_ADRI`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`, `price`) values (1, '03', 3, 1,2,1,500);
insert into `KERI_ADRI`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`, `price`) values (3, '03', 3.5, 1,3,2,1500);
insert into `KERI_ADRI`.`housing` (`bedroomNumber`, `theme`, `rating`,`available`,`host_id`,`room_id`, `price`) values (1, '03', 4, 0,3,5, 300);

-- insertions in table parking

insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Rivoli', '2 Rue Boucher', '01');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Rivoli', '2 Rue Boucher', '02');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Beaubourg', '31 Rue Beaubourg', '03');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Lobau', '4 Rue Lobau', '04');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Soufflot', '22 Rue Soufflot', '05');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Jardin des plantes', '25 Rue Geoffroy-Saint-Hilaire', '06');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Maubourg', '45 Quai d Orsay', '07');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Champs-Elysees', '77 Avenue Marceau', '08');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Pigalle', '10 Rue Jean-Baptiste Pigalle', '09');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Lariboisiere', '1 bis Rue Ambroise Pare', '10');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Oberkampf', '11 Rue Ternaux', '11');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Gare de Lyon', '6 Rue de Rambouillet', '12');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Italie', '25 Rue Stephen Pichon', '13');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Raspail', '120 Boulevard Montparnasse', '14');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Beaugrenelle', '5 Quai Andre Citroen', '15');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Victor Hugo', '75 Avenue Victor Hugo', '16');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Ternes', '38 Avenue des Ternes', '17');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Stalingrad', '13 Rue d Aubervillier', '18');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Philharmonie', '185 Boulevard Serurier', '19');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Rosa Parks', '157 Boulevard Macdonald', '20');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Orly', 'Orly Airport', '21');
insert into `KERI_ADRI`.`parking` (`name`, `adress`, `theme`) values ('Roissy', 'Roissy Airport', '22');

-- insertions in table supervisor

insert into `KERI_ADRI`.`supervisor` (`firstname`, `lastname`) values ('Patrick', 'Star');
insert into `KERI_ADRI`.`supervisor` (`firstname`, `lastname`) values ('Jon', 'Snow');
insert into `KERI_ADRI`.`supervisor` (`firstname`, `lastname`) values ('Cave', 'Johnson');

-- insertions in table deal

insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (3, 'DG56784F', 7, 3, 3, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (4, 'DG56784F', 7, 1, 8, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (0, 'OU642EF', 0, 0, 12, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (1, 'GP654G5', 2, 1, 12, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (2, 'DG654GD', 4, 3, 12, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (2, 'DG68GEG', 5, 4, 12, 2018, 'confirmed');
insert into `KERI_ADRI`.`deal` (`id_stay`, `id_car`, `id_client`, `id_housing`, `week`, `year`,`state`) values (6, 'DG56784F', 7, 2, 12, 2018, 'confirmed');

-- insertions in table maintenance

insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('OU642EF', 'goku doesn t have a driving licence', 'replaced everything', 13, 2018, 1);
insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('OU642EF', 'radio explosed', 'replaced radio', 12, 2018, 1);
insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('GF6454GD', 'goku let gohan drive', 'replaced everything', 12, 2018, 0);
insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('DG56784F', 'pneu crevé', 'pneu remplacé', 12, 2018, 1);
insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('DG56784F', 'fenetre brisée', 'fenetre remplacée', 8, 2018, 1);
insert into `KERI_ADRI`.`maintenance` (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ('DG56784F', 'airbag déclanchés', 'capteurs recalibrés', 3, 2018, 1);
