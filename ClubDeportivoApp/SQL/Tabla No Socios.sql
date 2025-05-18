USE clubdeportivo;

DROP TABLE IF EXISTS NoSocio;
CREATE TABLE NoSocios(
	CodNoSocio VARCHAR(50),
    Dni int,
    constraint pk_NoSocio primary key (CodNoSocio),
    constraint fk_NoSocioClientes foreign key (Dni) references Clientes(Dni));