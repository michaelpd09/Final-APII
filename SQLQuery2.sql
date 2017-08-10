create table TiposUsuarios
(
	TiposUsuariosId int identity(1,1) primary key not null,
	Nombre varchar(40),
	Fecha datetime
);
