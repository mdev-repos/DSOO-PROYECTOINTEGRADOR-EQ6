-- DOCUMENTACION DEL ESQUEMA

/*
ESQUEMA DE LA BASE DE DATOS CLUB DEPORTIVO

Versión: 1.0
Autor: EQUIPO 6 - DSOO 1er CUATRIMESTRE 2025
Descripción: Base de Datos desarrollada para gestion del CLUB DEPORTIVO.

*/

-- CREACION DE LA BASE DE DATOS
CREATE DATABASE IF NOT EXISTS clubdeportivo 
CHARACTER SET utf8mb4 
COLLATE utf8mb4_general_ci;

USE clubdeportivo;

-- CREACION DE LAS TABLAS INDEPENDIENTES
DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    rol VARCHAR(20) NOT NULL,
    fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    activo BIT DEFAULT 1
) ENGINE=InnoDB;

DROP TABLE IF EXISTS clientes;
CREATE TABLE clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni INT UNIQUE NOT NULL,
    fecha_nac DATE,
    direccion VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100),
    ficha_medica BIT DEFAULT 0
) ENGINE=InnoDB;

DROP TABLE IF EXISTS Actividades;
CREATE TABLE Actividades(
    CodActividad VARCHAR(30) PRIMARY KEY,
    Nombre VARCHAR(25) NOT NULL,
    Valor FLOAT NOT NULL,
    Horario VARCHAR(55)
) ENGINE=InnoDB;

-- CREACION DE LAS TABLAS CON DEPENDENCIAS DE PRIMER NIVEL
DROP TABLE IF EXISTS Socio;
CREATE TABLE Socio(
    CodSocio VARCHAR(50) PRIMARY KEY,
    Dni INT NOT NULL,
    Carnet BIT DEFAULT 0,
    FechaInscripcion VARCHAR(20),
    Moroso BIT DEFAULT 0,
    Activo BIT DEFAULT 1,
    CONSTRAINT fk_Clientes_Socio FOREIGN KEY (Dni) 
        REFERENCES clientes(dni)
        ON DELETE CASCADE
) ENGINE=InnoDB;

DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios(
    CodNoSocio VARCHAR(50) PRIMARY KEY,
    Dni INT NOT NULL,
    Activo BIT DEFAULT 1,
    CONSTRAINT fk_NoSocioClientes FOREIGN KEY (Dni) 
        REFERENCES clientes(dni)
        ON DELETE CASCADE
) ENGINE=InnoDB;

-- CREACION DE LAS TABLAS CON MAS DEPENDENCIAS
DROP TABLE IF EXISTS CuotaMensual;
CREATE TABLE CuotaMensual (
    CodCuotaMensual VARCHAR(50) PRIMARY KEY,
    NroCuota INT NOT NULL,
    Vencimiento DATETIME NOT NULL,
    ValorMensual FLOAT NOT NULL,
    Pagada BIT NOT NULL DEFAULT 0,
    TipoDePago VARCHAR(50),
    CantidadCuotas INT,
    FechaDePago VARCHAR(10) NULL,
    CodSocio VARCHAR(50) NOT NULL,
    CONSTRAINT fk_CodSocio FOREIGN KEY (CodSocio) 
        REFERENCES Socio(CodSocio)
        ON DELETE CASCADE
) ENGINE=InnoDB;

DROP TABLE IF EXISTS CuotaDiaria;
CREATE TABLE CuotaDiaria (
    CodCuotaDiaria VARCHAR(50) PRIMARY KEY,
    Pagada BIT NOT NULL DEFAULT 0,
	ValorFinal FLOAT NOT NULL,
    TipoDePago VARCHAR(50) NOT NULL,
    CantidadCuotas INT NOT NULL,
	FechaDePago VARCHAR(10) NOT NULL,
    FechaDeUso VARCHAR(10) NOT NULL,
    CodNoSocio VARCHAR(50) NOT NULL,
    CodActividad VARCHAR(50) NOT NULL,
    CONSTRAINT fk_CodNoSocio FOREIGN KEY (CodNoSocio) 
        REFERENCES NoSocios(CodNoSocio)
        ON DELETE CASCADE,
    CONSTRAINT fk_CodActividad FOREIGN KEY (CodActividad) 
        REFERENCES Actividades(CodActividad)
        ON DELETE CASCADE
) ENGINE=InnoDB;