create table RegistroSpares(
	  
	SpareId  int identity(1,1) primary key not null,
	AlmacenId int foreign key references RegistroAlmacenes (AlmacenId),
	Nombre varchar(50),
	NumeroParte varchar(30),
	SerialNumero varchar(30),
	Ubicacion varchar(50),
	Fecha datetime,

);