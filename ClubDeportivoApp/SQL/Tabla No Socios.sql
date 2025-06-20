USE clubdeportivo;

DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios(
	CodNoSocio VARCHAR(50),
    Dni int,
    constraint pk_NoSocio primary key (CodNoSocio),
    constraint fk_NoSocioClientes foreign key (Dni) references Clientes(Dni));
    
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
