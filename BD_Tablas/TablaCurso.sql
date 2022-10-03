create table curso(
	id_curso int auto_increment,
	ano varchar(20) not null,
	jornada varchar(20) not null,
	orientacion int,
	primary key (id_curso),
	foreign key fk_orientacion_curso (orientacion) references orientacion (id_orientacion)
);