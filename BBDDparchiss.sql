DROP DATABASE IF EXISTS bdparchis;
CREATE DATABASE bdparchis;
USE bdparchis;

CREATE TABLE JUGADOR(
	id INT NOT NULL,
	username VARCHAR(25),
	passwd VARCHAR(25),
	PRIMARY KEY(id)
)ENGINE=InnoDB;

CREATE TABLE PARTIDA(
	idpartida INT NOT NULL,
	ganador VARCHAR(25),
	local VARCHAR(25),
	visitante VARCHAR(25),
	ciudad VARCHAR(25),
	PRIMARY KEY(idpartida)
)ENGINE=InnoDB;

CREATE TABLE CLASIFICACION(
	jugador_id INT NOT NULL,
	ultima_partida INT NOT NULL,
	posicion INT,
	FOREIGN KEY(jugador_id) REFERENCES jugador(id),
	FOREIGN KEY(ultima_partida) REFERENCES partida(idpartida)
)ENGINE=InnoDB;



