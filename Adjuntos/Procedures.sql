/*
PROCEDURES PARA CLUB DEPORTIVO

Versión: 1.0
Autor: EQUIPO 6 - DSOO 1er CUATRIMESTRE 2025
Fecha: 20/06/2025

*/

USE clubdeportivo;

-- =============================================
-- PROCEDIMIENTOS PARA SOCIOS
-- =============================================

-- NUEVO SOCIO (CREATE)
DROP PROCEDURE IF EXISTS NuevoSocio;
DELIMITER //
CREATE PROCEDURE NuevoSocio(
    IN Nombre VARCHAR(50),
    IN Apellido VARCHAR(50),
    IN Dni INT,
    IN FechaNac DATETIME,
    IN Direccion VARCHAR(100),
    IN Telefono VARCHAR(20),
    IN Email VARCHAR(100),
    IN FichaMedica BIT,
    IN CodSocio VARCHAR(50),
    IN Carnet BIT,
    IN FechaInscripcion VARCHAR(20),
    IN Moroso BIT,
    IN Activo BIT,
    OUT rta INT
)
BEGIN
	DECLARE existe INT DEFAULT 0;
    
    SELECT COUNT(*) INTO existe FROM Socio s 
    JOIN clientes c ON s.Dni = c.dni 
    WHERE c.dni = Dni;
    
    IF existe = 0 THEN
        INSERT INTO clientes(nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
        VALUES (Nombre, Apellido, Dni, FechaNac, Direccion, Telefono, Email, FichaMedica);
        
        INSERT INTO Socio(CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
        VALUES (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo);
        
        SET rta = 0;
    ELSE
        SET rta = 1;
    END IF;  
END//
DELIMITER ;

-- OBTENER SOCIO POR CODIGO (READ)
DROP PROCEDURE IF EXISTS ObtenerSocioPorCodigo;
DELIMITER //
CREATE PROCEDURE ObtenerSocioPorCodigo(IN p_codSocio VARCHAR(50))
BEGIN
    SELECT 
        s.CodSocio, 
        s.Dni, 
        c.Nombre, 
        c.Apellido,
        s.Carnet,
        s.FechaInscripcion,
        s.Moroso,
        s.Activo
    FROM 
        Socio s
    JOIN 
        Clientes c ON s.Dni = c.dni
    WHERE 
        s.CodSocio = p_codSocio;
END //
DELIMITER ;

-- LISTAR SOCIOS MOROSOS (READ)
DROP PROCEDURE IF EXISTS ListarSociosMorosos;
DELIMITER //
CREATE PROCEDURE ListarSociosMorosos()
BEGIN    
    SELECT 
        s.CodSocio,
        c.apellido,
        c.nombre,
        c.dni,
        cm.Vencimiento
    FROM 
        Socio s
    JOIN 
        clientes c ON s.Dni = c.dni
    JOIN 
        CuotaMensual cm ON s.CodSocio = cm.CodSocio
    WHERE 
        cm.Pagada = FALSE
        AND cm.Vencimiento <= CURDATE()
        AND s.Moroso = TRUE
    ORDER BY 
        cm.Vencimiento DESC;
END //
DELIMITER ;


-- =============================================
-- PROCEDIMIENTOS PARA NO SOCIOS
-- =============================================

-- NUEVO NO SOCIO (CREATE)
DROP PROCEDURE IF EXISTS NuevoNoSocio;
DELIMITER //
CREATE PROCEDURE NuevoNoSocio(
    IN Nombre VARCHAR(50),
    IN Apellido VARCHAR(50),
    IN Dni INT,
    IN FechaNac DATETIME,
    IN Direccion VARCHAR(100),
    IN Telefono VARCHAR(20),
    IN Email VARCHAR(100),
    IN FichaMedica BIT,
    IN CodNoSocio VARCHAR(50),
    OUT rta INT
)
BEGIN
	DECLARE existe INT DEFAULT 0;
    
    SELECT COUNT(*) INTO existe FROM NoSocios s 
    JOIN clientes c ON s.Dni = c.dni 
    WHERE c.dni = Dni;
    
    IF existe = 0 THEN
        INSERT INTO clientes(nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
        VALUES (Nombre, Apellido, Dni, FechaNac, Direccion, Telefono, Email, FichaMedica);
        
        INSERT INTO NoSocios(CodNoSocio, Dni)
        VALUES (CodNoSocio, Dni);
        
        SET rta = 0;
    ELSE
        SET rta = 1;
    END IF;    
END//
DELIMITER ;

DROP PROCEDURE IF EXISTS BuscarNoSocioPorDni;
DELIMITER //
CREATE PROCEDURE BuscarNoSocioPorDni(IN p_dni VARCHAR(20))
BEGIN
    SELECT 
        ns.CodNoSocio,  
        c.nombre,       
        c.apellido,     
        c.dni,          
        c.fecha_nac,    
        c.direccion,    
        c.telefono,     
        c.email,        
        c.ficha_medica  
    FROM clientes c
    INNER JOIN NoSocios ns ON c.dni = ns.dni
    WHERE c.dni = CAST(p_dni AS SIGNED) 
    LIMIT 1;
END //
DELIMITER ;

-- =============================================
-- PROCEDIMIENTOS PARA CUOTA MENSUAL
-- =============================================

-- GENERAR PRIMER CUOTA (CREATE)
DROP PROCEDURE IF EXISTS GenerarPrimerCuota;
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

-- GENERAR NUEVA CUOTA (CREATE)
DROP PROCEDURE IF EXISTS GenerarNuevaCuota;
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
    SET p_NuevaCodCuota = CONCAT('CUOTA-', LPAD(v_NroCuota, 2, '0'), '-', v_CodSocio);
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

-- OBTENER CUOTA COMPLETA (READ)
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

-- OBTENER CUOTA POR CODIGO DE SOCIO (READ)
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

-- =============================================
-- PROCEDIMIENTOS PARA CLIENTES
-- =============================================

-- OBTENER TODOS LOS CLIENTES MENOS LOS QUE ESTEN DE BAJA Y FILTRADOS
DROP PROCEDURE IF EXISTS ObtenerClientesActivosYFiltrados;
DELIMITER //
CREATE PROCEDURE ObtenerClientesActivosYFiltrados(IN dni VARCHAR(20))
BEGIN
    IF dni IS NULL OR dni = '' THEN
        SELECT c.Nombre, c.Apellido, c.Dni
        FROM Clientes c
        LEFT JOIN Socio s ON c.Dni = s.Dni AND s.Activo = 1
        LEFT JOIN NoSocios ns ON c.Dni = ns.Dni 
        WHERE s.Activo = 1 OR ns.Dni IS NOT NULL;
    ELSE
        SELECT c.Nombre, c.Apellido, c.Dni
        FROM Clientes c
        LEFT JOIN Socio s ON c.Dni = s.Dni AND s.Activo = 1
        LEFT JOIN NoSocios ns ON c.Dni = ns.Dni 
        WHERE s.Activo = 1 OR ns.Dni IS NOT NULL AND c.Dni = dni;
    END IF;
END //
DELIMITER ;


-- OBTENER DATOS CLIENTES
DROP PROCEDURE IF EXISTS sp_ObtenerDatosClienteTipoActivo;
DELIMITER //
CREATE PROCEDURE sp_ObtenerDatosClienteTipoActivo(IN p_dni INT)
BEGIN
	SELECT 
        c.Nombre,
        c.Apellido,
        c.Dni,
        c.Fecha_Nac,
        c.Direccion,
        c.Telefono,
        c.Email,
        c.Ficha_Medica,
        COALESCE(s.CodSocio, ns.CodNoSocio) AS Codigo,
        s.Carnet,
        s.FechaInscripcion,
        s.Moroso
    FROM Clientes c
    LEFT JOIN Socio s ON c.Dni = s.Dni 
    LEFT JOIN NoSocios ns ON c.Dni = ns.Dni 
    WHERE c.Dni = p_dni;
END//

DELIMITER ;

-- ACTUALIZAR CLIENTE
DROP PROCEDURE IF EXISTS sp_ActualizarClienteYTipo;
DELIMITER //
CREATE PROCEDURE sp_ActualizarClienteYTipo(
    IN dni INT,
    IN nuevo_dni INT,
    IN nombre VARCHAR(50),
    IN apellido VARCHAR(50),
    IN fecha_nac DATE,
    IN direccion VARCHAR(100),
    IN telefono VARCHAR(20),
    IN email VARCHAR(100),
    IN ficha_medica TINYINT(1),
    IN nuevo_tipo_cliente VARCHAR(20)
)
BEGIN
    UPDATE Clientes
    SET Dni = nuevo_dni,
		Nombre = nombre,
        Apellido = apellido,
        Fecha_Nac = fecha_nac,
        Direccion = direccion,
        Telefono = telefono,
        Email = email,
        Ficha_Medica = ficha_medica
    WHERE Dni = dni;
END//

DELIMITER ;

-- =============================================
-- PROCEDIMIENTOS PARA ACTIVIDADES
-- =============================================
DROP PROCEDURE IF EXISTS NuevaActividad;
DELIMITER //
CREATE PROCEDURE NuevaActividad(
    IN CodActividad VARCHAR(30),
    IN Nombre VARCHAR(25),
    IN Valor FLOAT,
    IN Horario VARCHAR(55),
    OUT rta INT
)
BEGIN
	DECLARE existe INT DEFAULT 0;
    
    SELECT COUNT(*) INTO existe FROM Actividades act
    WHERE act.nombre = Nombre;
    
    IF existe = 0 THEN
        INSERT INTO Actividades(codActividad, nombre, valor, horario)
        VALUES (CodActividad , Nombre, Valor, Horario);
        
        SET rta = 0;
    ELSE
        SET rta = 1;
    END IF;  
END//
DELIMITER ;

-- OBTENER NOMBRE DE ACTIVIDADES
DROP PROCEDURE IF EXISTS ObtenerNombresActividades;
DELIMITER //
CREATE PROCEDURE ObtenerNombresActividades()
BEGIN
    SELECT Nombre FROM Actividades;
END //

DELIMITER ;

-- OBTENER DATOS DE ACTIVIDADES
DROP PROCEDURE IF EXISTS ObtenerDatosActividades;
DELIMITER //
CREATE PROCEDURE ObtenerDatosActividades(IN nombre VARCHAR(100))
BEGIN
    SELECT Valor, Horario
    FROM Actividades
    WHERE Nombre = nombre;
END //

DELIMITER ;

-- OBTENER TODAS LAS ACTIVIDADES DESDE LA BBDD
DROP PROCEDURE IF EXISTS ListarTodasLasActividades;
DELIMITER //
CREATE PROCEDURE ListarTodasLasActividades()
BEGIN
    SELECT 
        CodActividad AS 'Código',
        Nombre AS 'Nombre',
        Valor AS 'Precio',
        Horario AS 'Horarios'
    FROM 
        Actividades
    ORDER BY Nombre;
END //
DELIMITER ;

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