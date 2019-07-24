# if it's hot
#   it's a hot day
#   drink plenty of water
# otherwise if it's cold
#   it's a cold day
#   wear warm clothes
# otherwise
#   it's a lovely day

is_hot = False
is_cold = True

if is_hot:
    print("It's a hot day")
    print("Drink plenty of water")
elif is_cold:
    print("It's a cold day")
    print("Wear warm clothes")
else:
    print("Enjoy your day")


#Exercise
good_credit = False
price = 1000000
print("The price of a house is $1M")
if good_credit:
    print("You need to put down 10%")
    down_payment = price * .10
else:
    print("You need to put down 20%")
    down_payment = price * .20
print(f"Down payment is: ${down_payment}")
