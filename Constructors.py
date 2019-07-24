#use classes to define new types
#constructor is called at the time of creating an oject

class Point:
    def __init__(self, x, y):       #this is the "constructor" that gets called when a new object is created
        self.x = x                  # "self" is a reference to the current object. And x and y are attributes
        self.y = y
    def move(self):
        print("move")
    def draw(self):
        print("draw")
        

#objects are instances of a class
point1 = Point(10,20)
print(point1.x)
point1.x = 11
print(point1.x)

#Exercise - define a Person class with a name attribute and a talk() method

class Person:
    def __init__(self,name):
        self.name = name
    def talk(self):
        print(f"Hi, I am {self.name}")

john = Person("John Smith")
john.talk()

bob = Person("Bob Smith")
bob.talk()