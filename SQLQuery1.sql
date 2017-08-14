create table DetalleAlmacenSpares
(
	DetalleAlmacenSpareId int identity(1,1)primary key not null,
	SpareId int foreign key references RegistroSpares (SpareId),
	AlmacenId int,
	UsuarioId int,
	Tecnologia varchar(100),
	Fecha DateTime
);