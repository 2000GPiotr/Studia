def is_palindrom(text):
    text = text.lower()
    new = ""
    for i in text:
        if(i.isalpha()):
            new += i
    return new == new[::-1]
