create table RegistroUsuarios
(
	UsuarioId int identity(1,1) primary key not null,
	TiposUsuariosId int foreign key references TiposUsuarios (TiposUsuariosId),
	Nombre varchar(40),
	Apellido varchar(70),
	Clave varchar(70),
	Fecha datetime,
);