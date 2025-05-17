USE clubdeportivo;

DROP TABLE IF EXISTS CuotaDiaria;

CREATE TABLE CuotaDiaria (
	CodCuota VARCHAR(50),
	ValorFinal FLOAT NOT NULL,
	TipoDePago VARCHAR(50) NOT NULL,
	CodNoSocio VARCHAR(50) NOT NULL,
	constraint pk_CuotaDiaria primary key (CodCuota),
	constraint fk_CodNoSocio FOREIGN KEY (CodNoSocio) REFERENCES NoSocios(CodNoSocio)
);

