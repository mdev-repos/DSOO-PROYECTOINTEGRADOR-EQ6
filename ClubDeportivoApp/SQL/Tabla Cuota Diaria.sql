USE clubdeportivo;

DROP TABLE IF EXISTS CuotaDiaria;

CREATE TABLE CuotaDiaria (
	CodCuotaDiaria VARCHAR(50),
	Pagada bit NOT NULL,
	ValorFinal FLOAT NOT NULL,
	TipoDePago VARCHAR(50) NOT NULL,
	CantidadCuotas int NOT NULL,
	FechaDePago VARCHAR(10) NULL,
	FechaDeUso VARCHAR(10) NOT NULL,
	CodNoSocio VARCHAR(50) NOT NULL,
	CodActividad VARCHAR(50) NOT NULL,
	constraint pk_CuotaDiaria primary key (CodCuotaDiaria),
	constraint fk_CodNoSocio FOREIGN KEY (CodNoSocio) REFERENCES NoSocios(CodNoSocio)
);