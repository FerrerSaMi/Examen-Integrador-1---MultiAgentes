import time

class Agent:
    def __init__(self):
        self.x = 0
        self.direction = 1  # 1 = derecha, -1 = izquierda

    def update(self):
        #mover entre -5 y 5
        self.x += 0.1 * self.direction

        if self.x >= 5:
            self.direction = -1
        elif self.x <= -5:
            self.direction = 1
        
        return self.x


if __name__ == "__main__":
    a = Agent()
    while True:
        print(a.update())
        time.sleep(0.1)
