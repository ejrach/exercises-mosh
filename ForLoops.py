
# In for loops, 'item' is the loop variable.
# We don't need a loop counter

# Loop through each character
for item in 'Python':
    print(item)

# Loop through each item in a list
for item in ['Eric', 'Nancy', 'River']:
    print(item)

# Loop through each item in a list
for item in [1, 2, 3, 4]:
    print(item)

# Loop through each item in a range of numbers
for item in range(10):
    print(item)

# Loop through each item in a range of numbers from 5 to 10 (exclusive)
for item in range(5,10):
    print(item)

# Loop through each item in a range of numbers from 5 to 10 (exclusive), stepping by 2
for item in range(5,10,2):
    print(item)

#exercise - using a for loop, loop through items in a cart, calculating the total and then printing it out
prices = [10,20,30]
total = 0
for price in prices:
    total += price
print(f"Total is: {total}")