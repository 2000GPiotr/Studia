def is_palindrom(text):
    text = text.lower()
    new = ""
    for i in text:
        if(i.isalpha()):
            new += i
    return new == new[::-1]

print(is_palindrom("Kobyła ma mały bok"))
print(is_palindrom("Kobyła, ma:; mały. bok!!"))
print(is_palindrom("Eine güldne, gute Tugend: Lüge nie!"))
