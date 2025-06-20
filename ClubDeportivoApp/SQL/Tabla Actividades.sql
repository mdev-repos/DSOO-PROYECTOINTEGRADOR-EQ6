USE clubdeportivo;

DROP TABLE IF EXISTS Actividades;
CREATE TABLE Actividades(
	CodActividad VARCHAR(30),
	Nombre varchar(25),
	Valor float,
	Horario VARCHAR(40),
    constraint pk_Actividades primary key (CodActividad));

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