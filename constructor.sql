create database `escapade`;
use escapade;

create user 'escapade'@'localhost';
grant all privileges on escapade.* to 'escapade'@'localhost' identified by 'esilv';

create table `escapade`.`stay` (
	`id` int not null auto_increment,
	`theme` varchar(3) not null,
	primary key (`id`) );

create table `escapade`.`car` (
	`id` varchar(10) not null,
	`brand` varchar(50) not null,
	`type` enum('berline', 'cabriolet') not null,
	`model` varchar(50) not null,
	`available` bit not null,
	`id_supervisor` int not null,
	`parkingSpace` enum('A0', 'A1', 'A2', 'A3', 'A4', 'A5', 'A6', 'A7', 'A8', 'A9'),
	`id_parking` int,
	primary key (`id`) );

create table `escapade`.`client` (
	`id` int not null auto_increment,
	`firstname` varchar(20) not null,
	`lastname` varchar(20) not null,
	`phone` varchar(12) not null,
	`adress` varchar(100) not null,
	`email` varchar(20) not null,
	primary key (`id`) );

create table `escapade`.`housing` (
	`id` int not null auto_increment,
	`name` varchar(50),
	`theme` varchar(3) not null,
	primary key (`id`) );

create table `escapade`.`deal` (
	`id` int not null auto_increment,
	`id_stay` int not null,
	`id_car` varchar(10) not null,
	`id_client` int not null,
	`id_housing` int not null,
	`price` int not null,
	`week` int not null,
	`year` int not null,
	`rating` int,
	`ratingDescription` varchar(100),
	primary key (`id`) );

create table `escapade`.`supervisor` (
	`id` int not null auto_increment,
	`firstname` varchar(20) not null,
	`lastname` varchar(20) not null,
	primary key (`id`) );

create table `escapade`.`parking` (
	`id` int not null auto_increment,
	`name` varchar(50) not null,
	`adress` varchar(100) not null,
	`theme` varchar(3) not null,
	primary key (`id`) );

create table `escapade`.`maintenance` (
	`id` int not null auto_increment,
	`id_car` varchar(10) not null,
	`cause` varchar(100) not null,
	`intervention` varchar(100),
	`week` int not null,
	`year` int not null,
	`done` bit not null,
	primary key (`id`) );

