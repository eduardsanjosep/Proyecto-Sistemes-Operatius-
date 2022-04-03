#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

int i;
int sockets[100];

typedef struct{
	char nombre[20];
	int socket;
}Conectado;

typedef struct{
	Conectado conectados[100];
	int num;
}ListaConectados;

int PonJugador (ListaConectados *lista, char nombre[20], int socket){
	if (lista->num == 100)
		return -1;
	else{
		strcpy (lista->conectados[lista->num].nombre,nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
}

void DameConectados (ListaConectados *lista, char genteconectada[300]){
	//Pone numero de conectados y su nombre separado por '/'
	sprintf(genteconectada,"%d",lista->num);
	for(int i=0;i<lista->num;i++)
	{
		sprintf(genteconectada,"%s/%s",genteconectada,lista->conectados[i].nombre);
	}
	
}

void *AtenderCliente (void*socket)
{
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int  ret;
	char genteconectada[300];
	
	//Bucle de atención al cliente
	int terminar =0;
	//int mayus =0;
	while(terminar == 0)
	{
		
		
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		//Escribimos el nombre en la consola
		printf ("Se ha conectado: %s\n",peticion);
		
		
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		char nombre[20];
		char password[30];
		
		
		
		
		if (codigo ==0)
			terminar =1;
		
		else if (codigo ==1){
			//Creacion de usuario nuevo
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			p = strtok( NULL, "/");
			strcpy (password, p);
			
			printf ("Nombre: %s, Contraseña: %s\n", nombre,password);
			
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado1;
			MYSQL_RES *resultado2;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexi?n: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			char consulta1[200];
			char consulta2[200];
			strcpy (consulta1,"SELECT jugadores.id FROM jugadores WHERE jugadores.id = (SELECT MAX(id) FROM jugadores);");
			err=mysql_query (conn, consulta1);
			
			if (err!=0) {
				sprintf (respuesta, "Error al consultar datos de la base %u %s\n",
						 mysql_errno(conn), mysql_error(conn));
				
				exit (1);
			}
			
			resultado1 = mysql_store_result (conn);
			row = mysql_fetch_row (resultado1);
			
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			
			else
			{
				//while (row !=NULL) {
				// la columna 0 contiene el id del jugador
				printf ("%s\n", row[0]);
				
				// obtenemos la siguiente fila
				//row = mysql_fetch_row (resultado);
				//}	
			}
			char copiaid[5];
			strcpy(copiaid,row[0]);
			int ultimaid =  atoi (copiaid);
			ultimaid++;
			printf("%d\n",ultimaid);
			
			sprintf (consulta2, "INSERT INTO jugadores VALUES (%d,'%s','%s',0)",ultimaid, nombre, password);
			printf(consulta2);
			err=mysql_query (conn, consulta2);
			
			if (err!=0) {
				sprintf (respuesta, "Error al consultar datos de la base %u %s\n",
						 mysql_errno(conn), mysql_error(conn));
				
				//exit (1);
			}
			
			resultado2 = mysql_store_result (conn);
			sprintf (respuesta,"Usuario registrado correctamente");				
			
			mysql_close (conn);
		}
		else if (codigo ==2)
		{
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			p = strtok( NULL, "/");
			strcpy (password, p);
			
			printf ("Nombre: %s, Contraseña: %s\n", nombre,password);
			
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexi?n: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			int encontrado = 0;
			char consulta[200];
			printf(nombre);
			sprintf(consulta,"SELECT jugadores.password FROM jugadores WHERE jugadores.nickname = '%s';", nombre);
			printf(consulta);
			
			
			err=mysql_query (conn, consulta);
			
			if (err!=0) {
				sprintf (respuesta, "Error al consultar datos de la base %u %s\n",
						 mysql_errno(conn), mysql_error(conn));
				
				exit (1);
			}
			
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			
			if (row == NULL){
				
				printf ("No se han obtenido datos en la consulta\n");
			}
			
			else
			{
				//while (row !=NULL) {
				// la columna 0 contiene el nombre del jugador
				printf ("%s\n", row[0]);
				
				// obtenemos la siguiente fila
				//row = mysql_fetch_row (resultado);
				//}	
			}
			
			if (strcmp (row[0],password)== 0)
				encontrado =1;
			
			if(encontrado==1)
			{
				sprintf(respuesta,"Logeado correctamente");
				ListaConectados miLista;
				PonJugador(&miLista, nombre, sock_conn);
			}
			else
			   sprintf(respuesta,"Error en nombre de usuario o contraseña");
			
			mysql_close (conn);
			
		}
		else if (codigo ==3){
			//Quien tiene más kills
			
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexi?n: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			char consulta[200];
			strcpy (consulta,"SELECT jugadores.id,jugadores.nickname FROM jugadores WHERE jugadores.killstotales = (SELECT MAX(killstotales) FROM jugadores);");
			err=mysql_query (conn, consulta);
			
			if (err!=0) {
				sprintf (respuesta, "Error al consultar datos de la base %u %s\n",
						 mysql_errno(conn), mysql_error(conn));
				
				exit (1);
			}
			
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			
			else
			{
				//while (row !=NULL) {
				// la columna 0 contiene el nombre del jugador
				printf ("%s\n", row[1]);
				
				// obtenemos la siguiente fila
				//row = mysql_fetch_row (resultado);
				//}	
			}
			
			sprintf(respuesta,row[1]);
			
			
			mysql_close (conn);
			
		}	
		else if (codigo ==4){
			//Quien ha jugado mas partidas
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			char consulta[200];
			strcpy (consulta,"SELECT jugadores.nickname FROM (jugadores,partidas)  WHERE jugadores.id = (SELECT ganador FROM partidas GROUP BY ganador ORDER BY count(*) DESC LIMIT 1);");
			err=mysql_query (conn, consulta);
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
				while (row !=NULL) {
					// la columna 0 contiene el nombre del jugador
					sprintf (respuesta,row[0]);
					// obtenemos la siguiente fila
					row = mysql_fetch_row (resultado);
			}
				
				mysql_close (conn);
				
				
		}
		
		else if (codigo ==5){
			//Quien ha ganado mas partidas
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				sprintf ("Error al inicializar la conexion: %u %s\n", 
						 mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			char consulta[200];
			strcpy (consulta,"SELECT jugadores.nickname FROM (jugadores,partidas)  WHERE jugadores.id = (SELECT ganador FROM partidas GROUP BY ganador ORDER BY count(*) DESC LIMIT 1);");
			err=mysql_query (conn, consulta);
			if (err!=0) {
				sprintf (respuesta,"Error al consultar datos de la base %u %s\n",
						 mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			
			if (row == NULL)
				sprintf (respuesta,"No se han obtenido datos en la consulta\n");
			else
				while (row !=NULL) {
					// la columna 0 contiene el nombre del jugador
					sprintf (respuesta,row[0]);
					// obtenemos la siguiente fila
					row = mysql_fetch_row (resultado);
			}
				
				mysql_close (conn);
				
		}
		else if(codigo == 6){
			
			MYSQL *conn;
			int err;
			// Estructura especial para almacenar resultados de consultas 
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			
			//Creamos una conexion al servidor MYSQL 
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//inicializar la conexin
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "juego",0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
			
			ListaConectados miLista;
			/*	miLista.num;*/
			/*			char conectados [200];*/
			/*			strcpy (conectados,nombre);*/
			/*	PonJugador(&miLista, conectados, sock_conn);*/
			/*char genteconectada[300];*/
			DameConectados (&miLista,genteconectada);
			printf("Resultado: %s\n",genteconectada);
			
			
			/*			if (miLista.num == 100)*/
			/*			{*/
			/*				sprintf (respuesta, "Lista llena\n");*/
			/*			}*/
			//Añade conectado a la lista de conecatdos
			/*			else{*/
			/*				strcpy (miLista.conectados[miLista.num].nombre,nombre);*/
			/*				miLista.conectados[miLista.num].socket = socket;*/
			/*				pthread_mutex_lock( &mutex ); *///No me interrumpas ahora
			/*				miLista.num++;*/
			/*				pthread_mutex_unlock( &mutex); *///ya puedes interrumpirme
			/*			}*/
			
			
			//Pone numero de conectados y su nombre separado por '/'
			/*			sprintf(genteconectada,"%d",miLista.num);*/
			/*			for(int i=0;i<miLista.num;i++)*/
			/*			{*/
			/*				sprintf(genteconectada,"%s/%s",genteconectada,miLista.conectados[i].nombre);*/
			/*			}*/
			
			
			sprintf (respuesta,genteconectada);
			mysql_close (conn);
			
		}
		
		if (codigo!=0)
		{
			printf ("%s\n", respuesta);
			// Y lo enviamos
			write (sock_conn,respuesta, strlen(respuesta));
		}
		
		
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}







int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	/*	char peticion[512];*/
	/*	char respuesta[512];*/
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9065);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	pthread_t thread;
	i=0;
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}
}

