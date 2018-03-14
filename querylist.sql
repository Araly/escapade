--1
select id from client;
--2
insert into client (`firstname`, `lastname`, `phone`, `adress`, `email`) values ({$firstname}, {$lastname}, {$phone}, {$adress}, {$email});
--3
select id, available, id_parking, parkingSpace from car;
--4
select car.id from car join parking on parking.id = car.id_parking where parking.theme like %{$arrondissement};
--5
update car set parkingSpace = {$parkingSpace} where id = {immatriculation$};
--6
select count(id) from maintenance where id_car = {$immatriculation};
--7
update car set available = 1 where id = {$immatriculation};
--8
select count(id) from car group by id_supervisor;
--9
select car.idi, maintenance.cause from car join maintenance on maintenance.id_car = car.id where done = 0;
--10
update car set available = 0 where car.id = {$immatriculation};
insert into maintenance (`id_car`, `cause`, `intervention`, `week`, `year`, `done`) values ({$immatriculation}, {$cause}, {$intervention}, {$week}, {$year}, {$done});
