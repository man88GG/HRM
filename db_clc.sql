-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-11-2020 a las 06:38:05
-- Versión del servidor: 10.4.13-MariaDB
-- Versión de PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_clc`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Login', 'Ventana de Ingreso', 1),
(2, 1, 'Mantenimiento Usuario', 'Mantenimientos de usuario', 1),
(3, 1, 'Mantenimiento Aplicacion', 'ABC de las Aplicaciones', 1),
(4, 1, 'Mantenimiento Perfil', 'ABC de perfiles', 1),
(5, 1, 'Asignacion de Aplicaciones a Perfil', 'Asignacion Aplicacion y perfil', 1),
(6, 1, 'Asignacaion de Aplicaciones', 'Asignacion especificas a un usuario', 1),
(7, 1, 'Consulta Aplicacion', 'Mantenimiento de Aplicaciones', 1),
(8, 1, 'Agregar Modulo', 'Mantenimientos de Modulos', 1),
(9, 1, 'Consultar Perfil', 'Consultas de perfiles disponibles', 1),
(10, 1, 'Permisos', 'Asignar permisos a perfiles y aplicaciones', 1),
(11, 1, 'Bitacora', 'Guarda todos los movimientos', 1),
(12, 4, 'PUESTO', 'Mantenimiento de Puestos Empresariales', 1),
(13, 4, 'DEPARTAMENTO_EMPRESARIAL', 'Mantenimiento de Departamentos Empresariales', 1),
(14, 4, 'TIPO_COMPETENCIA', 'Mantenimiento Tipos de Competencias', 1),
(15, 4, 'FALTA', 'Mantenimiento de Faltas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_perfil`
--

CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int(10) NOT NULL,
  `fk_idaplicacion_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_perfil`
--

