first_name = 'John'
last_name = 'Smith'

#the output can be written like this, a concatenated string
message = first_name + ' [' + last_name + '] is a coder'
print(message)

#or like this formatted string - prefixed with an f
msg = f'{first_name} [{last_name}] is a coder'
print(msg)