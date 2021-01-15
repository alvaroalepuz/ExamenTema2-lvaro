-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-10-2020 a las 21:22:57
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `placemybet`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `apuesta`
--

CREATE TABLE `apuesta` (
  `IdApuesta` int(11) NOT NULL,
  `Tipo` varchar(25) NOT NULL,
  `Dinero` double NOT NULL,
  `MercadoIDFK` int(11) NOT NULL,
  `Email` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `casaapuestas`
--

CREATE TABLE `casaapuestas` (
  `IdCasaApuestas` int(11) NOT NULL,
  `SaldoActual` double NOT NULL,
  `NombreBanco` varchar(30) NOT NULL,
  `NumTarjeta` int(11) NOT NULL,
  `CorreoIDFK` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evento`
--

CREATE TABLE `evento` (
  `IdEvento` int(11) NOT NULL,
  `NombreELocal` varchar(40) NOT NULL,
  `NombreEVisitante` varchar(40) NOT NULL,
  `Fecha` date NOT NULL,
  `MercadoIDFK2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mercado`
--

CREATE TABLE `mercado` (
  `IDMercado` int(11) NOT NULL,
  `Mercado` double NOT NULL,
  `CuotaOver` double NOT NULL,
  `CuotaUnder` double NOT NULL,
  `DineroOver` double NOT NULL,
  `DineroUnder` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `CorreoIDPK` varchar(20) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Edad` int(3) NOT NULL,
  `CasaApuestasIDFK` int(11) NOT NULL,
  `MercadoIDFK3` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `apuesta`
--
ALTER TABLE `apuesta`
  ADD PRIMARY KEY (`IdApuesta`),
  ADD KEY `MercadoIDFK` (`MercadoIDFK`),
  ADD KEY `Email` (`Email`);

--
-- Indices de la tabla `casaapuestas`
--
ALTER TABLE `casaapuestas`
  ADD PRIMARY KEY (`IdCasaApuestas`),
  ADD KEY `CorreoIDFK` (`CorreoIDFK`);

--
-- Indices de la tabla `evento`
--
ALTER TABLE `evento`
  ADD PRIMARY KEY (`IdEvento`),
  ADD KEY `MercadoIDFK2` (`MercadoIDFK2`);

--
-- Indices de la tabla `mercado`
--
ALTER TABLE `mercado`
  ADD PRIMARY KEY (`IDMercado`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`CorreoIDPK`),
  ADD KEY `CasaApuestasIDFK` (`CasaApuestasIDFK`),
  ADD KEY `MercadoIDFK3` (`MercadoIDFK3`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `apuesta`
--
ALTER TABLE `apuesta`
  MODIFY `IdApuesta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `casaapuestas`
--
ALTER TABLE `casaapuestas`
  MODIFY `IdCasaApuestas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `evento`
--
ALTER TABLE `evento`
  MODIFY `IdEvento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `mercado`
--
ALTER TABLE `mercado`
  MODIFY `IDMercado` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `apuesta`
--
ALTER TABLE `apuesta`
  ADD CONSTRAINT `mercado_ibfk_11` FOREIGN KEY (`MercadoIDFK`) REFERENCES `mercado` (`IDMercado`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `casaapuestas`
--
ALTER TABLE `casaapuestas`
  ADD CONSTRAINT `CorreoFK` FOREIGN KEY (`CorreoIDFK`) REFERENCES `usuarios` (`CorreoIDPK`) ON UPDATE CASCADE,
  ADD CONSTRAINT `casaapuestas_ibfk_1` FOREIGN KEY (`IdCasaApuestas`) REFERENCES `usuarios` (`CasaApuestasIDFK`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `evento`
--
ALTER TABLE `evento`
  ADD CONSTRAINT `mercado_ibfk_3` FOREIGN KEY (`MercadoIDFK2`) REFERENCES `mercado` (`IDMercado`);

--
-- Filtros para la tabla `mercado`
--
ALTER TABLE `mercado`
  ADD CONSTRAINT `mercado_ibfk_2` FOREIGN KEY (`IDMercado`) REFERENCES `usuarios` (`MercadoIDFK3`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`CorreoIDPK`) REFERENCES `apuesta` (`Email`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
