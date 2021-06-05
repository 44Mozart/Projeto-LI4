-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema PitStop
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema PitStop
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `PitStop` DEFAULT CHARACTER SET utf8 ;
USE `PitStop` ;

-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Utilizador` (
  `idUtilizador` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Pass` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idUtilizador`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Piloto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Piloto` (
  `idPiloto` VARCHAR(45) NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Apelido` VARCHAR(45) NOT NULL,
  `Nacionalidade` VARCHAR(45) NOT NULL,
  `DataDeNascimentp` INT NOT NULL,
  `NumeroPermanente` INT NULL,
  PRIMARY KEY (`idPiloto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Circuito`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Circuito` (
  `idCircuito` VARCHAR(45) NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Pais` VARCHAR(45) NOT NULL,
  `Localidade` VARCHAR(45) NOT NULL,
  `Latitude` FLOAT NOT NULL,
  `Longitude` FLOAT NOT NULL,
  PRIMARY KEY (`idCircuito`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Corrida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Corrida` (
  `Data` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `VoltasTotais` INT NOT NULL,
  `Circuito_idCircuito` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Data`),
  INDEX `fk_Corrida_Circuito_idx` (`Circuito_idCircuito` ASC) VISIBLE,
  CONSTRAINT `fk_Corrida_Circuito`
    FOREIGN KEY (`Circuito_idCircuito`)
    REFERENCES `PitStop`.`Circuito` (`idCircuito`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador_has_Piloto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Utilizador_has_Piloto` (
  `Utilizador_idUtilizador` INT NOT NULL,
  `Piloto_idPiloto` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Utilizador_idUtilizador`, `Piloto_idPiloto`),
  INDEX `fk_Utilizador_has_Piloto_Piloto1_idx` (`Piloto_idPiloto` ASC) VISIBLE,
  INDEX `fk_Utilizador_has_Piloto_Utilizador1_idx` (`Utilizador_idUtilizador` ASC) VISIBLE,
  CONSTRAINT `fk_Utilizador_has_Piloto_Utilizador1`
    FOREIGN KEY (`Utilizador_idUtilizador`)
    REFERENCES `PitStop`.`Utilizador` (`idUtilizador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Utilizador_has_Piloto_Piloto1`
    FOREIGN KEY (`Piloto_idPiloto`)
    REFERENCES `PitStop`.`Piloto` (`idPiloto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Construtor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Construtor` (
  `idConstrutor` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Nacionalidade` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idConstrutor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador_has_Construtor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Utilizador_has_Construtor` (
  `Utilizador_idUtilizador` INT NOT NULL,
  `Construtor_idConstrutor` INT NOT NULL,
  PRIMARY KEY (`Utilizador_idUtilizador`, `Construtor_idConstrutor`),
  INDEX `fk_Utilizador_has_Construtor_Construtor1_idx` (`Construtor_idConstrutor` ASC) VISIBLE,
  INDEX `fk_Utilizador_has_Construtor_Utilizador1_idx` (`Utilizador_idUtilizador` ASC) VISIBLE,
  CONSTRAINT `fk_Utilizador_has_Construtor_Utilizador1`
    FOREIGN KEY (`Utilizador_idUtilizador`)
    REFERENCES `PitStop`.`Utilizador` (`idUtilizador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Utilizador_has_Construtor_Construtor1`
    FOREIGN KEY (`Construtor_idConstrutor`)
    REFERENCES `PitStop`.`Construtor` (`idConstrutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `PitStop`.`Resultado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PitStop`.`Resultado` (
  `Corrida_Data` INT NOT NULL,
  `Piloto_idPiloto` VARCHAR(45) NOT NULL,
  `Construtor_idConstrutor` INT NOT NULL,
  `Tempo` VARCHAR(45) NOT NULL,
  `Pontos` INT NOT NULL,
  `Qualificatoria` INT NOT NULL,
  `Posicao` INT NOT NULL,
  `Status` VARCHAR(45) NOT NULL,
  `Volta` INT NOT NULL,
  PRIMARY KEY (`Corrida_Data`, `Piloto_idPiloto`, `Construtor_idConstrutor`),
  INDEX `fk_Corrida_has_Piloto_Piloto1_idx` (`Piloto_idPiloto` ASC) VISIBLE,
  INDEX `fk_Corrida_has_Piloto_Corrida1_idx` (`Corrida_Data` ASC) VISIBLE,
  INDEX `fk_Resultado_Construtor1_idx` (`Construtor_idConstrutor` ASC) VISIBLE,
  CONSTRAINT `fk_Corrida_has_Piloto_Corrida1`
    FOREIGN KEY (`Corrida_Data`)
    REFERENCES `PitStop`.`Corrida` (`Data`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Corrida_has_Piloto_Piloto1`
    FOREIGN KEY (`Piloto_idPiloto`)
    REFERENCES `PitStop`.`Piloto` (`idPiloto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Resultado_Construtor1`
    FOREIGN KEY (`Construtor_idConstrutor`)
    REFERENCES `PitStop`.`Construtor` (`idConstrutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
