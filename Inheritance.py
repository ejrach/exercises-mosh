class Mammal:
    def walk(self):
        print("walk")


#To inherit the walk method from mammal, write the following
class Dog(Mammal):
    def bark(self):
        print("bark")


#suppose we want to create a new class and don't want to write the walk method from dog here.
class Cat(Mammal):
    def be_annoying(self):
        print("annoying")


dog1 = Dog()
dog1.walk()
dog1.bark()

cat1 = Cat()
cat1.be_annoying()