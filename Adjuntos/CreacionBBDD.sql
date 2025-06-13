USE clubdeportivo;

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password_hash` varchar(255) DEFAULT NULL,
  `rol` varchar(20) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `dni` int DEFAULT NULL,
  `fecha_nac` datetime DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `ficha_medica` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `socio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socio` (
  `CodSocio` varchar(50) NOT NULL,
  `Dni` int DEFAULT NULL,
  `Carnet` bit(1) DEFAULT NULL,
  `FechaInscripcion` varchar(20) DEFAULT NULL,
  `Moroso` bit(1) DEFAULT NULL,
  PRIMARY KEY (`CodSocio`),
  KEY `fk_Clientes_Socio` (`Dni`),
  CONSTRAINT `fk_Clientes_Socio` FOREIGN KEY (`Dni`) REFERENCES `clientes` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;


DROP TABLE IF EXISTS `nosocios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocios` (
  `CodNoSocio` varchar(50) NOT NULL,
  `Dni` int DEFAULT NULL,
  PRIMARY KEY (`CodNoSocio`),
  KEY `fk_Clientes` (`Dni`),
  CONSTRAINT `fk_Clientes` FOREIGN KEY (`Dni`) REFERENCES `clientes` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `cuotamensual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuotamensual` (
  `CodCuota` varchar(50) NOT NULL,
  `NroCuota` int NOT NULL,
  `Vencimiento` datetime NOT NULL,
  `ValorMensual` float NOT NULL,
  `TipoDePago` varchar(50) NOT NULL,
  `CodSocio` varchar(50) NOT NULL,
  `Pagada` bit(1) DEFAULT b'0',
  PRIMARY KEY (`CodCuota`),
  KEY `fk_CodSocio` (`CodSocio`),
  CONSTRAINT `fk_CodSocio` FOREIGN KEY (`CodSocio`) REFERENCES `socio` (`CodSocio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `cuotadiaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuotadiaria` (
  `CodCuota` varchar(50) NOT NULL,
  `ValorFinal` float NOT NULL,
  `TipoDePago` varchar(50) NOT NULL,
  `CodNoSocio` varchar(50) NOT NULL,
  PRIMARY KEY (`CodCuota`),
  KEY `fk_CodNoSocio` (`CodNoSocio`),
  CONSTRAINT `fk_CodNoSocio` FOREIGN KEY (`CodNoSocio`) REFERENCES `nosocios` (`CodNoSocio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `actividades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actividades` (
  `CodActividad` varchar(50) NOT NULL,
  `CodNoSocio` varchar(50) DEFAULT NULL,
  `CodCuotaDiaria` varchar(50) DEFAULT NULL,
  `Nombre` varchar(150) DEFAULT NULL,
  `Valor` float DEFAULT NULL,
  `Horario` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`CodActividad`),
  KEY `fk_NoSocio` (`CodNoSocio`),
  KEY `fk_CuotaDiaria` (`CodCuotaDiaria`),
  CONSTRAINT `fk_CuotaDiaria` FOREIGN KEY (`CodCuotaDiaria`) REFERENCES `cuotadiaria` (`CodCuota`),
  CONSTRAINT `fk_NoSocio` FOREIGN KEY (`CodNoSocio`) REFERENCES `nosocios` (`CodNoSocio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;