USE clubdeportivo;

DROP TABLE IF EXISTS CuotaMensual;

CREATE TABLE CuotaMensual (
    CodCuotaMensual VARCHAR(50),
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    Pagada bit NOT NULL,
    TipoDePago VARCHAR(50) NULL,
    CantidadCuotas INT NULL,
    FechaDePago VARCHAR(10) NULL,
    CodSocio VARCHAR(50) NOT NULL,
    constraint pk_CuotaMensual primary key (CodCuotaMensual),
    constraint fk_CodSocio foreign key (CodSocio) references Socio(CodSocio)
);

DROP PROCEDURE IF EXISTS ObtenerCuotaPorSocio;
DELIMITER //
CREATE PROCEDURE ObtenerCuotaPorSocio(IN p_codSocio VARCHAR(50), IN p_pagada bit)
BEGIN
    SELECT 
        CodCuotaMensual, 
        NroCuota, 
        Vencimiento, 
        ValorMensual, 
        Pagada, 
        IFNULL(TipoDePago, '') AS TipoDePago,
        IFNULL(CantidadCuotas, 0) AS CantidadCuotas,
        IFNULL(FechaDePago, '') AS FechaDePago,
        CodSocio
    FROM 
        CuotaMensual
    WHERE 
        CodSocio = p_codSocio AND Pagada = p_pagada
    ORDER BY Vencimiento DESC
    LIMIT 1;
END //
DELIMITER ;


DROP PROCEDURE IF EXISTS ObtenerCuotaCompleta;
DELIMITER //
CREATE PROCEDURE ObtenerCuotaCompleta(IN p_codCuota VARCHAR(50))
BEGIN
    SELECT 
        CodCuotaMensual, 
        NroCuota, 
        Vencimiento, 
        ValorMensual, 
        Pagada, 
        TipoDePago,
        CantidadCuotas,
        FechaDePago,
        CodSocio
    FROM 
        CuotaMensual
    WHERE 
        CodCuotaMensual = p_codCuota;
END //
DELIMITER ;


DELIMITER //
CREATE PROCEDURE GenerarPrimerCuota(
    IN p_CodCuota VARCHAR(50),
    IN p_NroCuota INT,
    IN p_Vencimiento DATETIME,
    IN p_ValorMensual FLOAT,
    IN p_CodSocio VARCHAR(50),
    OUT rta INT
)
BEGIN
    INSERT INTO CuotaMensual(
        CodCuotaMensual,
        NroCuota,
        Vencimiento,
        ValorMensual,
        Pagada,
        CodSocio
    ) VALUES (
        p_CodCuota,
        p_NroCuota,
        p_Vencimiento,
        p_ValorMensual,
        0, 
        p_CodSocio
    );
    
    SET rta = 0;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE GenerarNuevaCuota(
    IN p_CodCuotaActual VARCHAR(50),
    OUT p_NuevaCodCuota VARCHAR(50),
    OUT rta INT
)
BEGIN
    DECLARE v_CodSocio VARCHAR(50);
    DECLARE v_NroCuota INT;
    DECLARE v_ValorMensual FLOAT;
    
    -- 1. Obtener datos de la cuota actual
    SELECT 
        CodSocio, 
        NroCuota + 1, 
        ValorMensual,
        DATE_ADD(Vencimiento, INTERVAL 1 MONTH)
    INTO 
        v_CodSocio, 
        v_NroCuota, 
        v_ValorMensual,
        @nuevoVencimiento
    FROM CuotaMensual 
    WHERE CodCuotaMensual = p_CodCuotaActual;
    
    -- 2. Generar nuevo código de cuota
    SET p_NuevaCodCuota = CONCAT('CUOTA-', LPAD(v_NroCuota, 2, '0'), '-', v_CodSocio);
    
    -- 3. Insertar nueva cuota
    INSERT INTO CuotaMensual (
        CodCuotaMensual,
        NroCuota,
        Vencimiento,
        ValorMensual,
        Pagada,
        CodSocio
    ) VALUES (
        p_NuevaCodCuota,
        v_NroCuota,
        @nuevoVencimiento,
        v_ValorMensual,
        0,
        v_CodSocio
    );
    
    SET rta = 0;
END //
DELIMITER ;