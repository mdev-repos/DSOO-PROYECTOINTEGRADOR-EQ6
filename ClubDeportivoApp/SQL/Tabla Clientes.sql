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
