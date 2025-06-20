USE clubdeportivo;

DROP TABLE IF EXISTS CuotaDiaria;

CREATE TABLE CuotaDiaria (
	CodCuotaDiaria VARCHAR(50),
	Pagada bit NOT NULL,
	ValorFinal FLOAT NOT NULL,
	TipoDePago VARCHAR(50) NULL,
	CantidadCuotas int NULL,
	FechaDePago VARCHAR(10) NULL,
	FechaDeUso VARCHAR(10) NOT NULL,
	CodNoSocio VARCHAR(50) NOT NULL,
	CodActividad VARCHAR(50) NOT NULL,
	constraint pk_CuotaDiaria primary key (CodCuotaDiaria),
	constraint fk_CodNoSocio FOREIGN KEY (CodNoSocio) REFERENCES NoSocios(CodNoSocio),
	constraint fk_CodActividad FOREIGN key (CodActividad) REFERENCES Actividad(CodActividad)
);

-- =============================================
-- PROCEDIMIENTOS PARA CUOTA DIARIA
-- =============================================
DELIMITER //
DROP PROCEDURE IF EXISTS CrearCuotaDiariaParcial;
CREATE PROCEDURE CrearCuotaDiariaParcial(
    IN p_CodCuotaDiaria VARCHAR(50),
    IN p_ValorFinal FLOAT,
    IN p_FechaDeUso VARCHAR(10),
    IN p_CodNoSocio VARCHAR(50),
    IN p_CodActividad VARCHAR(50),
    OUT rta INT
)
BEGIN
    INSERT INTO CuotaDiaria (
        CodCuotaDiaria,
        ValorFinal,
        FechaDeUso,
        CodNoSocio,
        CodActividad
    ) VALUES (
        p_CodCuotaDiaria,
        p_ValorFinal,
        p_FechaDeUso,
        p_CodNoSocio,
        p_CodActividad        
    );    
    SET rta = 0;
END //
DELIMITER ;

DELIMITER //
DROP PROCEDURE IF EXISTS ActualizarCuotaDiariaCompleta;
CREATE PROCEDURE ActualizarCuotaDiariaCompleta(
    IN p_CodCuotaDiaria VARCHAR(50),
    IN p_TipoDePago VARCHAR(50),
    IN p_CantidadCuotas INT,
    IN p_FechaDePago VARCHAR(10),
    OUT rta INT
)
BEGIN
    UPDATE CuotaDiaria 
    SET 
        Pagada = 1,
        TipoDePago = p_TipoDePago,
        CantidadCuotas = p_CantidadCuotas,
        FechaDePago = p_FechaDePago
    WHERE 
        CodCuotaDiaria = p_CodCuotaDiaria;
    
    SET rta = 0; -- Éxito
END //
DELIMITER ;