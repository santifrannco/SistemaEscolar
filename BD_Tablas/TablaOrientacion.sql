create table orientacion (
	id_orientacion int auto_increment,
	descripcion varchar(50) not null,
	primary key (id_orientacion),
	unique key (descripcion)
); 