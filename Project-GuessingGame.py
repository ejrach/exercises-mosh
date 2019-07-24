secret_number = 9
tries = 0
guess_limit = 3

#while loops can have else blocks
while tries < guess_limit:
    guessed_number = int(input('Enter your guess: '))
    tries += 1
    if guessed_number == secret_number:
        print("You win!")
        break
#this runs if the while loop finishes without a break happening. In 
#this case, if the while loop terminates without a correct guess, then
#we print a message that the user lost.
else:
    print('Sorry, you lose :(')

