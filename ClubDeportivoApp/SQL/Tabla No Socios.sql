USE clubdeportivo;

DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios(
	CodNoSocio VARCHAR(50),
    Dni int,
    constraint pk_NoSocio primary key (CodNoSocio),
    constraint fk_NoSocioClientes foreign key (Dni) references Clientes(Dni));
    
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