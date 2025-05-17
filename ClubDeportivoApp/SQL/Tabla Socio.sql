use clubdeportivo;

create table Socio(
	CodSocio varchar(50),
	DNI int,
	Carnet boolean,
	FechaInscripcion varchar(20),
	Moroso boolean,
	constraint pk_Socio primary key (CodSocio),
	constraint fk_Cliente foreign key (DNI) references Cliente(DNI)
);