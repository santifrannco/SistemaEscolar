create table horario_alumno (
	id_horario int auto_increment,
	dia varchar (40) not null,
	hora_inicio varchar (15) not null,
	hora_fin varchar (15) not null,
	materia_horario int,
	primary key(id_horario),
	foreign key fk_horario_materia (materia_horario) references materia(id_materia)
);	