INSERT INTO `aplicacion_perfil` (`pk_id_aplicacion_perfil`, `fk_idaplicacion_aplicacion_perfil`, `fk_idperfil_aplicacion_perfil`, `fk_idpermiso_aplicacion_perfil`) VALUES
(1, 1, 1, 1),
(2, 4, 1, 2),
(3, 5, 1, 3),
(4, 2, 1, 4),
(5, 3, 1, 5),
(6, 6, 1, 6),
(7, 8, 1, 7),
(8, 2, 3, 8),
(9, 3, 3, 9),
(10, 4, 3, 11),
(11, 2, 4, 12),
(12, 8, 4, 13),
(13, 8, 5, 15),
(14, 12, 1, 1),
(15, 13, 1, 1),
(16, 14, 1, 1),
(17, 15, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_usuario`
--

CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int(10) NOT NULL,
  `fk_idlogin_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_usuario`
--

INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(1, 1, 4, 1),
(2, 1, 5, 2),
(3, 1, 6, 3),
(4, 3, 8, 10),
(5, 4, 6, 14),
(6, 5, 5, 16),
(7, 5, 2, 17),
(8, 6, 12, 10),
(9, 6, 13, 10),
(10, 6, 14, 10),
(11, 6, 15, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ascenso`
--

CREATE TABLE `ascenso` (
  `pk_id_ascenso` int(11) NOT NULL,
  `fk_id_empleado_ascenso` int(11) DEFAULT NULL,
  `fecha_ascenso` varchar(10) DEFAULT NULL,
  `fk_puesto_anterior_ascenso` int(11) NOT NULL,
  `fk_departamento_anterior_ascenso` int(11) DEFAULT NULL,
  `salario_anterior_ascenso` double DEFAULT NULL,
  `fk_puesto_nuevo_ascenso` int(11) DEFAULT NULL,
  `fk_departamento_nuevo_ascenso` int(11) DEFAULT NULL,
  `salario_nuevo_ascenso` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `baja`
--

CREATE TABLE `baja` (
  `pk_id_baja` int(11) NOT NULL,
  `fk_id_empleado_baja` int(11) DEFAULT NULL,
  `fk_id_tipo_baja` int(11) DEFAULT NULL,
  `prestaciones_baja` double DEFAULT NULL,
  `tiempo_laborado_baja` varchar(125) DEFAULT NULL,
  `fecha_despido_baja` varchar(10) DEFAULT NULL,
  `causa_bajas` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `balance_detalle`
--

CREATE TABLE `balance_detalle` (
  `pk_id_balance_encabezado` int(11) NOT NULL,
  `pk_id_cuenta_contable` int(11) NOT NULL,
  `debe_balance_detalle` double DEFAULT NULL,
  `haber_balance_detalle` double DEFAULT NULL,
  `deudor_balance_detalle` double DEFAULT NULL,
  `acreedor_balance_detalle` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `balance_encabezado`
--

CREATE TABLE `balance_encabezado` (
  `pk_id_balance_encabezado` int(11) NOT NULL,
  `descripcion_balance_encabezado` varchar(75) DEFAULT NULL,
  `fecha_creacion_balance_encabezado` datetime DEFAULT NULL,
  `total_debe_haber_balance_encabezado` double DEFAULT NULL,
  `total_deudor_acreedor_balance_encabezado` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `banco`
--

CREATE TABLE `banco` (
  `pk_id_banco` int(11) NOT NULL,
  `nombre_banco` varchar(50) DEFAULT NULL,
  `estado_banco` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `pk_id_bitacora` int(10) NOT NULL,
  `fk_idusuario_bitacora` int(10) DEFAULT NULL,
  `fk_idaplicacion_bitacora` int(10) DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`pk_id_bitacora`, `fk_idusuario_bitacora`, `fk_idaplicacion_bitacora`, `fechahora_bitacora`, `direccionhost_bitacora`, `nombrehost_bitacora`, `accion_bitacora`) VALUES
(1, 6, 1, '08/11/2020 16:50:05', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(2, 6, 1, '08/11/2020 16:56:20', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(3, 6, 1, '08/11/2020 16:58:26', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(4, 6, 1, '08/11/2020 17:01:32', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(5, 6, 1, '08/11/2020 17:06:00', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(6, 6, 1, '08/11/2020 17:07:30', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(7, 6, 1, '08/11/2020 17:10:52', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(8, 6, 1, '08/11/2020 17:14:44', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(9, 6, 1, '08/11/2020 17:14:44', '192.168.0.31', 'LAP_MRJST21', 'Cancelar'),
(10, 6, 1, '08/11/2020 18:31:25', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(11, 6, 1, '08/11/2020 18:31:25', '192.168.0.31', 'LAP_MRJST21', ' INSERT INTO tipo_competencia VALUES ( 1,  Trabajo en Equipo,  1) '),
(12, 6, 1, '08/11/2020 18:34:19', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(13, 6, 1, '08/11/2020 18:34:19', '192.168.0.31', 'LAP_MRJST21', ' INSERT INTO tipo_competencia VALUES ( 2,  Organización,  1) '),
(14, 6, 1, '08/11/2020 18:34:19', '192.168.0.31', 'LAP_MRJST21', ' INSERT INTO tipo_competencia VALUES ( 3,  Comunicación Efectiva,  1) '),
(15, 6, 1, '08/11/2020 18:37:54', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(16, 6, 1, '08/11/2020 18:48:23', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(17, 6, 1, '08/11/2020 18:52:00', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(18, 6, 1, '08/11/2020 19:03:41', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(19, 6, 1, '08/11/2020 19:09:23', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(20, 6, 1, '08/11/2020 19:12:13', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(21, 6, 1, '08/11/2020 19:17:08', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(22, 6, 1, '08/11/2020 19:19:31', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(23, 6, 1, '08/11/2020 19:21:14', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(24, 6, 1, '08/11/2020 19:22:45', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(25, 6, 1, '08/11/2020 19:28:29', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(26, 6, 1, '08/11/2020 19:31:30', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(27, 6, 1, '08/11/2020 19:33:52', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(28, 6, 1, '08/11/2020 19:44:25', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(29, 6, 1, '08/11/2020 20:10:23', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(30, 6, 1, '08/11/2020 20:12:11', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(31, 9, 1, '09/11/2020 10:54:08', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(32, 6, 1, '09/11/2020 11:06:55', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(33, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(34, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(35, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(36, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(37, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(38, 6, 1, '09/11/2020 11:26:17', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(39, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(40, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(41, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(42, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(43, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(44, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(45, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(46, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(47, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(48, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(49, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(50, 6, 1, '09/11/2020 11:32:58', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(51, 6, 1, '09/11/2020 11:56:49', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(52, 6, 1, '09/11/2020 12:18:01', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(53, 6, 1, '09/11/2020 12:18:30', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(54, 6, 1, '09/11/2020 12:38:14', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(55, 6, 1, '09/11/2020 12:43:07', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(56, 6, 1, '09/11/2020 12:47:06', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(57, 6, 1, '09/11/2020 13:11:21', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(58, 6, 1, '09/11/2020 13:11:21', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(59, 6, 1, '09/11/2020 13:18:32', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(60, 6, 1, '09/11/2020 13:18:32', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(61, 6, 1, '09/11/2020 13:18:32', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(62, 6, 1, '09/11/2020 13:18:32', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(63, 6, 1, '09/11/2020 13:20:44', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(64, 6, 1, '09/11/2020 13:20:44', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(65, 6, 1, '09/11/2020 13:20:44', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(66, 6, 1, '09/11/2020 13:20:44', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(67, 6, 1, '09/11/2020 13:20:44', '192.168.0.31', 'LAP_MRJST21', 'Formulario de ayuda'),
(68, 6, 1, '09/11/2020 15:56:09', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(69, 6, 1, '09/11/2020 16:46:16', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(70, 6, 1, '09/11/2020 17:43:25', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(71, 6, 1, '09/11/2020 18:08:49', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(72, 6, 1, '09/11/2020 18:50:13', '192.168.0.31', 'LAP_MRJST21', 'Logeo Exitoso'),
(74, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Logeo Exitoso'),
(75, 7, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Logeo Exitoso'),
(76, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Logeo Exitoso'),
(77, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', ' INSERT INTO puesto VALUES ( 10,  Gerente Informatico,  10000,  3,  1) '),
(78, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'UPDATE puesto SET   nombre_puesto =  Gerente Informatico,  salario_puesto =  5000,  fk_id_horario_puesto =  3,  estado_puesto =  1  WHERE pk_id_puesto = 10; '),
(79, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Formulario de ayuda'),
(80, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Salir de la aplicacion'),
(81, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', ' INSERT INTO departamento_empresarial VALUES ( 9,  Recursos Humanos,  1) '),
(82, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'UPDATE departamento_empresarial SET   nombre_departamento_empresarial =  HRM,  estado_departamento_empresarial =  1  WHERE pk_id__departamento_empresarial = 9; '),
(83, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Formulario de ayuda'),
(84, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', ' INSERT INTO tipo_competencia VALUES ( 4,  Innovación,  1) '),
(85, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', ' INSERT INTO tipo_competencia VALUES ( 5,  Análisis de Datos,  1) '),
(86, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Salir de la aplicacion'),
(87, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', ' INSERT INTO falta VALUES ( 1,  Agresión,  Mala interacción por parte del empleado,  1) '),
(88, 6, 1, '10/11/2020 21:33:37', '192.168.0.29', 'MRJST21', 'Salir de la aplicacion'),
(89, 6, 1, '10/11/2020 22:24:01', '192.168.0.29', 'MRJST21', 'Logeo Exitoso'),
(90, 6, 1, '10/11/2020 22:46:56', '192.168.0.29', 'MRJST21', 'Logeo Exitoso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `pk_id_bodega` int(10) NOT NULL,
  `fk_id_municipio` int(10) NOT NULL,
  `descripcion_bodega` varchar(45) NOT NULL,
  `dimensiones_bodega` double(5,2) NOT NULL,
  `direccion_bodega` varchar(45) NOT NULL,
  `telefono_bodega` int(8) NOT NULL,
  `estado_bodega` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `capacitacion`
--

CREATE TABLE `capacitacion` (
  `pk_id_capacitacion` int(11) NOT NULL,
  `fk_id_encabezado_capacitacion` int(11) DEFAULT NULL,
  `fk_id_empleado_capacitacion` int(11) DEFAULT NULL,
  `resultado_capacitacion` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria_producto`
--

CREATE TABLE `categoria_producto` (
  `pk_id_categoria_producto` int(10) NOT NULL,
  `nombre_categoria_producto` varchar(35) NOT NULL,
  `descripcion_categoria_producto` varchar(60) NOT NULL,
  `estado_categoria_producto` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `pk_id_cliente` int(11) NOT NULL,
  `nit_cliente` varchar(45) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `nombre_cliente` varchar(45) DEFAULT NULL,
  `apellido_cliente` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `correo_cliente` varchar(45) DEFAULT NULL,
  `direccion_cliente` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `competencia_desarrollo`
--

CREATE TABLE `competencia_desarrollo` (
  `pk_id_competencia_desarrollo` int(11) NOT NULL,
  `fk_id_encabezado_competencia` int(11) NOT NULL,
  `fk_id_tipo_competencia_desarrollo` int(11) DEFAULT NULL,
  `resultado_competencia_desarrollo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_detalle`
--

CREATE TABLE `compra_detalle` (
  `fk_id_compra_encabezado` int(10) NOT NULL,
  `cod_linea_compra_detalle` int(10) NOT NULL,
  `fk_id_producto` int(10) NOT NULL,
  `cantidad_compra_detalle` int(10) NOT NULL,
  `precio_unitario_compra_detalle` double(8,2) NOT NULL,
  `subtotal_compra_detalle` double(12,2) NOT NULL,
  `estado_compra_detalle` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_encabezado`
--

CREATE TABLE `compra_encabezado` (
  `pk_id_compra_encabezado` int(10) NOT NULL,
  `fk_id_proveedor` int(10) NOT NULL,
  `estado_proceso_encabezado_compra` int(1) NOT NULL,
  `fec_compra_encabezado_compra` datetime NOT NULL,
  `total_compra_encabezado_compra` double(12,2) NOT NULL,
  `estado_encabezado_compra` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `consulta_inteligente`
--

CREATE TABLE `consulta_inteligente` (
  `pk_id_consulta_inteligente` int(11) NOT NULL,
  `nombre_consulta_inteligente` varchar(100) DEFAULT NULL,
  `contenido_consulta_inteligente` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_asistencia`
--

CREATE TABLE `control_asistencia` (
  `pk_id_control_asistencia` int(11) NOT NULL,
  `fk_id_control_asistencia_empleado` int(11) DEFAULT NULL,
  `fk_id_control_asistencia_encabezado_nomina` int(11) DEFAULT NULL,
  `dias_laborados` int(11) DEFAULT NULL,
  `dias_ausente_justificados` int(11) DEFAULT NULL,
  `dias_ausente_injustificados` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_calidad`
--

CREATE TABLE `control_calidad` (
  `pk_id_control_calidad` int(10) NOT NULL,
  `fk_id_pedido_encabezado_control_calidad` int(11) NOT NULL,
  `fk_id_empleado_control_calidad` int(10) NOT NULL,
  `resultado_control_calidad` varchar(45) DEFAULT NULL,
  `estado_control_calidad` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_empleado`
--

CREATE TABLE `control_empleado` (
  `pk_id_control` int(11) NOT NULL,
  `horas_extras_de_trabajo` varchar(45) DEFAULT NULL,
  `comisiones_ventas` varchar(45) DEFAULT NULL,
  `fk_id_venta` int(11) NOT NULL,
  `fk_id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_horas`
--

CREATE TABLE `control_horas` (
  `pk_id_control_horas` int(11) NOT NULL,
  `fk_id_control_horas_empleado` int(11) DEFAULT NULL,
  `fk_id_control_horas_encabezado_nomina` int(11) DEFAULT NULL,
  `horas_hordinarias` double DEFAULT NULL,
  `horas_extra` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `control_producto`
--

CREATE TABLE `control_producto` (
  `pk_id_control_producto` int(10) NOT NULL,
  `fk_id_pedido_encabezado_control_producto` int(10) DEFAULT NULL,
  `fk_id_estado_produccion_control_producto` int(10) DEFAULT NULL,
  `resultado_control_producto` varchar(45) DEFAULT NULL,
  `estado_control_producto` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `correo_proveedor`
--

CREATE TABLE `correo_proveedor` (
  `pk_id_correo_proveedor` int(10) NOT NULL,
  `fk_id_proveedor` int(10) NOT NULL,
  `correo_correo_proveedor` varchar(50) NOT NULL,
  `estado_correo_proveedor` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE `cotizacion` (
  `pk_id_cotizacion` int(11) NOT NULL,
  `fk_id_cliente` int(11) NOT NULL,
  `fecha_cotizacion` date DEFAULT NULL,
  `total_cotizacion` varchar(45) DEFAULT NULL,
  `estado_cotizacion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_bancaria`
--

CREATE TABLE `cuenta_bancaria` (
  `pk_id_numero_cuenta_bancaria` int(11) NOT NULL,
  `fk_id_banco` int(11) NOT NULL,
  `fk_id_propietario` int(11) NOT NULL,
  `fk_id_tipo_moneda` int(11) NOT NULL,
  `saldo_cuenta_bancaria` double DEFAULT NULL,
  `fecha_apertura_cuenta_bancaria` datetime DEFAULT NULL,
  `estado_apertura_cuenta_bancaria` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_contable`
--

CREATE TABLE `cuenta_contable` (
  `pk_id_cuenta_contable` int(11) NOT NULL,
  `nombre_cuenta_contable` varchar(75) DEFAULT NULL,
  `nivel_cuenta_contable` int(11) DEFAULT NULL,
  `fk_cuenta_padre_cuenta_contable` int(11) DEFAULT NULL,
  `saldo_anterior_cuenta_contable` double DEFAULT NULL,
  `saldo_actual_cuenta_contable` double DEFAULT NULL,
  `cargo_mes_cuenta_contable` double DEFAULT NULL,
  `abono_mes_cuenta_contable` double DEFAULT NULL,
  `cargo_acumulado_cuenta_contable` double DEFAULT NULL,
  `abono_acumulado_cuenta_contable` double DEFAULT NULL,
  `estado_cuenta_contable` tinyint(4) DEFAULT NULL,
  `fk_id_tipo_cuenta_contable` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `curso`
--

CREATE TABLE `curso` (
  `pk_id_curso` int(11) NOT NULL,
  `nombre_curso` varchar(45) DEFAULT NULL,
  `fk_id_empleado_curso` int(11) DEFAULT NULL,
  `detalle_curso` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `curso`
--

INSERT INTO `curso` (`pk_id_curso`, `nombre_curso`, `fk_id_empleado_curso`, `detalle_curso`) VALUES
(1, 'Indrustrias Inteligentes', 1, 'Para conocer la industria'),
(2, 'Empresa Industrial', 2, 'La industria de la empresa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deduccion`
--

CREATE TABLE `deduccion` (
  `pk_id_deduccion` int(11) NOT NULL,
  `nombre_deduccion` varchar(45) DEFAULT NULL,
  `monto_deduccion` double DEFAULT NULL,
  `descripcion_deduccion` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `deduccion`
--

INSERT INTO `deduccion` (`pk_id_deduccion`, `nombre_deduccion`, `monto_deduccion`, `descripcion_deduccion`) VALUES
(1, 'Seguro Médico', 200, 'Seguro médico de la empresa.'),
(2, 'Plan de Ahorro Empresarial', 100, 'Plan de Ahorro Empresarial.'),
(3, 'Transporte de la Empresa', 150, 'Servicio de transporte de la empresa.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `pk_id_departamento` int(10) NOT NULL,
  `nombre_departamento` varchar(30) NOT NULL,
  `descripcion_departamento` varchar(45) NOT NULL,
  `estado_departamento` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento_empresarial`
--

CREATE TABLE `departamento_empresarial` (
  `pk_id__departamento_empresarial` int(11) NOT NULL,
  `nombre_departamento_empresarial` varchar(150) DEFAULT NULL,
  `estado_departamento_empresarial` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `departamento_empresarial`
--

INSERT INTO `departamento_empresarial` (`pk_id__departamento_empresarial`, `nombre_departamento_empresarial`, `estado_departamento_empresarial`) VALUES
(1, 'Recursos Humanos', 1),
(2, 'Financiero', 1),
(3, 'Tecnico', 1),
(4, 'Marketing', 1),
(5, 'Comercial', 1),
(6, 'Compras', 1),
(7, 'Logistica y Operaciones', 1),
(8, 'Control de Gestion', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalles_venta_empleado`
--

CREATE TABLE `detalles_venta_empleado` (
  `fk_id_venta` int(11) NOT NULL,
  `fk_id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_bitacora`
--

CREATE TABLE `detalle_bitacora` (
  `pk_id_detalle_bitacora` int(10) NOT NULL,
  `fk_idbitacora_detalle_bitacora` int(10) DEFAULT NULL,
  `querryantigua_detalle_bitacora` varchar(50) DEFAULT NULL,
  `querrynueva_detalle_bitacora` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_cotizacion`
--

CREATE TABLE `detalle_cotizacion` (
  `fk_id_cotizacion` int(11) NOT NULL,
  `fk_id_producto` int(11) NOT NULL,
  `cantidad_producto` int(11) DEFAULT NULL,
  `precio_producto` float DEFAULT NULL,
  `subtotal_producto` float DEFAULT NULL,
  `descuento_producto` float DEFAULT NULL,
  `subtotal_descuento` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

CREATE TABLE `detalle_factura` (
  `fk_id_factura` int(11) NOT NULL,
  `fk_id_producto` int(11) NOT NULL,
  `DETALLE_FACTURAcol` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descuento` float DEFAULT NULL,
  `subtotal` float DEFAULT NULL,
  `sub_total_descuento` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_hora_empleado`
--

CREATE TABLE `detalle_hora_empleado` (
  `pk_id_detalle_hora_empleado` int(10) NOT NULL,
  `fk_id_hora_empleado_detalle` int(10) DEFAULT NULL,
  `descripcion_detalle_hora_empleado` varchar(250) DEFAULT NULL,
  `tiempo_detalle_hora_empleado` double DEFAULT NULL,
  `estado_detalle_hora_empleado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_nomina`
--

CREATE TABLE `detalle_nomina` (
  `pk_id_detalle_nomina` int(11) NOT NULL,
  `fk_id_encabezado_detalle_nomina` int(11) DEFAULT NULL,
  `fk_id_empleado_detalle_nomina` int(11) DEFAULT NULL,
  `fk_id_percepciones_detalle_nomina` int(11) DEFAULT NULL,
  `fk_id_deducciones_detalle_nomina` int(11) DEFAULT NULL,
  `salario_base_detalle_nomina` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_receta`
--

CREATE TABLE `detalle_receta` (
  `pk_id_detalle_detalle_receta` int(10) NOT NULL,
  `fk_id_receta_encabezado_detalle` int(10) DEFAULT NULL,
  `fk_id_estado_produccion_detalle_receta` int(10) DEFAULT NULL,
  `fk_id_producto_detalle_receta` int(10) DEFAULT NULL,
  `cantidad_detalle_receta` double DEFAULT NULL,
  `costo_unitario_detalle_receta` double DEFAULT NULL,
  `estado_detalle_receta` tinyint(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion`
--

CREATE TABLE `direccion` (
  `pk_id_direccion` int(11) NOT NULL,
  `departamento_direccion` varchar(45) DEFAULT NULL,
  `zona_direccion` varchar(7) DEFAULT NULL,
  `municipio_direccion` varchar(100) DEFAULT NULL,
  `residencia_direccion` varchar(45) DEFAULT NULL,
  `fk_empleado_direccion` int(11) DEFAULT NULL,
  `fk_reclutamiento_direccion` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `direccion`
--

INSERT INTO `direccion` (`pk_id_direccion`, `departamento_direccion`, `zona_direccion`, `municipio_direccion`, `residencia_direccion`, `fk_empleado_direccion`, `fk_reclutamiento_direccion`) VALUES
(1, 'Guatemala', '6', 'Guatemala', '25', NULL, 1),
(2, 'Guatemala', '4', 'Guatemala', '26', NULL, 2),
(3, 'Guatemala', '5', 'Guatemala', '412', NULL, 3),
(4, 'Guatemala', '3', 'Guatemala', '123', NULL, 4),
(5, 'Guatemala', '1', 'Guatemala', '64', NULL, 5),
(6, 'Guatemala', '5', 'Guatemala', '501', NULL, 6),
(7, 'Guatemala', '6', 'Guatemala', '25', 1, NULL),
(8, 'Guatemala', '4', 'Guatemala', '26', 2, NULL),
(9, 'Guatemala', '6', 'Guatemala', '25', 3, NULL),
(10, 'Guatemala', '4', 'Guatemala', '26', 4, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `pk_id_empleado` int(11) NOT NULL,
  `nombre1_empleado` varchar(45) DEFAULT NULL,
  `nombre2_empleado` varchar(45) DEFAULT NULL,
  `apellido1_empleado` varchar(45) DEFAULT NULL,
  `apellido2_empleado` varchar(45) DEFAULT NULL,
  `fecha_nacimiento_empleado` varchar(10) DEFAULT NULL,
  `dpi_empleado` int(11) DEFAULT NULL,
  `fk_id_genero_empleado` int(11) DEFAULT NULL,
  `fk_id_estado_civil_empleado` int(11) DEFAULT NULL,
  `email_empleado` varchar(125) DEFAULT NULL,
  `telefono_empleado` int(11) DEFAULT NULL,
  `numero_iggs_empleado` int(11) DEFAULT NULL,
  `fk_id_licencia_conducir_empleado` int(11) DEFAULT NULL,
  `fk_id_puesto_empleado` int(11) DEFAULT NULL,
  `cuenta_bancaria_empleado` int(11) DEFAULT NULL,
  `fk_id_departamento_empresarial_empleado` int(11) DEFAULT NULL,
  `estado_empleado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`pk_id_empleado`, `nombre1_empleado`, `nombre2_empleado`, `apellido1_empleado`, `apellido2_empleado`, `fecha_nacimiento_empleado`, `dpi_empleado`, `fk_id_genero_empleado`, `fk_id_estado_civil_empleado`, `email_empleado`, `telefono_empleado`, `numero_iggs_empleado`, `fk_id_licencia_conducir_empleado`, `fk_id_puesto_empleado`, `cuenta_bancaria_empleado`, `fk_id_departamento_empresarial_empleado`, `estado_empleado`) VALUES
(1, 'Juan', 'Pablo', 'De Las Casas', 'Galicia', '12/03/1985', 123123123, 1, 1, 'mmeer@micorreo.com', 45984236, 123123, 1, 9, 35555, 1, 1),
(2, 'Pedro', 'Pabo', 'Marino', 'Marrueco', '12/03/1988', 44558877, 1, 2, 'ppmarino@yahoo.com', 44778855, 24556688, 1, 2, 5252, 1, 1),
(3, 'Luis', 'Eduardo', 'Noriega', 'Lopez', '15/03/1990', 23531232, 1, 2, 'noriega@gmail.com', 46851326, 321321, 3, 4, 46815326, 4, 1),
(4, 'Jose', 'Jorge', 'Lopez', 'Barahona', '18/02/1999', 4135412, 1, 2, 'lopez@gmail.com', 10321405, 615320, 4, 3, 4651320, 6, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_capacitacion`
--

CREATE TABLE `encabezado_capacitacion` (
  `pk_id_encabezado_capacitacion` int(11) NOT NULL,
  `fecha_inicio_encabezado_capacitacion` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_capacitacion` varchar(10) DEFAULT NULL,
  `fk_id_curso_encabezado_capacitacion` int(11) DEFAULT NULL,
  `horas_encabezado_capacitacion` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `encabezado_capacitacion`
--

INSERT INTO `encabezado_capacitacion` (`pk_id_encabezado_capacitacion`, `fecha_inicio_encabezado_capacitacion`, `fecha_fin_encabezado_capacitacion`, `fk_id_curso_encabezado_capacitacion`, `horas_encabezado_capacitacion`) VALUES
(1, '10/03/2020', '11/04/2020', 2, 5),
(2, '10/03/2020', '11/04/2020', 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_competencia`
--

CREATE TABLE `encabezado_competencia` (
  `pk_id_encabezado_competencia` int(11) NOT NULL,
  `fk_id_empleado_encabezado_competencia` int(11) DEFAULT NULL,
  `fecha_inicio_encabezado_competencia` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_competencia` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `encabezado_competencia`
--

INSERT INTO `encabezado_competencia` (`pk_id_encabezado_competencia`, `fk_id_empleado_encabezado_competencia`, `fecha_inicio_encabezado_competencia`, `fecha_fin_encabezado_competencia`) VALUES
(1, 3, '1/01/2020', '30/06/2020');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_nomina`
--

CREATE TABLE `encabezado_nomina` (
  `pk_id_encabezado_nomina` int(11) NOT NULL,
  `nombre_encabezado_nomina` varchar(45) DEFAULT NULL,
  `fecha_inicio_encabezado_nomina` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_nomina` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `encabezado_nomina`
--

INSERT INTO `encabezado_nomina` (`pk_id_encabezado_nomina`, `nombre_encabezado_nomina`, `fecha_inicio_encabezado_nomina`, `fecha_fin_encabezado_nomina`) VALUES
(1, 'Periodo Noviembre 2020', '01/11/2020', '01/12/2020');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encargado_bodega`
--

CREATE TABLE `encargado_bodega` (
  `pk_id_encargado_bodega` int(10) NOT NULL,
  `fk_id_empleado` int(10) NOT NULL,
  `fk_id_bodega` int(10) NOT NULL,
  `estado_encargado_bodega` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entrevista`
--

CREATE TABLE `entrevista` (
  `pk_id_entrevista` int(11) NOT NULL,
  `fk_id_empleado_entrevista` int(11) DEFAULT NULL,
  `fk_id_reclutamiento_entrevista` int(11) DEFAULT NULL,
  `fk_id_tipo_entrevista` int(11) DEFAULT NULL,
  `resultado_entrevista` int(11) DEFAULT NULL,
  `comentarios_entrevistador_entrevista` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `entrevista`
--

INSERT INTO `entrevista` (`pk_id_entrevista`, `fk_id_empleado_entrevista`, `fk_id_reclutamiento_entrevista`, `fk_id_tipo_entrevista`, `resultado_entrevista`, `comentarios_entrevistador_entrevista`) VALUES
(1, 1, 3, 3, 1, 'Presenta Iniciativa y buen desempeño'),
(2, 2, 6, 5, 2, 'Tiene un buen conocimiento sobre el tema');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado_civil`
--

CREATE TABLE `estado_civil` (
  `pk_id_estado_civil` int(11) NOT NULL,
  `nombre_estado_civil` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estado_civil`
--

INSERT INTO `estado_civil` (`pk_id_estado_civil`, `nombre_estado_civil`) VALUES
(1, 'Casado'),
(2, 'Soltero'),
(3, 'Divorciado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado_produccion`
--

CREATE TABLE `estado_produccion` (
  `pk_id_estado_produccion` int(10) NOT NULL,
  `nombre_estado_produccion` varchar(45) DEFAULT NULL,
  `duracion_estado_produccion` varchar(45) DEFAULT NULL,
  `estado_estado_produccion` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `existencia`
--

CREATE TABLE `existencia` (
  `pk_id_existencia` int(10) NOT NULL,
  `fk_id_bodega` int(10) NOT NULL,
  `fk_id_producto` int(10) NOT NULL,
  `cantidad_existencia` int(10) NOT NULL,
  `estado_existencia` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fabrica`
--

CREATE TABLE `fabrica` (
  `pk_id_fabrica` int(10) NOT NULL,
  `fk_id_municipio` int(10) NOT NULL,
  `dimensiones_fabrica` double(5,2) NOT NULL,
  `direccion_fabrica` varchar(45) NOT NULL,
  `telefono_fabrica` int(8) NOT NULL,
  `descripcion_fabrica` varchar(45) NOT NULL,
  `estado_fabrica` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `pk_id_factura` int(11) NOT NULL,
  `fk_id_empleado` int(11) NOT NULL,
  `fk_id_cliente` int(11) NOT NULL,
  `fk_id_tipo_venta` int(11) NOT NULL,
  `fecha_factura` datetime DEFAULT NULL,
  `total_factura` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `falta`
--

CREATE TABLE `falta` (
  `pk_id_falta` int(11) NOT NULL,
  `nombre_falta` varchar(45) DEFAULT NULL,
  `descripcion_falta` varchar(45) DEFAULT NULL,
  `estado_falta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `falta`
--

INSERT INTO `falta` (`pk_id_falta`, `nombre_falta`, `descripcion_falta`, `estado_falta`) VALUES
(1, 'Agresión', 'Mala interacción por parte del empleado', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `falta_empleado`
--

CREATE TABLE `falta_empleado` (
  `pk_id_falta_empleado` int(11) NOT NULL,
  `fk_id_empleado_falta_empleado` int(11) DEFAULT NULL,
  `fk_id_tipo_falta_empleado` int(11) DEFAULT NULL,
  `fecha_falta_empleado` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formacion_academica`
--

CREATE TABLE `formacion_academica` (
  `pk_id_formacion_academica` int(11) NOT NULL,
  `nombre_formacion_academica` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `formacion_academica`
--

INSERT INTO `formacion_academica` (`pk_id_formacion_academica`, `nombre_formacion_academica`) VALUES
(1, 'Primaria'),
(2, 'Secundaria'),
(3, 'Basicos'),
(4, 'Diversificado'),
(5, 'Universitario'),
(6, 'Maestria'),
(7, 'Doctorado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genero`
--

CREATE TABLE `genero` (
  `pk_id_genero` int(11) NOT NULL,
  `nombre_genero` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `genero`
--

INSERT INTO `genero` (`pk_id_genero`, `nombre_genero`) VALUES
(1, 'Masculino'),
(2, 'Femenino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horario`
--

CREATE TABLE `horario` (
  `pk_id_horario` int(11) NOT NULL,
  `nombre_horario` varchar(45) DEFAULT NULL,
  `descripcion_horario` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `horario`
--

INSERT INTO `horario` (`pk_id_horario`, `nombre_horario`, `descripcion_horario`) VALUES
(1, 'Matutina', 'Horario entre las 6am hasta 3pm'),
(2, 'Vespertina', 'Desde las 2pm hasta las 9pm'),
(3, 'Nocturno', 'Desde las 10pm hasta las 6am');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `hora_empleado`
--

CREATE TABLE `hora_empleado` (
  `pk_id_hora_empleado` int(10) NOT NULL,
  `fk_id_empleado_hora_empleado` int(10) DEFAULT NULL,
  `fk_id_pedido_encabezado_hora_empleado` int(11) DEFAULT NULL,
  `fecha_hora_empleado` date DEFAULT NULL,
  `estado_hora_empleado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `pk_id_inventario` int(10) NOT NULL,
  `fk_id_producto` int(10) NOT NULL,
  `cantidad_inventario` int(10) NOT NULL,
  `estado_inventario` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `licencia_conduccion`
--

CREATE TABLE `licencia_conduccion` (
  `pk_id_licencia_conduccion` int(11) NOT NULL,
  `tipo_licencia_conduccion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `licencia_conduccion`
--

INSERT INTO `licencia_conduccion` (`pk_id_licencia_conduccion`, `tipo_licencia_conduccion`) VALUES
(1, 'A'),
(2, 'B'),
(3, 'C'),
(4, 'M'),
(5, 'E');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea_producto`
--

CREATE TABLE `linea_producto` (
  `pk_id_linea_producto` int(10) NOT NULL,
  `nombre_linea_producto` varchar(25) NOT NULL,
  `descripcion_linea_producto` varchar(50) NOT NULL,
  `estado_linea_producto` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `pk_id_login` int(10) NOT NULL,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'sistema', 'bi0PL96rbxVRPKJQsLJJAg==', 'Usuario de prueba', 1),
(2, 'bjsican', '0FOYy5u5h0djKjzCYqfvkg==', 'Billy Sican', 1),
(3, 'bmaza', 'xTfsC3/XR/CVyDvNr1Fs+g==', 'Bryan Mazariegos', 1),
(4, 'jsican', 'jsican', 'Jeshua Sican', 0),
(5, 'jmorataya', '123', 'Julio Morataya', 0),
(6, 'Tefa21', 'tefa123', 'Sthefany Johana Campos Hernández', 1),
(7, 'Man88', '88man', 'Antonio Manuel Alejandro García González', 1),
(8, 'Yisus', 'Car123', 'Carlos Augusto Rodas Guerra', 1),
(9, 'HOXA', 'Alex123', 'Raul Alexander Sandoval Estrada', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `pk_id_marca` int(10) NOT NULL,
  `descripcion_marca` varchar(45) NOT NULL,
  `estado_marca` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_prima`
--

CREATE TABLE `materia_prima` (
  `pk_id_materia_prima` int(11) NOT NULL,
  `fk_id_producto_materia_prima` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado_materia_prima` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `pk_id_modulo` int(10) NOT NULL,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'Seguridad', 'Aplicaciones de seguridad', 1),
(2, 'Consultas', 'Consultas Inteligentes', 1),
(3, 'Reporteador', 'Aplicaciones de Reporteador', 1),
(4, 'HRM', 'Aplicaciones de Recursos Humanos', 1),
(5, 'FRM', 'Aplicaciones de Finanzas', 1),
(6, 'SCM', 'Aplicaciones Control de Inventario', 1),
(7, 'MRP', 'Aplicaciones de Produccion', 1),
(8, 'CRM', 'Aplicaciones de Ventas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_cuenta_por_cobrar`
--

CREATE TABLE `movimiento_cuenta_por_cobrar` (
  `pk_id_movimiento_cuenta` int(11) NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `fk_id_tipo_cuenta` int(11) NOT NULL,
  `fk_id_cliente` int(11) NOT NULL,
  `fk_id_factura` int(11) NOT NULL,
  `saldo_cuenta` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_inventario`
--

CREATE TABLE `movimiento_inventario` (
  `pk_id_movimiento_inventario` int(10) NOT NULL,
  `fecha_movimiento_inventario` datetime NOT NULL,
  `fk_id_tipo_movimiento` int(10) NOT NULL,
  `fk_id_ruta` int(10) NOT NULL,
  `fk_id_vehiculo` int(10) NOT NULL,
  `documento_asociado_movimiento_inventario` int(10) NOT NULL,
  `descripcion_movimiento_inventario` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento_inventario_detalle`
--

CREATE TABLE `movimiento_inventario_detalle` (
  `pk_id_movimiento_inventario_detalle` int(10) NOT NULL,
  `fk_id_movimiento_inventario` int(10) NOT NULL,
  `fk_id_producto` int(10) NOT NULL,
  `cantidad_inventario_detalle` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipio`
--

CREATE TABLE `municipio` (
  `pk_id_municipio` int(10) NOT NULL,
  `fk_id_departamento` int(10) NOT NULL,
  `nombre_municipio` varchar(30) NOT NULL,
  `descripcion_municipio` varchar(45) NOT NULL,
  `estado_municipio` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden_compra`
--

CREATE TABLE `orden_compra` (
  `pk_id_orden_compra` int(10) NOT NULL,
  `fk_id_producto_orden_compra` int(11) DEFAULT NULL,
  `fecha_envio_orden_compra` date DEFAULT NULL,
  `cantidad_orden_compra` int(11) DEFAULT NULL,
  `estado_orden_compra` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pais`
--

CREATE TABLE `pais` (
  `pk_id_pais` int(10) NOT NULL,
  `nombre_pais` varchar(40) NOT NULL,
  `capital_pais` varchar(40) NOT NULL,
  `estado_pais` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_detalle`
--

CREATE TABLE `pedido_detalle` (
  `fk_id_pedido_encabezado` int(10) NOT NULL,
  `cod_linea_pedido_detalle` int(10) NOT NULL,
  `fk_id_producto` int(10) NOT NULL,
  `cantidad_pedido_detalle` int(10) NOT NULL,
  `precio_unitario_pedido_detalle` double(8,2) NOT NULL,
  `subtotal_pedido_detalle` double(12,2) NOT NULL,
  `estado_pedido_detalle` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_encabezado`
--

CREATE TABLE `pedido_encabezado` (
  `pk_id_pedido_encabezado` int(10) NOT NULL,
  `fk_id_fabrica` int(10) NOT NULL,
  `estado_proceso_pedido_encabezado` int(1) NOT NULL,
  `fec_pedido_pedido_encabezado` datetime NOT NULL,
  `total_pedido_encabezado` double(12,2) NOT NULL,
  `estado_pedido_encabezado` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `percepcion`
--

CREATE TABLE `percepcion` (
  `pk_id_percepcion` int(11) NOT NULL,
  `nombre_percepcion` varchar(45) DEFAULT NULL,
  `monto_percepcion` double DEFAULT NULL,
  `descripcion_percepcion` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `percepcion`
--

INSERT INTO `percepcion` (`pk_id_percepcion`, `nombre_percepcion`, `monto_percepcion`, `descripcion_percepcion`) VALUES
(1, 'Bono Ley', 250, 'Bono de Ley.'),
(2, 'Comisión Venta Colchón A', 1500, 'Comisión por vender colchón tipo A.'),
(3, 'Bono Incentivo', 500, 'Bono Incentivo.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `pk_id_perfil` int(10) NOT NULL,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'Admin', 'Administracion del programa', 1),
(2, 'Sistema', 'Administrador del sistema', 1),
(3, 'Digitador', 'Digitador para Cuentas', 1),
(4, 'Consultor', 'Unicamente consultas ', 1),
(5, 'Reportes', 'Ingreso y consultas de reportes', 1),
(6, 'Pruebas', 'pruebas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_usuario`
--

CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int(10) NOT NULL,
  `fk_idusuario_perfil_usuario` int(10) DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil_usuario`
--

INSERT INTO `perfil_usuario` (`pk_id_perfil_usuario`, `fk_idusuario_perfil_usuario`, `fk_idperfil_perfil_usuario`) VALUES
(1, 1, 1),
(2, 3, 3),
(4, 4, 1),
(5, 5, 5),
(6, 6, 1),
(7, 7, 1),
(8, 8, 1),
(9, 9, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permiso`
--

CREATE TABLE `permiso` (
  `pk_id_permiso` int(10) NOT NULL,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `permiso`
--

INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1),
(2, 1, 0, 0, 1, 1),
(3, 1, 1, 1, 0, 0),
(4, 1, 1, 1, 1, 1),
(5, 1, 1, 1, 1, 1),
(6, 1, 1, 1, 1, 1),
(7, 1, 1, 1, 1, 1),
(8, 1, 0, 1, 0, 0),
(9, 1, 1, 0, 0, 0),
(10, 1, 1, 0, 0, 0),
(11, 1, 1, 1, 1, 1),
(12, 0, 0, 0, 1, 0),
(13, 0, 0, 0, 1, 0),
(14, 0, 0, 0, 0, 0),
(15, 1, 0, 0, 1, 0),
(16, 0, 0, 0, 0, 0),
(17, 1, 1, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peticion_poliza`
--

CREATE TABLE `peticion_poliza` (
  `pk_id_peticion_poliza` int(11) NOT NULL,
  `concepto_peticion_poliza` varchar(30) DEFAULT NULL,
  `fecha_peticion_poliza` datetime DEFAULT NULL,
  `descripcion_peticion_poliza` varchar(100) DEFAULT NULL,
  `monto_peticion_poliza` double DEFAULT NULL,
  `fk_pk_poliza_encabezado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `poliza_detalle`
--

CREATE TABLE `poliza_detalle` (
  `pk_poliza_encabezado` int(11) NOT NULL,
  `pk_id_cuenta_contable` int(11) NOT NULL,
  `monto_poliza_detalle` double DEFAULT NULL,
  `debe_poliza_detalle` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `poliza_encabezado`
--

CREATE TABLE `poliza_encabezado` (
  `pk_poliza_encabezado` int(11) NOT NULL,
  `fecha_poliza_encabezado` datetime DEFAULT NULL,
  `descripcion_poliza_encabezado` varchar(75) DEFAULT NULL,
  `estado_poliza_encabezado` tinyint(4) DEFAULT NULL,
  `total_poliza_encabezado` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `pk_id_producto` int(10) NOT NULL,
  `fk_id_linea_producto` int(10) NOT NULL,
  `fk_id_categoria_producto` int(10) NOT NULL,
  `nombre_producto` varchar(50) NOT NULL,
  `precio_producto` double(12,2) NOT NULL,
  `medida_producto` double(5,2) NOT NULL,
  `descripcion_producto` varchar(45) NOT NULL,
  `estado_producto` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto_terminado`
--

CREATE TABLE `producto_terminado` (
  `pk_id_producto_terminado` int(10) NOT NULL,
  `fk_id_producto_producto_terminado` int(10) DEFAULT NULL,
  `cantidad_producto_terminado` int(11) DEFAULT NULL,
  `estado_producto_terminado` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `propietario`
--

CREATE TABLE `propietario` (
  `pk_id_propietario` int(11) NOT NULL,
  `nombre_propietario` varchar(45) DEFAULT NULL,
  `descripcion_propietario` varchar(75) DEFAULT NULL,
  `estado_propietario` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `pk_id_proveedor` int(10) NOT NULL,
  `fk_id_pais` int(10) NOT NULL,
  `razon_social_proveedor` varchar(45) NOT NULL,
  `representante_legal_proveedor` varchar(45) NOT NULL,
  `nit_proveedor` varchar(20) NOT NULL,
  `estado_proveedor` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE `puesto` (
  `pk_id_puesto` int(11) NOT NULL,
  `nombre_puesto` varchar(45) DEFAULT NULL,
  `salario_puesto` double DEFAULT NULL,
  `fk_id_horario_puesto` int(11) DEFAULT NULL,
  `estado_puesto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`pk_id_puesto`, `nombre_puesto`, `salario_puesto`, `fk_id_horario_puesto`, `estado_puesto`) VALUES
(1, 'CEO', 7500, 1, 1),
(2, 'Secretaria', 4000, 1, 1),
(3, 'Gerente Logística', 6500, 2, 1),
(4, 'Gerente Financiero', 6500, 2, 1),
(5, 'Gerente Comunicaciones', 5000, 2, 1),
(6, 'Gerente Operaciones', 5500, 1, 1),
(7, 'Gerente TI', 7500, 2, 1),
(8, 'Gerente Recursos Humanos', 5200, 1, 1),
(9, 'Capactitador', 5200, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recetas_encabezado`
--

CREATE TABLE `recetas_encabezado` (
  `pk_id_receta_encabezado` int(10) NOT NULL,
  `descripcion_receta_encabezado` varchar(100) DEFAULT NULL,
  `fk_id_producto_receta_encabezado` int(10) DEFAULT NULL,
  `estado_encabezado_receta` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reclutamiento`
--

CREATE TABLE `reclutamiento` (
  `pk_id_reclutamiento` int(11) NOT NULL,
  `fk_id_nivel_estudio_reclutamiento` int(11) DEFAULT NULL,
  `nombre1_reclutamiento` varchar(45) DEFAULT NULL,
  `nombre2_reclutamiento` varchar(45) DEFAULT NULL,
  `apellido1_reclutamiento` varchar(45) DEFAULT NULL,
  `apellido2_reclutamiento` varchar(45) DEFAULT NULL,
  `fecha_nacimiento_reclutamiento` varchar(10) DEFAULT NULL,
  `dpi_reclutamiento` int(11) DEFAULT NULL,
  `fk_id_genero_reclutamiento` int(11) DEFAULT NULL,
  `fk_id_estado_civil_reclutamiento` int(11) DEFAULT NULL,
  `email_reclutamiento` varchar(125) DEFAULT NULL,
  `telefono_reclutamiento` int(11) DEFAULT NULL,
  `numero_igss_reclutamiento` int(11) DEFAULT NULL,
  `fk_id_licencia_conducir_reclutamiento` int(11) DEFAULT NULL,
  `fk_id_puesto_reclutamiento` int(11) DEFAULT NULL,
  `estado_reclutado_entrevista` int(11) DEFAULT NULL,
  `nombre_profesion` varchar(125) DEFAULT NULL,
  `fk_id_departamento_empresarial_reclutamiento` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `reclutamiento`
--

INSERT INTO `reclutamiento` (`pk_id_reclutamiento`, `fk_id_nivel_estudio_reclutamiento`, `nombre1_reclutamiento`, `nombre2_reclutamiento`, `apellido1_reclutamiento`, `apellido2_reclutamiento`, `fecha_nacimiento_reclutamiento`, `dpi_reclutamiento`, `fk_id_genero_reclutamiento`, `fk_id_estado_civil_reclutamiento`, `email_reclutamiento`, `telefono_reclutamiento`, `numero_igss_reclutamiento`, `fk_id_licencia_conducir_reclutamiento`, `fk_id_puesto_reclutamiento`, `estado_reclutado_entrevista`, `nombre_profesion`, `fk_id_departamento_empresarial_reclutamiento`) VALUES
(1, 7, 'Luis', 'Eduardo', 'Noriega', 'Lopez', '15/03/1990', 23531232, 1, 2, 'noriega@gmail.com', 46851326, 321321, 3, 4, 4, 'Contador', 4),
(2, 3, 'Jose', 'Jorge', 'Lopez', 'Barahona', '18/02/1999', 4135412, 1, 2, 'lopez@gmail.com', 10321405, 615320, 4, 3, 4, 'Ninguna', 6),
(3, 5, 'Armando', 'Gabriel', 'Rodriguez', 'Chavez', '15/06/1989', 25045453, 1, 2, 'chavez@gmail.com', 54412312, 12, 4, 7, 1, 'Psicólogo', 3),
(4, 5, 'Jose', 'Gabriel', 'Mollinedo', 'Lopez', '4/02/1999', 41304513, 1, 1, 'mollinedo@gmail.com', 46531265, 13246513, 4, 3, 0, 'Contador', 6),
(5, 5, 'Mario', 'Raul', 'Villatoro', 'Perez', '9/02/1989', 32156443, 1, 3, 'raul@gmail.com', 542154, 6543120, 1, 7, 0, 'Ingeniero en Electricidad', 5),
(6, 5, 'Luis', 'Manuel', 'Mejia', 'Urrutia', '18/02/1999', 65234653, 1, 2, 'mejia@gmail.com', 45623065, 64513215, 3, 7, 2, 'Ninguna', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE `reporte` (
  `pk_id_reporte` int(10) NOT NULL,
  `nombre_reporte` varchar(40) NOT NULL,
  `ruta_reporte` varchar(100) NOT NULL,
  `estado_reporte` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte_aplicativo`
--

CREATE TABLE `reporte_aplicativo` (
  `fk_id_reporte` int(10) NOT NULL,
  `fk_id_aplicacion` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `estado_reporte_aplicativo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte_modulo`
--

CREATE TABLE `reporte_modulo` (
  `fk_id_reporte` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `estado_reporte_modulo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ruta`
--

CREATE TABLE `ruta` (
  `pk_id_ruta` int(10) NOT NULL,
  `origen_ruta` varchar(40) NOT NULL,
  `destino_ruta` varchar(40) NOT NULL,
  `descripcion_ruta` varchar(45) NOT NULL,
  `estado_ruta` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `saldo_historico`
--

CREATE TABLE `saldo_historico` (
  `pk_id_cuenta_contable` int(11) NOT NULL,
  `pk_fecha_saldo_historico` datetime NOT NULL,
  `monto_saldo_historico` double DEFAULT NULL,
  `cargo_saldo_hostorico` double DEFAULT NULL,
  `abono_saldo_historico` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `telefono_proveedor`
--

CREATE TABLE `telefono_proveedor` (
  `pk_id_telefono_proveedor` int(10) NOT NULL,
  `fk_id_proveedor` int(10) NOT NULL,
  `telefono_telefono_proveedor` varchar(20) NOT NULL,
  `estado_telefono_proveedor` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_baja`
--

CREATE TABLE `tipo_baja` (
  `pk_id_tipo_baja` int(11) NOT NULL,
  `nombre_tipo_baja` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_baja`
--

INSERT INTO `tipo_baja` (`pk_id_tipo_baja`, `nombre_tipo_baja`) VALUES
(1, 'Renuncia'),
(2, 'Despido');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_competencia`
--

CREATE TABLE `tipo_competencia` (
  `pk_id_tipo_competencia` int(11) NOT NULL,
  `nombre_competencia` varchar(150) DEFAULT NULL,
  `estado_competencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_competencia`
--

INSERT INTO `tipo_competencia` (`pk_id_tipo_competencia`, `nombre_competencia`, `estado_competencia`) VALUES
(1, 'Trabajo en Equipo', 1),
(2, 'Organización', 1),
(3, 'Comunicación Efectiva', 1),
(4, 'Innovación', 1),
(5, 'Análisis de Datos', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_cuenta_contable`
--

CREATE TABLE `tipo_cuenta_contable` (
  `pk_id_tipo_cuenta_contable` int(11) NOT NULL,
  `nombre_tipo_cuenta_contable` varchar(75) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_cuenta_por_cobrar`
--

CREATE TABLE `tipo_cuenta_por_cobrar` (
  `pk_id_tipo_cuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_entrevista`
--

CREATE TABLE `tipo_entrevista` (
  `pk_id_tipo_entrevista` int(11) NOT NULL,
  `nombre_tipo_entrevista` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_entrevista`
--

INSERT INTO `tipo_entrevista` (`pk_id_tipo_entrevista`, `nombre_tipo_entrevista`) VALUES
(1, 'Competencias'),
(2, 'Practica'),
(3, 'Libre'),
(4, 'Estructurada'),
(5, 'Charla');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_moneda`
--

CREATE TABLE `tipo_moneda` (
  `pk_id_tipo_moneda` int(11) NOT NULL,
  `moneda_tipo_moneda` varchar(45) DEFAULT NULL,
  `simbolo_tipo_moneda` varchar(2) DEFAULT NULL,
  `descripcion_tipo_moneda` varchar(75) DEFAULT NULL,
  `estado_tipo_moneda` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_movimiento`
--

CREATE TABLE `tipo_movimiento` (
  `pk_id_tipo_movimiento` int(10) NOT NULL,
  `nombre_tipo_movimiento` varchar(45) NOT NULL,
  `signo_tipo_movimiento` varchar(1) DEFAULT NULL,
  `estado_tipo_movimiento` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_transaccion`
--

CREATE TABLE `tipo_transaccion` (
  `pk_id_tipo_transaccion` int(11) NOT NULL,
  `nombre_tipo_transaccion` varchar(45) DEFAULT NULL,
  `descripcion_tipo_transaccion` varchar(75) DEFAULT NULL,
  `estado_tipo_transaccion` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_venta`
--

CREATE TABLE `tipo_venta` (
  `pk_id_tipo_venta` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transaccion`
--

CREATE TABLE `transaccion` (
  `pk_id_transaccion` int(11) NOT NULL,
  `fk_id_numero_cuenta_bancaria` int(11) NOT NULL,
  `fecha_transaccion` datetime DEFAULT NULL,
  `fk_id_tipo_transaccion` int(11) NOT NULL,
  `fk_id_tipo_moneda` int(11) NOT NULL,
  `monto_transaccion` double DEFAULT NULL,
  `descripcion_transaccion` varchar(75) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo`
--

CREATE TABLE `vehiculo` (
  `pk_id_vehiculo` int(10) NOT NULL,
  `fk_id_marca` int(10) NOT NULL,
  `placa_vehiculo` varchar(45) NOT NULL,
  `modelo_vehiculo` varchar(45) NOT NULL,
  `color_vehiculo` varchar(45) NOT NULL,
  `anio_vehiculo` varchar(45) NOT NULL,
  `tipo_combustible_vehiculo` varchar(45) NOT NULL,
  `estado_vehiculo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`pk_id_aplicacion`),
  ADD KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  ADD KEY `fk_aplicacion_modulo` (`fk_id_modulo`);

--
-- Indices de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD PRIMARY KEY (`pk_id_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`);

--
-- Indices de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD PRIMARY KEY (`pk_id_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`);

--
-- Indices de la tabla `ascenso`
--
ALTER TABLE `ascenso`
  ADD PRIMARY KEY (`pk_id_ascenso`),
  ADD KEY `fk_ascenso_empleado` (`fk_id_empleado_ascenso`),
  ADD KEY `fk_ascenso_puesto_anterior` (`fk_puesto_anterior_ascenso`),
  ADD KEY `fk_ascenso_depto_anterior` (`fk_departamento_anterior_ascenso`),
  ADD KEY `fk_ascenso_puesto_nuevo` (`fk_puesto_nuevo_ascenso`),
  ADD KEY `fk_ascenso_depto_nuevo` (`fk_departamento_nuevo_ascenso`);

--
-- Indices de la tabla `baja`
--
ALTER TABLE `baja`
  ADD PRIMARY KEY (`pk_id_baja`),
  ADD KEY `fk_bajas_empleado` (`fk_id_empleado_baja`),
  ADD KEY `fk_tipo_bajas` (`fk_id_tipo_baja`);

--
-- Indices de la tabla `balance_detalle`
--
ALTER TABLE `balance_detalle`
  ADD PRIMARY KEY (`pk_id_balance_encabezado`),
  ADD KEY `fk_balance_detalle_cuenta` (`pk_id_cuenta_contable`);

--
-- Indices de la tabla `balance_encabezado`
--
ALTER TABLE `balance_encabezado`
  ADD PRIMARY KEY (`pk_id_balance_encabezado`);

--
-- Indices de la tabla `banco`
--
ALTER TABLE `banco`
  ADD PRIMARY KEY (`pk_id_banco`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`pk_id_bitacora`),
  ADD KEY `fk_login_bitacora` (`fk_idusuario_bitacora`),
  ADD KEY `fk_aplicacion_bitacora` (`fk_idaplicacion_bitacora`);

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`pk_id_bodega`),
  ADD KEY `pk_id_bodega` (`pk_id_bodega`),
  ADD KEY `fk_bodega_municipio` (`fk_id_municipio`);

--
-- Indices de la tabla `capacitacion`
--
ALTER TABLE `capacitacion`
  ADD PRIMARY KEY (`pk_id_capacitacion`),
  ADD KEY `fk_encabezado_capacitacion` (`fk_id_encabezado_capacitacion`),
  ADD KEY `fk_empleado_capacitacion` (`fk_id_empleado_capacitacion`);

--
-- Indices de la tabla `categoria_producto`
--
ALTER TABLE `categoria_producto`
  ADD PRIMARY KEY (`pk_id_categoria_producto`),
  ADD KEY `pk_id_categoria_producto` (`pk_id_categoria_producto`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`pk_id_cliente`);

--
-- Indices de la tabla `competencia_desarrollo`
--
ALTER TABLE `competencia_desarrollo`
  ADD PRIMARY KEY (`pk_id_competencia_desarrollo`),
  ADD KEY `fk_encabezado_competencia` (`fk_id_encabezado_competencia`),
  ADD KEY `fk_tipo_competencia_desarrollo` (`fk_id_tipo_competencia_desarrollo`);

--
-- Indices de la tabla `compra_detalle`
--
ALTER TABLE `compra_detalle`
  ADD PRIMARY KEY (`fk_id_compra_encabezado`,`cod_linea_compra_detalle`),
  ADD KEY `fk_id_compra_encabezado` (`fk_id_compra_encabezado`,`cod_linea_compra_detalle`),
  ADD KEY `fk_compra_producto` (`fk_id_producto`);

--
-- Indices de la tabla `compra_encabezado`
--
ALTER TABLE `compra_encabezado`
  ADD PRIMARY KEY (`pk_id_compra_encabezado`),
  ADD KEY `pk_id_compra_encabezado` (`pk_id_compra_encabezado`),
  ADD KEY `fk_compra_proveedor` (`fk_id_proveedor`);

--
-- Indices de la tabla `consulta_inteligente`
--
ALTER TABLE `consulta_inteligente`
  ADD PRIMARY KEY (`pk_id_consulta_inteligente`);

--
-- Indices de la tabla `control_asistencia`
--
ALTER TABLE `control_asistencia`
  ADD PRIMARY KEY (`pk_id_control_asistencia`),
  ADD KEY `fk_control_asistencia_empleado` (`fk_id_control_asistencia_empleado`),
  ADD KEY `fk_control_asistencia_encabezado_nomina` (`fk_id_control_asistencia_encabezado_nomina`);

--
-- Indices de la tabla `control_calidad`
--
ALTER TABLE `control_calidad`
  ADD PRIMARY KEY (`pk_id_control_calidad`),
  ADD KEY `fk_CONTROL_CALIDAD_PEDIDO_ENCABEZADO` (`fk_id_pedido_encabezado_control_calidad`);

--
-- Indices de la tabla `control_empleado`
--
ALTER TABLE `control_empleado`
  ADD PRIMARY KEY (`pk_id_control`),
  ADD KEY `fk_CONTROL_EMPLEADO_EMPLEADOS HRM1_idx` (`fk_id_empleado`);

--
-- Indices de la tabla `control_horas`
--
ALTER TABLE `control_horas`
  ADD PRIMARY KEY (`pk_id_control_horas`),
  ADD KEY `fk_control_horas_empleado` (`fk_id_control_horas_empleado`),
  ADD KEY `fk_control_horas_encabezado_nomina` (`fk_id_control_horas_encabezado_nomina`);

--
-- Indices de la tabla `control_producto`
--
ALTER TABLE `control_producto`
  ADD PRIMARY KEY (`pk_id_control_producto`),
  ADD KEY `fk_CONTROL_PRODUCTO_ORDEN_PRODUCCION1` (`fk_id_pedido_encabezado_control_producto`),
  ADD KEY `fk_CONTROL_PRODUCTO_ESTADO_PRODUCCION` (`fk_id_estado_produccion_control_producto`);

--
-- Indices de la tabla `correo_proveedor`
--
ALTER TABLE `correo_proveedor`
  ADD PRIMARY KEY (`pk_id_correo_proveedor`),
  ADD KEY `pk_id_correo_proveedor` (`pk_id_correo_proveedor`),
  ADD KEY `fk_proveedor_correo` (`fk_id_proveedor`);

--
-- Indices de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD PRIMARY KEY (`pk_id_cotizacion`),
  ADD KEY `fk_COTIZACION_CLIENTES1_idx` (`fk_id_cliente`);

--
-- Indices de la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD PRIMARY KEY (`pk_id_numero_cuenta_bancaria`),
  ADD KEY `fk_cuenta_bancaria_banco` (`fk_id_banco`),
  ADD KEY `fk_cuenta_bancaria_propietario` (`fk_id_propietario`),
  ADD KEY `fk_cuenta_bancaria_tipomoneda` (`fk_id_tipo_moneda`);

--
-- Indices de la tabla `cuenta_contable`
--
ALTER TABLE `cuenta_contable`
  ADD PRIMARY KEY (`pk_id_cuenta_contable`),
  ADD KEY `fk_cuenta_padre_cuenta_hijo` (`fk_cuenta_padre_cuenta_contable`),
  ADD KEY `fk_tipo_cuenta_cuenta_contable` (`fk_id_tipo_cuenta_contable`);

--
-- Indices de la tabla `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`pk_id_curso`),
  ADD KEY `fk_empleado_curso` (`fk_id_empleado_curso`);

--
-- Indices de la tabla `deduccion`
--
ALTER TABLE `deduccion`
  ADD PRIMARY KEY (`pk_id_deduccion`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`pk_id_departamento`),
  ADD KEY `pk_id_departamento` (`pk_id_departamento`);

--
-- Indices de la tabla `departamento_empresarial`
--
ALTER TABLE `departamento_empresarial`
  ADD PRIMARY KEY (`pk_id__departamento_empresarial`);

--
-- Indices de la tabla `detalles_venta_empleado`
--
ALTER TABLE `detalles_venta_empleado`
  ADD PRIMARY KEY (`fk_id_venta`,`fk_id_empleado`),
  ADD KEY `fk_VENTAS_has_EMPLEADOS HRM_EMPLEADOS HRM1_idx` (`fk_id_empleado`);

--
-- Indices de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD PRIMARY KEY (`pk_id_detalle_bitacora`),
  ADD KEY `fk_bitacora_detallebitacora` (`fk_idbitacora_detalle_bitacora`);

--
-- Indices de la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  ADD PRIMARY KEY (`fk_id_cotizacion`,`fk_id_producto`),
  ADD KEY `fk_COTIZACION_has_PRODUCTO_SCM_PRODUCTO_SCM1_idx` (`fk_id_producto`),
  ADD KEY `fk_COTIZACION_has_PRODUCTO_SCM_COTIZACION1_idx` (`fk_id_cotizacion`);

--
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`fk_id_factura`),
  ADD KEY `fk_VENTAS_has_FACTURAS_FACTURAS1_idx` (`fk_id_factura`),
  ADD KEY `fk_DETALLE_FACTURA_PRODUCTO_SCM1_idx` (`fk_id_producto`);

--
-- Indices de la tabla `detalle_hora_empleado`
--
ALTER TABLE `detalle_hora_empleado`
  ADD PRIMARY KEY (`pk_id_detalle_hora_empleado`),
  ADD KEY `fk_HORA_EMPLEADO_DETALLE_HORA_EMPLEADO` (`fk_id_hora_empleado_detalle`);

--
-- Indices de la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD PRIMARY KEY (`pk_id_detalle_nomina`),
  ADD KEY `fk_encabezado_detalle_nomina` (`fk_id_encabezado_detalle_nomina`),
  ADD KEY `fk_emplado_detalle_nomina` (`fk_id_empleado_detalle_nomina`),
  ADD KEY `fk_percepcion_detalle_nomina` (`fk_id_percepciones_detalle_nomina`),
  ADD KEY `fk_deduccion_detalle_nomina` (`fk_id_deducciones_detalle_nomina`);

--
-- Indices de la tabla `detalle_receta`
--
ALTER TABLE `detalle_receta`
  ADD PRIMARY KEY (`pk_id_detalle_detalle_receta`),
  ADD KEY `fk_detalle_receta_encabezado` (`fk_id_receta_encabezado_detalle`),
  ADD KEY `fk_estado_produccion_detalle` (`fk_id_estado_produccion_detalle_receta`),
  ADD KEY `fk_producto_detalle` (`fk_id_producto_detalle_receta`);

--
-- Indices de la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD PRIMARY KEY (`pk_id_direccion`),
  ADD KEY `fk_empleado_direccion` (`fk_empleado_direccion`),
  ADD KEY `fk_reclutamiento_direccion` (`fk_reclutamiento_direccion`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`pk_id_empleado`),
  ADD KEY `fk_genero_empleado1` (`fk_id_genero_empleado`),
  ADD KEY `fk_estado_civil_empleado` (`fk_id_estado_civil_empleado`),
  ADD KEY `fk_licencia_conducir_empleado` (`fk_id_licencia_conducir_empleado`),
  ADD KEY `fk_puesto_empleado` (`fk_id_puesto_empleado`),
  ADD KEY `fk_departamento_empresarial_empleado` (`fk_id_departamento_empresarial_empleado`);

--
-- Indices de la tabla `encabezado_capacitacion`
--
ALTER TABLE `encabezado_capacitacion`
  ADD PRIMARY KEY (`pk_id_encabezado_capacitacion`),
  ADD KEY `fk_curso_encabezado_capacitacion` (`fk_id_curso_encabezado_capacitacion`);

--
-- Indices de la tabla `encabezado_competencia`
--
ALTER TABLE `encabezado_competencia`
  ADD PRIMARY KEY (`pk_id_encabezado_competencia`),
  ADD KEY `fk_empleado_encabezado_competencia` (`fk_id_empleado_encabezado_competencia`);

--
-- Indices de la tabla `encabezado_nomina`
--
ALTER TABLE `encabezado_nomina`
  ADD PRIMARY KEY (`pk_id_encabezado_nomina`);

--
-- Indices de la tabla `encargado_bodega`
--
ALTER TABLE `encargado_bodega`
  ADD PRIMARY KEY (`pk_id_encargado_bodega`),
  ADD KEY `pk_id_encargado_bodega` (`pk_id_encargado_bodega`),
  ADD KEY `fk_empleado_bodega` (`fk_id_bodega`),
  ADD KEY `fk_empleado_encargado` (`fk_id_empleado`);

--
-- Indices de la tabla `entrevista`
--
ALTER TABLE `entrevista`
  ADD PRIMARY KEY (`pk_id_entrevista`),
  ADD KEY `fk_empleado_entrevista` (`fk_id_empleado_entrevista`),
  ADD KEY `fk_reclutamiento_entrevista` (`fk_id_reclutamiento_entrevista`),
  ADD KEY `fk_tipo_entrevista` (`fk_id_tipo_entrevista`);

--
-- Indices de la tabla `estado_civil`
--
ALTER TABLE `estado_civil`
  ADD PRIMARY KEY (`pk_id_estado_civil`);

--
-- Indices de la tabla `estado_produccion`
--
ALTER TABLE `estado_produccion`
  ADD PRIMARY KEY (`pk_id_estado_produccion`);

--
-- Indices de la tabla `existencia`
--
ALTER TABLE `existencia`
  ADD PRIMARY KEY (`pk_id_existencia`),
  ADD KEY `pk_id_existencia` (`pk_id_existencia`),
  ADD KEY `fk_inventario_producto` (`fk_id_producto`),
  ADD KEY `fk_inventario_bodega` (`fk_id_bodega`);

--
-- Indices de la tabla `fabrica`
--
ALTER TABLE `fabrica`
  ADD PRIMARY KEY (`pk_id_fabrica`),
  ADD KEY `pk_id_fabrica` (`pk_id_fabrica`),
  ADD KEY `fk_fabrica_municipio` (`fk_id_municipio`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`pk_id_factura`),
  ADD KEY `fk_FACTURAS_TIPO_VENTA1_idx` (`fk_id_tipo_venta`),
  ADD KEY `fk_FACTURAS_CLIENTES1_idx` (`fk_id_cliente`),
  ADD KEY `fk_FACTURAS_EMPLEADOS HRM1_idx` (`fk_id_empleado`);

--
-- Indices de la tabla `falta`
--
ALTER TABLE `falta`
  ADD PRIMARY KEY (`pk_id_falta`);

--
-- Indices de la tabla `falta_empleado`
--
ALTER TABLE `falta_empleado`
  ADD KEY `fk_empleado_falta` (`fk_id_empleado_falta_empleado`),
  ADD KEY `fk_tipo_falta` (`fk_id_tipo_falta_empleado`);

--
-- Indices de la tabla `formacion_academica`
--
ALTER TABLE `formacion_academica`
  ADD PRIMARY KEY (`pk_id_formacion_academica`);

--
-- Indices de la tabla `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`pk_id_genero`);

--
-- Indices de la tabla `horario`
--
ALTER TABLE `horario`
  ADD PRIMARY KEY (`pk_id_horario`);

--
-- Indices de la tabla `hora_empleado`
--
ALTER TABLE `hora_empleado`
  ADD PRIMARY KEY (`pk_id_hora_empleado`),
  ADD KEY `fk_HORA_EMPLEADO_ORDEN_PRODUCCION1` (`fk_id_pedido_encabezado_hora_empleado`),
  ADD KEY `fk_HORAEMPLEADO_EMPLEADO` (`fk_id_empleado_hora_empleado`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`pk_id_inventario`),
  ADD KEY `pk_id_inventario` (`pk_id_inventario`),
  ADD KEY `fk_total_inventario` (`fk_id_producto`);

--
-- Indices de la tabla `licencia_conduccion`
--
ALTER TABLE `licencia_conduccion`
  ADD PRIMARY KEY (`pk_id_licencia_conduccion`);

--
-- Indices de la tabla `linea_producto`
--
ALTER TABLE `linea_producto`
  ADD PRIMARY KEY (`pk_id_linea_producto`),
  ADD KEY `pk_id_linea_producto` (`pk_id_linea_producto`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`pk_id_login`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`pk_id_marca`),
  ADD KEY `pk_id_marca` (`pk_id_marca`);

--
-- Indices de la tabla `materia_prima`
--
ALTER TABLE `materia_prima`
  ADD PRIMARY KEY (`pk_id_materia_prima`),
  ADD KEY `fk_materia_prima_producto` (`fk_id_producto_materia_prima`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`pk_id_modulo`),
  ADD KEY `pk_id_modulo` (`pk_id_modulo`);

--
-- Indices de la tabla `movimiento_cuenta_por_cobrar`
--
ALTER TABLE `movimiento_cuenta_por_cobrar`
  ADD PRIMARY KEY (`pk_id_movimiento_cuenta`),
  ADD KEY `fk_MOVIMIENTO_CUENTA_POR_COBRAR_CLIENTES1_idx` (`fk_id_cliente`),
  ADD KEY `fk_MOVIMIENTO_CUENTA_POR_COBRAR_TIPO_CUENTA_POR_COBRAR1_idx` (`fk_id_tipo_cuenta`),
  ADD KEY `fk_MOVIMIENTO_CUENTA_POR_COBRAR_FACTURAS1_idx` (`fk_id_factura`);

--
-- Indices de la tabla `movimiento_inventario`
--
ALTER TABLE `movimiento_inventario`
  ADD PRIMARY KEY (`pk_id_movimiento_inventario`),
  ADD KEY `pk_id_movimiento_inventario` (`pk_id_movimiento_inventario`),
  ADD KEY `fk_mov_inventario_tipo` (`fk_id_tipo_movimiento`),
  ADD KEY `fk_mov_inventario_ruta` (`fk_id_ruta`),
  ADD KEY `fk_mov_inventario_vehiculo` (`fk_id_vehiculo`);

--
-- Indices de la tabla `movimiento_inventario_detalle`
--
ALTER TABLE `movimiento_inventario_detalle`
  ADD PRIMARY KEY (`pk_id_movimiento_inventario_detalle`),
  ADD KEY `pk_id_movimiento_inventario_detalle` (`pk_id_movimiento_inventario_detalle`),
  ADD KEY `fk_mov_inventario_detalle_mov` (`fk_id_movimiento_inventario`),
  ADD KEY `fk_mov_inventario_detalle_producto` (`fk_id_producto`);

--
-- Indices de la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD PRIMARY KEY (`pk_id_municipio`),
  ADD KEY `pk_id_municipio` (`pk_id_municipio`),
  ADD KEY `fk_municipio_departamento` (`fk_id_departamento`);

--
-- Indices de la tabla `orden_compra`
--
ALTER TABLE `orden_compra`
  ADD PRIMARY KEY (`pk_id_orden_compra`),
  ADD KEY `fk_ORDEN_COMPRA_PRODUCTO1` (`fk_id_producto_orden_compra`);

--
-- Indices de la tabla `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`pk_id_pais`),
  ADD KEY `pk_id_pais` (`pk_id_pais`);

--
-- Indices de la tabla `pedido_detalle`
--
ALTER TABLE `pedido_detalle`
  ADD PRIMARY KEY (`fk_id_pedido_encabezado`,`cod_linea_pedido_detalle`),
  ADD KEY `fk_id_pedido_encabezado` (`fk_id_pedido_encabezado`,`cod_linea_pedido_detalle`),
  ADD KEY `fk_pedido_producto` (`fk_id_producto`);

--
-- Indices de la tabla `pedido_encabezado`
--
ALTER TABLE `pedido_encabezado`
  ADD PRIMARY KEY (`pk_id_pedido_encabezado`),
  ADD KEY `pk_id_pedido_encabezado` (`pk_id_pedido_encabezado`),
  ADD KEY `fk_pedido_fabrica` (`fk_id_fabrica`);

--
-- Indices de la tabla `percepcion`
--
ALTER TABLE `percepcion`
  ADD PRIMARY KEY (`pk_id_percepcion`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`pk_id_perfil`);

--
-- Indices de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD PRIMARY KEY (`pk_id_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`);

--
-- Indices de la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD PRIMARY KEY (`pk_id_permiso`);

--
-- Indices de la tabla `peticion_poliza`
--
ALTER TABLE `peticion_poliza`
  ADD PRIMARY KEY (`pk_id_peticion_poliza`);

--
-- Indices de la tabla `poliza_detalle`
--
ALTER TABLE `poliza_detalle`
  ADD PRIMARY KEY (`pk_poliza_encabezado`,`pk_id_cuenta_contable`),
  ADD KEY `fk_poliza_detalle_cuenta` (`pk_id_cuenta_contable`);

--
-- Indices de la tabla `poliza_encabezado`
--
ALTER TABLE `poliza_encabezado`
  ADD PRIMARY KEY (`pk_poliza_encabezado`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`pk_id_producto`),
  ADD KEY `pk_id_producto` (`pk_id_producto`),
  ADD KEY `fk_producto_lineaProducto` (`fk_id_linea_producto`),
  ADD KEY `fk_producto_categoriaProducto` (`fk_id_categoria_producto`);

--
-- Indices de la tabla `producto_terminado`
--
ALTER TABLE `producto_terminado`
  ADD PRIMARY KEY (`pk_id_producto_terminado`),
  ADD KEY `fk_producto_terminado_producto` (`fk_id_producto_producto_terminado`);

--
-- Indices de la tabla `propietario`
--
ALTER TABLE `propietario`
  ADD PRIMARY KEY (`pk_id_propietario`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`pk_id_proveedor`),
  ADD KEY `pk_id_proveedor` (`pk_id_proveedor`),
  ADD KEY `fk_proveedor_pais` (`fk_id_pais`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD PRIMARY KEY (`pk_id_puesto`),
  ADD KEY `fk_horario_puesto` (`fk_id_horario_puesto`);

--
-- Indices de la tabla `recetas_encabezado`
--
ALTER TABLE `recetas_encabezado`
  ADD PRIMARY KEY (`pk_id_receta_encabezado`),
  ADD KEY `fk_recetas_encabezado_productos` (`fk_id_producto_receta_encabezado`);

--
-- Indices de la tabla `reclutamiento`
--
ALTER TABLE `reclutamiento`
  ADD PRIMARY KEY (`pk_id_reclutamiento`),
  ADD KEY `fk_nivel_estudio_reclutamiento` (`fk_id_nivel_estudio_reclutamiento`),
  ADD KEY `fk_genero_reclutamiento` (`fk_id_genero_reclutamiento`),
  ADD KEY `fk_estado_civil_reclutamiento` (`fk_id_estado_civil_reclutamiento`),
  ADD KEY `fk_licencia_conducir_reclutamiento` (`fk_id_licencia_conducir_reclutamiento`),
  ADD KEY `fk_puesto_reclutamiento` (`fk_id_puesto_reclutamiento`),
  ADD KEY `fk_departamento_empresarial_reclutamiento` (`fk_id_departamento_empresarial_reclutamiento`);

--
-- Indices de la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD PRIMARY KEY (`pk_id_reporte`),
  ADD KEY `pk_id_reporte` (`pk_id_reporte`);

--
-- Indices de la tabla `reporte_aplicativo`
--
ALTER TABLE `reporte_aplicativo`
  ADD PRIMARY KEY (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  ADD KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  ADD KEY `fk_reporte_aplicativo_modulo` (`fk_id_modulo`),
  ADD KEY `fk_report_aplicativo` (`fk_id_aplicacion`);

--
-- Indices de la tabla `reporte_modulo`
--
ALTER TABLE `reporte_modulo`
  ADD PRIMARY KEY (`fk_id_reporte`,`fk_id_modulo`),
  ADD KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_modulo`),
  ADD KEY `fk_reporte_de_modulo_reportes` (`fk_id_modulo`);

--
-- Indices de la tabla `ruta`
--
ALTER TABLE `ruta`
  ADD PRIMARY KEY (`pk_id_ruta`),
  ADD KEY `pk_id_ruta` (`pk_id_ruta`);

--
-- Indices de la tabla `saldo_historico`
--
ALTER TABLE `saldo_historico`
  ADD PRIMARY KEY (`pk_id_cuenta_contable`,`pk_fecha_saldo_historico`);

--
-- Indices de la tabla `telefono_proveedor`
--
ALTER TABLE `telefono_proveedor`
  ADD PRIMARY KEY (`pk_id_telefono_proveedor`),
  ADD KEY `pk_id_telefono_proveedor` (`pk_id_telefono_proveedor`),
  ADD KEY `fk_proveedor_telefono` (`fk_id_proveedor`);

--
-- Indices de la tabla `tipo_baja`
--
ALTER TABLE `tipo_baja`
  ADD PRIMARY KEY (`pk_id_tipo_baja`);

--
-- Indices de la tabla `tipo_competencia`
--
ALTER TABLE `tipo_competencia`
  ADD PRIMARY KEY (`pk_id_tipo_competencia`);

--
-- Indices de la tabla `tipo_cuenta_contable`
--
ALTER TABLE `tipo_cuenta_contable`
  ADD PRIMARY KEY (`pk_id_tipo_cuenta_contable`);

--
-- Indices de la tabla `tipo_cuenta_por_cobrar`
--
ALTER TABLE `tipo_cuenta_por_cobrar`
  ADD PRIMARY KEY (`pk_id_tipo_cuenta`);

--
-- Indices de la tabla `tipo_entrevista`
--
ALTER TABLE `tipo_entrevista`
  ADD PRIMARY KEY (`pk_id_tipo_entrevista`);

--
-- Indices de la tabla `tipo_moneda`
--
ALTER TABLE `tipo_moneda`
  ADD PRIMARY KEY (`pk_id_tipo_moneda`);

--
-- Indices de la tabla `tipo_movimiento`
--
ALTER TABLE `tipo_movimiento`
  ADD PRIMARY KEY (`pk_id_tipo_movimiento`),
  ADD KEY `pk_id_tipo_movimiento` (`pk_id_tipo_movimiento`);

--
-- Indices de la tabla `tipo_transaccion`
--
ALTER TABLE `tipo_transaccion`
  ADD PRIMARY KEY (`pk_id_tipo_transaccion`);

--
-- Indices de la tabla `tipo_venta`
--
ALTER TABLE `tipo_venta`
  ADD PRIMARY KEY (`pk_id_tipo_venta`);

--
-- Indices de la tabla `transaccion`
--
ALTER TABLE `transaccion`
  ADD PRIMARY KEY (`pk_id_transaccion`),
  ADD KEY `fk_transaccion_numero_cuenta` (`fk_id_numero_cuenta_bancaria`),
  ADD KEY `fk_transaccion_tipo_transaccion` (`fk_id_tipo_transaccion`),
  ADD KEY `fk_transaccion_tipo_moneda` (`fk_id_tipo_moneda`);

--
-- Indices de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD PRIMARY KEY (`pk_id_vehiculo`),
  ADD KEY `pk_id_vehiculo` (`pk_id_vehiculo`),
  ADD KEY `fk_vehiculo_marca` (`fk_id_marca`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `pk_id_aplicacion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  MODIFY `pk_id_aplicacion_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  MODIFY `pk_id_aplicacion_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `pk_id_bitacora` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;

--
-- AUTO_INCREMENT de la tabla `bodega`
--
ALTER TABLE `bodega`
  MODIFY `pk_id_bodega` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `categoria_producto`
--
ALTER TABLE `categoria_producto`
  MODIFY `pk_id_categoria_producto` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `pk_id_cliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `consulta_inteligente`
--
ALTER TABLE `consulta_inteligente`
  MODIFY `pk_id_consulta_inteligente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `control_calidad`
--
ALTER TABLE `control_calidad`
  MODIFY `pk_id_control_calidad` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `control_empleado`
--
ALTER TABLE `control_empleado`
  MODIFY `pk_id_control` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `control_producto`
--
ALTER TABLE `control_producto`
  MODIFY `pk_id_control_producto` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `correo_proveedor`
--
ALTER TABLE `correo_proveedor`
  MODIFY `pk_id_correo_proveedor` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  MODIFY `pk_id_cotizacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `pk_id_departamento` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalles_venta_empleado`
--
ALTER TABLE `detalles_venta_empleado`
  MODIFY `fk_id_venta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  MODIFY `pk_id_detalle_bitacora` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_hora_empleado`
--
ALTER TABLE `detalle_hora_empleado`
  MODIFY `pk_id_detalle_hora_empleado` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_receta`
--
ALTER TABLE `detalle_receta`
  MODIFY `pk_id_detalle_detalle_receta` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `encargado_bodega`
--
ALTER TABLE `encargado_bodega`
  MODIFY `pk_id_encargado_bodega` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estado_produccion`
--
ALTER TABLE `estado_produccion`
  MODIFY `pk_id_estado_produccion` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `existencia`
--
ALTER TABLE `existencia`
  MODIFY `pk_id_existencia` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `fabrica`
--
ALTER TABLE `fabrica`
  MODIFY `pk_id_fabrica` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `facturas`
--
ALTER TABLE `facturas`
  MODIFY `pk_id_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `hora_empleado`
--
ALTER TABLE `hora_empleado`
  MODIFY `pk_id_hora_empleado` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `inventario`
--
ALTER TABLE `inventario`
  MODIFY `pk_id_inventario` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `linea_producto`
--
ALTER TABLE `linea_producto`
  MODIFY `pk_id_linea_producto` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `pk_id_login` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `pk_id_marca` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `materia_prima`
--
ALTER TABLE `materia_prima`
  MODIFY `pk_id_materia_prima` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `modulo`
--
ALTER TABLE `modulo`
  MODIFY `pk_id_modulo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `movimiento_cuenta_por_cobrar`
--
ALTER TABLE `movimiento_cuenta_por_cobrar`
  MODIFY `pk_id_movimiento_cuenta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `municipio`
--
ALTER TABLE `municipio`
  MODIFY `pk_id_municipio` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `orden_compra`
--
ALTER TABLE `orden_compra`
  MODIFY `pk_id_orden_compra` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pais`
--
ALTER TABLE `pais`
  MODIFY `pk_id_pais` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `pk_id_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  MODIFY `pk_id_perfil_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `permiso`
--
ALTER TABLE `permiso`
  MODIFY `pk_id_permiso` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `pk_id_producto` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `producto_terminado`
--
ALTER TABLE `producto_terminado`
  MODIFY `pk_id_producto_terminado` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `pk_id_proveedor` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `recetas_encabezado`
--
ALTER TABLE `recetas_encabezado`
  MODIFY `pk_id_receta_encabezado` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `reporte`
--
ALTER TABLE `reporte`
  MODIFY `pk_id_reporte` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ruta`
--
ALTER TABLE `ruta`
  MODIFY `pk_id_ruta` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `telefono_proveedor`
--
ALTER TABLE `telefono_proveedor`
  MODIFY `pk_id_telefono_proveedor` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipo_cuenta_por_cobrar`
--
ALTER TABLE `tipo_cuenta_por_cobrar`
  MODIFY `pk_id_tipo_cuenta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipo_venta`
--
ALTER TABLE `tipo_venta`
  MODIFY `pk_id_tipo_venta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  MODIFY `pk_id_vehiculo` int(10) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD CONSTRAINT `fk_aplicacion_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`);

--
-- Filtros para la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `ascenso`
--
ALTER TABLE `ascenso`
  ADD CONSTRAINT `fk_ascenso_depto_anterior` FOREIGN KEY (`fk_departamento_anterior_ascenso`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ascenso_depto_nuevo` FOREIGN KEY (`fk_departamento_nuevo_ascenso`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ascenso_empleado` FOREIGN KEY (`fk_id_empleado_ascenso`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ascenso_puesto_anterior` FOREIGN KEY (`fk_puesto_anterior_ascenso`) REFERENCES `puesto` (`pk_id_puesto`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ascenso_puesto_nuevo` FOREIGN KEY (`fk_puesto_nuevo_ascenso`) REFERENCES `puesto` (`pk_id_puesto`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `baja`
--
ALTER TABLE `baja`
  ADD CONSTRAINT `fk_bajas_empleado` FOREIGN KEY (`fk_id_empleado_baja`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tipo_bajas` FOREIGN KEY (`fk_id_tipo_baja`) REFERENCES `tipo_baja` (`pk_id_tipo_baja`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `balance_detalle`
--
ALTER TABLE `balance_detalle`
  ADD CONSTRAINT `fk_balance_detalle_cuenta_contable` FOREIGN KEY (`pk_id_cuenta_contable`) REFERENCES `cuenta_contable` (`pk_id_cuenta_contable`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_balance_encabezado_detalle` FOREIGN KEY (`pk_id_balance_encabezado`) REFERENCES `balance_encabezado` (`pk_id_balance_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `fk_aplicacion_bitacora` FOREIGN KEY (`fk_idaplicacion_bitacora`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_login_bitacora` FOREIGN KEY (`fk_idusuario_bitacora`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD CONSTRAINT `fk_bodega_municipio` FOREIGN KEY (`fk_id_municipio`) REFERENCES `municipio` (`pk_id_municipio`);

--
-- Filtros para la tabla `capacitacion`
--
ALTER TABLE `capacitacion`
  ADD CONSTRAINT `fk_empleado_capacitacion` FOREIGN KEY (`fk_id_empleado_capacitacion`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_encabezado_capacitacion` FOREIGN KEY (`fk_id_encabezado_capacitacion`) REFERENCES `encabezado_capacitacion` (`pk_id_encabezado_capacitacion`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `competencia_desarrollo`
--
ALTER TABLE `competencia_desarrollo`
  ADD CONSTRAINT `fk_encabezado_competencia` FOREIGN KEY (`fk_id_encabezado_competencia`) REFERENCES `encabezado_competencia` (`pk_id_encabezado_competencia`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tipo_competencia_desarrollo` FOREIGN KEY (`fk_id_tipo_competencia_desarrollo`) REFERENCES `tipo_competencia` (`pk_id_tipo_competencia`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `compra_detalle`
--
ALTER TABLE `compra_detalle`
  ADD CONSTRAINT `fk_compra_detalle` FOREIGN KEY (`fk_id_compra_encabezado`) REFERENCES `compra_encabezado` (`pk_id_compra_encabezado`),
  ADD CONSTRAINT `fk_compra_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `compra_encabezado`
--
ALTER TABLE `compra_encabezado`
  ADD CONSTRAINT `fk_compra_proveedor` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`);

--
-- Filtros para la tabla `control_asistencia`
--
ALTER TABLE `control_asistencia`
  ADD CONSTRAINT `fk_control_asistencia_empleado` FOREIGN KEY (`fk_id_control_asistencia_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_control_asistencia_encabezado_nomina` FOREIGN KEY (`fk_id_control_asistencia_encabezado_nomina`) REFERENCES `encabezado_nomina` (`pk_id_encabezado_nomina`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `control_calidad`
--
ALTER TABLE `control_calidad`
  ADD CONSTRAINT `fk_CONTROL_CALIDAD_PEDIDO_ENCABEZADO` FOREIGN KEY (`fk_id_pedido_encabezado_control_calidad`) REFERENCES `pedido_encabezado` (`pk_id_pedido_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `control_empleado`
--
ALTER TABLE `control_empleado`
  ADD CONSTRAINT `fk_CONTROL_EMPLEADO_EMPLEADOS HRM1` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `control_horas`
--
ALTER TABLE `control_horas`
  ADD CONSTRAINT `fk_control_horas_empleado` FOREIGN KEY (`fk_id_control_horas_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_control_horas_encabezado_nomina` FOREIGN KEY (`fk_id_control_horas_encabezado_nomina`) REFERENCES `encabezado_nomina` (`pk_id_encabezado_nomina`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `control_producto`
--
ALTER TABLE `control_producto`
  ADD CONSTRAINT `fk_CONTROL_PRODUCTO_ESTADO_PRODUCCION` FOREIGN KEY (`fk_id_estado_produccion_control_producto`) REFERENCES `estado_produccion` (`pk_id_estado_produccion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_CONTROL_PRODUCTO_ORDEN_PRODUCCION1` FOREIGN KEY (`fk_id_pedido_encabezado_control_producto`) REFERENCES `pedido_encabezado` (`pk_id_pedido_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `correo_proveedor`
--
ALTER TABLE `correo_proveedor`
  ADD CONSTRAINT `fk_proveedor_correo` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`);

--
-- Filtros para la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD CONSTRAINT `fk_COTIZACION_CLIENTES1` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `cuenta_bancaria`
--
ALTER TABLE `cuenta_bancaria`
  ADD CONSTRAINT `fk_cuenta_bancaria_banco` FOREIGN KEY (`fk_id_banco`) REFERENCES `banco` (`pk_id_banco`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_cuenta_bancaria_propietario` FOREIGN KEY (`fk_id_propietario`) REFERENCES `propietario` (`pk_id_propietario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_cuenta_bancaria_tipomoneda` FOREIGN KEY (`fk_id_tipo_moneda`) REFERENCES `tipo_moneda` (`pk_id_tipo_moneda`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `cuenta_contable`
--
ALTER TABLE `cuenta_contable`
  ADD CONSTRAINT `fk_cuenta_padre_cuenta_hijo` FOREIGN KEY (`fk_cuenta_padre_cuenta_contable`) REFERENCES `cuenta_contable` (`pk_id_cuenta_contable`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tipo_cuenta_contable` FOREIGN KEY (`fk_id_tipo_cuenta_contable`) REFERENCES `tipo_cuenta_contable` (`pk_id_tipo_cuenta_contable`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `curso`
--
ALTER TABLE `curso`
  ADD CONSTRAINT `fk_empleado_curso` FOREIGN KEY (`fk_id_empleado_curso`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalles_venta_empleado`
--
ALTER TABLE `detalles_venta_empleado`
  ADD CONSTRAINT `fk_VENTAS_has_EMPLEADOS HRM_EMPLEADOS HRM1` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD CONSTRAINT `fk_bitacora_detallebitacora` FOREIGN KEY (`fk_idbitacora_detalle_bitacora`) REFERENCES `bitacora` (`pk_id_bitacora`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_cotizacion`
--
ALTER TABLE `detalle_cotizacion`
  ADD CONSTRAINT `fk_COTIZACION_has_PRODUCTO_SCM_COTIZACION1` FOREIGN KEY (`fk_id_cotizacion`) REFERENCES `cotizacion` (`pk_id_cotizacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_COTIZACION_has_PRODUCTO_SCM_PRODUCTO_SCM1` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD CONSTRAINT `fk_DETALLE_FACTURA_PRODUCTO_SCM1` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_VENTAS_has_FACTURAS_FACTURAS1` FOREIGN KEY (`fk_id_factura`) REFERENCES `facturas` (`pk_id_factura`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_hora_empleado`
--
ALTER TABLE `detalle_hora_empleado`
  ADD CONSTRAINT `fk_HORA_EMPLEADO_DETALLE_HORA_EMPLEADO` FOREIGN KEY (`fk_id_hora_empleado_detalle`) REFERENCES `hora_empleado` (`pk_id_hora_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `detalle_nomina`
--
ALTER TABLE `detalle_nomina`
  ADD CONSTRAINT `fk_deduccion_detalle_nomina` FOREIGN KEY (`fk_id_deducciones_detalle_nomina`) REFERENCES `deduccion` (`pk_id_deduccion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_emplado_detalle_nomina` FOREIGN KEY (`fk_id_empleado_detalle_nomina`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_encabezado_detalle_nomina` FOREIGN KEY (`fk_id_encabezado_detalle_nomina`) REFERENCES `encabezado_nomina` (`pk_id_encabezado_nomina`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_percepcion_detalle_nomina` FOREIGN KEY (`fk_id_percepciones_detalle_nomina`) REFERENCES `percepcion` (`pk_id_percepcion`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_receta`
--
ALTER TABLE `detalle_receta`
  ADD CONSTRAINT `fk_detalle_receta_encabezado` FOREIGN KEY (`fk_id_receta_encabezado_detalle`) REFERENCES `recetas_encabezado` (`pk_id_receta_encabezado`),
  ADD CONSTRAINT `fk_estado_produccion_detalle` FOREIGN KEY (`fk_id_estado_produccion_detalle_receta`) REFERENCES `estado_produccion` (`pk_id_estado_produccion`),
  ADD CONSTRAINT `fk_producto_detalle` FOREIGN KEY (`fk_id_producto_detalle_receta`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD CONSTRAINT `fk_empleado_direccion` FOREIGN KEY (`fk_empleado_direccion`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reclutamiento_direccion` FOREIGN KEY (`fk_reclutamiento_direccion`) REFERENCES `reclutamiento` (`pk_id_reclutamiento`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `fk_departamento_empresarial_empleado` FOREIGN KEY (`fk_id_departamento_empresarial_empleado`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_estado_civil_empleado` FOREIGN KEY (`fk_id_estado_civil_empleado`) REFERENCES `estado_civil` (`pk_id_estado_civil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_genero_empleado1` FOREIGN KEY (`fk_id_genero_empleado`) REFERENCES `genero` (`pk_id_genero`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_licencia_conducir_empleado` FOREIGN KEY (`fk_id_licencia_conducir_empleado`) REFERENCES `licencia_conduccion` (`pk_id_licencia_conduccion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_puesto_empleado` FOREIGN KEY (`fk_id_puesto_empleado`) REFERENCES `puesto` (`pk_id_puesto`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `encabezado_capacitacion`
--
ALTER TABLE `encabezado_capacitacion`
  ADD CONSTRAINT `fk_curso_encabezado_capacitacion` FOREIGN KEY (`fk_id_curso_encabezado_capacitacion`) REFERENCES `curso` (`pk_id_curso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `encabezado_competencia`
--
ALTER TABLE `encabezado_competencia`
  ADD CONSTRAINT `fk_empleado_encabezado_competencia` FOREIGN KEY (`fk_id_empleado_encabezado_competencia`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `encargado_bodega`
--
ALTER TABLE `encargado_bodega`
  ADD CONSTRAINT `fk_empleado_bodega` FOREIGN KEY (`fk_id_bodega`) REFERENCES `bodega` (`pk_id_bodega`),
  ADD CONSTRAINT `fk_empleado_encargado` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`);

--
-- Filtros para la tabla `entrevista`
--
ALTER TABLE `entrevista`
  ADD CONSTRAINT `fk_empleado_entrevista` FOREIGN KEY (`fk_id_empleado_entrevista`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_reclutamiento_entrevista` FOREIGN KEY (`fk_id_reclutamiento_entrevista`) REFERENCES `reclutamiento` (`pk_id_reclutamiento`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tipo_entrevista` FOREIGN KEY (`fk_id_tipo_entrevista`) REFERENCES `tipo_entrevista` (`pk_id_tipo_entrevista`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `existencia`
--
ALTER TABLE `existencia`
  ADD CONSTRAINT `fk_inventario_bodega` FOREIGN KEY (`fk_id_bodega`) REFERENCES `bodega` (`pk_id_bodega`),
  ADD CONSTRAINT `fk_inventario_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `fabrica`
--
ALTER TABLE `fabrica`
  ADD CONSTRAINT `fk_fabrica_municipio` FOREIGN KEY (`fk_id_municipio`) REFERENCES `municipio` (`pk_id_municipio`);

--
-- Filtros para la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD CONSTRAINT `fk_FACTURAS_CLIENTES1` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_FACTURAS_EMPLEADO` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_FACTURAS_TIPO_VENTA1` FOREIGN KEY (`fk_id_tipo_venta`) REFERENCES `tipo_venta` (`pk_id_tipo_venta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `falta_empleado`
--
ALTER TABLE `falta_empleado`
  ADD CONSTRAINT `fk_empleado_falta` FOREIGN KEY (`fk_id_empleado_falta_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tipo_falta` FOREIGN KEY (`fk_id_tipo_falta_empleado`) REFERENCES `falta` (`pk_id_falta`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `hora_empleado`
--
ALTER TABLE `hora_empleado`
  ADD CONSTRAINT `fk_HORAEMPLEADO_EMPLEADO` FOREIGN KEY (`fk_id_empleado_hora_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_HORA_EMPLEADO_ORDEN_PRODUCCION1` FOREIGN KEY (`fk_id_pedido_encabezado_hora_empleado`) REFERENCES `pedido_encabezado` (`pk_id_pedido_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `fk_total_inventario` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `materia_prima`
--
ALTER TABLE `materia_prima`
  ADD CONSTRAINT `fk_materia_prima_producto` FOREIGN KEY (`fk_id_producto_materia_prima`) REFERENCES `producto` (`pk_id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `movimiento_cuenta_por_cobrar`
--
ALTER TABLE `movimiento_cuenta_por_cobrar`
  ADD CONSTRAINT `fk_MOVIMIENTO_CUENTA_POR_COBRAR_CLIENTES1` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_MOVIMIENTO_CUENTA_POR_COBRAR_FACTURAS1` FOREIGN KEY (`fk_id_factura`) REFERENCES `facturas` (`pk_id_factura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_MOVIMIENTO_CUENTA_POR_COBRAR_TIPO_CUENTA_POR_COBRAR1` FOREIGN KEY (`fk_id_tipo_cuenta`) REFERENCES `tipo_cuenta_por_cobrar` (`pk_id_tipo_cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `movimiento_inventario`
--
ALTER TABLE `movimiento_inventario`
  ADD CONSTRAINT `fk_mov_inventario_ruta` FOREIGN KEY (`fk_id_ruta`) REFERENCES `ruta` (`pk_id_ruta`),
  ADD CONSTRAINT `fk_mov_inventario_tipo` FOREIGN KEY (`fk_id_tipo_movimiento`) REFERENCES `tipo_movimiento` (`pk_id_tipo_movimiento`),
  ADD CONSTRAINT `fk_mov_inventario_vehiculo` FOREIGN KEY (`fk_id_vehiculo`) REFERENCES `vehiculo` (`pk_id_vehiculo`);

--
-- Filtros para la tabla `movimiento_inventario_detalle`
--
ALTER TABLE `movimiento_inventario_detalle`
  ADD CONSTRAINT `fk_mov_inventario_detalle_mov` FOREIGN KEY (`fk_id_movimiento_inventario`) REFERENCES `movimiento_inventario` (`pk_id_movimiento_inventario`),
  ADD CONSTRAINT `fk_mov_inventario_detalle_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD CONSTRAINT `fk_municipio_departamento` FOREIGN KEY (`fk_id_departamento`) REFERENCES `departamento` (`pk_id_departamento`);

--
-- Filtros para la tabla `orden_compra`
--
ALTER TABLE `orden_compra`
  ADD CONSTRAINT `fk_ORDEN_COMPRA_PRODUCTO1` FOREIGN KEY (`fk_id_producto_orden_compra`) REFERENCES `producto` (`pk_id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `pedido_detalle`
--
ALTER TABLE `pedido_detalle`
  ADD CONSTRAINT `fk_encabezado_pedido` FOREIGN KEY (`fk_id_pedido_encabezado`) REFERENCES `pedido_encabezado` (`pk_id_pedido_encabezado`),
  ADD CONSTRAINT `fk_pedido_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `pedido_encabezado`
--
ALTER TABLE `pedido_encabezado`
  ADD CONSTRAINT `fk_pedido_fabrica` FOREIGN KEY (`fk_id_fabrica`) REFERENCES `fabrica` (`pk_id_fabrica`);

--
-- Filtros para la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `poliza_detalle`
--
ALTER TABLE `poliza_detalle`
  ADD CONSTRAINT `fk_poliza_detalle_cuenta` FOREIGN KEY (`pk_id_cuenta_contable`) REFERENCES `cuenta_contable` (`pk_id_cuenta_contable`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_poliza_detalle_poliza_encabezado` FOREIGN KEY (`pk_poliza_encabezado`) REFERENCES `poliza_encabezado` (`pk_poliza_encabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `fk_producto_categoriaProducto` FOREIGN KEY (`fk_id_categoria_producto`) REFERENCES `categoria_producto` (`pk_id_categoria_producto`),
  ADD CONSTRAINT `fk_producto_lineaProducto` FOREIGN KEY (`fk_id_linea_producto`) REFERENCES `linea_producto` (`pk_id_linea_producto`);

--
-- Filtros para la tabla `producto_terminado`
--
ALTER TABLE `producto_terminado`
  ADD CONSTRAINT `fk_producto_terminado_producto` FOREIGN KEY (`fk_id_producto_producto_terminado`) REFERENCES `producto` (`pk_id_producto`);

--
-- Filtros para la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD CONSTRAINT `fk_proveedor_pais` FOREIGN KEY (`fk_id_pais`) REFERENCES `pais` (`pk_id_pais`);

--
-- Filtros para la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD CONSTRAINT `fk_horario_puesto` FOREIGN KEY (`fk_id_horario_puesto`) REFERENCES `horario` (`pk_id_horario`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `recetas_encabezado`
--
ALTER TABLE `recetas_encabezado`
  ADD CONSTRAINT `fk_recetas_encabezado_productos` FOREIGN KEY (`fk_id_producto_receta_encabezado`) REFERENCES `producto` (`pk_id_producto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `reclutamiento`
--
ALTER TABLE `reclutamiento`
  ADD CONSTRAINT `fk_departamento_empresarial_reclutamiento` FOREIGN KEY (`fk_id_departamento_empresarial_reclutamiento`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_estado_civil_reclutamiento` FOREIGN KEY (`fk_id_estado_civil_reclutamiento`) REFERENCES `estado_civil` (`pk_id_estado_civil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_genero_reclutamiento` FOREIGN KEY (`fk_id_genero_reclutamiento`) REFERENCES `genero` (`pk_id_genero`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_licencia_conducir_reclutamiento` FOREIGN KEY (`fk_id_licencia_conducir_reclutamiento`) REFERENCES `licencia_conduccion` (`pk_id_licencia_conduccion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_nivel_estudio_reclutamiento` FOREIGN KEY (`fk_id_nivel_estudio_reclutamiento`) REFERENCES `formacion_academica` (`pk_id_formacion_academica`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_puesto_reclutamiento` FOREIGN KEY (`fk_id_puesto_reclutamiento`) REFERENCES `puesto` (`pk_id_puesto`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `reporte_aplicativo`
--
ALTER TABLE `reporte_aplicativo`
  ADD CONSTRAINT `fk_report_aplicativo` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `aplicacion` (`pk_id_aplicacion`),
  ADD CONSTRAINT `fk_reporte_aplicativo_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`),
  ADD CONSTRAINT `fk_reporte_aplicativo_reporte` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`);

--
-- Filtros para la tabla `reporte_modulo`
--
ALTER TABLE `reporte_modulo`
  ADD CONSTRAINT `fk_reporte_de_modulo` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`),
  ADD CONSTRAINT `fk_reporte_de_modulo_reportes` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`);

--
-- Filtros para la tabla `saldo_historico`
--
ALTER TABLE `saldo_historico`
  ADD CONSTRAINT `fk_saldo_cuenta_contable` FOREIGN KEY (`pk_id_cuenta_contable`) REFERENCES `cuenta_contable` (`pk_id_cuenta_contable`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `telefono_proveedor`
--
ALTER TABLE `telefono_proveedor`
  ADD CONSTRAINT `fk_proveedor_telefono` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`);

--
-- Filtros para la tabla `transaccion`
--
ALTER TABLE `transaccion`
  ADD CONSTRAINT `fk_encabezado_transaccion_numero_cuenta` FOREIGN KEY (`fk_id_numero_cuenta_bancaria`) REFERENCES `cuenta_bancaria` (`pk_id_numero_cuenta_bancaria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_transaccion_tipo_transaccion` FOREIGN KEY (`fk_id_tipo_transaccion`) REFERENCES `tipo_transaccion` (`pk_id_tipo_transaccion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD CONSTRAINT `fk_vehiculo_marca` FOREIGN KEY (`fk_id_marca`) REFERENCES `marca` (`pk_id_marca`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
