USE clubdeportivo;

drop table if exists Socio;
create table Socio(
	CodSocio varchar(50),
	Dni int,
	Carnet bit,
	FechaInscripcion varchar(20),
	Moroso bit,
	constraint pk_Socio primary key (CodSocio),
	constraint fk_Clientes_Socio foreign key (Dni) references Clientes(Dni)
);