from sense_hat import SenseHat
from random import randint

sense = SenseHat()

class Particle:
    def __init__(self, x, y, color):
        self.x = x
        self.y = y
        self.color = color

    def draw(self):
        sense.set_pixel(self.x, self.y, self.color)

def randomColor():
    r = randint(0,255)
    g = randint(0,255)
    b = randint(0,255)
    return (r,g,b)

particles = []

for i in range(0,8):
    particles.append(Particle(i, 0, randomColor()))
for x in range(0,8):
    particles.append(Particle(x, 1, randomColor()))

while True:
    acceleration = sense.get_accelerometer_raw()
    x = acceleration['x']
    y = acceleration['y']

    for i in range(0,15):
        if (x > 0):
            if (particles[i].x + 1 < 8):
                pX = particles[i].x
                pY = particles[i].y

                emptySpace = True

                for p in particles:
                    if (p.x == pX + 1 and p.y == pY):
                        emptySpace = False
                        break

                if (emptySpace):
                    particles[i].x += 1
        elif (x < 0):
            if (particles[i].x - 1 > -1):
                pX = particles[i].x
                pY = particles[i].y

                emptySpace = True

                for p in particles:
                    if (p.x == pX - 1 and p.y == pY):
                        emptySpace = False
                        break

                if (emptySpace):
                    particles[i].x -= 1

        if (y > 0):
            if (particles[i].y + 1 < 8):
                pX = particles[i].x
                pY = particles[i].y

                emptySpace = True

                for p in particles:
                    if (p.y == pY + 1 and p.x == pX):
                        emptySpace = False
                        break

                if (emptySpace):
                    particles[i].y += 1
        elif (y < 0):
            if (particles[i].y - 1 > -1):
                pX = particles[i].x
                pY = particles[i].y

                emptySpace = True

                for p in particles:
                    if (p.y == pY - 1 and p.x == pX):
                        emptySpace = False
                        break

                if (emptySpace):
                    particles[i].y -= 1
                    
        particles[i].draw()

    sense.clear()
