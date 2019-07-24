#use classes to define new types

class Point:
    def move(self):
        print("move")
    def draw(self):
        print("draw")
        

#objects are instances of a class
point1 = Point()
point1.x = 10
point1.y = 20
print(point1.x)
point1.draw()

point2 = Point()
point2.x = 1
print(point2.x)