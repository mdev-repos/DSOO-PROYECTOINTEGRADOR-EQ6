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