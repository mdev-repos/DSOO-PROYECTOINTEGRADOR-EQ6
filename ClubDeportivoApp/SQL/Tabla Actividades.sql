USE clubdeportivo;

DROP TABLE IF EXISTS Actividades;
CREATE TABLE Actividades(
	CodActividad VARCHAR(50),
    CodNoSocio VARCHAR(50),
	Nombre varchar(150),
	Valor float,
	Horario varchar(150),
    constraint pk_Actividades primary key (CodActividad),
    constraint fk_NoSocio foreign key (CodNoSocio) references NoSocios(CodNoSocio));
