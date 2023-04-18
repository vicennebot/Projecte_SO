#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdlib.h>
#include <mysql.h>
#include <pthread.h>
//Estructura para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

typedef struct{
	char username[25];
	int socket;
}Conectado;

typedef struct{
	Conectado conectados [100];
	int num;
}ListaConectados;
ListaConectados milista;

int añadeConectado (ListaConectados *milista, char username[20], int socket)
{
	if (milista->num == 100)
		return -1;
	else
	{
		strcpy (milista->conectados[milista->num].username, username);
		MiLista->conectados[milista->num].socket = socket;
		MiLista->num++;
		return 0;
		
	}
}

int DameSocket (ListaConectados *milista, char username[20])
{
	int i=0;
	int encontrado = 0;
	while ((i < MiLista->num) && (encontrado==0))
	{
		if (strcmp(MiLista->conectados[i].username, username) == 0)
			encontrado =1;
		else
			i=i+1;
	}
	if (encontrado==1)
		return MiLista->conectados[i].socket;
	else
		return -1;
}

int eliminaConectado (ListaConectados *MiLista, char username[20])
{
	printf("%s\n",username);
	int encontrado=0;
	int i=0;
	while((encontrado==0)&&(i<milista->num))
	{
		if(strcmp(username,milista->conectados[i].username)==0)
		{
			encontrado==1;
			for (int j=i;j<milista->num;j++)
			{
				strcpy(milista->conectados[j].username,milista->conectados[j+1].username);
				milista->conectados[j].socket=milista->conectados[j+1].socket;
			}
			milista->num--;
		}
		i++;
	}
	
}

void login(MYSQL *conn, char respuesta[512], char username[20], char passwd[20], int sock_conn)
{
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char *p;
	p = strtok(NULL, "/");
	strcpy (password, p);
	
	char consulta [512];
	sprintf (consulta,"SELECT jugadores.username FROM (jugadores) WHERE jugadores.username = '%s' AND jugadores.passwd = '%s';", username, passwd); 
	
	int err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error, nombre o contraseña incorrectos %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
	{
		printf ("Nombre o contraseña incorrectos\n");
		strcpy(respuesta,"Nombre o contraseña incorrectos\n");
	}
	else
	{			
		pthread_mutex_lock(&mutex);
		int res = PonConectado(&milista,username,sock_conn);
		pthread_mutex_unlock(&mutex);
		if (res==-1)
		{
			sprintf(respuesta, "Log in erroneo, tabla llena\n");
		}
		else
		{
			sprintf(respuesta,"Logueado correctamente");
		}
	}
	printf("%s\n",respuesta);
	printf("\n");
}

void signin(MYSQL *conn, char respuesta[512], char username[25], char passwd[25], int sock_conn)
{
	pthread_mutex_lock( &mutex );
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char *p;
	p = strtok( NULL, "/");
	strcpy (passwd, p);
	char consulta [512];
	char consulta2 [512];
	int id;			
	
	sprintf(consulta2,"SELECT (COUNT(jugadores.username))+1 FROM (jugadores)");
	int err=mysql_query (conn, consulta2);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		if (row !=NULL){
			id = atoi (row[0]);
			row = mysql_fetch_row (resultado);
	}
	sprintf(consulta, "INSERT INTO jugadores VALUES(%d,'%s','%s',0,0)",id,username,passwd);
	
	err = mysql_query(conn, consulta);
	
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
			mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		
	sprintf(respuesta,"Registrado\n");
	printf("\n");
	pthread_mutex_unlock(&mutex);
}
}
void jugadoresciudad(MYSQL *conn, char ciudad[25], char respuesta[512])
{
	pthread_mutex_lock( &mutex ); //No me interrumpas ahora
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	sprintf(consulta, "SELECT JUGADOR.username FROM (JUGADOR, PARTIDA) WHERE PARTIDA.ciudad = '%s' AND PARTIDA.ganador = JUGADOR.username", ciudad[25]);
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
	}
	pthread_mutex_unlock(&mutex);
	
}

