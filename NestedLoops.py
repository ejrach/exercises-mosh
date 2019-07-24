#useful in generating coordinates like (x,y)

for x in range(4):
    for y in range(3):
        print(f"({x},{y})")



#Exercise
# Using nested loops, draw out the following pattern 'F' using x's:
#  xxxxx
#  xx
#  xxxxx
#  xx
#  xx
# using only: numbers = [5,2,5,2,2]
numbers = [5,2,5,2,2]
for item in numbers:        #outer loop will loop 5 times
    output = ''
    for x in range(item):   #then for the value in the list, create the string output
        output += 'x'
    print(output)

print('')

#Exercise
# Using nested loops, draw out the following pattern 'L' using x's:
#  xx
#  xx
#  xx
#  xx
#  xxxxx
# using only: numbers = [2,2,2,2,5]
numbers = [2,2,2,2,5]
for item in numbers:        #outer loop will loop 5 times
    output = ''
    for x in range(item):   #then for the value in the list, create the string output
        output += 'x'
    print(output)

print('')

#Exercise
# Instead of nested loops, we can do this to draw out the following pattern 'F' using x's:
#  xxxxx
#  xx
#  xxxxx
#  xx
#  xx
# using only: numbers = [5,2,5,2,2]
numbers = [5,2,5,2,2]
for item in numbers:        #outer loop will loop 5 times
    print('x' * item)