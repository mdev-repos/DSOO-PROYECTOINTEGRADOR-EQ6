INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Martín', 'Gutiérrez', 35123456, '1986-09-14', 'Av. Belgrano 1234', '1145678901', 'martin.gutierrez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-35123456', 35123456, 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH), 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-35123456', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 25000.00, 1, 'Efectivo', DATE_SUB(CURDATE(), INTERVAL 4 MONTH), 'SOC-35123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-02-SOC-35123456', 2, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 25000.00, 1, 'Transferencia', DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 'SOC-35123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-03-SOC-35123456', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Débito', DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-35123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-04-SOC-35123456', 4, DATE_ADD(CURDATE(), INTERVAL 20 DAY), 25000.00, 0, 'SOC-35123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Lucía', 'Pereyra', 36123456, '1991-03-22', 'Calle Chile 567', '1156789012', 'lucia.pereyra@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-36123456', 36123456, 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-36123456', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Efectivo', DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-36123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-02-SOC-36123456', 2, DATE_ADD(CURDATE(), INTERVAL 20 DAY), 25000.00, 0, 'SOC-36123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Gustavo', 'Mendoza', 37123456, '1984-07-30', 'Av. San Martín 890', '1167890123', 'gustavo.mendoza@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-37123456', 37123456, 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 0);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-37123456', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Débito', DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-37123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-02-SOC-37123456', 2, DATE_ADD(CURDATE(), INTERVAL 20 DAY), 25000.00, 0, 'SOC-37123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Florencia', 'Ríos', 38123456, '1995-11-18', 'Calle Uruguay 345', '1178901234', 'florencia.rios@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-38123456', 38123456, 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-38123456', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 25000.00, 1, 'Efectivo', DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 'SOC-38123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-02-SOC-38123456', 2, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Transferencia', DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-38123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-03-SOC-38123456', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 0, 'SOC-38123456');

INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Ricardo', 'Silva', 39123456, '1989-05-25', 'Av. Colón 678', '1189012345', 'ricardo.silva@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso)
VALUES ('SOC-39123456', 39123456, 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-01-SOC-39123456', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 25000.00, 1, 'Transferencia', DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 'SOC-39123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, FechaDePago, CodSocio)
VALUES ('CUOTA-02-SOC-39123456', 2, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Débito', DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-39123456');

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, CodSocio)
VALUES ('CUOTA-03-SOC-39123456', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 0, 'SOC-39123456');