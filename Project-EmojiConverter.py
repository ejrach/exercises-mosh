# use a dictionary that maps emojis to smily faces

message = input(">")

#use the split method to split the input string (at the spaces) into a list of words
words = message.split(' ')
#print(words)

#press control + command + space to bring up the emojis
emojis = {
    ":)": "😀",
    ":(": "😞"
}

output = ''
for word in words:
    #Use the get method for dictionary so that we don't error if the word is not
    #found in the dictionary. Otherwise if not found use default.
    #What this says: Look up the "word" in the emojis dictionary, if not found, 
    #                   use the "word" supplied
    output += emojis.get(word, word) + " "

print(output)



