-- =============================================
-- DOCUMENTACIÓN DE LOS DATOS INSERTADOS
-- =============================================
/*
SCRIPT DE INSERCIÓN DE DATOS PARA CLUB DEPORTIVO

Versión: 1.0
Autor: EQUIPO 6 - DSOO 1er CUATRIMESTRE 2025
Fecha: 21/06/2025

Descripción: 
  Este script carga datos de prueba para el sistema del club deportivo, incluyendo:
  - 10 socios registrados (5 morosos, 2 con cuotas que vencen hoy)
  - 8 no socios con cuotas diarias
  - 8 actividades disponibles 
  - 32 cuotas mensuales (24 pagadas, 8 pendientes)
  - 14 cuotas diarias
  - Todos los tipos de pago utilizados con diversas combinaciones
  - Datos variados para probar todas las funcionalidades:
      * Morosidad
      * Pagos adelantados
      * Diferentes métodos de pago
      * Actividades diversas
      * Fechas realistas para pruebas
*/

USE clubdeportivo;

-- =============================================
-- INSERCIÓN DE ACTIVIDADES
-- =============================================

INSERT INTO Actividades (CodActividad, Nombre, Valor, Horario)
VALUES 
('ACT-Musculacion', 'Musculacion', 3500.00, 'Lun a Vie - 07:00 a 22:00 | Sab - 10:00 a 17:00'),
('ACT-Boxeo', 'Boxeo', 2500.00, 'Lun | Mie | Vie - 18:00 a 20:00'),
('ACT-Zumba', 'Zumba', 2800.00, 'Lun y Jue - 18:30 a 19:30'),
('ACT-TaeKwonDo', 'TaeKwonDo', 3200.00, 'Mar y Jue - 17:00 a 18:30 '),
('ACT-Futbol', 'Fútbol', 4000.00, 'Mie - 16:00 a 18:00 | Sab - 15:00 a 17:00'),
('ACT-Basquet', 'Básquet', 3800.00, 'Lun y Vie - 20:00 a 22:00 | Dom - 11:00 a 13:00'),
('ACT-Atletismo', 'Atletismo', 2200.00, 'Lun a Vie - 07:00 a 09:00'),
('ACT-Crossfit', 'Crossfit', 4500.00, 'Lun a Vie - 07:00 a 21:00 | Sab - 09:00 a 13:00');

-- =============================================
-- INSERCIÓN DE CLIENTES Y SOCIOS
-- =============================================

-- Socio 1: Al día con sus pagos
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Martín', 'Gutiérrez', 35123456, '1986-09-14', 'Av. Belgrano 1234', '1145678901', 'martin.gutierrez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-35123456', 35123456, 1, DATE_SUB(CURDATE(), INTERVAL 6 MONTH), 0, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-35123456', 1, DATE_SUB(CURDATE(), INTERVAL 5 MONTH) + INTERVAL 2 DAY, 25000.00, 1, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 5 MONTH) + INTERVAL 2 DAY, 'SOC-35123456'),
('CUOTA-02-SOC-35123456', 2, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 2 DAY, 25000.00, 1, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 2 DAY, 'SOC-35123456'),
('CUOTA-03-SOC-35123456', 3, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 2 DAY, 25000.00, 1, 'QR', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 2 DAY, 'SOC-35123456'),
('CUOTA-04-SOC-35123456', 4, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 2 DAY, 25000.00, 1, 'Tarjeta de débito', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 2 DAY, 'SOC-35123456'),
('CUOTA-05-SOC-35123456', 5, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) + INTERVAL 2 DAY, 25000.00, 1, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) + INTERVAL 2 DAY, 'SOC-35123456'),
('CUOTA-06-SOC-35123456', 6, DATE_ADD(CURDATE(), INTERVAL 2 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-35123456');

-- Socio 2: Al día con pagos variados
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Lucía', 'Pereyra', 36123456, '1991-03-22', 'Calle Chile 567', '1156789012', 'lucia.pereyra@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-36123456', 36123456, 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) - INTERVAL 10 DAY, 0, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-36123456', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) - INTERVAL 5 DAY, 25000.00, 1, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) - INTERVAL 5 DAY, 'SOC-36123456'),
('CUOTA-02-SOC-36123456', 2, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) - INTERVAL 5 DAY, 25000.00, 1, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) - INTERVAL 5 DAY, 'SOC-36123456'),
('CUOTA-03-SOC-36123456', 3, DATE_ADD(CURDATE(), INTERVAL 2 MONTH) - INTERVAL 5 DAY, 25000.00, 0, NULL, NULL, NULL, 'SOC-36123456');

