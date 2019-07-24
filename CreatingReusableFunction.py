# create a reusable function based off: "Project-EmojiConverter"

def emoji_converter(message):
    words = message.split(' ')

    #press control + command + space to bring up the emojis
    emojis = {
        ":)": "😀",
        ":(": "😞"
    }
    output = ''
    for word in words:
        output += emojis.get(word, word) + " "
    return output


message = input(">")
emoji_converter(message)
print(emoji_converter(message))