void ganadorpartida(MYSQL *conn, int idpartida, char respuesta[512])
{
	pthread_mutex_lock( &mutex );
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	sprintf(consulta, "SELECT PARTIDA.ganador FROM (JUGADOR, PARTIDA, CLASIFICACION) WHERE PARTIDA.idpartida = '%d' AND PARTIDA.ganador = JUGADOR.username", idpartida);
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
	}
	pthread_mutex_unlock(&mutex);
	
}
int dameposicion(MYSQL *conn, char username[25], int respuesta;)
{
	pthread_mutex_lock( &mutex );
	MYSQL_RES *resultado;
	MYSQL_ROW row
	sprintf(consulta, "SELECT CLASIFICACION.posicion FROM (JUGADOR, CLASIFICACION) WHERE JUGADOR.username = '%s' AND JUGADOR.id = CLASIFICACION.jugador_id", username[25]);
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
void mostrarConectados(char respuesta[512])
{
	pthread_mutex_lock(&mutex);
	char respuestaAUX[512];
	memset(respuestaAUX, 0, 512);
	sprintf(respuesta,"%d/",milista.num);
	int i; 
	for (i=0; i<milista.num; i++)
	{
		sprintf(respuestaAUX,"%s%s/",respuestaAUX,milista.conectados[i].username);
	}
	respuestaAUX[strlen(respuestaAUX)-1] = '\0';
	strcat(respuesta,respuestaAUX);
	printf("%s\n",respuesta);
	printf("\n");
	pthread_mutex_unlock(&mutex);
}

void *atendercliente(void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	char mensaje[512];
	char respuesta[512];
	char notificacion[512];
	int ret;
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL) 
	{
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "bdparchis",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	int acaabar =0;
	while(acabar==0)
	{
		memset(respuesta, 0, 512);
		memset(notificacion, 0, 512);
		printf("\n");
		printf ("Esperando peticion\n");
		ret=read(sock_conn,mensaje, sizeof(mensaje));
		printf ("peticion recibida\n");
		mensaje[ret]='\0';
		char *p = strtok(mensaje, "/");
		int codigo =  atoi (p);
		int res;
		char ciudad[25];
		char username[25];
		char passwd[25];
		char listajugadores[100];
		int idpartida;
		switch(codigo)
		{
		case 1:
			p=strtok(NULL,"/");
			sprintf(ciudad,p);
			jugadoresciudad(conn, ciudad, respuesta);
		break;
		case 2:
			p=strtok(NULL,"/");
			sprintf(username,p);
			dameposicion(conn, username, respuesta);
		break;
		case 3:
			p=strtok(NULL,"/");
			idpartida = atoi(p);
			ganadorpartida(conn, idpartida, respuesta);
		break;
		case 4:
			p=strtok(NULL,"/");
			sprintf(username,p);
			p=strtok(NULL,"/");
			sprintf(passwd,p);
			login(conn, respuesta, username, passwd, sock_conn);
		break;
		case 5:
			p=strtok(NULL,"/");
			sprintf(username,p);
			p=strtok(NULL,"/");
			sprintf(passwd,p);
			signin(conn, respuesta, username, passwd, sock_conn);
		break;
		case 6:
			mostrarConectados(respuesta);
		break;
	default:
		break;
		}
	}
	mysql_close(conn)
	close(sock_conn);
}

int main(int argc, char *argv[]) {

	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	if (listen(sock_listen, 15) < 0)
		printf("Error en el Listen");
	int i;
	int sockets[100];
	pthread_t thread;
	i=0;
	
	for(;;) //per atendre totes les peticions que volguem
	{
		
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("conexion recibida\n");
		sockets[i] =sock_conn;
		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]);
		i=i+1;
	}
	
}

