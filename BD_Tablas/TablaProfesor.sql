create table profesor(
	id_profesor int auto_increment,
	DNI varchar(8) not null,
	nombre varchar(25) not null,
	apellido varchar(25) not null,
	fecha_nacimiento date,
	direccion varchar(30) not null,
	telefono varchar(15) null,
	primary key(id_profesor),
	unique key(DNI)
);