-- Socio 3: Moroso (5 días de atraso)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Gustavo', 'Mendoza', 37123456, '1984-07-30', 'Av. San Martín 890', '1167890123', 'gustavo.mendoza@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-37123456', 37123456, 1, DATE_SUB(CURDATE(), INTERVAL 5 MONTH) + INTERVAL 7 DAY, 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-37123456', 1, DATE_SUB(CURDATE(), INTERVAL 5 MONTH) + INTERVAL 7 DAY, 25000.00, 1, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 5 MONTH) + INTERVAL 7 DAY, 'SOC-37123456'),
('CUOTA-02-SOC-37123456', 2, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 7 DAY, 25000.00, 1, 'QR', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 7 DAY, 'SOC-37123456'),
('CUOTA-03-SOC-37123456', 3, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 7 DAY, 25000.00, 1, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 7 DAY, 'SOC-37123456'),
('CUOTA-04-SOC-37123456', 4, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 7 DAY, 25000.00, 1, 'Tarjeta de débito', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 7 DAY, 'SOC-37123456'),
('CUOTA-05-SOC-37123456', 5, DATE_SUB(CURDATE(), INTERVAL 5 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-37123456');

-- Socio 4: Moroso (8 días de atraso)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Florencia', 'Ríos', 38123456, '1995-11-18', 'Calle Uruguay 345', '1178901234', 'florencia.rios@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-38123456', 38123456, 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 3 DAY, 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-38123456', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 3 DAY, 25000.00, 1, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 3 DAY, 'SOC-38123456'),
('CUOTA-02-SOC-38123456', 2, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) - INTERVAL 3 DAY, 25000.00, 1, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) - INTERVAL 3 DAY, 'SOC-38123456'),
('CUOTA-03-SOC-38123456', 3, DATE_SUB(CURDATE(), INTERVAL 8 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-38123456');

-- Socio 5: Moroso (3 días de atraso)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Ricardo', 'Silva', 39123456, '1989-05-25', 'Av. Colón 678', '1189012345', 'ricardo.silva@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-39123456', 39123456, 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 4 DAY, 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-39123456', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 4 DAY, 25000.00, 1, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH) + INTERVAL 4 DAY, 'SOC-39123456'),
('CUOTA-02-SOC-39123456', 2, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 4 DAY, 25000.00, 1, 'Tarjeta de crédito', 6, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) + INTERVAL 4 DAY, 'SOC-39123456'),
('CUOTA-03-SOC-39123456', 3, DATE_SUB(CURDATE(), INTERVAL 3 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-39123456');

-- Socio 6: Al día con pagos variados
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Carolina', 'Vega', 40123456, '1992-08-12', 'Av. Libertador 123', '1190123456', 'carolina.vega@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-40123456', 40123456, 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 8 DAY, 0, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-40123456', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 8 DAY, 25000.00, 1, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH) - INTERVAL 8 DAY, 'SOC-40123456'),
('CUOTA-02-SOC-40123456', 2, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) - INTERVAL 8 DAY, 25000.00, 1, 'Tarjeta de crédito', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) - INTERVAL 8 DAY, 'SOC-40123456'),
('CUOTA-03-SOC-40123456', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) - INTERVAL 8 DAY, 25000.00, 1, 'QR', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH) - INTERVAL 8 DAY, 'SOC-40123456'),
('CUOTA-04-SOC-40123456', 4, DATE_ADD(CURDATE(), INTERVAL 22 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-40123456');

-- Socio 7: Al día con pago único adelantado
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Diego', 'López', 41123456, '1987-12-05', 'Calle Sarmiento 456', '1101234567', 'diego.lopez@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-41123456', 41123456, 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 12 DAY, 0, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-41123456', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 12 DAY, 25000.00, 1, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH) + INTERVAL 12 DAY, 'SOC-41123456'),
('CUOTA-02-SOC-41123456', 2, DATE_ADD(CURDATE(), INTERVAL 12 DAY), 25000.00, 0, NULL, NULL, NULL, 'SOC-41123456');

