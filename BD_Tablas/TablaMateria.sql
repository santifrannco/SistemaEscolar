create table materia(
	id_materia int auto_increment,
	nombre_materia varchar(40) not null,
	ano_materia varchar(25) not null,
	primary key(id_materia),
	unique key(nombre_materia)
);