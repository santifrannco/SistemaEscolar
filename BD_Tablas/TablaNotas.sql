create table notas(
	id_nota int auto_increment,
	nom_materia int not null,
	nota1 int null,
	nota2 int  null,
	promedio double(4,2) null,
	recupera varchar(8) null,
	primary key(id_nota),
	foreign key fk_nombremat_prof_nota (nom_materia) references materia_profesor (id_mat_prof)
);