#[
#  1 2 3
#  4 5 6
#  7 8 9
# ]

# 2D lists
matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

#to access the first row, second column (item with value of 2)
print(matrix[0][1])

# to modify that value
matrix[0][1] = 20
print(matrix[0][1])

# to print the items in a 2D list
for row in matrix:
    for item in row:
        print(item)


