create table alumno(
	id_alumno int auto_increment,
	DNI varchar(8) not null,
	nombre varchar(25) not null,
	apellido varchar(25) not null,
	ciudad varchar(25) not null,
	direccion varchar(25) not null,
	fecha_nacimiento date not null,
	sexo varchar(15) not null,
	fecha_inscripcion date not null,
	curso int, 
	primary key(id_alumno),
	unique key(DNI),
	foreign key fk_curso_alumno (curso) references curso (id_curso)
);