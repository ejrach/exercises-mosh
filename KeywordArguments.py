def greet_user(first_name, last_name):
    print(f'Hi {first_name} {last_name}!')
    print('Welcome aboard')


print("Start")
greet_user(last_name="Smith", first_name="John")
#calc_cost(total=50, shipping=5, discount=0.1)

#IMPORTANT: keyword arguments must always come after positional arguments
greet_user("John", last_name="Smith")

print("Finish")


