USE clubdeportivo;

DROP TABLE IF EXISTS CuotaDiaria;

CREATE TABLE CuotaDiaria (
	CodCuotaDiaria VARCHAR(50),
	ValorFinal FLOAT NOT NULL,
	--Pagada bit NOT NULL,
	TipoDePago VARCHAR(50) NOT NULL,
	--FechaDePago VARCHAR(10) NULL,
	CodNoSocio VARCHAR(50) NOT NULL,
	--CodActividad VARCHAR(50) NOT NULL,
	constraint pk_CuotaDiaria primary key (CodCuotaDiaria),
	constraint fk_CodNoSocio FOREIGN KEY (CodNoSocio) REFERENCES NoSocios(CodNoSocio)
);

-- ATRIBUTOS PARA APLICAR LOS CAMBIOS HABLADOS.