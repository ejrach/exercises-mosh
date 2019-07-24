names = ['John','Bob','Mosh','Sarah','Mary']
print(names)

# you can index the items in the list
print(names[0])

#return the last item in the list
print(names[-1])

#return items from index 2 to end of list
print(names[2:])

#now change just 1 item in the list
names[0] = 'Jon'
print(names)


#Exercise: write a program to find the largest number in a list
numbers =[2, 456, 12, 12, 43, 500, 1, -3, 52, 12]
max_number = numbers[0]
for item in numbers:
    if item > max_number:
        max_number = item
print(f"Max number is: {max_number}")