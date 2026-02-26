-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-02-2026 a las 12:12:14
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `taller_carlos_cosa`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `idCliente` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `telefono` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`idCliente`, `nombre`, `apellidos`, `telefono`) VALUES
(3, 'Carlos', 'Cosa', 0),
(4, 'Carlos', 'Cosa', 0),
(5, 'Carlos', 'Cosa', 0),
(6, 'Carlos', 'Cosa', 0),
(7, 'Carlos', 'Cosa', 0),
(8, 'Carlos', 'Cosa', 0),
(9, 'Carlos', 'Cosa', 0),
(10, 'Carlos', 'Cosa', 0),
(11, 'Carlos', 'Cosa', 0),
(12, 'Antonio', 'Perez', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `coches`
--

CREATE TABLE `coches` (
  `idCoche` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `anio` int(4) NOT NULL,
  `numeroChasis` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `coches`
--

INSERT INTO `coches` (`idCoche`, `marca`, `modelo`, `anio`, `numeroChasis`) VALUES
(2, 'Renault', 'dssd', 2004, 'ASD12125'),
(3, 'Peugeot', 'dssd', 2004, 'ASD12125'),
(4, 'Audi', 'dssd', 2004, 'ASD12125'),
(5, 'prueba', 'prueba', 2021, 'ASD45545'),
(6, 'prueba', 'prueba', 2021, 'ASD45545'),
(7, 'prueba', 'prueba', 2021, 'ASD45545'),
(10, 'd', 'd', 5, 'd'),
(11, 'd', 'd', 5, 'd'),
(12, 'd', 'd', 5, 'd'),
(13, 'd', 'd', 5, 'd'),
(14, 'd', 'd', 5, 'd'),
(15, 'dsdd', 'dsds', 544, 'ds');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `coches`
--
ALTER TABLE `coches`
  ADD PRIMARY KEY (`idCoche`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `coches`
--
ALTER TABLE `coches`
  MODIFY `idCoche` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
