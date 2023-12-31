-- MySQL Script generated by MySQL Workbench
-- Mon Dec 11 07:20:42 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Pais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Pais` (
  `IdPais` INT NOT NULL,
  `nombrePais` VARCHAR(45) NULL,
  PRIMARY KEY (`IdPais`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Departamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Departamento` (
  `idDepartamento` INT NOT NULL,
  `nombreDepartamento` VARCHAR(45) NULL,
  `Pais_IdPais` INT NOT NULL,
  PRIMARY KEY (`idDepartamento`),
  INDEX `fk_Departamento_Pais1_idx` (`Pais_IdPais` ASC) VISIBLE,
  CONSTRAINT `fk_Departamento_Pais1`
    FOREIGN KEY (`Pais_IdPais`)
    REFERENCES `mydb`.`Pais` (`IdPais`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Ciudad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Ciudad` (
  `idCiudad` INT NOT NULL,
  `NombreCiudad` VARCHAR(45) NULL,
  `Departamento_idDepartamento` INT NOT NULL,
  PRIMARY KEY (`idCiudad`),
  INDEX `fk_Ciudad_Departamento1_idx` (`Departamento_idDepartamento` ASC) VISIBLE,
  CONSTRAINT `fk_Ciudad_Departamento1`
    FOREIGN KEY (`Departamento_idDepartamento`)
    REFERENCES `mydb`.`Departamento` (`idDepartamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`categoriaPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`categoriaPersona` (
  `idcategoriaPersona` INT NOT NULL,
  `nombreCategoria` VARCHAR(45) NULL,
  PRIMARY KEY (`idcategoriaPersona`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tipoPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tipoPersona` (
  `idtipoPersona` INT NOT NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idtipoPersona`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Persona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Persona` (
  `idPersona` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `fechaRegistro` DATE NULL,
  `Ciudad_idCiudad` INT NOT NULL,
  `categoriaPersona_idcategoriaPersona` INT NOT NULL,
  `tipoPersona_idtipoPersona` INT NOT NULL,
  PRIMARY KEY (`idPersona`),
  INDEX `fk_Persona_Ciudad1_idx` (`Ciudad_idCiudad` ASC) VISIBLE,
  INDEX `fk_Persona_categoriaPersona1_idx` (`categoriaPersona_idcategoriaPersona` ASC) VISIBLE,
  INDEX `fk_Persona_tipoPersona1_idx` (`tipoPersona_idtipoPersona` ASC) VISIBLE,
  CONSTRAINT `fk_Persona_Ciudad1`
    FOREIGN KEY (`Ciudad_idCiudad`)
    REFERENCES `mydb`.`Ciudad` (`idCiudad`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_categoriaPersona1`
    FOREIGN KEY (`categoriaPersona_idcategoriaPersona`)
    REFERENCES `mydb`.`categoriaPersona` (`idcategoriaPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_tipoPersona1`
    FOREIGN KEY (`tipoPersona_idtipoPersona`)
    REFERENCES `mydb`.`tipoPersona` (`idtipoPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tipoContacto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tipoContacto` (
  `idtipoContacto` INT NOT NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idtipoContacto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`contactoPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`contactoPersona` (
  `idcontactoPersona` INT NOT NULL,
  `descripcion` VARCHAR(45) NULL,
  `Persona_idPersona` INT NOT NULL,
  `tipoContacto_idtipoContacto` INT NOT NULL,
  PRIMARY KEY (`idcontactoPersona`),
  INDEX `fk_contactoPersona_Persona1_idx` (`Persona_idPersona` ASC) VISIBLE,
  INDEX `fk_contactoPersona_tipoContacto1_idx` (`tipoContacto_idtipoContacto` ASC) VISIBLE,
  CONSTRAINT `fk_contactoPersona_Persona1`
    FOREIGN KEY (`Persona_idPersona`)
    REFERENCES `mydb`.`Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contactoPersona_tipoContacto1`
    FOREIGN KEY (`tipoContacto_idtipoContacto`)
    REFERENCES `mydb`.`tipoContacto` (`idtipoContacto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tipoDireccion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tipoDireccion` (
  `idtipoDireccion` INT NOT NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idtipoDireccion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`estado` (
  `idestado` INT NOT NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idestado`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`contrato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`contrato` (
  `idcontrato` INT NOT NULL,
  `fechaContrato` DATE NULL,
  `fechaFin` DATE NULL,
  `estado_idestado` INT NOT NULL,
  `Persona_idCliente` INT NOT NULL,
  `Persona_idEmpleado` INT NOT NULL,
  PRIMARY KEY (`idcontrato`),
  INDEX `fk_contrato_estado1_idx` (`estado_idestado` ASC) VISIBLE,
  INDEX `fk_contrato_Persona1_idx` (`Persona_idCliente` ASC) VISIBLE,
  INDEX `fk_contrato_Persona2_idx` (`Persona_idEmpleado` ASC) VISIBLE,
  CONSTRAINT `fk_contrato_estado1`
    FOREIGN KEY (`estado_idestado`)
    REFERENCES `mydb`.`estado` (`idestado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contrato_Persona1`
    FOREIGN KEY (`Persona_idCliente`)
    REFERENCES `mydb`.`Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contrato_Persona2`
    FOREIGN KEY (`Persona_idEmpleado`)
    REFERENCES `mydb`.`Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`turnos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`turnos` (
  `idturnos` INT NOT NULL,
  `nombreTurno` VARCHAR(45) NULL,
  `horaTurnoInicio` TIME NULL,
  `horaTurnoFin` TIME NULL,
  PRIMARY KEY (`idturnos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`programacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`programacion` (
  `idprogramacion` INT NOT NULL,
  `turnos_idturnos` INT NOT NULL,
  `Persona_idEmpleado` INT NOT NULL,
  `contrato_idcontrato` INT NOT NULL,
  PRIMARY KEY (`idprogramacion`),
  INDEX `fk_programacion_turnos_idx` (`turnos_idturnos` ASC) VISIBLE,
  INDEX `fk_programacion_Persona1_idx` (`Persona_idEmpleado` ASC) VISIBLE,
  INDEX `fk_programacion_contrato1_idx` (`contrato_idcontrato` ASC) VISIBLE,
  CONSTRAINT `fk_programacion_turnos`
    FOREIGN KEY (`turnos_idturnos`)
    REFERENCES `mydb`.`turnos` (`idturnos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_programacion_Persona1`
    FOREIGN KEY (`Persona_idEmpleado`)
    REFERENCES `mydb`.`Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_programacion_contrato1`
    FOREIGN KEY (`contrato_idcontrato`)
    REFERENCES `mydb`.`contrato` (`idcontrato`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`direccionPersona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`direccionPersona` (
  `iddireccionPersona` INT NOT NULL,
  `direccion` VARCHAR(45) NULL,
  `Persona_idPersona` INT NOT NULL,
  `tipoDireccion_idtipoDireccion` INT NOT NULL,
  PRIMARY KEY (`iddireccionPersona`),
  INDEX `fk_direccionPersona_Persona1_idx` (`Persona_idPersona` ASC) VISIBLE,
  INDEX `fk_direccionPersona_tipoDireccion1_idx` (`tipoDireccion_idtipoDireccion` ASC) VISIBLE,
  CONSTRAINT `fk_direccionPersona_Persona1`
    FOREIGN KEY (`Persona_idPersona`)
    REFERENCES `mydb`.`Persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_direccionPersona_tipoDireccion1`
    FOREIGN KEY (`tipoDireccion_idtipoDireccion`)
    REFERENCES `mydb`.`tipoDireccion` (`idtipoDireccion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
