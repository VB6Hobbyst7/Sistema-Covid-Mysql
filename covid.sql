-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-11-2020 a las 03:29:40
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `covid`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientescovid`
--

CREATE TABLE `pacientescovid` (
  `Id` int(11) NOT NULL,
  `Paciente` varchar(250) NOT NULL,
  `Estado` varchar(250) NOT NULL,
  `StatusCovid` varchar(50) NOT NULL,
  `Obesidad` varchar(2) NOT NULL DEFAULT 'NO',
  `Diabetes` varchar(2) NOT NULL DEFAULT 'NO',
  `Hipertencion` varchar(2) NOT NULL DEFAULT 'NO',
  `TosSeca` varchar(2) NOT NULL DEFAULT 'NO',
  `Cansancio` varchar(2) NOT NULL DEFAULT 'NO',
  `Fiebre` varchar(2) NOT NULL DEFAULT 'NO',
  `Edad` varchar(3) NOT NULL,
  `Otras_Enfermedades` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pacientescovid`
--

INSERT INTO `pacientescovid` (`Id`, `Paciente`, `Estado`, `StatusCovid`, `Obesidad`, `Diabetes`, `Hipertencion`, `TosSeca`, `Cansancio`, `Fiebre`, `Edad`, `Otras_Enfermedades`) VALUES
(7, 'kevin', 'aguascalientes', 'confirmado', 'SI', 'SI', 'SI', 'SI', 'SI', 'SI', '22', '...');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `pacientescovid`
--
ALTER TABLE `pacientescovid`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `pacientescovid`
--
ALTER TABLE `pacientescovid`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
