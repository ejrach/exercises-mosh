temperature = 31

# <, <=, >, >=, !=, ==

if temperature > 30:
    print("It's a hot day")
else:
    print("It's not a hot day")


#exercise
name = 'Eric Rach'
if len(name) < 3:
    print('Name must be at least 3 characters long')
elif len(name) > 50:
    print('Name can be a maximum of 50 characters long')
else:
    print('Name looks good')
