#error handling - try except
# Error values can be added as you test your code. Python will indicate why 
# program crashed.

try:
    age = int(input('Age: '))
    income = 20000
    risk = income/age
    print(age)
except ValueError:              #handles non-numeric
    print("Invalid value")
except ZeroDivisionError:
    print("Age cannot be 0.")

