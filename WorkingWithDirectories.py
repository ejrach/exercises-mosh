from pathlib import Path

# Absolute Path
# c:\Program Files\Microsoft
# /usr/local/bin

# Relative Path
#relative to the project directory

# check if a path exists
path = Path("ecommerce")
print(path.exists())

# make a directory
path = Path("emails")
#print(path.mkdir())

# remove a directory
path = Path("emails")
#print(path.rmdir())

# get the files in the current directory
path = Path()
for file in path.glob('*.py'):
    print(file)

# get the files and directories in the current directory
path = Path()
for file in path.glob('*'):
    print(file)