course = 'Python for Beginners'

#print the length of the string
print(len(course))

#print all in upper
print(course.upper())

#print all in lower
print(course.lower())

#Find index of the first instance of 'P'
print(course.find('P'))

#Find index of the first instance of 'o'
print(course.find('o'))

#Find index of the first instance of '0' --> returns -1 (not found)
print(course.find('0'))

#Find index of the first instance of 'Beginners'
print(course.find('Beginners'))

#replace 'Beginners' with 'Absolute Beginners'
print(course.replace('Beginners','Absolute Beginners'))

#return boolean value if 'Python' is in the course variable
print('Python' in course)

#return boolean value if 'python' is in the course variable
print('python' in course)