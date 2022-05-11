create database sigefoause;

CREATE TABLE `users` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `LoginName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Password` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Firstname` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Lastname` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Email` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Rol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `LoginName` (`LoginName`)
);

CREATE TABLE `documento` (
  `iddocumento` int NOT NULL,
  `NombreVendedor` varchar(100) NOT NULL,
  `NumeroIdentificacion` varchar(100) NOT NULL,
  `Curp` varchar(100) NOT NULL,
  `Rfc` varchar(100) NOT NULL,
  `Domicilio` varchar(100) NOT NULL,
  `CP` varchar(20) NOT NULL,
  `TelefonoVendedor` varchar(20) DEFAULT NULL,
  `Marca` varchar(30) NOT NULL,
  `Modelo` varchar(50) NOT NULL,
  `ColorExterior` varchar(50) NOT NULL,
  `ColorInterior` varchar(50) NOT NULL,
  `Motor` varchar(50) NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  `Serie` varchar(50) NOT NULL,
  `FacturaOrigen` tinyint DEFAULT NULL,
  `FacturaOriginal` tinyint DEFAULT NULL,
  `TarjetaCirculacion` tinyint DEFAULT NULL,
  `2021` tinyint DEFAULT NULL,
  `2020` tinyint DEFAULT NULL,
  `2019` tinyint DEFAULT NULL,
  `2018` tinyint DEFAULT NULL,
  `2017` tinyint DEFAULT NULL,
  `2016` tinyint DEFAULT NULL,
  `2015` tinyint DEFAULT NULL,
  `2014` tinyint DEFAULT NULL,
  `2013` tinyint DEFAULT NULL,
  `Placas` tinyint DEFAULT NULL,
  `Llaves` tinyint DEFAULT NULL,  
  `CantidadCompra` varchar(45) NOT NULL,
  `CantidadCompraEscrita` varchar(100) NOT NULL,
  `FacturaNumero` varchar(50) NOT NULL,
  `Fecha` date NOT NULL,
  `FechaEscrita` varchar(45) NOT NULL,
  `Verificacion` tinyint DEFAULT NULL,
  `JuegoPlacasNumero` varchar(20) NOT NULL,
  `JuegoLlaves` varchar(10) NOT NULL,
  `UnidadesLuces` tinyint DEFAULT NULL,
  `Luces` tinyint DEFAULT NULL,
  `Antena` tinyint DEFAULT NULL,
  `EspejosLaterales` tinyint DEFAULT NULL,
  `MoldurasCompletas` tinyint DEFAULT NULL,
  `TaponGasolina` tinyint DEFAULT NULL,
  `InstrumentoTablero` tinyint DEFAULT NULL,
  `CalefaccionAireAcondicionado` tinyint DEFAULT NULL,
  `Radio` tinyint DEFAULT NULL,
  `Bocinas` tinyint DEFAULT NULL,
  `EspejoRetrovisor` tinyint DEFAULT NULL,
  `Ceniceros` tinyint DEFAULT NULL,
  `CinturonesSeguridad` tinyint DEFAULT NULL,
  `ManeralGato` tinyint DEFAULT NULL,
  `LlaveRuedas` tinyint DEFAULT NULL,
  `TrianguloSeguridad` tinyint DEFAULT NULL,
  `LlantaRefaccion` tinyint DEFAULT NULL,
  `Extinguidor` tinyint DEFAULT NULL,
  `CarroceriaGolpes` tinyint DEFAULT NULL,
  `Claxon` tinyint DEFAULT NULL,
  `ConprobantesTendencia` tinyint DEFAULT NULL,
  `ComprobantesVerificacionVehi` tinyint DEFAULT NULL,
  PRIMARY KEY (`iddocumento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `sigefoause`.`marcas` (
  `idMarcas` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idMarcas`));


INSERT INTO `sigefoause`.`users` (`LoginName`, `Password`, `Firstname`, `Lastname`, `Email`, `Rol`) VALUES ('administrador', 'administrador', 'Nicolas', 'Ortega Moreno', 'admin@gmail.com', 'ADMINISTRADOR');

; 

