#using single quotes
course = 'Python for Beginners'

#use double quotes if there is an apostrophe in the string
course = "Python's course for Beginners"

#use single quotes if there is a word that has a double quote
course = 'Python for "Beginners"'

#use triple quote for long strings separated on different lines
course = '''
Hi John,

Here is our first email to you.

Thank you,
The suport team

'''
print(course)

#indexing strings
course = 'Python for Beginners'
#get the first character
print(course[0])
#get the last character using negative index
print(course[-1])
#get the second to last character using negative index
print(course[-2])
#return first 3 characters
print(course[0:3])
#return all characters to the end of the string, without supplying the end index
print(course[0:])
#return all characters to the end of the string, but exlude the first character
print(course[1:])
#you can also leave off the first index and Python will assume 0. Returns first 5 characters
print(course[:5])
#or leave off both indexes, and it essentially means cloning the string up to string length
print(course[:])

#exercise
name = 'Jennifer'
#prints out 'ennife'. This basically says to return characters from index 1 up to the last character, 
#but excluding it
print(name[1:-1])
