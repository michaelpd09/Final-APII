create table DetalleAlmacenSpare
(
	DetalleAlmacenSparesId int identity(1,1) primary key not null,
	AlmacenId int,
    SpareId int,
    Fecha DateTime
);