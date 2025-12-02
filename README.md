# Examen-Integrador-1---MultiAgentes
Evidencia 1


# Tipo de Conexión Usada: SOCKETS TCP
### ¿Por qué TCP?
- Permite enviar datos de manera continua sin reconectar.
- Es ideal para transmitir posiciones de agentes en tiempo real.

### Como se usa en este proyecto
Python abre un servidor TCP en el puerto "5005".  
Unity se conecta a ese servidor como cliente.  
Una vez conectados, Python envia posiciones a Unity 10 veces por segundo.

---

# Arquitectura del Sistema
Python (agent.py) -> calcula movimiento
Python (server.py) -> servidor TCP que envia posiciones
Unity (TCPClient.cs) -> cliente TCP que recibe la posición
Unity (agente) -> se actualiza en la escena
- Python es simulacion.  
- Unity es visualizacion.  

---

# Formato del Mensaje
Python envia un numero representando la posición X del agente.

Ejemplos de los mensajes enviados:
-4.9
-4.8
-4.7
-4.6



para convertir el mensaje a un número.


## VIDEO: 

