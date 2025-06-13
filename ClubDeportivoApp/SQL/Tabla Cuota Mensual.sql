USE clubdeportivo;

DROP TABLE IF EXISTS CuotaMensual;

CREATE TABLE CuotaMensual (
    CodCuotaMensual VARCHAR(50),
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    TipoDePago VARCHAR(50) NOT NULL, -- DEBERIA SER NULL
    Pagada bit NOT NULL,
    -- FECHA DE PAGO NULL
    --COMPROBANTE NULL
    CodSocio VARCHAR(50) NOT NULL,
    constraint pk_CuotaMensual primary key (CodCuotaMensual),
    constraint fk_CodSocio foreign key (CodSocio) references Socio(CodSocio)
);

-- SE PUEDEN AGREGAR LOS CAMPOS O CREAR OTRA ENTIDAD (PAGO) PARA MANEJAR LOS MISMOS