-- Socio 8: Entra en mora hoy (probar requerimiento del Proyecto)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Maximiliano', 'Pagadios', 33435132, '1989-04-05', 'Azcuenaga 3123', '1155333567', 'maxi.godpayer@gmail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-33435132', 33435132, 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-33435132', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 25000.00, 1, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-33435132'),
('CUOTA-02-SOC-33435132', 2, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 'SOC-33435132'),
('CUOTA-03-SOC-33435132', 3, CURDATE(), 25000.00, 0, NULL, NULL, NULL, 'SOC-33435132');

-- Socio 9: Moroso hoy mismo (para probar funcionalidad)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Valentina', 'Morales', 45123456, '1990-02-14', 'Av. Corrientes 1234', '1145678901', 'valentina.morales@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-45123456', 45123456, 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-45123456', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 25000.00, 1, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 3 MONTH), 'SOC-45123456'),
('CUOTA-02-SOC-45123456', 2, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 25000.00, 1, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 2 MONTH), 'SOC-45123456'),
('CUOTA-03-SOC-45123456', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'QR', 1, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 'SOC-45123456'),
('CUOTA-04-SOC-45123456', 4, CURDATE(), 25000.00, 0, NULL, NULL, NULL, 'SOC-45123456');

-- Socio 10: Moroso hoy mismo (segundo caso)
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Roberto', 'García', 46123456, '1983-09-28', 'Calle Lavalle 567', '1156789012', 'roberto.garcia@mail.com', 1);

INSERT INTO Socio (CodSocio, Dni, Carnet, FechaInscripcion, Moroso, Activo)
VALUES ('SOC-46123456', 46123456, 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH), 1, 1);

INSERT INTO CuotaMensual (CodCuotaMensual, NroCuota, Vencimiento, ValorMensual, Pagada, TipoDePago, CantidadCuotas, FechaDePago, CodSocio)
VALUES 
('CUOTA-01-SOC-46123456', 1, DATE_SUB(CURDATE(), INTERVAL 4 MONTH), 25000.00, 1, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 4 MONTH), 'SOC-46123456'),
('CUOTA-02-SOC-46123456', 2, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 25000.00, 1, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 1 MONTH), 'SOC-46123456'),
('CUOTA-03-SOC-46123456', 3, CURDATE(), 25000.00, 0, NULL, NULL, NULL, 'SOC-46123456');

-- =============================================
-- INSERCIÓN DE NO SOCIOS
-- =============================================

-- No Socio 1
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Marta', 'Gómez', 42123456, '1980-04-15', 'Av. Rivadavia 789', '1112345678', 'marta.gomez@mail.com', 0);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-42123456', 42123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-42123456', 1, 3500.00, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 5 DAY), DATE_SUB(CURDATE(), INTERVAL 5 DAY), 'NOSOC-42123456', 'ACT-Musculacion'),
('CUOTA-02-NOSOC-42123456', 1, 2500.00, 'QR', 1, DATE_SUB(CURDATE(), INTERVAL 3 DAY), DATE_SUB(CURDATE(), INTERVAL 3 DAY), 'NOSOC-42123456', 'ACT-Boxeo');

-- No Socio 2
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Jorge', 'Pérez', 43123456, '1975-10-22', 'Calle Mitre 321', '1123456789', 'jorge.perez@mail.com', 0);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-43123456', 43123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-43123456', 1, 3500.00, 'Tarjeta de débito', 1, DATE_SUB(CURDATE(), INTERVAL 2 DAY), DATE_SUB(CURDATE(), INTERVAL 2 DAY), 'NOSOC-43123456', 'ACT-Musculacion'),
('CUOTA-02-NOSOC-43123456', 1, 2500.00, 'Tarjeta de débito', 1, CURDATE(), CURDATE(), 'NOSOC-43123456', 'ACT-Boxeo');

-- No Socio 3
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Ana', 'Rodríguez', 44123456, '1993-07-30', 'Av. Santa Fe 654', '1134567890', 'ana.rodriguez@mail.com', 1);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-44123456', 44123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-44123456', 1, 2500.00, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 1 DAY), DATE_SUB(CURDATE(), INTERVAL 1 DAY), 'NOSOC-44123456', 'ACT-Boxeo'),
('CUOTA-02-NOSOC-44123456', 1, 3500.00, 'Efectivo', 1, CURDATE(), CURDATE(), 'NOSOC-44123456', 'ACT-Musculacion');

