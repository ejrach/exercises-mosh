#key/value pairs

#Name: John Smith
#Email: john@gmail.com
#Phone: 1234

customer = {
    "name": "John Smith",
    "age": 30,
    "is_verified": True
}

print(customer["name"])

#print(customer["birthdate"])        # returns an error
print(customer.get("birthdate"))    # returns None instead of an error

customer["name"] = "Jack Smith"
print(customer["name"])

#add new key/value pairs
customer["birthdate"] = "Jan 1 1980"
print(customer["birthdate"])

#Exercise: Write a program which takes user input of 1234 and then prints out "One Two Three Four"
numbers_to_words = {
    "0": "Zero",
    "1": "One",
    "2": "Two",
    "3": "Three",
    "4": "Four",
    "5": "Five",
    "6": "Six",
    "7": "Seven",
    "8": "Eight",
    "9": "Nine"
}
value = input("Enter a number: ")
output = ''
for digit in value:
    output += numbers_to_words[digit] + " "
    #output += numbers_to_words.get(digit,"!")   #do this so in case you dont have all digits defined
print(output)




