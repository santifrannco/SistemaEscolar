create table materia_profesor(
	id_mat_prof int auto_increment,
	materia int not null,
	profesor int not null,
	primary key(id_mat_prof),
	foreign key fk_materia_materia (materia) references materia (id_materia),
	foreign key fk_materia_profesor(profesor) references profesor (id_profesor)
);