-- No Socio 4
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Fernando', 'López', 47123456, '1988-06-17', 'Av. Callao 890', '1167890123', 'fernando.lopez@mail.com', 0);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-47123456', 47123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-47123456', 1, 2800.00, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 4 DAY), DATE_SUB(CURDATE(), INTERVAL 4 DAY), 'NOSOC-47123456', 'ACT-Zumba'),
('CUOTA-02-NOSOC-47123456', 1, 3200.00, 'Tarjeta de crédito', 3, DATE_SUB(CURDATE(), INTERVAL 2 DAY), DATE_SUB(CURDATE(), INTERVAL 2 DAY), 'NOSOC-47123456', 'ACT-TaeKwonDo');

-- No Socio 5
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Patricia', 'Martínez', 48123456, '1979-11-05', 'Calle Paraguay 345', '1178901234', 'patricia.martinez@mail.com', 1);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-48123456', 48123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-48123456', 1, 4000.00, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 3 DAY), DATE_SUB(CURDATE(), INTERVAL 3 DAY), 'NOSOC-48123456', 'ACT-Futbol'),
('CUOTA-02-NOSOC-48123456', 1, 3800.00, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 3 DAY), CURDATE(), 'NOSOC-48123456', 'ACT-Basquet');

-- No Socio 6
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Sergio', 'Díaz', 49123456, '1994-03-22', 'Av. Pueyrredón 678', '1189012345', 'sergio.diaz@mail.com', 0);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-49123456', 49123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-49123456', 1, 2200.00, 'Transferencia', 1, DATE_SUB(CURDATE(), INTERVAL 1 DAY), DATE_SUB(CURDATE(), INTERVAL 1 DAY), 'NOSOC-49123456', 'ACT-Atletismo'),
('CUOTA-02-NOSOC-49123456', 1, 4500.00, 'QR', 1, CURDATE(), CURDATE(), 'NOSOC-49123456', 'ACT-Crossfit');

-- No Socio 7
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Lucila', 'Fernández', 50123456, '1991-07-30', 'Calle Suipacha 321', '1190123456', 'lucila.fernandez@mail.com', 1);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-50123456', 50123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-50123456', 1, 3500.00, 'Tarjeta de débito', 1, DATE_SUB(CURDATE(), INTERVAL 5 DAY), DATE_SUB(CURDATE(), INTERVAL 5 DAY), 'NOSOC-50123456', 'ACT-Musculacion'),
('CUOTA-02-NOSOC-50123456', 1, 2500.00, 'Adelanto', 1, DATE_SUB(CURDATE(), INTERVAL 3 DAY), DATE_SUB(CURDATE(), INTERVAL 3 DAY), 'NOSOC-50123456', 'ACT-Boxeo');

-- No Socio 8
INSERT INTO Clientes (nombre, apellido, dni, fecha_nac, direccion, telefono, email, ficha_medica)
VALUES ('Gabriel', 'Sánchez', 51123456, '1985-12-12', 'Av. Santa Fe 654', '1101234567', 'gabriel.sanchez@mail.com', 0);

INSERT INTO NoSocios (CodNoSocio, Dni)
VALUES ('NOSOC-51123456', 51123456);

INSERT INTO CuotaDiaria (CodCuotaDiaria, Pagada, ValorFinal, TipoDePago, CantidadCuotas, FechaDePago, FechaDeUso, CodNoSocio, CodActividad)
VALUES 
('CUOTA-01-NOSOC-51123456', 1, 2800.00, 'Efectivo', 1, DATE_SUB(CURDATE(), INTERVAL 2 DAY), DATE_SUB(CURDATE(), INTERVAL 2 DAY), 'NOSOC-51123456', 'ACT-Zumba'),
('CUOTA-02-NOSOC-51123456', 1, 3200.00, 'Efectivo', 1, DATE_ADD(CURDATE(), INTERVAL 1 DAY), DATE_ADD(CURDATE(), INTERVAL 1 DAY), 'NOSOC-51123456', 'ACT-TaeKwonDo');