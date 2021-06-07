-- -----------------------------------------------------
-- Schema PitStop
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema PitStop
-- -----------------------------------------------------

CREATE database PitStop;
GO
USE PitStop;

-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador`
-- -----------------------------------------------------
CREATE TABLE Utilizador (
  Username varchar(45) not null,
  Nome VARCHAR(45) NOT NULL,
  Pass VARCHAR(45) NOT NULL,
  Email VARCHAR(45) NOT NULL,
  PRIMARY KEY (Username)
)



-- -----------------------------------------------------
-- Table `PitStop`.`Piloto`
-- -----------------------------------------------------
CREATE TABLE Piloto (
  idPiloto int not null identity(1,1),
  Nome VARCHAR(45) NOT NULL,
  Apelido VARCHAR(45) NOT NULL,
  Nacionalidade VARCHAR(45) NOT NULL,
  DataDeNascimentp INT NOT NULL,
  NumeroPermanente INT NULL,
  PRIMARY KEY (idPiloto)
)


-- -----------------------------------------------------
-- Table `PitStop`.`Circuito`
-- -----------------------------------------------------
CREATE TABLE Circuito (
  idCircuito int not null identity(1,1),
  Nome VARCHAR(45) NOT NULL,
  Pais VARCHAR(45) NOT NULL,
  Localidade VARCHAR(45) NOT NULL,
  Latitude FLOAT NOT NULL,
  Longitude FLOAT NOT NULL,
  PRIMARY KEY (idCircuito)
)


-- -----------------------------------------------------
-- Table `PitStop`.`Corrida`
-- -----------------------------------------------------
CREATE TABLE Corrida (
  idCorrida int not null identity(1,1),
  Data INT NOT NULL,
  Nome VARCHAR(45) NOT NULL,
  VoltasTotais INT NOT NULL,
  Circuito_idCircuito int NOT NULL,
  PRIMARY KEY (idCorrida),
  CONSTRAINT fk_Corrida_Circuito FOREIGN KEY (Circuito_idCircuito)
    REFERENCES Circuito (idCircuito)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)



-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador_has_Piloto`
-- -----------------------------------------------------
CREATE TABLE Utilizador_has_Piloto (
  Utilizador_Username varchar(45) NOT NULL,
  Piloto_idPiloto INT NOT NULL,
  PRIMARY KEY (Utilizador_Username, Piloto_idPiloto),
  CONSTRAINT fk_Utilizador_has_Piloto_Utilizador1 FOREIGN KEY (Utilizador_Username)
    REFERENCES Utilizador (Username)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Utilizador_has_Piloto_Piloto1
    FOREIGN KEY (Piloto_idPiloto)
    REFERENCES Piloto (idPiloto)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)


-- -----------------------------------------------------
-- Table `PitStop`.`Construtor`
-- -----------------------------------------------------
CREATE TABLE Construtor (
  idConstrutor INT NOT NULL identity(1,1),
  Nome VARCHAR(45) NOT NULL,
  Nacionalidade VARCHAR(45) NOT NULL,
  PRIMARY KEY (idConstrutor)
)


-- -----------------------------------------------------
-- Table `PitStop`.`Utilizador_has_Construtor`
-- -----------------------------------------------------
CREATE TABLE Utilizador_has_Construtor (
  Utilizador_Username varchar(45) NOT NULL,
  Construtor_idConstrutor INT NOT NULL,
  PRIMARY KEY (Utilizador_Username, Construtor_idConstrutor),
  CONSTRAINT fk_Utilizador_has_Construtor_Utilizador1
    FOREIGN KEY (Utilizador_Username)
    REFERENCES Utilizador (Username)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Utilizador_has_Construtor_Construtor1
    FOREIGN KEY (Construtor_idConstrutor)
    REFERENCES Construtor (idConstrutor)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)


-- -----------------------------------------------------
-- Table `PitStop`.`Resultado`
-- -----------------------------------------------------
CREATE TABLE Resultado(
  Corrida_idCorrida INT NOT NULL,
  Piloto_idPiloto int NOT NULL,
  Construtor_idConstrutor INT NOT NULL,
  Tempo VARCHAR(45) NOT NULL,
  Pontos INT NOT NULL,
  Qualificatoria INT NOT NULL,
  Posicao INT NOT NULL,
  Status VARCHAR(45) NOT NULL,
  Volta INT NOT NULL,
  PRIMARY KEY (Corrida_idCorrida, Piloto_idPiloto, Construtor_idConstrutor),
  CONSTRAINT fk_Corrida_has_Piloto_Corrida1
    FOREIGN KEY (Corrida_idCorrida)
    REFERENCES Corrida (idCorrida)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Corrida_has_Piloto_Piloto1
    FOREIGN KEY (Piloto_idPiloto)
    REFERENCES Piloto (idPiloto)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Resultado_Construtor1
    FOREIGN KEY (Construtor_idConstrutor)
    REFERENCES Construtor (idConstrutor)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)

