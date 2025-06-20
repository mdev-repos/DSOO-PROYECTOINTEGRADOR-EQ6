USE clubdeportivo;
SELECT * FROM clientes;
DROP TABLE IF EXISTS clientes;

CREATE TABLE clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni INT UNIQUE,
    fecha_nac DATETIME,
    direccion VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100),
    ficha_medica BIT
);

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
