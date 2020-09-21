-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.11-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para apuestas
CREATE DATABASE IF NOT EXISTS `apuestas` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci */;
USE `apuestas`;

-- Volcando estructura para tabla apuestas.apuesta
CREATE TABLE IF NOT EXISTS `apuesta` (
  `ID` int(11) NOT NULL,
  `Tipo` int(11) DEFAULT NULL,
  `Cuota` int(11) DEFAULT NULL,
  `Dinero_apuesta` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_apuesta_usuario` (`Usuario`),
  KEY `FK_apuesta_mercado` (`Tipo`),
  CONSTRAINT `FK_apuesta_mercado` FOREIGN KEY (`Tipo`) REFERENCES `mercado` (`over/under`),
  CONSTRAINT `FK_apuesta_usuario` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.apuesta: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `apuesta` DISABLE KEYS */;
INSERT INTO `apuesta` (`ID`, `Tipo`, `Cuota`, `Dinero_apuesta`, `Fecha`, `Usuario`) VALUES
	(1, 1, 20, 100, '2020-09-16', 'algo@gmail.com');
/*!40000 ALTER TABLE `apuesta` ENABLE KEYS */;

-- Volcando estructura para tabla apuestas.cuenta
CREATE TABLE IF NOT EXISTS `cuenta` (
  `Num_tarjeta` int(11) DEFAULT NULL,
  `Saldo_actual` int(11) DEFAULT NULL,
  `Nombre_banco` varchar(50) DEFAULT NULL,
  `Usuario` varchar(50) DEFAULT NULL,
  KEY `FK_cuenta_usuario` (`Usuario`),
  CONSTRAINT `FK_cuenta_usuario` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.cuenta: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;
INSERT INTO `cuenta` (`Num_tarjeta`, `Saldo_actual`, `Nombre_banco`, `Usuario`) VALUES
	(123456789, 150, 'Bankia', 'algo@gmail.com');
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

-- Volcando estructura para tabla apuestas.evento
CREATE TABLE IF NOT EXISTS `evento` (
  `Equipo local` varchar(50) DEFAULT NULL,
  `Equipo visitante` varchar(50) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.evento: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` (`Equipo local`, `Equipo visitante`, `Fecha`, `ID`) VALUES
	('Levante', 'Malaga', '2020-10-10', 1);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;

-- Volcando estructura para tabla apuestas.mercado
CREATE TABLE IF NOT EXISTS `mercado` (
  `over/under` int(11) NOT NULL,
  `Cuota_over` double DEFAULT NULL,
  `Cuota_under` double DEFAULT NULL,
  `Dinero_over` double DEFAULT NULL,
  `Dinero_under` double DEFAULT NULL,
  `Partido` int(11) DEFAULT NULL,
  PRIMARY KEY (`over/under`),
  KEY `FK_tipo_mercado_evento` (`Partido`),
  CONSTRAINT `FK_tipo_mercado_evento` FOREIGN KEY (`Partido`) REFERENCES `evento` (`ID`),
  CONSTRAINT `FK_tipo_mercado_mercados` FOREIGN KEY (`over/under`) REFERENCES `tipo_mercado` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.mercado: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `mercado` DISABLE KEYS */;
INSERT INTO `mercado` (`over/under`, `Cuota_over`, `Cuota_under`, `Dinero_over`, `Dinero_under`, `Partido`) VALUES
	(1, 1.45, 2.67, 3.45, 1.32, 1);
/*!40000 ALTER TABLE `mercado` ENABLE KEYS */;

-- Volcando estructura para tabla apuestas.tipo_mercado
CREATE TABLE IF NOT EXISTS `tipo_mercado` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` double DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.tipo_mercado: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tipo_mercado` DISABLE KEYS */;
INSERT INTO `tipo_mercado` (`ID`, `Tipo`) VALUES
	(1, 1.5),
	(2, 2.5),
	(3, 3.5);
/*!40000 ALTER TABLE `tipo_mercado` ENABLE KEYS */;

-- Volcando estructura para tabla apuestas.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `Email` varchar(50) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellidos` varchar(50) DEFAULT NULL,
  `Edad` int(11) DEFAULT NULL,
  PRIMARY KEY (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla apuestas.usuario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`Email`, `Nombre`, `Apellidos`, `Edad`) VALUES
	('algo@gmail.com', 'Antonio', 'Perez los Santos', 25);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
