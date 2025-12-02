import socket
import time
from agent import Agent

HOST = '127.0.0.1'
PORT = 5005

agent = Agent()

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.bind((HOST, PORT))
    s.listen(1)
    print("Servidor TCP esperando conexión...")

    conn, addr = s.accept()
    print("Conectado a Unity:", addr)

    with conn:
        while True:
            x = agent.update()
            msg = f"{x}\n"#unity leeaá linea por linea
            conn.sendall(msg.encode("utf-8"))
            time.sleep(0.1)
