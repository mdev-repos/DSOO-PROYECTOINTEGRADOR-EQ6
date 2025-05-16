USE clubdeportivo;

DROP TABLE IF EXISTS CuotaMensual;

CREATE TABLE CuotaMensual (
    CodCuota VARCHAR(50) PRIMARY KEY,
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    TipoDePago VARCHAR(50) NOT NULL
);
constraint pk_CuotaMensual primary key (CodCuota),