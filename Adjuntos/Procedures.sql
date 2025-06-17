-- PROCEDURES SOCIO

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
    -- Verificar si el cliente ya existe por su DNI
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


-- PROCEDURES NO SOCIO

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

-- PROCEDURES CUOTA MENSUAL

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
        FechaDePago,
        CodSocio
    FROM 
        CuotaMensual
    WHERE 
        CodCuotaMensual = p_codCuota;
END //
DELIMITER ;