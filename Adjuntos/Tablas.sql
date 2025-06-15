USE clubdeportivo;

DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE,
    password_hash VARCHAR(255),
    rol VARCHAR(20),
    fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    activo BIT DEFAULT 1
);

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

DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios(
	CodNoSocio VARCHAR(50),
    Dni int,
    constraint pk_NoSocio primary key (CodNoSocio),
    constraint fk_NoSocioClientes foreign key (Dni) references Clientes(Dni));

DROP TABLE IF EXISTS CuotaMensual;
CREATE TABLE CuotaMensual (
    CodCuotaMensual VARCHAR(50),
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    Pagada bit NOT NULL,
    TipoDePago VARCHAR(50) NULL,    
    FechaDePago VARCHAR(10) NULL,
    CodSocio VARCHAR(50) NOT NULL,
    constraint pk_CuotaMensual primary key (CodCuotaMensual),
    constraint fk_CodSocio foreign key (CodSocio) references Socio(CodSocio)
);

DROP TABLE IF EXISTS CuotaDiaria;
CREATE TABLE CuotaDiaria (
	CodCuotaDiaria VARCHAR(50),
	ValorFinal FLOAT NOT NULL,
	--Pagada bit NOT NULL,
	TipoDePago VARCHAR(50) NOT NULL,
	--FechaDePago VARCHAR(10) NULL,
	CodNoSocio VARCHAR(50) NOT NULL,
	--CodActividad VARCHAR(50) NOT NULL,
	constraint pk_CuotaDiaria primary key (CodCuotaDiaria),
	constraint fk_CodNoSocio FOREIGN KEY (CodNoSocio) REFERENCES NoSocios(CodNoSocio)
);
-- ATRIBUTOS PARA APLICAR LOS CAMBIOS HABLADOS.

DROP TABLE IF EXISTS Actividades;
CREATE TABLE Actividades(
	CodActividad VARCHAR(50),
    --CodNoSocio VARCHAR(50),
	Nombre varchar(150),
	Valor float,
	Dia VARCHAR(12),
	Horario varchar(20),
    constraint pk_Actividades primary key (CodActividad),
    constraint fk_NoSocio foreign key (CodNoSocio) references NoSocios(CodNoSocio));