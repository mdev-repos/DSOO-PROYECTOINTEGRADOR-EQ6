USE clubdeportivo;

DROP TABLE IF EXISTS CuotaMensual;

CREATE TABLE CuotaMensual (
    CodCuota VARCHAR(50),
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    TipoDePago VARCHAR(50) NOT NULL,
    CodSocio VARCHAR(50) NOT NULL,
    constraint pk_CuotaMensual primary key (CodCuota),
    constraint fk_CodSocio foreign key (CodSocio) references Socio(CodSocio),
);

