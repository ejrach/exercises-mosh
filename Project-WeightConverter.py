weight = int(input('Please enter your weight: '))
units = input('Is that in (L)bs or (K)gs? ')

if units.lower() == 'l':
    converted = weight * 0.45
    print(f'Your weight in kg is: {converted}')
elif units.lower() == 'k':
    weight = weight / 0.45
    print(f'Your weight in lbs is: {converted}')
else:
    print("Incorrect units. Please try again.")