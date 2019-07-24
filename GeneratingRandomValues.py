import random

#generate 3 random numbers between 0 and 1
for i in range(3):
    print(random.random())

#generate 3 random numbers between 10 and 20
for i in range(3):
    print(random.randint(10,20))


members = ['John', 'Mary', 'Bob', 'Mosh']
leader = random.choice(members)
print(leader)

#Exercise:
# define a class called "Dice"
# add method called roll() that returns a tuple of 2 random dice values between 1 and 6#
class Dice:
    def roll(self):
        first = random.randint(1,6)
        second = random.randint(1,6)
        return (first, second)

diceval = Dice()
print(diceval.roll())