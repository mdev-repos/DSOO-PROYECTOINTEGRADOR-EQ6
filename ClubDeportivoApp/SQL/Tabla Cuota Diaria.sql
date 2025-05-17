USE clubdeportivo;

DROP TABLE IF EXISTS CuotaDiaria;

CREATE TABLE CuotaDiaria (
	CodCuota VARCHAR(50) PRIMARY KEY,
	ValorFinal FLOAT NOT NULL,
	TipoDePago VARCHAR(50) NOT NULL
);

constraint pk_CuotaDiaria primary key (CodCuota),