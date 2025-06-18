USE clubdeportivo;

DROP TABLE IF EXISTS Actividades;
CREATE TABLE Actividades(
	CodActividad VARCHAR(50),
	Nombre varchar(50),
	Valor float,
	Horario VARCHAR(40),
    constraint pk_Actividades primary key (CodActividad),
    constraint fk_NoSocio foreign key (CodNoSocio) references NoSocios(CodNoSocio));
