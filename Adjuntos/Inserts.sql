INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Juan', 'Pérez', 30123456, '1985-05-15', 'Calle Falsa 123', '1156789012', 'juan.perez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-30123456', 30123456, 1, '2023-01-10', 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-30123456', 1, DATE_SUB(CURDATE(), INTERVAL 3 DAY), 25000.00, 0, 'SOC-30123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('María', 'Gómez', 28987654, '1990-08-22', 'Av. Siempreviva 742', '1165432109', 'maria.gomez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-28987654', 28987654, 1, '2023-02-15', 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-28987654', 1, DATE_SUB(CURDATE(), INTERVAL 1 DAY), 25000.00, 0, 'SOC-28987654');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Carlos', 'López', 32123456, '1988-11-30', 'Calle 5 789', '1145678901', 'carlos.lopez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-32123456', 32123456, 1, '2023-03-05', 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-32123456', 1, DATE_SUB(CURDATE(), INTERVAL 4 DAY), 25000.00, 0, 'SOC-32123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Ana', 'Rodríguez', 27876543, '1992-04-18', 'Av. Libertador 456', '1154321098', 'ana.rodriguez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-27876543', 27876543, 1, '2023-04-20', 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-27876543', 1, DATE_SUB(CURDATE(), INTERVAL 2 DAY), 25000.00, 0, 'SOC-27876543');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Luis', 'Martínez', 33456789, '1987-07-12', 'Calle 10 234', '1167890123', 'luis.martinez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-33456789', 33456789, 1, '2023-05-10', 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-33456789', 1, DATE_ADD(CURDATE(), INTERVAL 10 DAY), 25000.00, 1, 'SOC-33456789');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Laura', 'Fernández', 34567890, '1995-09-25', 'Av. Corrientes 1234', '1178901234', 'laura.fernandez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-34567890', 34567890, 1, '2023-06-15', 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-34567890', 1, DATE_ADD(CURDATE(), INTERVAL 15 DAY), 25000.00, 1, 'SOC-34567890');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Pedro', 'García', 35678901, '1980-12-05', 'Calle 20 345', '1189012345', 'pedro.garcia@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-35678901', 35678901, 1, '2022-11-01', 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-35678901', 1, '2022-12-01', 25000.00, 1, 'Transferencia', '2022-11-30', 'SOC-35678901');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-02-SOC-35678901', 2, '2023-01-01', 25000.00, 1, 'Efectivo', '2022-12-28', 'SOC-35678901');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-03-SOC-35678901', 3, DATE_ADD(CURDATE(), INTERVAL 5 DAY), 25000.00, 0, 'SOC-35678901');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Sofía', 'Díaz', 36789012, '1993-03-20', 'Av. Rivadavia 5678', '1190123456', 'sofia.diaz@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-36789012', 36789012, 1, '2022-10-15', 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-36789012', 1, DATE_SUB(CURDATE(), INTERVAL 4 DAY), 25000.00, 0, 'SOC-36789012');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Diego', 'Sánchez', 37890123, '1983-06-08', 'Calle 30 678', '1101234567', 'diego.sanchez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-37890123', 37890123, 1, '2023-07-01', 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-37890123', 1, DATE_ADD(CURDATE(), INTERVAL 20 DAY), 25000.00, 1, 'SOC-37890123');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Valeria', 'Torres', 38901234, '1998-01-30', 'Av. Santa Fe 987', '1112345678', 'valeria.torres@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-38901234', 38901234, 1, '2023-08-05', 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-01-SOC-38901234', 1, DATE_ADD(CURDATE(), INTERVAL 12 DAY), 25000.00, 1, 'SOC-38901234');