#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdlib.h>
#include <mysql.h>

int main(int argc, char *argv[]) {

	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	char consulta[512];
	
	if((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	
	serv_adr.sin_addr.s_addr = hton1(INADDR_ANY);
	serv_adr.sin_port = htons(9050);
	if(bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind");
	
	
	if(listen(sock_listen, 3) < 0)
		printf("Error al listen");
	
	int i;
	for(i=0; i<5;i++)
		printf("Escuchando\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibiudo conexion\n");
		ret=read(sock_conn, peticion, sizeof(peticion));
		printf("Recibido\n");
		peticion[ret]='\0';
		printf("Peticion: %s\n", peticion);
		char *p = strtok(peticion, "/");
		int codigo = atoi(p);
		char cliente[25];
		int consola;
		if(codigo==3)
		{
			consola = strtok(NULL, "/");
		}
		else
		{
			cliente[25] = strtok(NULL, "/");
		}
		MYSQL *conn;
		int err;
		MYSQL_RES *resultado;
		MYSQL_ROW row;
		conn = mysql_init(NULL);
		
		if(conn==NULL)
		{
			printf("Error al crear la conexion\n");
			exit(1);
		}
		
		conn = mysql_real_connect(conn, "localhost", "root", "mysql","bdparchis", 0, NULL, 0);
		if(conn=NULL)
		{
			printf("Error al conectar\n");
			exit(1);
		} 
		
		if(codigo==1)
		{
			sprintf(consulta, "SELECT JUGADOR.username FROM (JUGADOR, PARTIDA) WHERE PARTIDA.ciudad = '%s' AND PARTIDA.ganador = JUGADOR.username", cliente[25]);
			strcat(respuesta, resultado);
			err = mysql_query(conn, consulta);
			if(err!=0)
			{
				printf("Error en la consulta\n");
				exit(1);
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if(row == NULL)
			{
				printf("No hay datos");
			}
			else
			{
				printf("Respuesta: %s\n", respuesta);
				write(sock_conn, respuesta, strlen(respuesta));
				close(sock_conn);
			}
		}
		else if(codigo==2)
		{
			sprintf(consulta, "SELECT CLASIFICACION.posicion FROM (JUGADOR, CLASIFICACION) WHERE JUGADOR.username = '%s' AND JUGADOR.id = CLASIFICACION.jugador_id", cliente[25]);
			strcat(respuesta, resultado);
			err = mysql_query(conn, consulta);
			if(err!=0)
			{
				printf("Error en la consulta\n");
				exit(1);
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if(row == NULL)
			{
				printf("No hay datos");
			}
			else
			{
				
				printf("Respuesta: %d\n", respuesta);
				write(sock_conn, respuesta, strlen(respuesta));
				close(sock_conn);
			}
		}
		else
		{
			sprintf(consulta, "SELECT PARTIDA.ganador FROM (JUGADOR, PARTIDA, CLASIFICACION) WHERE PARTIDA.idpartida = '%d' AND PARTIDA.ganador = JUGADOR.username", consola);
			strcat(respuesta, resultado);
			err = mysql_query(conn, consulta);
			if(err!=0)
			{
				printf("Error en la consulta\n");
				exit(1);
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if(row == NULL)
			{
				printf("No hay datos");
			}
			else
			{
				
				printf("Respuesta: %s\n", respuesta);
				write (sock_conn, respuesta, strlen(respuesta));
				close(sock_conn);
			}
		}
		
	
	
	
	mysql_close(conn);
	exit(0);
}

