DROP DATABASE IF EXISTS bdparchis;
CREATE DATABASE bdparchis;
USE bdparchis;

CREATE TABLE jugador(
	id INT PRIMARY KEY NOT NULL,
	username VARCHAR(25),
	passwd VARCHAR(25)
)ENGINE=InnoDB;

CREATE TABLE partida(
	idpartida INT PRIMARY KEY NOT NULL,
	ganador VARCHAR(25),
	local VARCHAR(25),
	visitante VARCHAR(25),
	ciudad VARCHAR(25)
)ENGINE=InnoDB;

CREATE TABLE CLASIFICACION(
    jugador_id INT NOT NULL,
    ultima_partida INT NOT NULL,
    posicion INT,
    FOREIGN KEY(jugador_id) REFERENCES jugador(id),
    FOREIGN KEY(ultima_partida) REFERENCES partida(idpartida)
)ENGINE=InnoDB;



