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
DROP PROCEDURE IF EXISTS NuevoCliente;
DELIMITER //
CREATE PROCEDURE NuevoCliente(
    IN Nombre VARCHAR(50),
    IN Apellido VARCHAR(50),
    IN Dni INT,
    IN FechaNac DATETIME,
    IN Direccion VARCHAR(100),
    IN Telefono VARCHAR(20),
    IN Email VARCHAR(100),
    IN FichaMedica BIT,
    OUT rta INT
)
BEGIN
    -- Verificar si el cliente ya existe por su DNI
		declare existe int default 0;
        set existe = (select count(*) from clientes where clientes.dni = Dni);
		if existe = 0 then	 
        INSERT INTO clientes(nombre, apellido, Dni, fecha_nac, direccion, telefono, email, ficha_medica)
        VALUES (Nombre, Apellido, Dni, FechaNac, Direccion, Telefono, Email, FichaMedica);
        set rta  = 0;
        else
        set rta = 1;
        end if;
    
END//

DELIMITER ;
SELECT `cliente`.`nombre`,
    `cliente`.`apellido`,
    `cliente`.`dni`,
    `cliente`.`fechanac`,
    `cliente`.`direccion`,
    `cliente`.`telefono`,
    `cliente`.`email`,
    `cliente`.`fichamedica`
FROM `clubdeportivo`.`cliente`;