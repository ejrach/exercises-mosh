numbers = [5, 2, 1, 1, 7, 4]

#append a number to a list
numbers.append(20)
print(numbers)

#insert a number to the beginning of the list
numbers.insert(0,10)
print(numbers)

#remove a number
numbers.remove(5)
print(numbers)

#pop the last item from the list
numbers.pop()
print(numbers)

#return the index of a value
print(numbers.index(2))

#check for the value in the list
print(50 in numbers)

#count the instances of a value in a list
print(numbers.count(1))

#sort the list
numbers.sort()
print(numbers)

#reverse the list
numbers.reverse()
print(numbers)

#copy the list
numbers2 = numbers.copy()
numbers.append(10)
print(numbers2)

#clear the list
numbers.clear()
print(numbers)

#Exercise - remove the duplicates in a list
mylist = [2, 2, 4, 6, 3, 4, 6, 1]
uniques = []
for number in mylist:
    if number not in uniques:
        uniques.append(number)
print(uniques)

