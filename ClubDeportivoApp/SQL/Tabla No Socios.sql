USE clubdeportivo;

DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios(
	CodNoSocio VARCHAR(50),
    Dni int,
    constraint pk_NoSocios primary key (CodNoSocio),
    constraint fk_Clientes foreign key (Dni) references Clientes(Dni));