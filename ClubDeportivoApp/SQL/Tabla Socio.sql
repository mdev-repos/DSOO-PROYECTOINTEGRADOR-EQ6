USE clubdeportivo;

drop table if exists Socio;
create table Socio(
    CodSocio varchar(50),
	Dni int,
	Carnet bit,
	FechaInscripcion varchar(20),
	Moroso bit,
	constraint pk_Socio primary key (CodSocio),
	constraint fk_Clientes_Socio foreign key (Dni) references Clientes(Dni)
);

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
        
        INSERT INTO Socio(CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
        VALUES (CodSocio, Dni, Carnet, FechaInscripcion, Moroso);
        
        SET rta = 0;
    ELSE
        SET rta = 1;
    END IF;

    
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